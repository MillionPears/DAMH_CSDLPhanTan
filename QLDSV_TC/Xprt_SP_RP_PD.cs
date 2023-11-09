using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xprt_SP_RP_PD : DevExpress.XtraReports.UI.XtraReport
    {
        public Xprt_SP_RP_PD(string masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            
            this.sqlDataSource1.Fill();

        }

    }
}
