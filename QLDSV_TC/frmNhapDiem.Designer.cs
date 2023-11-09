
using System.Drawing;
using System.Windows.Forms;

namespace QLDSV_TC
{
    partial class frmNhapDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnBatdau = new DevExpress.XtraEditors.SimpleButton();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS1 = new QLDSV_TC.DS1();
            this.cbxHocKy = new System.Windows.Forms.ComboBox();
            this.cbxNhom = new System.Windows.Forms.ComboBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.cbxNienKhoa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_TC.DS1TableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS1TableAdapters.TableAdapterManager();
            this.bdsDSNhapDiem = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GETDSNHAPDIEMTableAdapter = new QLDSV_TC.DS1TableAdapters.SP_GETDSNHAPDIEMTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMGKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMHETMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONHOCTableAdapter = new QLDSV_TC.DS1TableAdapters.MONHOCTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNhapDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnBatdau);
            this.panel2.Controls.Add(this.cbxMonHoc);
            this.panel2.Controls.Add(this.cbxHocKy);
            this.panel2.Controls.Add(this.cbxNhom);
            this.panel2.Controls.Add(this.cbxKhoa);
            this.panel2.Controls.Add(this.cbxNienKhoa);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 169);
            this.panel2.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Appearance.Options.UseForeColor = true;
            this.btnCapNhat.Location = new System.Drawing.Point(309, 115);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 34);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnBatdau
            // 
            this.btnBatdau.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnBatdau.Appearance.Options.UseForeColor = true;
            this.btnBatdau.Location = new System.Drawing.Point(159, 115);
            this.btnBatdau.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.Size = new System.Drawing.Size(121, 34);
            this.btnBatdau.TabIndex = 2;
            this.btnBatdau.Text = "Bắt Đầu";
            this.btnBatdau.Click += new System.EventHandler(this.btnBatdau_Click);
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.DataSource = this.mONHOCBindingSource;
            this.cbxMonHoc.DisplayMember = "TENMH";
            this.cbxMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(402, 36);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(150, 28);
            this.cbxMonHoc.TabIndex = 1;
            this.cbxMonHoc.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.DS1;
            // 
            // DS1
            // 
            this.DS1.DataSetName = "DS1";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxHocKy
            // 
            this.cbxHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHocKy.FormattingEnabled = true;
            this.cbxHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxHocKy.Location = new System.Drawing.Point(117, 70);
            this.cbxHocKy.Name = "cbxHocKy";
            this.cbxHocKy.Size = new System.Drawing.Size(150, 28);
            this.cbxHocKy.TabIndex = 1;
            this.cbxHocKy.SelectedIndexChanged += new System.EventHandler(this.cbxHocKy_SelectedIndexChanged);
            // 
            // cbxNhom
            // 
            this.cbxNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhom.FormattingEnabled = true;
            this.cbxNhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxNhom.Location = new System.Drawing.Point(402, 73);
            this.cbxNhom.Name = "cbxNhom";
            this.cbxNhom.Size = new System.Drawing.Size(150, 28);
            this.cbxNhom.TabIndex = 1;
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(771, 0);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(264, 28);
            this.cbxKhoa.TabIndex = 1;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // cbxNienKhoa
            // 
            this.cbxNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNienKhoa.FormattingEnabled = true;
            this.cbxNienKhoa.Location = new System.Drawing.Point(117, 36);
            this.cbxNienKhoa.Name = "cbxNienKhoa";
            this.cbxNienKhoa.Size = new System.Drawing.Size(150, 28);
            this.cbxNienKhoa.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = " Môn học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = " Nhóm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = " Học kì:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = " Niên khóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập thông tin:";
            // 
            // bdsLopTinChi
            // 
            this.bdsLopTinChi.DataMember = "LOPTINCHI";
            this.bdsLopTinChi.DataSource = this.DS1;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.DSGVTableAdapter = null;
            this.tableAdapterManager.DSMHTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDSNhapDiem
            // 
            this.bdsDSNhapDiem.DataMember = "SP_GETDSNHAPDIEM";
            this.bdsDSNhapDiem.DataSource = this.DS1;
            // 
            // sP_GETDSNHAPDIEMTableAdapter
            // 
            this.sP_GETDSNHAPDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvDiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 215);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1197, 361);
            this.panelControl1.TabIndex = 2;
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AutoGenerateColumns = false;
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.dIEMCCDataGridViewTextBoxColumn,
            this.dIEMGKDataGridViewTextBoxColumn,
            this.dIEMCKDataGridViewTextBoxColumn,
            this.DIEMHETMON});
            this.dgvDiem.DataSource = this.bdsDSNhapDiem;
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(2, 2);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 62;
            this.dgvDiem.RowTemplate.Height = 28;
            this.dgvDiem.Size = new System.Drawing.Size(1193, 357);
            this.dgvDiem.TabIndex = 0;
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MÃ SINH VIÊN";
            this.mASVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            this.mASVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "HỌ TÊN";
            this.hOTENDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIEMCCDataGridViewTextBoxColumn
            // 
            this.dIEMCCDataGridViewTextBoxColumn.DataPropertyName = "DIEM_CC";
            this.dIEMCCDataGridViewTextBoxColumn.HeaderText = "ĐIỂM CC";
            this.dIEMCCDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dIEMCCDataGridViewTextBoxColumn.Name = "dIEMCCDataGridViewTextBoxColumn";
            // 
            // dIEMGKDataGridViewTextBoxColumn
            // 
            this.dIEMGKDataGridViewTextBoxColumn.DataPropertyName = "DIEM_GK";
            this.dIEMGKDataGridViewTextBoxColumn.HeaderText = "ĐIỂM GK";
            this.dIEMGKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dIEMGKDataGridViewTextBoxColumn.Name = "dIEMGKDataGridViewTextBoxColumn";
            // 
            // dIEMCKDataGridViewTextBoxColumn
            // 
            this.dIEMCKDataGridViewTextBoxColumn.DataPropertyName = "DIEM_CK";
            this.dIEMCKDataGridViewTextBoxColumn.HeaderText = "ĐIỂM CK";
            this.dIEMCKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dIEMCKDataGridViewTextBoxColumn.Name = "dIEMCKDataGridViewTextBoxColumn";
            // 
            // DIEMHETMON
            // 
            this.DIEMHETMON.HeaderText = "ĐIỂM HẾT MÔN";
            this.DIEMHETMON.MinimumWidth = 8;
            this.DIEMHETMON.Name = "DIEMHETMON";
            this.DIEMHETMON.ReadOnly = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 948);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNhapDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxHocKy;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.ComboBox cbxNienKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnBatdau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.ComboBox cbxNhom;
        private DS1 DS1;
        private System.Windows.Forms.BindingSource bdsLopTinChi;
        private DS1TableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsDSNhapDiem;
        private DS1TableAdapters.SP_GETDSNHAPDIEMTableAdapter sP_GETDSNHAPDIEMTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvDiem;
        private DataGridViewTextBoxColumn DIEMHETMON;
        private DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dIEMCCDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dIEMGKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dIEMCKDataGridViewTextBoxColumn;
        private BindingSource mONHOCBindingSource;
        private DS1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
    }
}