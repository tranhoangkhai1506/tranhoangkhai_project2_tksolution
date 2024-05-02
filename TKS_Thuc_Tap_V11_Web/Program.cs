using Telerik.Reporting.Cache.File;
using Telerik.Reporting.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.IO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Utility;
using Append.Blazor.Printing;
using TKS_Thuc_Tap_V11_Web.Background_Service;
using TKS_Thuc_Tap_V11_Web;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddMvc();
builder.Services.TryAddSingleton<IReportServiceConfiguration>(sp => new ReportServiceConfiguration
{
    ReportingEngineConfiguration = sp.GetService<IConfiguration>(),
    HostAppId = "BlazorReportViewerDemo",
    Storage = new FileStorage(),
    ReportSourceResolver = new UriReportSourceResolver(
        System.IO.Path.Combine(GetReportsDir(sp)))
});


// Add services to the container.
builder.Services.AddRazorPages().AddNewtonsoftJson();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IPrintingService, PrintingService>();

// Connection
CConfig.TKS_Thuc_Tap_V11_Conn_String = builder.Configuration.GetConnectionString("TKS_Thuc_Tap_V11_Conn_String");

// Đọc thông tin config công ty
CConfig.Company_Name = builder.Configuration.GetValue<string>("Company_Name");
CConfig.Company_Address = builder.Configuration.GetValue<string>("Company_Address");
CConfig.Company_Tel = builder.Configuration.GetValue<string>("Company_Tel");
CConfig.Company_Fax = builder.Configuration.GetValue<string>("Company_Fax");
CConfig.Company_Email = builder.Configuration.GetValue<string>("Company_Email");
CConfig.Company_Ten_Ngan_Hang = builder.Configuration.GetValue<string>("Company_Ten_Ngan_Hang");
CConfig.Company_So_Tai_Khoan = builder.Configuration.GetValue<string>("Company_So_Tai_Khoan");
CConfig.Report_Logo_Url = builder.Configuration.GetValue<string>("Report_Logo_Url");
CConfig.Khach_Hang_ID = builder.Configuration.GetValue<int>("Khach_Hang_ID");
CConfig.API_DataSource = builder.Configuration.GetValue<int>("API_DataSource");
CConfig.Khach_Hang_Name = builder.Configuration.GetValue<string>("Khach_Hang_Name");
CConfig.Product_Title = builder.Configuration.GetValue<string>("Product_Title");

// Đọc thông tin cấu hình cơ bản, format
CConfig.Page_Size = builder.Configuration.GetValue<int>("Page_Size");
CConfig.Date_Format_String = builder.Configuration.GetValue<string>("Date_Format_String");
CConfig.Time_Format_String = builder.Configuration.GetValue<string>("Time_Format_String");
CConfig.FullTime_Format_String = builder.Configuration.GetValue<string>("FullTime_Format_String");
CConfig.Number_Format_String = builder.Configuration.GetValue<string>("Number_Format_String");
CConfig.Footer_Number_Format_String = builder.Configuration.GetValue<string>("Footer_Number_Format_String");

// Đọc thông tin cấu hình import
CConfig.Import_Excel_URL = builder.Configuration.GetValue<string>("Import_Excel_URL");
CConfig.Template_URL = builder.Configuration.GetValue<string>("Template_URL");
CConfig.Export_Excel_URL = builder.Configuration.GetValue<string>("Export_Excel_URL");
CConfig.Log_File_Path = builder.Configuration.GetValue<string>("Log_File_Path");
CLogger.File_Name = builder.Configuration.GetValue<string>("Log_File_Path");
CConfig.Upload_URL = builder.Configuration.GetValue<string>("Upload_URL");
CConfig.Upload_URL_App = builder.Configuration.GetValue<string>("Upload_URL_App");

// Đọc thông tin cấu hình mail
CConfig.Smtp_Host = builder.Configuration.GetValue<string>("Smtp_Host");
CConfig.Smtp_UseDefaultCredentials = builder.Configuration.GetValue<bool>("Smtp_UseDefaultCredentials");
CConfig.Smtp_Port = builder.Configuration.GetValue<int>("Smtp_Port");
CConfig.Smtp_User = builder.Configuration.GetValue<string>("Smtp_User");
CConfig.Smtp_Pass = builder.Configuration.GetValue<string>("Smtp_Pass");
CConfig.Smtp_EnableSsl = builder.Configuration.GetValue<bool>("Smtp_EnableSsl");
CConfig.Email_From = builder.Configuration.GetValue<string>("Email_From");
CConfig.API_Grid_Field_URL = builder.Configuration.GetValue<string>("API_Grid_Field_URL");

CLogger.Enable_Trace = CUtility.Convert_To_Bool(CUtility.Convert_To_Int32(builder.Configuration.GetValue<string>("Enable_Trace")));

// Load cache system
CCache_Common_Controller.Is_Used_Cache = true;
CCache_Common_Controller.Is_Completed_Load_Cache = false;

CCache_Chu_Hang.Load_Cache_Chu_Hang();
CCache_Chuc_Nang.Load_Cache_Chuc_Nang();
CCache_Nhom_Thanh_Vien.Load_Cache_Nhom_Thanh_Vien();
CCache_Nhom_Thanh_Vien_User.Load_Cache_Nhom_Thanh_Vien_User();
CCache_Phan_Quyen_Chuc_Nang.Load_Cache_Phan_Quyen_Chuc_Nang();
CCache_Token.Load_Cache_Token();
CCache_Thanh_Vien.Load_Cache_Thanh_Vien();

builder.Services.AddHostedService<Cache_Timer_Service>();

builder.Services.AddHostedService<Thread_1_Timer_Service>();
builder.Services.AddHostedService<Thread_2_Timer_Service>();
builder.Services.AddHostedService<Thread_3_Timer_Service>();
builder.Services.AddHostedService<Thread_4_Timer_Service>();
builder.Services.AddHostedService<Thread_5_Timer_Service>();
builder.Services.AddHostedService<Thread_6_Timer_Service>();
builder.Services.AddHostedService<Thread_7_Timer_Service>();
builder.Services.AddHostedService<Thread_8_Timer_Service>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    endpoints.MapControllers();
    // ... 
});
// Xử lý các URL dạng file
if (CConfig.Import_Excel_URL != "")
{
    if (CConfig.Import_Excel_URL[1] != ':')
        CConfig.Import_Excel_URL = Path.Combine(app.Environment.WebRootPath) + Path.Combine(CConfig.Import_Excel_URL);
}

if (CConfig.Upload_URL != "")
{
    if (CConfig.Upload_URL[1] != ':')
        CConfig.Upload_URL = Path.Combine(app.Environment.WebRootPath) + Path.Combine(CConfig.Upload_URL);
}

if (CConfig.Report_Logo_Url != "")
    CConfig.Report_Logo_Url = Path.Combine(app.Environment.WebRootPath) + Path.Combine(CConfig.Report_Logo_Url);

if (CConfig.Report_File != "")
    CConfig.Report_File = Path.Combine(app.Environment.WebRootPath);

CConfig.API_Log_Physical_URL = Path.Combine(app.Environment.WebRootPath) + Path.Combine(CConfig.API_Log_Virtual_URL.Replace("/", "\\"));

CLogger.File_Name = Path.Combine(app.Environment.WebRootPath) + Path.Combine(CLogger.File_Name.Replace("/", "\\"));

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

static string GetReportsDir(IServiceProvider sp)

{
    return Path.Combine(sp.GetService<IWebHostEnvironment>().ContentRootPath, "Reports");
}
