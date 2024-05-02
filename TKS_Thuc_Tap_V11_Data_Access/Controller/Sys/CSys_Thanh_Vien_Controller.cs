using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TKS_Thuc_Tap_V11_Data_Access.DataLayer;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Sys
{
    public class CSys_Thanh_Vien_Controller
    {
        public List<CSys_Thanh_Vien> FQ_531_TV_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_531_TV_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }
        public List<CSys_Thanh_Vien> FQ_531_TV_sp_sel_List()
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_531_TV_sp_sel_List");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }


        public List<CSys_Thanh_Vien> FQ_531_TV_sp_sel_List_For_Cache()
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_531_TV_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public CSys_Thanh_Vien FQ_531_TV_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Thanh_Vien v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_531_TV_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_dt.Rows[0]);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }

               public long FQ_531_TV_sp_ins_Insert(CSys_Thanh_Vien p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_531_TV_sp_ins_Insert",
                    p_objData.Ma_Dang_Nhap, p_objData.Mat_Khau, p_objData.Ho_Ten, p_objData.Email, p_objData.Dien_Thoai, p_objData.Trang_Thai_ID,
                    p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_531_TV_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_Thanh_Vien p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_531_TV_sp_ins_Insert",
                    p_objData.Ma_Dang_Nhap, p_objData.Mat_Khau, p_objData.Ho_Ten, p_objData.Email, p_objData.Dien_Thoai, p_objData.Trang_Thai_ID,
                    p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

       
        public void FQ_531_TV_sp_upd_Update(CSys_Thanh_Vien p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_531_TV_sp_upd_Update",
                    p_objData.Auto_ID, p_objData.Ma_Dang_Nhap, p_objData.Mat_Khau, p_objData.Ho_Ten, p_objData.Email, p_objData.Dien_Thoai,
                    p_objData.Trang_Thai_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }


        public void FQ_531_TV_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_531_TV_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

       
        public CSys_Thanh_Vien FQ_531_TV_sp_sel_Get_By_Ma_Dang_Nhap(string p_strMa_Dang_Nhap)
        {
            CSys_Thanh_Vien v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_531_TV_sp_sel_Get_By_Ma_Dang_Nhap", p_strMa_Dang_Nhap);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_dt.Rows[0]);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }


        public List<CSys_Thanh_Vien> F1004_sp_sel_List_Thanh_Vien_Khong_Thuoc_Nhom(long p_iNhom_Thanh_Vien_ID)
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F1004_sp_sel_List_Thanh_Vien_Khong_Thuoc_Nhom", p_iNhom_Thanh_Vien_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public void F1007_sp_upd_Doi_Mat_Khau(long p_iAuto_ID, string p_strMat_Khau_Moi, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1007_sp_upd_Doi_Mat_Khau", p_iAuto_ID,
                    p_strMat_Khau_Moi, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<CSys_Thanh_Vien> F1011_sp_sel_List_Thanh_Vien_Khong_Thuoc_Chu_Hang(long p_iChu_Hang_ID)
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F1011_sp_sel_List_Thanh_Vien_Khong_Thuoc_Chu_Hang", p_iChu_Hang_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public List<CSys_Thanh_Vien> F1012_sp_sel_List_Thanh_Vien_Khong_Thuoc_Kho(long p_iKho_ID)
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F1012_sp_sel_List_Thanh_Vien_Khong_Thuoc_Kho", p_iKho_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public List<CSys_Thanh_Vien> F1024_sp_sel_List_Thanh_Vien_Khong_Thuoc_Du_An(long p_iDu_An_ID)
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F1024_sp_sel_List_Thanh_Vien_Khong_Thuoc_Du_An", p_iDu_An_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public List<CSys_Thanh_Vien> F1037_sp_sel_List_Thanh_Vien_Khong_Thuoc_Nhom_PDA(long p_iNhom_PDA_ID)
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F1037_sp_sel_List_Thanh_Vien_Khong_Thuoc_Nhom_PDA", p_iNhom_PDA_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }
       

        public List<CSys_Thanh_Vien> F1025_sp_sel_List_Sys_Thanh_Vien()
        {
            List<CSys_Thanh_Vien> v_arrRes = new List<CSys_Thanh_Vien>();
            DataTable v_dt = new DataTable();

            try
            {

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F1025_sp_sel_List_Sys_Thanh_Vien");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Thanh_Vien v_objRes = CUtility.Map_Row_To_Entity<CSys_Thanh_Vien>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public void F1025_sp_upd_Reset_Mat_Khau_Thanh_Vien(CSys_Thanh_Vien p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1025_sp_upd_Reset_Mat_Khau_Thanh_Vien",
                    p_objData.Auto_ID, p_objData.Mat_Khau, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void F1005_sp_upd_Doi_Mat_Khau_Thanh_Vien(long p_iAuto_ID, string p_strMat_Khau_Moi)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1005_sp_upd_Doi_Mat_Khau_Thanh_Vien", p_iAuto_ID, p_strMat_Khau_Moi);
            }

            catch (Exception)
            {
                throw;
            }
        }

    }
}
