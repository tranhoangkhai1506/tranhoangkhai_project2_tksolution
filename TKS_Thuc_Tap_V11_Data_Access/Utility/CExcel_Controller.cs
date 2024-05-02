using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Common;
using static OfficeOpenXml.ExcelErrorValue;
using Microsoft.Extensions.FileProviders;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
	public class CExcel_Controller
	{
		const int maxFileSize = 10485760;
		private ExcelPackage m_objExcel_Package = null;

		public CExcel_Controller(FileInfo p_objFile_Info)
		{
			m_objExcel_Package = new ExcelPackage(p_objFile_Info);
        }

        public static bool Check_Excel_File_Type(string p_strFileName)
		{
			if (p_strFileName != ".xls" && p_strFileName != ".xlsx")
				return false;
			return true;
		}

		public static bool Check_Excel_File_Type(List<string> p_arrList_Extensions, string p_strCheck)
		{
			if (p_arrList_Extensions.Contains(p_strCheck))
				return true;
			return false;
		}

		public FileInfo Get_File(string p_strPath_File)
		{
			try
			{
				FileInfo v_fileInfo = new FileInfo(p_strPath_File);
				return v_fileInfo;
			}

			catch (Exception)
			{
				throw;
			}
		}

		public DataTable List_Range_Value(int p_intSheet_Index, string p_strCell_From, string p_strCell_End)
		{
			DataTable v_dt = new DataTable();
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			int v_intRowStart = v_excelWorksheet.Cells[p_strCell_From].End.Row;
			int v_intColumnStart = v_excelWorksheet.Cells[p_strCell_From].End.Column;
			int v_intRowEnd = v_excelWorksheet.Cells[p_strCell_End].End.Row;
			int v_intColumnEnd = v_excelWorksheet.Cells[p_strCell_End].End.Column;
			foreach (var cell in v_excelWorksheet.Cells[v_intRowStart, v_intColumnStart, v_intRowStart, v_intColumnEnd])
			{
				string v_strColumnName = cell.Text.Trim();
				v_dt.Columns.Add(v_strColumnName);
			}
			for (int i = v_intRowStart; i <= v_intRowEnd; i++)
			{
				var row = v_excelWorksheet.Cells[i, v_intColumnStart, i, v_intColumnEnd];
				DataRow v_Row = v_dt.NewRow();
				int v_intColumn = 0;
				for (int j = v_intColumnStart; j <= v_intColumnEnd; j++)
				{
					v_Row[v_intColumn] = row[i, j].Value;
					v_intColumn++;
				}
				v_dt.Rows.Add(v_Row);
			}

			return v_dt;
		}

		public DataTable List_Range_Value(string p_strCell_From, string p_strCell_End)
		{
			return List_Range_Value(1, p_strCell_From, p_strCell_End);
		}

		public DataTable List_Range_Value_To_End(string p_strCell_From, string p_strCell_End)
		{
			//3.5 thi STT start sheet = 1,  > 3.5 thi = 0
			return List_Range_Value_To_End(1, p_strCell_From, p_strCell_End);
		}

        public DataTable List_Range_Value_To_End(string p_strSheet_Name, string p_strCell_From, string p_strCell_End)
        {
            DataTable v_dt = new DataTable();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_strSheet_Name];
            int v_intRowStart = v_excelWorksheet.Cells[p_strCell_From].End.Row;
            int v_intColumnStart = v_excelWorksheet.Cells[p_strCell_From].End.Column;
            int v_intRowEnd = v_excelWorksheet.Dimension.End.Row;
            p_strCell_End = p_strCell_End + v_intRowEnd.ToString();
            int v_intColumnEnd = v_excelWorksheet.Cells[p_strCell_End].End.Column;

            //doc tiêu đề làm Col name
            for (int v_i = v_intColumnStart; v_i <= v_intColumnEnd; v_i++)
                v_dt.Columns.Add(v_i.ToString());

            for (int i = v_intRowStart; i <= v_intRowEnd; i++)
            {
                var row = v_excelWorksheet.Cells[i, v_intColumnStart, i, v_intColumnEnd];
                DataRow v_Row = v_dt.NewRow();
                int v_intColumn = 0;
                for (int j = v_intColumnStart; j <= v_intColumnEnd; j++)
                {
                    v_Row[v_intColumn] = row[i, j].Value;
                    v_intColumn++;
                }
                v_dt.Rows.Add(v_Row);
            }

            return v_dt;
        }

        public DataTable List_Range_Value_To_End(int p_intSheet_Index, string p_strCell_From, string p_strCell_End)
		{
			DataTable v_dt = new DataTable();
			
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
			int v_intRowStart = v_excelWorksheet.Cells[p_strCell_From].End.Row;
			int v_intColumnStart = v_excelWorksheet.Cells[p_strCell_From].End.Column;
			int v_intRowEnd = v_excelWorksheet.Dimension.End.Row;
			p_strCell_End = p_strCell_End + v_intRowEnd.ToString();
			int v_intColumnEnd = v_excelWorksheet.Cells[p_strCell_End].End.Column;

			//doc tiêu đề làm Col name
			for (int v_i = v_intColumnStart; v_i <= v_intColumnEnd; v_i++)
				v_dt.Columns.Add(v_i.ToString());

			for (int i = v_intRowStart; i <= v_intRowEnd; i++)
			{
				var row = v_excelWorksheet.Cells[i, v_intColumnStart, i, v_intColumnEnd];
				DataRow v_Row = v_dt.NewRow();
				int v_intColumn = 0;
				for (int j = v_intColumnStart; j <= v_intColumnEnd; j++)
				{
					v_Row[v_intColumn] = row[i, j].Value;
					v_intColumn++;
				}
				v_dt.Rows.Add(v_Row);
			}

			return v_dt;
		}
        
        public string Cell_From()
		{
			return Cell_From(1);
		}

		public string Cell_From(int p_intSheet_Index)
		{
			string v_intCell_From;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			v_intCell_From = v_excelWorksheet.Dimension.Start.Address.ToString();
			
			return v_intCell_From;
		}

		public string Cell_End()
		{
			return Cell_End(1);
		}

		public string Cell_End(int p_intSheet_Index)
		{
			string v_intCell_End;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			v_intCell_End = v_excelWorksheet.Dimension.End.Address.ToString();
			
			return v_intCell_End;
		}

		public int Row_From()
		{
			return Row_From(1);
		}

		public int Row_From(int p_intSheet_Index)
		{
			int v_intRow_From;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			v_intRow_From = v_excelWorksheet.Dimension.Start.Row;
			
			return v_intRow_From;
		}

		public int Column_From()
		{
			return Column_From(1);
		}

		public int Column_From(int p_intSheet_Index)
		{
			int v_intColumn_From;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			v_intColumn_From = v_excelWorksheet.Dimension.Start.Column;
			
			return v_intColumn_From;
		}

		public int Row_End()
		{
			return Row_End(1);
		}

		public int Row_End(int p_intSheet_Index)
		{
			int v_intRow_End;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			v_intRow_End = v_excelWorksheet.Dimension.End.Row;
			
			return v_intRow_End;
		}

		public int Column_End()
		{
			return Column_End(1);
		}

		public int Column_End(int p_intSheet_Index)
		{
			int v_intColumn_End;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			v_intColumn_End = v_excelWorksheet.Dimension.End.Column;
			
			return v_intColumn_End;
		}

		//public static byte[] Export_Excel<T>(string p_strCell_From, List<T> p_arrData, Dictionary<int, string[]> p_dicHeader_Field, 
		//	Dictionary<int, string[]> p_dicBold_Text, Dictionary<int, string[]> p_dicBkd_Color)
		//{
		//	return Export_Excel<T>(1, p_strCell_From, p_arrData, p_dicHeader_Field, p_dicBold_Text, p_dicBkd_Color);
		//}

  //      public static byte[] Export_Excel<T>(int p_intSheet_Index, string p_strCell_From, List<T> p_arrData, 
		//	Dictionary<int, string[]> p_dicHeader_Field, Dictionary<int, string[]> p_dicBold_Text, Dictionary<int, string[]> p_dicBkd_Color)
		//{
		//	byte[] v_fileContents;
		//	ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
		//	using (ExcelPackage v_excelPackage = new ExcelPackage())
		//	{
		//		var v_excelWorksheet = v_excelPackage.Workbook.Worksheets.Add($"Sheet{p_intSheet_Index}");
		//		v_excelWorksheet.DefaultRowHeight = 12;
		//		if (p_dicBold_Text != null)
		//		{
		//			for (int i = 1; i <= p_dicBold_Text.Count; i++)
		//			{
		//				v_excelWorksheet = Bold_Text_List_Range_Value(p_dicBold_Text[i][0], p_dicBold_Text[i][1], v_excelWorksheet);
		//			}
		//		}
		//		if (p_dicBkd_Color != null)
		//		{
		//			for (int i = 1; i <= p_dicBkd_Color.Count; i++)
		//			{
		//				v_excelWorksheet = Background_Color_List_Range_Value(p_dicBkd_Color[i][0], p_dicBkd_Color[i][1], p_dicBkd_Color[i][2], v_excelWorksheet);
		//			}
		//		}
		//		int v_intRowStart = v_excelWorksheet.Cells[p_strCell_From].End.Row;
		//		int v_intColumnStart = v_excelWorksheet.Cells[p_strCell_From].End.Column;
		//		int v_intRowEnd = p_arrData.Count() + 1;
		//		int v_intColummEnd = p_dicHeader_Field.Count() + v_intColumnStart;
		//		using (var range = v_excelWorksheet.Cells[1, v_intColumnStart, 1, v_intColummEnd])
		//		{
		//			range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
		//		}
		//		int v_intKey_Value = 1;
		//		for (int i = v_intColumnStart; i < v_intColummEnd; i++)
		//		{
		//			v_excelWorksheet.Cells[v_intRowStart, i].Value = p_dicHeader_Field[v_intKey_Value][0].ToString();
		//			v_intKey_Value++;
		//		}
		//		foreach (T item in p_arrData)
		//		{
		//			v_intRowStart++;
		//			v_intKey_Value = 1;
		//			for (int i = v_intColumnStart; i < v_intColummEnd; i++)
		//			{
		//				v_excelWorksheet.Cells[v_intRowStart, i].Value = item.GetType().GetProperty(p_dicHeader_Field[v_intKey_Value][1]).GetValue(item).ToString();
		//				v_intKey_Value++;
		//			}
		//		}
		//		v_excelWorksheet.Cells[v_excelWorksheet.Dimension.Address].AutoFitColumns();
		//		v_fileContents = v_excelPackage.GetAsByteArray();
		//	}
		//	return v_fileContents;
		//}

        public static byte[] Export_Excel_Template(string p_strPath_File, int p_intSheet_Index, int p_iRow_Start, List<object[]> p_arrData)
        {
            byte[] v_arrContents;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage v_objPackage = new ExcelPackage(p_strPath_File))
            {
                var v_objWorksheet = v_objPackage.Workbook.Worksheets[p_intSheet_Index];// v_objPackage.Workbook.Worksheets.($"Sheet{p_intSheet_Index}");
                int v_intRowStart = p_iRow_Start;
                //int v_intColumnStart = 1;
                object[] v_objData = p_arrData[0];
                int v_intColummEnd = v_objData.Length;

                foreach (object[] item in p_arrData)
                {
                    v_intRowStart++;
                    for (int v_i = 0; v_i < v_intColummEnd; v_i++)
                    {
                        v_objWorksheet.Cells[v_intRowStart, v_i + 1].Value = item[v_i];
                    }
                }

                v_arrContents = v_objPackage.GetAsByteArray();
				v_objPackage.Dispose();
            }

            return v_arrContents;
        }

        public  byte[] Export_Excel_Grid(string p_strPath_File, int p_intSheet_Index, int p_iRow_Start,
            List<CCol_Grid_Property> p_arrCol_Grid, object[] p_objHeader_Band, object[] p_objHeader, int p_iLine_Band_End, DataTable p_dataTable)
        {
            byte[] v_arrContents;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //using (ExcelPackage v_objPackage = new ExcelPackage(p_strPath_File))
            {
                var v_objWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
                v_objWorksheet.CustomHeight = false;

                int v_intRowStart = p_iRow_Start;
                int v_intColummEnd = p_arrCol_Grid.Count;

                //fotmat all col 
                for (int v_i = 0; v_i < p_arrCol_Grid.Count; v_i++)
                {
                    int v_iCol = v_i + 1;
                    CCol_Grid_Property v_objCol_Grd = p_arrCol_Grid[v_i];
                    string v_strType_Name = v_objCol_Grd.Type_Name.ToLower();
                    string v_strField_Name = v_objCol_Grd.Field_Name.ToLower();
                    v_objWorksheet.Columns[v_iCol].Range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    //set width column
                    double v_dblWidthCell = CUtility.Convert_To_Double(v_objCol_Grd.Width_Col.Replace("px", ""));
                    v_objWorksheet.Column(v_iCol).Width = v_dblWidthCell / 7;
                    v_objWorksheet.Columns[v_iCol].Range.Style.WrapText = true;

                    //fotmat col datetime
                    if (v_strType_Name == "system.datetime")
                    {
                        string v_strFotmat_Date = CConfig.Date_Format_String;

                        if (v_strField_Name.StartsWith("ngay_gio") || v_strField_Name == "created" || v_strField_Name == "last_updated")
                        {
                            v_strFotmat_Date = CConfig.DateTime_Format_String;
                        }

                        v_objWorksheet.Columns[v_iCol].Range.Style.Numberformat.Format = v_strFotmat_Date;
                        v_objWorksheet.Columns[v_iCol].Range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    //fotmat colnumber
                    if (v_strType_Name == "system.int32" || v_strType_Name == "system.int64" || v_strType_Name == "system.double")
                    {
                        if (v_strField_Name.ToLower() != "auto_id")
                        {
                            string v_strFotmat_Number = "#,###,##0.##;-#,###,##0.##;-";
                            v_objWorksheet.Columns[v_iCol].Range.Style.Numberformat.Format = v_strFotmat_Number;
                            v_objWorksheet.Columns[v_iCol].Range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                        }
                    }
                }

                //set border row
                for (int v_i = 1; v_i < p_dataTable.Rows.Count + 2; v_i++)
                {
                    v_objWorksheet.Cells[v_i, 1, v_i, v_intColummEnd].Style.Border.Right.Style = ExcelBorderStyle.Dotted;
                    v_objWorksheet.Cells[v_i, 1, v_i, v_intColummEnd].Style.Border.Bottom.Style = ExcelBorderStyle.Dotted;
                }

                //ghi nội dung
                ExcelRange v_objExcelRange = v_objWorksheet.Cells[2, 1, p_dataTable.Rows.Count + 2, v_intColummEnd];
                v_objExcelRange.LoadFromDataTable(p_dataTable, false);

                //set style cho footer
                int v_iRow_End = p_dataTable.Rows.Count + 1;
                ExcelRange v_objRang_Footer = v_objWorksheet.Cells[v_iRow_End, p_iRow_Start, v_iRow_End, v_intColummEnd];
                v_objRang_Footer.Style.Fill.PatternType = ExcelFillStyle.Solid;
                v_objRang_Footer.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(242, 242, 242));
                v_objRang_Footer.Style.Font.Bold = true;
                v_objRang_Footer.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                v_objRang_Footer.Style.VerticalAlignment = ExcelVerticalAlignment.Center;


                //set style cho header ()
                ExcelRange v_objRang_Title = v_objWorksheet.Cells[p_iRow_Start, p_iRow_Start, p_iRow_Start, v_intColummEnd];
                v_objRang_Title.Style.Fill.PatternType = ExcelFillStyle.Solid;
                v_objRang_Title.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(242, 242, 242));
                v_objRang_Title.Style.Font.Bold = true;
                v_objRang_Title.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                v_objRang_Title.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                //ghi tiêu đề
                v_objRang_Title.LoadFromArrays(new List<object[]> { p_objHeader });

                //add thêm 1 dòng band column
                if (p_objHeader_Band != null)
                {
                    ExcelRange v_objRang_Band = v_objWorksheet.Cells[p_iRow_Start, p_iRow_Start, p_iRow_Start, v_intColummEnd];
                    v_objRang_Band.Insert(eShiftTypeInsert.EntireRow);
                    v_objRang_Band.EntireRow.Height = 27;
                    v_objRang_Band.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    v_objRang_Band.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(242, 242, 242));
                    v_objRang_Band.Style.Font.Bold = true;
                    v_objRang_Band.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    v_objRang_Band.Style.VerticalAlignment = ExcelVerticalAlignment.Center;


                    v_objRang_Band.Style.Border.Bottom.Style = ExcelBorderStyle.Dotted;

                    //set border right cho Band
                    for (int v_i = 0; v_i < p_objHeader_Band.Length; v_i++)
                    {
                        string v_strTitle = CUtility.Convert_To_String(p_objHeader_Band[v_i]);
                        if (v_strTitle != "")
                            v_objWorksheet.Cells[1, v_i + 1].Style.Border.Left.Style = ExcelBorderStyle.Dotted;

                    }
                    //kẻ border cuối cùng cho band
                    v_objWorksheet.Cells[1, p_iLine_Band_End + 1].Style.Border.Left.Style = ExcelBorderStyle.Dotted;
                    v_objRang_Band.LoadFromArrays(new List<object[]> { p_objHeader_Band });
                }

                v_arrContents = m_objExcel_Package.GetAsByteArray();
            }

            return v_arrContents;
        }

        public string Get_Cell_Value(string p_strCell)
		{
			return Get_Cell_Value(1, p_strCell);
		}

		public string Get_Cell_Value(int p_intSheet_Index, string p_strCell)
		{
			string v_strCell_Value;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			v_strCell_Value = CUtility.Convert_To_String(v_excelWorksheet.Cells[p_strCell].Value);
			
			return v_strCell_Value;
		}

        public string Get_Cell_Value(string p_strSheet_Name, string p_strCell)
        {
            string v_strCell_Value;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_strSheet_Name];
            v_strCell_Value = CUtility.Convert_To_String(v_excelWorksheet.Cells[p_strCell].Value);
            
			return v_strCell_Value;
        }

        public void Set_Cell_Value<T>(string p_strCell, T p_objValue_Cell)
		{
			Set_Cell_Value<T>(1, p_strCell, p_objValue_Cell);
		}

		public void Set_Cell_Value<T>(int p_intSheet_Index, string p_strCell, T p_objValue_Cell)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];
			v_excelWorksheet.Cells[p_strCell].Value = p_objValue_Cell.ToString();
		}

		public static ExcelWorksheet Bold_Text_List_Range_Value(string p_strCell_From, string p_strCell_End, ExcelWorksheet p_excelWorksheet)
		{
			ExcelWorksheet v_excelWorksheet = p_excelWorksheet;
			using (var range = v_excelWorksheet.Cells[$"{p_strCell_From}:{p_strCell_End}"])
			{

				range.Style.Font.Bold = true;
			}
			return v_excelWorksheet;
		}

		public static ExcelWorksheet Background_Color_List_Range_Value(string p_strCell_From, string p_strCell_End, string p_strColor, ExcelWorksheet p_excelWorksheet)
		{
			Color v_colFromHex = System.Drawing.ColorTranslator.FromHtml($"{p_strColor}");
			p_excelWorksheet.Cells[$"{p_strCell_From}:{p_strCell_End}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
			p_excelWorksheet.Cells[$"{p_strCell_From}:{p_strCell_End}"].Style.Fill.BackgroundColor.SetColor(v_colFromHex);
			return p_excelWorksheet;
		}

		public void Set_Value_To_Cell(int p_intSheet_Index, string p_strCell, object p_objValue)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
			v_excelWorksheet.Cells[p_strCell].Value = p_objValue;
		}

		public void Set_Value_To_Cell(string p_strCell, object p_objValue)
		{
			Set_Value_To_Cell(0, p_strCell, p_objValue);
		}

		public void Set_List_Range_Value(int p_intSheet_Index, int p_iCol_Start, int p_iCol_End, int p_intRowIndex, object[] p_arrValue)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
			string v_strCol_Start = CUtility.Get_Excel_ColumnName(p_iCol_Start);
			if (v_strCol_Start == "")
				v_strCol_Start = "A";

            string v_strCol_End = CUtility.Get_Excel_ColumnName(p_iCol_End);
			ExcelRange v_excelRange = v_excelWorksheet.Cells[$"{v_strCol_Start}{p_intRowIndex}:{v_strCol_End}{p_intRowIndex}"];

			v_excelRange.LoadFromArrays(new List<object[]> { p_arrValue });
		}

		public void Set_List_Range_Value(int p_iCol_Start, int p_iCol_End, int p_intRowIndex, object[] p_arrValue)
		{
			Set_List_Range_Value(0, p_iCol_Start, p_iCol_End, p_intRowIndex, p_arrValue);
		}

		public void Change_Sheet_Name(int p_iSheet_Index, string p_strSheet_Name)
		{
            m_objExcel_Package.Workbook.Worksheets[p_iSheet_Index].Name = p_strSheet_Name;
		}

		public void Save_File(string p_strFile_Path)
		{
			File.WriteAllBytes(p_strFile_Path, m_objExcel_Package.GetAsByteArray());

		}

		public void Delete_Row_Du_Thua(int p_iCol_Start, int p_iCol_End)
		{
			Delete_Row_Du_Thua(0, p_iCol_Start, p_iCol_End);
		}

		public void Delete_Row_Du_Thua(int p_intSheet_Index, int p_iStart, int p_iEnd)
		{
			int v_intNumber_Rows = p_iEnd - p_iStart + 1;
			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
				v_excelWorksheet.DeleteRow(p_iStart, v_intNumber_Rows);
		}

		public void Delete_Column_Du_Thua(int p_intSheet_Index, int p_iCol_Start, int p_iCol_End)
		{
			string v_strCol_Start = CUtility.Get_Excel_ColumnName(p_iCol_Start);
			string v_strCol_End = CUtility.Get_Excel_ColumnName(p_iCol_End);

			ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
			ExcelRange v_objRange = v_excelWorksheet.Cells[$"{v_strCol_Start}:{v_strCol_End}"];
			int v_intCol_Start = v_objRange.EntireColumn.StartColumn;
			int v_intCol_End = v_objRange.EntireColumn.EndColumn;
			int v_intNumber_Columns = v_intCol_End - v_intCol_Start + 1;
			v_excelWorksheet.DeleteColumn(v_intCol_Start, v_intNumber_Columns);
		}

		public void Delete_Column_Du_Thua(int p_iCol_Start, int p_iCol_End)
		{

			Delete_Column_Du_Thua(0, p_iCol_Start, p_iCol_End);
		}

		public void Close()
		{
			if (m_objExcel_Package != null)
				m_objExcel_Package.Dispose();

			m_objExcel_Package = null;

        }

        public void Set_Color_To_Cell(int p_intSheet_Index, string p_strCell, string p_strMa_Mau)
        {
            Color colFromHex = System.Drawing.ColorTranslator.FromHtml(p_strMa_Mau);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
            v_excelWorksheet.Cells[p_strCell].Style.Fill.PatternType = ExcelFillStyle.Solid;
            v_excelWorksheet.Cells[p_strCell].Style.Fill.BackgroundColor.SetColor(colFromHex);
            v_excelWorksheet.Cells[p_strCell].Style.Fill.PatternColor.SetColor(colFromHex);
        }

        public void Set_Font_Text_To_Cell(int p_intSheet_Index, string p_strCell, bool p_blBlod)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
            v_excelWorksheet.Cells[p_strCell].Style.Font.Bold = p_blBlod;
        }

        public void Set_Border_Text_To_Cell(int p_intSheet_Index, string p_strCell)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
            v_excelWorksheet.Cells[p_strCell].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            v_excelWorksheet.Cells[p_strCell].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            v_excelWorksheet.Cells[p_strCell].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            v_excelWorksheet.Cells[p_strCell].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
        }

        public void Set_Filter_Text_To_Cell(int p_intSheet_Index, string p_strCell)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
            v_excelWorksheet.Cells[p_strCell].AutoFilter = true;
        }

        public void Set_Merge_Cell(int p_intSheet_Index, string p_strCell_Start, string p_strCell_End)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
			string v_strRegion_Cell = p_strCell_Start + ":"+ p_strCell_End;
            v_excelWorksheet.Cells[v_strRegion_Cell].Merge = true;
        }

        public void Set_Function_To_Cell(int p_intSheet_Index, string p_strCell, string p_strFunction_Excel)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelWorksheet v_excelWorksheet = m_objExcel_Package.Workbook.Worksheets[p_intSheet_Index];
            v_excelWorksheet.Cells[p_strCell].Formula = p_strFunction_Excel;
        }

        public void Coppy_Sheet(string p_strSheet_Name , string p_strSheet_Name_New)
        {
			m_objExcel_Package.Workbook.Worksheets.Copy(p_strSheet_Name, p_strSheet_Name_New);
		}

		public void Delete_Sheet_Name(string p_srtfilePath, List<string> p_arrSheet_Name)
		{

			using (var package = new ExcelPackage(new FileInfo(p_srtfilePath)))
			{
				foreach (string v_strSheet_Name in p_arrSheet_Name)
				{
					var worksheet = package.Workbook.Worksheets[v_strSheet_Name];
					if (worksheet != null)
					{
						package.Workbook.Worksheets.Delete(worksheet);


					}
				}
				

				package.Save();
			}
		}

        public byte[] ConvertFileInfoToByteArray(FileInfo fileInfo)
        {
            using (FileStream fs = fileInfo.OpenRead())
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                return data;
            }
        }
    }
}
