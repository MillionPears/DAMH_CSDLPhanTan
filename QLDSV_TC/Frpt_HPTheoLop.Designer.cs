
namespace QLDSV_TC
{
    partial class Frpt_HPTheoLop
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIN = new DevExpress.XtraEditors.SimpleButton();
            this.cbxHocKy = new System.Windows.Forms.ComboBox();
            this.cbxNienKhoa = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_HP = new QLDSV_TC.DS_HP();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sINHVIENTableAdapter = new QLDSV_TC.DS_HPTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DS_HPTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnIN);
            this.panelControl1.Controls.Add(this.cbxHocKy);
            this.panelControl1.Controls.Add(this.cbxNienKhoa);
            this.panelControl1.Controls.Add(this.cbxLop);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(898, 337);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.Location = new System.Drawing.Point(408, 175);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIN
            // 
            this.btnIN.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnIN.Appearance.Options.UseForeColor = true;
            this.btnIN.Location = new System.Drawing.Point(259, 175);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(112, 34);
            this.btnIN.TabIndex = 2;
            this.btnIN.Text = "IN";
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // cbxHocKy
            // 
            this.cbxHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHocKy.FormattingEnabled = true;
            this.cbxHocKy.Location = new System.Drawing.Point(259, 118);
            this.cbxHocKy.Name = "cbxHocKy";
            this.cbxHocKy.Size = new System.Drawing.Size(241, 27);
            this.cbxHocKy.TabIndex = 1;
            this.cbxHocKy.SelectedIndexChanged += new System.EventHandler(this.cbxHocKy_SelectedIndexChanged);
            // 
            // cbxNienKhoa
            // 
            this.cbxNienKhoa.DisplayMember = "NIENKHOA";
            this.cbxNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNienKhoa.FormattingEnabled = true;
            this.cbxNienKhoa.Location = new System.Drawing.Point(259, 85);
            this.cbxNienKhoa.Name = "cbxNienKhoa";
            this.cbxNienKhoa.Size = new System.Drawing.Size(241, 27);
            this.cbxNienKhoa.TabIndex = 1;
            this.cbxNienKhoa.ValueMember = "NIENKHOA";
            this.cbxNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxNienKhoa_SelectedIndexChanged);
            // 
            // cbxLop
            // 
            this.cbxLop.DataSource = this.sINHVIENBindingSource;
            this.cbxLop.DisplayMember = "MALOP";
            this.cbxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(259, 46);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(241, 27);
            this.cbxLop.TabIndex = 1;
            this.cbxLop.ValueMember = "MALOP";
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLop_SelectedIndexChanged);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS_HP;
            // 
            // dS_HP
            // 
            this.dS_HP.DataSetName = "DS_HP";
            this.dS_HP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = " Học Kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = " Niên Khóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = " Mã Lớp:";
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_HPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frpt_HPTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 613);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frpt_HPTheoLop";
            this.Text = "In Học Phí Lớp";
            this.Load += new System.EventHandler(this.Frpt_HPTheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_HP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnIN;
        private System.Windows.Forms.ComboBox cbxHocKy;
        private System.Windows.Forms.ComboBox cbxNienKhoa;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS_HP dS_HP;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DS_HPTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DS_HPTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}