namespace RestaurantManagement_Demo
{
	partial class AdminForm
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
			this.tabcontrol = new System.Windows.Forms.TabControl();
			this.tpBill = new System.Windows.Forms.TabPage();
			this.txtSum = new System.Windows.Forms.TextBox();
			this.txtSumAmount = new System.Windows.Forms.TextBox();
			this.txtSumDiscount = new System.Windows.Forms.TextBox();
			this.dgvBillList = new System.Windows.Forms.DataGridView();
			this.btnViewBill = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.tpFood = new System.Windows.Forms.TabPage();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSaveFood = new System.Windows.Forms.Button();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.txtFoodName = new System.Windows.Forms.TextBox();
			this.txtFoodID = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvFoodList = new System.Windows.Forms.DataGridView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtCategoryID = new System.Windows.Forms.TextBox();
			this.dgvCategoryList = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.cbbType = new System.Windows.Forms.ComboBox();
			this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabcontrol.SuspendLayout();
			this.tpBill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).BeginInit();
			this.tpFood.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
			this.SuspendLayout();
			// 
			// tabcontrol
			// 
			this.tabcontrol.Controls.Add(this.tpBill);
			this.tabcontrol.Controls.Add(this.tpFood);
			this.tabcontrol.Controls.Add(this.tabPage1);
			this.tabcontrol.Controls.Add(this.tabPage2);
			this.tabcontrol.Location = new System.Drawing.Point(12, 4);
			this.tabcontrol.Name = "tabcontrol";
			this.tabcontrol.SelectedIndex = 0;
			this.tabcontrol.Size = new System.Drawing.Size(707, 424);
			this.tabcontrol.TabIndex = 0;
			// 
			// tpBill
			// 
			this.tpBill.Controls.Add(this.txtSum);
			this.tpBill.Controls.Add(this.txtSumAmount);
			this.tpBill.Controls.Add(this.txtSumDiscount);
			this.tpBill.Controls.Add(this.dgvBillList);
			this.tpBill.Controls.Add(this.btnViewBill);
			this.tpBill.Controls.Add(this.label2);
			this.tpBill.Controls.Add(this.dateTimePicker2);
			this.tpBill.Controls.Add(this.label5);
			this.tpBill.Controls.Add(this.label4);
			this.tpBill.Controls.Add(this.label3);
			this.tpBill.Controls.Add(this.label1);
			this.tpBill.Controls.Add(this.dateTimePicker1);
			this.tpBill.Location = new System.Drawing.Point(4, 22);
			this.tpBill.Name = "tpBill";
			this.tpBill.Padding = new System.Windows.Forms.Padding(3);
			this.tpBill.Size = new System.Drawing.Size(699, 398);
			this.tpBill.TabIndex = 0;
			this.tpBill.Text = "Doanh thu";
			this.tpBill.UseVisualStyleBackColor = true;
			// 
			// txtSum
			// 
			this.txtSum.Enabled = false;
			this.txtSum.Location = new System.Drawing.Point(521, 360);
			this.txtSum.Name = "txtSum";
			this.txtSum.Size = new System.Drawing.Size(162, 20);
			this.txtSum.TabIndex = 4;
			// 
			// txtSumAmount
			// 
			this.txtSumAmount.Enabled = false;
			this.txtSumAmount.Location = new System.Drawing.Point(67, 364);
			this.txtSumAmount.Name = "txtSumAmount";
			this.txtSumAmount.Size = new System.Drawing.Size(162, 20);
			this.txtSumAmount.TabIndex = 4;
			// 
			// txtSumDiscount
			// 
			this.txtSumDiscount.Enabled = false;
			this.txtSumDiscount.Location = new System.Drawing.Point(292, 364);
			this.txtSumDiscount.Name = "txtSumDiscount";
			this.txtSumDiscount.Size = new System.Drawing.Size(162, 20);
			this.txtSumDiscount.TabIndex = 4;
			// 
			// dgvBillList
			// 
			this.dgvBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
			this.dgvBillList.Location = new System.Drawing.Point(6, 74);
			this.dgvBillList.Name = "dgvBillList";
			this.dgvBillList.Size = new System.Drawing.Size(684, 269);
			this.dgvBillList.TabIndex = 3;
			// 
			// btnViewBill
			// 
			this.btnViewBill.Location = new System.Drawing.Point(296, 26);
			this.btnViewBill.Name = "btnViewBill";
			this.btnViewBill.Size = new System.Drawing.Size(85, 23);
			this.btnViewBill.TabIndex = 2;
			this.btnViewBill.Text = "Xem chi tiết";
			this.btnViewBill.UseVisualStyleBackColor = true;
			this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(406, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Đến ngày:";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(474, 29);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(185, 20);
			this.dateTimePicker2.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(460, 367);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Thực thu:";
			this.label5.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(235, 367);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Giảm giá:";
			this.label4.Click += new System.EventHandler(this.label3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 367);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tổng tiền:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Từ ngày:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(74, 29);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// tpFood
			// 
			this.tpFood.Controls.Add(this.btnReset);
			this.tpFood.Controls.Add(this.btnSaveFood);
			this.tpFood.Controls.Add(this.btnAddCategory);
			this.tpFood.Controls.Add(this.nudPrice);
			this.tpFood.Controls.Add(this.cbbCategory);
			this.tpFood.Controls.Add(this.label7);
			this.tpFood.Controls.Add(this.label12);
			this.tpFood.Controls.Add(this.label11);
			this.tpFood.Controls.Add(this.label10);
			this.tpFood.Controls.Add(this.label9);
			this.tpFood.Controls.Add(this.label8);
			this.tpFood.Controls.Add(this.txtUnit);
			this.tpFood.Controls.Add(this.txtNote);
			this.tpFood.Controls.Add(this.txtFoodName);
			this.tpFood.Controls.Add(this.txtFoodID);
			this.tpFood.Controls.Add(this.textBox1);
			this.tpFood.Controls.Add(this.label6);
			this.tpFood.Controls.Add(this.dgvFoodList);
			this.tpFood.Location = new System.Drawing.Point(4, 22);
			this.tpFood.Name = "tpFood";
			this.tpFood.Padding = new System.Windows.Forms.Padding(3);
			this.tpFood.Size = new System.Drawing.Size(699, 398);
			this.tpFood.TabIndex = 1;
			this.tpFood.Text = "Thức ăn";
			this.tpFood.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(586, 328);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(89, 24);
			this.btnReset.TabIndex = 7;
			this.btnReset.Text = "Xóa dữ liệu";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// btnSaveFood
			// 
			this.btnSaveFood.Location = new System.Drawing.Point(462, 328);
			this.btnSaveFood.Name = "btnSaveFood";
			this.btnSaveFood.Size = new System.Drawing.Size(89, 24);
			this.btnSaveFood.TabIndex = 7;
			this.btnSaveFood.Text = "Lưu";
			this.btnSaveFood.UseVisualStyleBackColor = true;
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Location = new System.Drawing.Point(631, 135);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(59, 19);
			this.btnAddCategory.TabIndex = 6;
			this.btnAddCategory.Text = "Thêm";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(468, 204);
			this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(223, 20);
			this.nudPrice.TabIndex = 5;
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(467, 134);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(156, 21);
			this.cbbCategory.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(397, 66);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "ID";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(388, 241);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(44, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "Ghi chú";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(388, 206);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(44, 13);
			this.label11.TabIndex = 3;
			this.label11.Text = "Đơn giá";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(388, 173);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "Đơn vị tính";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(388, 137);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Nhóm món ăn";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(388, 102);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Tên món ăn";
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(467, 170);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(228, 20);
			this.txtUnit.TabIndex = 2;
			this.txtUnit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(465, 238);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(228, 61);
			this.txtNote.TabIndex = 2;
			this.txtNote.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtFoodName
			// 
			this.txtFoodName.Location = new System.Drawing.Point(467, 95);
			this.txtFoodName.Name = "txtFoodName";
			this.txtFoodName.Size = new System.Drawing.Size(228, 20);
			this.txtFoodName.TabIndex = 2;
			this.txtFoodName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtFoodID
			// 
			this.txtFoodID.Enabled = false;
			this.txtFoodID.Location = new System.Drawing.Point(465, 59);
			this.txtFoodID.Name = "txtFoodID";
			this.txtFoodID.Size = new System.Drawing.Size(228, 20);
			this.txtFoodID.TabIndex = 2;
			this.txtFoodID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(81, 11);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(291, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Tìm theo tên:";
			// 
			// dgvFoodList
			// 
			this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
			this.dgvFoodList.Location = new System.Drawing.Point(6, 43);
			this.dgvFoodList.Name = "dgvFoodList";
			this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFoodList.Size = new System.Drawing.Size(366, 349);
			this.dgvFoodList.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cbbType);
			this.tabPage1.Controls.Add(this.lblMessage);
			this.tabPage1.Controls.Add(this.btnDelete);
			this.tabPage1.Controls.Add(this.btnSave);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Controls.Add(this.label18);
			this.tabPage1.Controls.Add(this.txtCategoryName);
			this.tabPage1.Controls.Add(this.txtCategoryID);
			this.tabPage1.Controls.Add(this.dgvCategoryList);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(699, 398);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Nhóm thức ăn";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(699, 398);
			this.tabPage2.TabIndex = 3;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(396, 64);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(18, 13);
			this.label13.TabIndex = 19;
			this.label13.Text = "ID";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(387, 132);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(27, 13);
			this.label15.TabIndex = 20;
			this.label15.Text = "Loại";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(387, 100);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(73, 13);
			this.label18.TabIndex = 15;
			this.label18.Text = "Nhóm món ăn";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(466, 93);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(228, 20);
			this.txtCategoryName.TabIndex = 12;
			// 
			// txtCategoryID
			// 
			this.txtCategoryID.Enabled = false;
			this.txtCategoryID.Location = new System.Drawing.Point(466, 57);
			this.txtCategoryID.Name = "txtCategoryID";
			this.txtCategoryID.Size = new System.Drawing.Size(226, 20);
			this.txtCategoryID.TabIndex = 11;
			// 
			// dgvCategoryList
			// 
			this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dgvCategoryList.Location = new System.Drawing.Point(5, 41);
			this.dgvCategoryList.Name = "dgvCategoryList";
			this.dgvCategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCategoryList.Size = new System.Drawing.Size(366, 349);
			this.dgvCategoryList.TabIndex = 8;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 60;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhóm món ăn";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 160;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
			this.dataGridViewTextBoxColumn3.HeaderText = "Đồ ăn / Thức uống";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(476, 200);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(82, 28);
			this.btnSave.TabIndex = 21;
			this.btnSave.Text = "Thêm";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(594, 200);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(82, 28);
			this.btnDelete.TabIndex = 21;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(387, 171);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(10, 13);
			this.lblMessage.TabIndex = 22;
			this.lblMessage.Text = ".";
			// 
			// cbbType
			// 
			this.cbbType.FormattingEnabled = true;
			this.cbbType.Items.AddRange(new object[] {
            "Thức uống",
            "Đồ ăn"});
			this.cbbType.Location = new System.Drawing.Point(466, 124);
			this.cbbType.Name = "cbbType";
			this.cbbType.Size = new System.Drawing.Size(226, 21);
			this.cbbType.TabIndex = 23;
			// 
			// Column14
			// 
			this.Column14.DataPropertyName = "ID";
			this.Column14.HeaderText = "ID";
			this.Column14.Name = "Column14";
			this.Column14.ReadOnly = true;
			this.Column14.Width = 20;
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "Name";
			this.Column9.HeaderText = "Tên món ăn";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "Unit";
			this.Column10.HeaderText = "Đơn vị tính";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 40;
			// 
			// Column11
			// 
			this.Column11.DataPropertyName = "Price";
			this.Column11.HeaderText = "Đơn giá";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			this.Column11.Width = 80;
			// 
			// Column12
			// 
			this.Column12.DataPropertyName = "CategoryName";
			this.Column12.HeaderText = "Loại món ăn";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			this.Column12.Width = 80;
			// 
			// Column13
			// 
			this.Column13.DataPropertyName = "Notes";
			this.Column13.HeaderText = "Ghi chú";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			this.Column13.Width = 200;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ID";
			this.Column1.HeaderText = "Số hóa đơn";
			this.Column1.Name = "Column1";
			this.Column1.Width = 60;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Name";
			this.Column2.HeaderText = "Khách hàng";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "TableId";
			this.Column3.HeaderText = "Bàn";
			this.Column3.Name = "Column3";
			this.Column3.Width = 60;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "CheckOutDate";
			this.Column4.HeaderText = "Ngày lập hóa đơn";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Amount";
			this.Column5.HeaderText = "Tồng tiền";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "Discount";
			this.Column6.HeaderText = "Giảm giá";
			this.Column6.Name = "Column6";
			this.Column6.Width = 60;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "MustPay";
			this.Column7.HeaderText = "Phải trả";
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "Account";
			this.Column8.HeaderText = "Nhân viên lập";
			this.Column8.Name = "Column8";
			this.Column8.Width = 80;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 440);
			this.Controls.Add(this.tabcontrol);
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.tabcontrol.ResumeLayout(false);
			this.tpBill.ResumeLayout(false);
			this.tpBill.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).EndInit();
			this.tpFood.ResumeLayout(false);
			this.tpFood.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabcontrol;
		private System.Windows.Forms.TabPage tpBill;
		private System.Windows.Forms.DataGridView dgvBillList;
		private System.Windows.Forms.Button btnViewBill;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TabPage tpFood;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSum;
		private System.Windows.Forms.TextBox txtSumAmount;
		private System.Windows.Forms.TextBox txtSumDiscount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvFoodList;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSaveFood;
		private System.Windows.Forms.Button btnAddCategory;
		private System.Windows.Forms.NumericUpDown nudPrice;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.TextBox txtFoodName;
		private System.Windows.Forms.TextBox txtFoodID;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtCategoryID;
		private System.Windows.Forms.DataGridView dgvCategoryList;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.ComboBox cbbType;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
	}
}