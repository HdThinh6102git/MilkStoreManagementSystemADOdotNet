
namespace FinalADOdotNET
{
    partial class fMain
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.USP_GetBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MilkShopProjectDataSet = new FinalADOdotNET.MilkShopProjectDataSet();
            this.dgvMilk = new System.Windows.Forms.DataGridView();
            this.milkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MilkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extantAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusPhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMilkName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.cbCusGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmCusBoughtAmount = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_GetBillTableAdapter = new FinalADOdotNET.MilkShopProjectDataSetTableAdapters.USP_GetBillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilkShopProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilk)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCusBoughtAmount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_GetBillBindingSource
            // 
            this.USP_GetBillBindingSource.DataMember = "USP_GetBill";
            this.USP_GetBillBindingSource.DataSource = this.MilkShopProjectDataSet;
            // 
            // MilkShopProjectDataSet
            // 
            this.MilkShopProjectDataSet.DataSetName = "MilkShopProjectDataSet";
            this.MilkShopProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvMilk
            // 
            this.dgvMilk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMilk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.milkID,
            this.MilkName,
            this.price,
            this.extantAmount,
            this.soldAmount});
            this.dgvMilk.Location = new System.Drawing.Point(0, 75);
            this.dgvMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMilk.Name = "dgvMilk";
            this.dgvMilk.RowHeadersWidth = 62;
            this.dgvMilk.Size = new System.Drawing.Size(1200, 152);
            this.dgvMilk.TabIndex = 0;
            this.dgvMilk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMilk_CellClick);
            // 
            // milkID
            // 
            this.milkID.DataPropertyName = "milkID";
            this.milkID.HeaderText = "ID";
            this.milkID.MinimumWidth = 8;
            this.milkID.Name = "milkID";
            // 
            // MilkName
            // 
            this.MilkName.DataPropertyName = "MilkName";
            this.MilkName.HeaderText = "Tên sữa";
            this.MilkName.MinimumWidth = 8;
            this.MilkName.Name = "MilkName";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            // 
            // extantAmount
            // 
            this.extantAmount.DataPropertyName = "extantAmount";
            this.extantAmount.HeaderText = "Số lượng còn";
            this.extantAmount.MinimumWidth = 8;
            this.extantAmount.Name = "extantAmount";
            // 
            // soldAmount
            // 
            this.soldAmount.DataPropertyName = "soldAmount";
            this.soldAmount.HeaderText = "Số lượng đã bán";
            this.soldAmount.MinimumWidth = 8;
            this.soldAmount.Name = "soldAmount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(88, 48);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(331, 26);
            this.txtCusName.TabIndex = 4;
            // 
            // txtCusPhoneNum
            // 
            this.txtCusPhoneNum.Location = new System.Drawing.Point(876, 51);
            this.txtCusPhoneNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusPhoneNum.Name = "txtCusPhoneNum";
            this.txtCusPhoneNum.Size = new System.Drawing.Size(217, 26);
            this.txtCusPhoneNum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên sữa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            // 
            // txtMilkName
            // 
            this.txtMilkName.Location = new System.Drawing.Point(141, 131);
            this.txtMilkName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMilkName.Name = "txtMilkName";
            this.txtMilkName.Size = new System.Drawing.Size(278, 26);
            this.txtMilkName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng tiền:";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Location = new System.Drawing.Point(141, 183);
            this.txtTotalMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(390, 26);
            this.txtTotalMoney.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(700, 172);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 45);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Tính tiền";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.cbCusGender);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nmCusBoughtAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCusName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTotalMoney);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCusPhoneNum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMilkName);
            this.panel1.Location = new System.Drawing.Point(9, 464);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 225);
            this.panel1.TabIndex = 16;
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(931, 175);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(209, 45);
            this.btnReload.TabIndex = 28;
            this.btnReload.Text = "Khách hàng mới";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbCusGender
            // 
            this.cbCusGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCusGender.FormattingEnabled = true;
            this.cbCusGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbCusGender.Location = new System.Drawing.Point(555, 48);
            this.cbCusGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCusGender.Name = "cbCusGender";
            this.cbCusGender.Size = new System.Drawing.Size(103, 28);
            this.cbCusGender.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Khách hàng";
            // 
            // nmCusBoughtAmount
            // 
            this.nmCusBoughtAmount.Location = new System.Drawing.Point(561, 131);
            this.nmCusBoughtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmCusBoughtAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmCusBoughtAmount.Name = "nmCusBoughtAmount";
            this.nmCusBoughtAmount.Size = new System.Drawing.Size(58, 26);
            this.nmCusBoughtAmount.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsAdmin
            // 
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(86, 29);
            this.tsAdmin.Text = "Admin ";
            this.tsAdmin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 242);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Chi tiết hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 29);
            this.label10.TabIndex = 29;
            this.label10.Text = "Thông tin sữa";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.USP_GetBillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalADOdotNET.ReportBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 274);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1184, 182);
            this.reportViewer1.TabIndex = 31;
            // 
            // USP_GetBillTableAdapter
            // 
            this.USP_GetBillTableAdapter.ClearBeforeFill = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 692);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMilk);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn thanh toán tiệm sữa";
            this.Load += new System.EventHandler(this.fMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilkShopProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCusBoughtAmount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMilk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMilkName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsAdmin;
        private System.Windows.Forms.NumericUpDown nmCusBoughtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCusGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn milkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MilkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn extantAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReload;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_GetBillBindingSource;
        private MilkShopProjectDataSet MilkShopProjectDataSet;
        private MilkShopProjectDataSetTableAdapters.USP_GetBillTableAdapter USP_GetBillTableAdapter;
    }
}