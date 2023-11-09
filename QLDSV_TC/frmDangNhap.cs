using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private void layDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";

        }
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private int ketNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open) conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Close();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }

        }
        private Form checkExits(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String strLenh = "";
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login Name và Mật Khẩu không được để trống", "", MessageBoxButtons.OK);
                // trỏ con trỏ chuột về ô user...
                txtLogin.Focus();
                return;
            }

            if (chkSinhVien.Checked)
            {
                String username = txtLogin.Text;
                String password = txtPass.Text;
                Program.mlogin = "SVKN";
                Program.mpassword = "123";
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                strLenh = "EXEC [dbo].[SP_DANGNHAPSV]'" + Program.mlogin + "','" + username + "','" + password + "'";


            }
            else
            {
                Program.mlogin = txtLogin.Text;
                Program.password = txtPass.Text;
                Program.mpassword = Program.password;
                if (Program.KetNoi() == 0) return;

                Program.mloginDN = Program.mlogin;
                strLenh = "EXEC SP_Lay_Thong_Tin_NV_Tu_Login'" + Program.mlogin + "'";

            }
            Program.mChiNhanh = cbxChiNhanh.SelectedIndex;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login Bạn nhập không có quyền truy cập dữ liệu \nBạn xem lại Username, Password", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Login bạn nhập không có quyền truy cập vào chương trình", "", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Close();
            Program.conn.Close();
           // Program.frmChinh.hienThiMenu();

            //..................

            Form frm = this.checkExits(typeof(frmMain));
            if (frm != null) frm.Activate();
            else
            {
                frmMain f = new frmMain();
             //   f.MdiParent = fr;
                f.Show();



            }
            this.Visible = false;





        }

        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbxChiNhanh.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (ketNoi_CSDLGOC() == 0) return;
            layDSPM("SELECT * FROM Get_Subscribes");
            cbxChiNhanh.SelectedIndex = 1; cbxChiNhanh.SelectedIndex = 0;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap1_Click(object sender, EventArgs e)
        {
            String strLenh = "";
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login Name và Mật Khẩu không được để trống", "", MessageBoxButtons.OK);
                // trỏ con trỏ chuột về ô user...
                txtLogin.Focus();
                return;
            }

            if (chkSinhVien.Checked)
            {
                String username = txtLogin.Text;
                String password = txtPass.Text;
                Program.mlogin = "SVKN";
                Program.mpassword = "123";
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                strLenh = "EXEC [dbo].[SP_DANGNHAPSV]'" + Program.mlogin + "','" + username + "','" + password + "'";


            }
            else
            {
                Program.mlogin = txtLogin.Text;
                Program.password = txtPass.Text;
                Program.mpassword = Program.password;
                if (Program.KetNoi() == 0) return;

                Program.mloginDN = Program.mlogin;
                strLenh = "EXEC SP_Lay_Thong_Tin_NV_Tu_Login'" + Program.mlogin + "'";

            }
            Program.mChiNhanh = cbxChiNhanh.SelectedIndex;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login Bạn nhập không có quyền truy cập dữ liệu \nBạn xem lại Username, Password", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Login bạn nhập không có quyền truy cập vào chương trình", "", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Close();
            Program.conn.Close();
           // Program.frmChinh.hienThiMenu();

            //..................





        }
    }
}