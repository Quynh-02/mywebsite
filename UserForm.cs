using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;

namespace QLPhongKham
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        //string opt = "";
       // QL_PhongkhamEntities db = new QL_PhongkhamEntities();

        public UserForm()
        {
            InitializeComponent();
            LoadGrd();
            SetControl("Reset");
        }

        #region Connect UC
        public static UserForm _instrance;
        public static UserForm Instrance
        {

            get
            {
                if (_instrance == null)
                    _instrance = new UserForm();
                return _instrance;
            }
        }

        #endregion

        #region Variables
        public static string Status = "";
        public static string ConnectionString = @"Data Source=DESKTOP-85CF1R9\SQLEXPRESS;Initial Catalog=QL_PhongKham;Integrated Security=True";
        SqlConnection conn;
        public static DataSet ds;
        #endregion

        private void LoadGrd()
        {
            conn = new SqlConnection(ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT * FROM tblTaiKhoan WHERE Quyen = '1'  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                GridDSTaiKhoan.DataSource = ds.Tables[0];
            }
            else
            {
                GridDSTaiKhoan.DataSource = null;
                lbl_BanGhi.Text = "Tổng số: 0 bản ghi";
            }
            BanGhi();
            BindingData();
        }
        public void BanGhi()
        {
            lbl_BanGhi.Text = "Tổng số bản ghi: " + ds.Tables[0].Rows.Count.ToString() + " bản ghi";
        }
        public void BindingData()
        {
            txt_ID.DataBindings.Clear();
            txt_TenTaiKhoan.DataBindings.Clear();
            txt_MatKhau.DataBindings.Clear();
            txt_Email.DataBindings.Clear();

            txt_ID.DataBindings.Add(new Binding("Text", ds.Tables[0], "ID", false, DataSourceUpdateMode.Never));
            txt_TenTaiKhoan.DataBindings.Add(new Binding("Text", ds.Tables[0], "TenTaiKhoan", false, DataSourceUpdateMode.Never));
            txt_MatKhau.DataBindings.Add(new Binding("Text", ds.Tables[0], "MatKhau", false, DataSourceUpdateMode.Never));
            txt_Email.DataBindings.Add(new Binding("Text", ds.Tables[0], "Email", false, DataSourceUpdateMode.Never));
        }
        #region Public Function
        public void SetControl(string Status)
        {
            switch (Status)
            {
                case "Reset":

                    lbl_ThongBao.Text = "";

                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_Luu.Enabled = false;
                    btn_QuayLai.Enabled = false;
                    btn_TTTimKiem.Enabled = true;
                    btn_TimKiem.Enabled = false;
                    btn_XuatE.Enabled = false;

                    txt_ID.Enabled = false;
                    txt_TenTaiKhoan.Enabled = false;
                    txt_MatKhau.Enabled = false;
                    txt_Email.Enabled = false;

                    txt_ID.Focus();
                    break;
                case "Insert":
                    lbl_ThongBao.Text = "";

                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_Luu.Enabled = false;
                    btn_QuayLai.Enabled = false;
                    btn_TTTimKiem.Enabled = true;
                    btn_TimKiem.Enabled = false;
                    btn_XuatE.Enabled = false;

                    txt_ID.Enabled = false;
                    txt_TenTaiKhoan.Enabled = false;
                    txt_MatKhau.Enabled = false;
                    txt_Email.Enabled = false;

                    txt_ID.Focus();

                    break;

                case "Update":
                    lbl_ThongBao.Text = "";

                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_Luu.Enabled = false;
                    btn_QuayLai.Enabled = false;
                    btn_TTTimKiem.Enabled = true;
                    btn_TimKiem.Enabled = false;
                    btn_XuatE.Enabled = false;

                    txt_ID.Enabled = false;
                    txt_TenTaiKhoan.Enabled = false;
                    txt_MatKhau.Enabled = false;
                    txt_Email.Enabled = false;

                    txt_ID.Focus();

                    break;
                case "Delete":
                    lbl_ThongBao.Text = "";

                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_Luu.Enabled = false;
                    btn_QuayLai.Enabled = false;
                    btn_TTTimKiem.Enabled = true;
                    btn_TimKiem.Enabled = false;
                    btn_XuatE.Enabled = false;

                    txt_ID.Enabled = false;
                    txt_TenTaiKhoan.Enabled = false;
                    txt_MatKhau.Enabled = false;
                    txt_Email.Enabled = false;

                    break;
                case "Search":
                    lbl_ThongBao.Text = "";

                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_Luu.Enabled = false;
                    btn_QuayLai.Enabled = false;
                    btn_TTTimKiem.Enabled = true;
                    btn_TimKiem.Enabled = false;
                    btn_XuatE.Enabled = false;

                    txt_ID.Enabled = false;
                    txt_TenTaiKhoan.Enabled = false;
                    txt_MatKhau.Enabled = false;
                    txt_Email.Enabled = false;

                    break;
                default:
                    break;
            }
        }
        public void Clear()


        {
            txt_ID.Text = "";

            txt_TenTaiKhoan.Text = "";
            txt_MatKhau.Text = "";
            txt_Email.Text = "";


        }
        public bool CheckExits(String ID)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sqlCheck = "CHECK_EXITS_TaiKhoan";
                SqlCommand cmd = new SqlCommand(sqlCheck, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", ID);
                DataSet dsCheck = new DataSet();
                da.Fill(dsCheck);
                if (dsCheck != null && dsCheck.Tables.Count > 0 && dsCheck.Tables[0].Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return true;
            }
        }
        public void InsertData()
        {
            try
            {
                if (txt_TenTaiKhoan.Text.Trim() == "")
                {
                    lbl_ThongBao.Text = "Nhập vào Tên tài khoản";
                    txt_TenTaiKhoan.Focus();
                }
                else if (txt_MatKhau.Text.Trim() == "")
                {
                    lbl_ThongBao.Text = "Nhập vào Mật khẩu";
                    txt_MatKhau.Focus();
                }
                else if (txt_Email.Text.Trim() == "")
                {
                    lbl_ThongBao.Text = "Nhập vào Email";
                    txt_MatKhau.Focus();
                }
                else
                {
                    string sqlInsert = "[INSERT_tblTaiKhoan]";
                    SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", txt_TenTaiKhoan.Text.Trim());
                    cmd.Parameters.AddWithValue("@MatKhau", txt_MatKhau.Text.Trim());
                    cmd.Parameters.AddWithValue("@EMail", txt_Email.Text.Trim());
                    cmd.Parameters.Add("@ID_OUT", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        LoadGrd();
                        lbl_ThongBao.Text = "Thêm thành công!";
                        Clear();
                    }
                    else
                    {
                        lbl_ThongBao.Text = "Không thể thêm!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        public void UpdateData()
        {
            try
            {
                if (txt_TenTaiKhoan.Text.Trim() == "")
                {
                    lbl_ThongBao.Text = "Nhập vào tên tài khoản";
                    txt_TenTaiKhoan.Focus();
                }
                else if (txt_MatKhau.Text.Trim() == "")
                {
                    lbl_ThongBao.Text = "Nhập vào Mật khẩu";
                    txt_MatKhau.Focus();
                }

                else if (txt_Email.Text.Trim() == "")
                {
                    lbl_ThongBao.Text = "Nhập vào Email";
                    txt_Email.Focus();
                }
                else
                {
                    string sqlInsert = "[INSERT_tblTaiKhoan]";
                    SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", txt_TenTaiKhoan.Text.Trim());
                    cmd.Parameters.AddWithValue("@MatKhau", txt_MatKhau.Text.Trim());
                    cmd.Parameters.AddWithValue("@EMail", txt_Email.Text.Trim());
                    cmd.Parameters.Add("@ID_OUT", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        LoadGrd();
                        lbl_ThongBao.Text = "Sửa thành công!";
                    }
                    else
                    {
                        lbl_ThongBao.Text = "Không thể Sửa!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        public void DeleteData()
        {
            try
            {
                if (txt_ID.Text.Trim() == "")
                {
                    lbl_ThongBao.Text = "Nhập vào ID";
                    txt_ID.Focus();
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        string sqlDelete = "DELETE_tblTaiKhoan";
                        SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                        cmd.Parameters.AddWithValue("@ID_OUT", txt_ID.Text.Trim());
                        cmd.CommandType = CommandType.StoredProcedure;
                        var result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Clear();
                            LoadGrd();
                            SetControl("Reset");
                            lbl_ThongBao.Text = "Đã xóa";
                        }
                    }
                    else
                    {
                        Clear();
                        SetControl("Reset");
                        BindingData();
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        public void SearchData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string sqlSearch = "SEARCH_tblTaiKhoan";
                SqlCommand cmd = new SqlCommand(sqlSearch, conn);

                cmd.Parameters.AddWithValue("@ID_OUT", txt_ID.Text.Trim());
                cmd.Parameters.AddWithValue("@TenTaiKhoan", txt_TenTaiKhoan.Text.Trim());
                cmd.Parameters.AddWithValue("@MatKhau", txt_MatKhau.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text.Trim());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
                GridDSTaiKhoan.DataSource = ds.Tables[0];
                GridDSTaiKhoan.Refresh();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        } 

            #endregion

      
       

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Status == "Insert")
            {
                bool cExits = false;
                cExits = CheckExits(txt_TenTaiKhoan.Text.Trim());
                if (cExits == false)
                {
                    lbl_ThongBao.Text = "Đã tồn tại Tên Tài Khoản: " + txt_TenTaiKhoan.Text.Trim() + " trong hệ thống";
                    return;
                }
                InsertData();
            }
            else if (Status == "Update")
            {
                UpdateData();
            }
        }

        private void btn_QuayLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                Clear();
                LoadGrd();
                Status = "Reset";
                SetControl(Status);
            }

        }

        private void btn_TTTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Clear();
                Status = "Search";
                SetControl(Status);

            }
            catch (Exception ex)
            {
                lbl_ThongBao.Text = ex.Message;
            }
        
    }

        private void btn_TimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SearchData();

            }
            catch (Exception ex)
            {
                lbl_ThongBao.Text = ex.Message;

            }
        }

        private void btn_Sua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                Status = "Update";
                SetControl(Status);
            }
            catch (Exception ex)
            {
                lbl_ThongBao.Text = ex.Message;
            }
        }
        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Clear();
                Status = "Insert";
                SetControl(Status);
            }
            catch (Exception ex)
            {
                lbl_ThongBao.Text = ex.Message;
            }
        }

        private void GridDSTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn colum = info.Column;

            }
        }

        private void btn_Xoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Status = "Delete";
                SetControl(Status);
                DeleteData();
            }
            catch (Exception ex)
            {
                lbl_ThongBao.Text = ex.Message;

            }
        }

       
    }
}
