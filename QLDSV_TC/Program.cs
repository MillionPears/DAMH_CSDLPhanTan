using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_TC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;

        public static String servername = "";
       /* public static String servername1 = "LAPTOP-BB4P1S1G\\MSSQLSERVER01";
        public static String servername2 = "LAPTOP-BB4P1S1G\\MSSQLSERVER02";
        public static String servername3 = "LAPTOP-BB4P1S1G\\MSSQLSERVER03";*/
        public static String servername1 = "";
        public static String servername2 = "";
        public static String servername3 = "";

        public static String username;
        public static String password = "123";
        public static String database = "QLDSV_TC";
        public static String mlogin = "sa";

        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";

        public static String mGroup;
        public static String mHoten;
        public static String mloginDN;
        public static String mpassword;
        public static String passwordDN;
        public static String connstr_publisher = "Data Source=LAPTOP-BB4P1S1G;Initial Catalog=QLDSV_TC;User ID=sa;password=123";

        public static int mChiNhanh = 0;
        public static BindingSource bds_dspm = new BindingSource();// giữ bds khi đăng nhập.
        public static frmDangNhap frmChinh;

        
        //trieu
        public static int hocPhi = 550000;
        public static int mKhoa = 0;
        // han
        public static String Control = "";
        public static String mMAKHOA = "";
        public static string[] NhomQuyen = new string[4] { "PGV", "Khoa", "PKT", "SV" };




        //trieu
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu hello.\nBạn xem lại user name và password.\n " + connstr + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myreader;
            //Program.conn = new SqlConnection(connectionstring);

            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);

            sqlcmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {

                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show("từ choi" + ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt1 = new DataTable();
            conn = new SqlConnection(connectionstring);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt1);
            return dt1;

        }
        // Hàm thực thi truy vấn có ther chỉnh sửa
        public static DataTable ExecSqlQuery(String strLenh)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(strLenh, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }

        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }

        //trieu
        // Hàm kiểm tra giá trị trả về có phải duy nhất hay không
        public static int CheckPrimaryKey(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            if (dataReader == null)
                return -1;

            dataReader.Read();
            int result = dataReader.GetInt32(0);
            dataReader.Close();
            return result;
        }



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmDangNhap();

            Application.Run(frmChinh);

        }
    }
}


