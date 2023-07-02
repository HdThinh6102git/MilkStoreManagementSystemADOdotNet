
namespace FinalADOdotNET
{
    partial class fAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tabPay = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tabMilk = new System.Windows.Forms.TabPage();
            this.dgvMilk = new System.Windows.Forms.DataGridView();
            this.milkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MilkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extantAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmExtantAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCancelMilk = new System.Windows.Forms.Button();
            this.txtsoldAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmMilkPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMilkName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveMilk = new System.Windows.Forms.Button();
            this.btnAddMilk = new System.Windows.Forms.Button();
            this.btnReloadMilk = new System.Windows.Forms.Button();
            this.btnDeleteMilk = new System.Windows.Forms.Button();
            this.btnFindMilk = new System.Windows.Forms.Button();
            this.btnUpdateMilk = new System.Windows.Forms.Button();
            this.tabEmploy = new System.Windows.Forms.TabPage();
            this.panelNV = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.nmWorkHour = new System.Windows.Forms.NumericUpDown();
            this.btnCancelNV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveNV = new System.Windows.Forms.Button();
            this.btnFindNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tcAdmin.SuspendLayout();
            this.tabPay.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabMilk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilk)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmExtantAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMilkPrice)).BeginInit();
            this.tabEmploy.SuspendLayout();
            this.panelNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmWorkHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tabPay);
            this.tcAdmin.Controls.Add(this.tabMilk);
            this.tcAdmin.Controls.Add(this.tabEmploy);
            this.tcAdmin.Location = new System.Drawing.Point(10, 18);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1172, 668);
            this.tcAdmin.TabIndex = 0;
            // 
            // tabPay
            // 
            this.tabPay.Controls.Add(this.panel3);
            this.tabPay.Controls.Add(this.dgvBill);
            this.tabPay.Location = new System.Drawing.Point(4, 29);
            this.tabPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPay.Name = "tabPay";
            this.tabPay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPay.Size = new System.Drawing.Size(1164, 635);
            this.tabPay.TabIndex = 0;
            this.tabPay.Text = "Doanh Thu";
            this.tabPay.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnViewBill);
            this.panel3.Controls.Add(this.dtpkToDate);
            this.panel3.Controls.Add(this.dtpkFromDate);
            this.panel3.Location = new System.Drawing.Point(0, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1149, 45);
            this.panel3.TabIndex = 18;
            // 
            // btnViewBill
            // 
            this.btnViewBill.AutoSize = true;
            this.btnViewBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBill.Location = new System.Drawing.Point(508, -5);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(196, 60);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToDate.Location = new System.Drawing.Point(844, 9);
            this.dtpkToDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(298, 26);
            this.dtpkToDate.TabIndex = 1;
            this.dtpkToDate.Value = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFromDate.Location = new System.Drawing.Point(127, 14);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(298, 26);
            this.dtpkFromDate.TabIndex = 0;
            this.dtpkFromDate.TabStop = false;
            this.dtpkFromDate.UseWaitCursor = true;
            this.dtpkFromDate.Value = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(0, 91);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 62;
            this.dgvBill.Size = new System.Drawing.Size(1149, 528);
            this.dgvBill.TabIndex = 17;
            // 
            // tabMilk
            // 
            this.tabMilk.Controls.Add(this.dgvMilk);
            this.tabMilk.Controls.Add(this.panel1);
            this.tabMilk.Location = new System.Drawing.Point(4, 29);
            this.tabMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMilk.Name = "tabMilk";
            this.tabMilk.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMilk.Size = new System.Drawing.Size(1164, 635);
            this.tabMilk.TabIndex = 1;
            this.tabMilk.Text = "Sữa";
            this.tabMilk.UseVisualStyleBackColor = true;
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
            this.dgvMilk.Location = new System.Drawing.Point(4, 9);
            this.dgvMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMilk.Name = "dgvMilk";
            this.dgvMilk.RowHeadersWidth = 62;
            this.dgvMilk.Size = new System.Drawing.Size(1146, 451);
            this.dgvMilk.TabIndex = 14;
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
            this.price.HeaderText = "Giá bán";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.nmExtantAmount);
            this.panel1.Controls.Add(this.btnCancelMilk);
            this.panel1.Controls.Add(this.txtsoldAmount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nmMilkPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMilkName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSaveMilk);
            this.panel1.Controls.Add(this.btnAddMilk);
            this.panel1.Controls.Add(this.btnReloadMilk);
            this.panel1.Controls.Add(this.btnDeleteMilk);
            this.panel1.Controls.Add(this.btnFindMilk);
            this.panel1.Controls.Add(this.btnUpdateMilk);
            this.panel1.Location = new System.Drawing.Point(2, 469);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 154);
            this.panel1.TabIndex = 15;
            // 
            // nmExtantAmount
            // 
            this.nmExtantAmount.Location = new System.Drawing.Point(748, 23);
            this.nmExtantAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmExtantAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmExtantAmount.Name = "nmExtantAmount";
            this.nmExtantAmount.Size = new System.Drawing.Size(58, 26);
            this.nmExtantAmount.TabIndex = 23;
            // 
            // btnCancelMilk
            // 
            this.btnCancelMilk.AutoSize = true;
            this.btnCancelMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMilk.Location = new System.Drawing.Point(531, 89);
            this.btnCancelMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelMilk.Name = "btnCancelMilk";
            this.btnCancelMilk.Size = new System.Drawing.Size(124, 60);
            this.btnCancelMilk.TabIndex = 22;
            this.btnCancelMilk.Text = "Hủy bỏ";
            this.btnCancelMilk.UseVisualStyleBackColor = true;
            this.btnCancelMilk.Click += new System.EventHandler(this.btnCancelMilk_Click);
            // 
            // txtsoldAmount
            // 
            this.txtsoldAmount.Location = new System.Drawing.Point(1050, 23);
            this.txtsoldAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsoldAmount.Name = "txtsoldAmount";
            this.txtsoldAmount.Size = new System.Drawing.Size(56, 26);
            this.txtsoldAmount.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(836, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số lượng đã bán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số lượng còn lại:";
            // 
            // nmMilkPrice
            // 
            this.nmMilkPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmMilkPrice.Location = new System.Drawing.Point(384, 23);
            this.nmMilkPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmMilkPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmMilkPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmMilkPrice.Name = "nmMilkPrice";
            this.nmMilkPrice.Size = new System.Drawing.Size(134, 26);
            this.nmMilkPrice.TabIndex = 17;
            this.nmMilkPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giá:";
            // 
            // txtMilkName
            // 
            this.txtMilkName.Location = new System.Drawing.Point(153, 23);
            this.txtMilkName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMilkName.Name = "txtMilkName";
            this.txtMilkName.Size = new System.Drawing.Size(148, 26);
            this.txtMilkName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Sữa:";
            // 
            // btnSaveMilk
            // 
            this.btnSaveMilk.AutoSize = true;
            this.btnSaveMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMilk.Location = new System.Drawing.Point(406, 89);
            this.btnSaveMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveMilk.Name = "btnSaveMilk";
            this.btnSaveMilk.Size = new System.Drawing.Size(117, 60);
            this.btnSaveMilk.TabIndex = 13;
            this.btnSaveMilk.Text = "Lưu";
            this.btnSaveMilk.UseVisualStyleBackColor = true;
            this.btnSaveMilk.Click += new System.EventHandler(this.btnSaveMilk_Click);
            // 
            // btnAddMilk
            // 
            this.btnAddMilk.AutoSize = true;
            this.btnAddMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMilk.Location = new System.Drawing.Point(15, 89);
            this.btnAddMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMilk.Name = "btnAddMilk";
            this.btnAddMilk.Size = new System.Drawing.Size(135, 60);
            this.btnAddMilk.TabIndex = 4;
            this.btnAddMilk.Text = "Thêm";
            this.btnAddMilk.UseVisualStyleBackColor = true;
            this.btnAddMilk.Click += new System.EventHandler(this.btnAddMilk_Click);
            // 
            // btnReloadMilk
            // 
            this.btnReloadMilk.AutoSize = true;
            this.btnReloadMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadMilk.Location = new System.Drawing.Point(686, 89);
            this.btnReloadMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReloadMilk.Name = "btnReloadMilk";
            this.btnReloadMilk.Size = new System.Drawing.Size(120, 60);
            this.btnReloadMilk.TabIndex = 11;
            this.btnReloadMilk.Text = "Reload";
            this.btnReloadMilk.UseVisualStyleBackColor = true;
            this.btnReloadMilk.Click += new System.EventHandler(this.btnReloadMilk_Click);
            // 
            // btnDeleteMilk
            // 
            this.btnDeleteMilk.AutoSize = true;
            this.btnDeleteMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMilk.Location = new System.Drawing.Point(159, 89);
            this.btnDeleteMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteMilk.Name = "btnDeleteMilk";
            this.btnDeleteMilk.Size = new System.Drawing.Size(112, 60);
            this.btnDeleteMilk.TabIndex = 5;
            this.btnDeleteMilk.Text = "Xóa";
            this.btnDeleteMilk.UseVisualStyleBackColor = true;
            this.btnDeleteMilk.Click += new System.EventHandler(this.btnDeleteMilk_Click);
            // 
            // btnFindMilk
            // 
            this.btnFindMilk.AutoSize = true;
            this.btnFindMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMilk.Location = new System.Drawing.Point(841, 89);
            this.btnFindMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindMilk.Name = "btnFindMilk";
            this.btnFindMilk.Size = new System.Drawing.Size(236, 60);
            this.btnFindMilk.TabIndex = 10;
            this.btnFindMilk.Text = "Sữa bán chạy nhất";
            this.btnFindMilk.UseVisualStyleBackColor = true;
            this.btnFindMilk.Click += new System.EventHandler(this.btnFindMilk_Click);
            // 
            // btnUpdateMilk
            // 
            this.btnUpdateMilk.AutoSize = true;
            this.btnUpdateMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMilk.Location = new System.Drawing.Point(280, 89);
            this.btnUpdateMilk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateMilk.Name = "btnUpdateMilk";
            this.btnUpdateMilk.Size = new System.Drawing.Size(117, 60);
            this.btnUpdateMilk.TabIndex = 6;
            this.btnUpdateMilk.Text = "Sửa";
            this.btnUpdateMilk.UseVisualStyleBackColor = true;
            this.btnUpdateMilk.Click += new System.EventHandler(this.btnUpdateMilk_Click);
            // 
            // tabEmploy
            // 
            this.tabEmploy.Controls.Add(this.panelNV);
            this.tabEmploy.Controls.Add(this.dgvEmployee);
            this.tabEmploy.Location = new System.Drawing.Point(4, 29);
            this.tabEmploy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabEmploy.Name = "tabEmploy";
            this.tabEmploy.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabEmploy.Size = new System.Drawing.Size(1164, 635);
            this.tabEmploy.TabIndex = 2;
            this.tabEmploy.Text = "Nhân viên";
            this.tabEmploy.UseVisualStyleBackColor = true;
            // 
            // panelNV
            // 
            this.panelNV.Controls.Add(this.btnReload);
            this.panelNV.Controls.Add(this.nmWorkHour);
            this.panelNV.Controls.Add(this.btnCancelNV);
            this.panelNV.Controls.Add(this.label4);
            this.panelNV.Controls.Add(this.txtEmID);
            this.panelNV.Controls.Add(this.label2);
            this.panelNV.Controls.Add(this.txtEmName);
            this.panelNV.Controls.Add(this.label1);
            this.panelNV.Controls.Add(this.btnSaveNV);
            this.panelNV.Controls.Add(this.btnFindNV);
            this.panelNV.Controls.Add(this.btnAddNV);
            this.panelNV.Controls.Add(this.btnDeleteNV);
            this.panelNV.Controls.Add(this.btnUpdateNV);
            this.panelNV.Location = new System.Drawing.Point(9, 465);
            this.panelNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNV.Name = "panelNV";
            this.panelNV.Size = new System.Drawing.Size(1146, 154);
            this.panelNV.TabIndex = 10;
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(610, 83);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(108, 60);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // nmWorkHour
            // 
            this.nmWorkHour.Location = new System.Drawing.Point(729, 25);
            this.nmWorkHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmWorkHour.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmWorkHour.Name = "nmWorkHour";
            this.nmWorkHour.Size = new System.Drawing.Size(58, 26);
            this.nmWorkHour.TabIndex = 15;
            // 
            // btnCancelNV
            // 
            this.btnCancelNV.AutoSize = true;
            this.btnCancelNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNV.Location = new System.Drawing.Point(489, 83);
            this.btnCancelNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelNV.Name = "btnCancelNV";
            this.btnCancelNV.Size = new System.Drawing.Size(104, 60);
            this.btnCancelNV.TabIndex = 14;
            this.btnCancelNV.Text = "Hủy bỏ";
            this.btnCancelNV.UseVisualStyleBackColor = true;
            this.btnCancelNV.Click += new System.EventHandler(this.btnCancelNV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số giờ làm việc:";
            // 
            // txtEmID
            // 
            this.txtEmID.Location = new System.Drawing.Point(418, 25);
            this.txtEmID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmID.Name = "txtEmID";
            this.txtEmID.Size = new System.Drawing.Size(86, 26);
            this.txtEmID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã NV:";
            // 
            // txtEmName
            // 
            this.txtEmName.Location = new System.Drawing.Point(124, 25);
            this.txtEmName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.Size = new System.Drawing.Size(148, 26);
            this.txtEmName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên NV:";
            // 
            // btnSaveNV
            // 
            this.btnSaveNV.AutoSize = true;
            this.btnSaveNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNV.Location = new System.Drawing.Point(368, 83);
            this.btnSaveNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveNV.Name = "btnSaveNV";
            this.btnSaveNV.Size = new System.Drawing.Size(112, 60);
            this.btnSaveNV.TabIndex = 8;
            this.btnSaveNV.Text = "Lưu";
            this.btnSaveNV.UseVisualStyleBackColor = true;
            this.btnSaveNV.Click += new System.EventHandler(this.btnSaveNV_Click);
            // 
            // btnFindNV
            // 
            this.btnFindNV.AutoSize = true;
            this.btnFindNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindNV.Location = new System.Drawing.Point(742, 83);
            this.btnFindNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindNV.Name = "btnFindNV";
            this.btnFindNV.Size = new System.Drawing.Size(366, 60);
            this.btnFindNV.TabIndex = 6;
            this.btnFindNV.Text = "Nhân viên làm nhiều giờ nhất ";
            this.btnFindNV.UseVisualStyleBackColor = true;
            this.btnFindNV.Click += new System.EventHandler(this.btnFindNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.AutoSize = true;
            this.btnAddNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.Location = new System.Drawing.Point(10, 83);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(90, 60);
            this.btnAddNV.TabIndex = 3;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.AutoSize = true;
            this.btnDeleteNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNV.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteNV.Location = new System.Drawing.Point(124, 83);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(112, 60);
            this.btnDeleteNV.TabIndex = 4;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.AutoSize = true;
            this.btnUpdateNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNV.Location = new System.Drawing.Point(246, 83);
            this.btnUpdateNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(112, 60);
            this.btnUpdateNV.TabIndex = 5;
            this.btnUpdateNV.Text = "Sửa";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.salary,
            this.workhour});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEmployee.Location = new System.Drawing.Point(4, 5);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.Size = new System.Drawing.Size(1156, 451);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên nhân viên";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Lương";
            this.salary.MinimumWidth = 8;
            this.salary.Name = "salary";
            // 
            // workhour
            // 
            this.workhour.DataPropertyName = "workhour";
            this.workhour.HeaderText = "Số giờ làm";
            this.workhour.MinimumWidth = 8;
            this.workhour.Name = "workhour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Từ ngày:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(711, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Đến ngày:";
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tcAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tiệm sữa";
            this.tcAdmin.ResumeLayout(false);
            this.tabPay.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabMilk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmExtantAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMilkPrice)).EndInit();
            this.tabEmploy.ResumeLayout(false);
            this.panelNV.ResumeLayout(false);
            this.panelNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmWorkHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tabPay;
        private System.Windows.Forms.TabPage tabMilk;
        private System.Windows.Forms.TabPage tabEmploy;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Panel panelNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNV;
        private System.Windows.Forms.Button btnFindNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveMilk;
        private System.Windows.Forms.Button btnAddMilk;
        private System.Windows.Forms.Button btnReloadMilk;
        private System.Windows.Forms.Button btnDeleteMilk;
        private System.Windows.Forms.Button btnFindMilk;
        private System.Windows.Forms.Button btnUpdateMilk;
        private System.Windows.Forms.DataGridView dgvMilk;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.TextBox txtEmName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelNV;
        private System.Windows.Forms.NumericUpDown nmWorkHour;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMilkName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmMilkPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsoldAmount;
        private System.Windows.Forms.Button btnCancelMilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn workhour;
        private System.Windows.Forms.DataGridViewTextBoxColumn milkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MilkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn extantAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldAmount;
        private System.Windows.Forms.NumericUpDown nmExtantAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}