
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FrmTaoTaiKhoan : Form
    {
        private bool checkFormData()
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Mã tài khoản không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtUserName.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Mã tài khoản không được chứa khoảng trắng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtPassWord.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtConfirm.Text.Trim() == "")
            {
                MessageBox.Show("Xác thực mật khẩu không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassWord.Text != txtConfirm.Text)
            {
                MessageBox.Show("Xác thực mật khẩu không trùng khớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbbMaGV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giảng viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void getTeacher()
        {
            string command = "SELECT MAGV, HOTEN = RTRIM(MAGV) + ' - ' + HO + ' ' + TEN FROM GIANGVIEN";
            DataTable data = Program.ExecSqlDataTable(command);
            BindingSource bdsGV = new BindingSource();
            bdsGV.DataSource = data;

            cbbMaGV.DataSource = bdsGV;
            cbbMaGV.DisplayMember = "HOTEN";
            cbbMaGV.ValueMember = "MAGV";
        }

        public FrmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.KHOA' table. You can move, or remove it, as needed.
            qLDSV_TCDataSet.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet.KHOA);
            cbbKhoa.DataSource = Program.bds_dspm;
            cbbKhoa.DisplayMember = "TENCN";
            cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedValue = Program.servername;

            getTeacher();

            if (Program.mGroup == "PGV")
            {
                cbbKhoa.Enabled = true;
                rdgGroup.Properties.Items[0].Enabled = true;
                rdgGroup.Properties.Items[1].Enabled = true;
                rdgGroup.Properties.Items[2].Enabled = false;

                rdgGroup.SelectedIndex = 0;
            }
            else if (Program.mGroup == "KHOA")
            {
                cbbKhoa.Enabled = false;
                rdgGroup.Properties.Items[1].Enabled = true;
                rdgGroup.Properties.Items[0].Enabled = false;
                rdgGroup.Properties.Items[2].Enabled = false;
                rdgGroup.SelectedIndex = 1;
            }
            else
            {
                cbbKhoa.Enabled = false;
                rdgGroup.Properties.Items[2].Enabled = true;
                rdgGroup.Properties.Items[1].Enabled = false;
                rdgGroup.Properties.Items[0].Enabled = false;
                rdgGroup.SelectedIndex = 2;
            }
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbbKhoa.SelectedValue.ToString();

            if (cbbKhoa.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.mpassword = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.mpassword = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length > 0 || txtPassWord.Text.Trim().Length > 0 || txtConfirm.Text.Trim().Length > 0 || cbbMaGV.SelectedIndex == -1)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFormData())
            {
                String login = txtUserName.Text.Trim();
                String password = txtPassWord.Text.Trim();
                String user = cbbMaGV.SelectedValue.ToString().Trim();
                String role = rdgGroup.EditValue.ToString();

                MessageBox.Show(login + "-----" + password + "-------" + user + "------" + role + "-------");

                String query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_TAOLOGIN]" +

                               " N'" + login + "', " +

                               " N'" + password + "', " +

                               " N'" + user + "', " +

                               " N'" + role + "'" +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Giảng viên này đã có tài khoản. Vui lòng chọn lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resultMa == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
