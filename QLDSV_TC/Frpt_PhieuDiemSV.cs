using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class Frpt_PhieuDiemSV : DevExpress.XtraEditors.XtraForm
    {
        public Frpt_PhieuDiemSV()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            Xprt_SP_RP_PD rpt = new Xprt_SP_RP_PD(txtMaSV.Text.ToString());
            rpt.lblMaSV.Text = txtMaSV.Text.ToUpper().ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);

            print.ShowPreviewDialog();
        }

       

        private void Frpt_PhieuDiemSV_Load(object sender, EventArgs e)
        {


            dS1.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;

            Program.bds_dspm.Filter = "TENCN LIKE 'KHOA%'";
            cbxKhoa.DataSource = Program.bds_dspm;
            cbxKhoa.DisplayMember = "TENCN";
            cbxKhoa.ValueMember = "TENSERVER";
            cbxKhoa.SelectedValue = Program.servername;

            if (Program.mGroup == "PGV")
            {
                cbxKhoa.Enabled = true;

            }
            else
            {
                cbxKhoa.Enabled = false;
            }


            cbxKhoa.SelectedIndex = Program.mChiNhanh;

            if(Program.mGroup == "SV")
            {
                txtMaSV.Text = Program.username.ToString();
                txtMaSV.Enabled = false;
            }
            else
            {
                txtMaSV.Enabled = true;
            }

        }

       

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbxKhoa.SelectedValue.ToString();
            if (cbxKhoa.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.mpassword;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Kết nối csdl thất bại!", "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}