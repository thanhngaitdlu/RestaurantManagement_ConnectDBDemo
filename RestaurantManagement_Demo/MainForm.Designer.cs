namespace RestaurantManagement_Demo
{
	partial class frmMainForm
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
			this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbbFood = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lvBillDetail = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpTable
			// 
			this.flpTable.Location = new System.Drawing.Point(12, 21);
			this.flpTable.Name = "flpTable";
			this.flpTable.Size = new System.Drawing.Size(404, 473);
			this.flpTable.TabIndex = 0;
			// 
			// cbbCategory
			// 
			this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Items.AddRange(new object[] {
            "Lẩu",
            "Cơm",
            "Rau"});
			this.cbbCategory.Location = new System.Drawing.Point(538, 21);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(248, 21);
			this.cbbCategory.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(432, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nhóm món ăn:";
			// 
			// cbbFood
			// 
			this.cbbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbFood.FormattingEnabled = true;
			this.cbbFood.Items.AddRange(new object[] {
            "Lẩu",
            "Cơm",
            "Rau"});
			this.cbbFood.Location = new System.Drawing.Point(538, 48);
			this.cbbFood.Name = "cbbFood";
			this.cbbFood.Size = new System.Drawing.Size(248, 21);
			this.cbbFood.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(432, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Món ăn:";
			// 
			// lvBillDetail
			// 
			this.lvBillDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvBillDetail.GridLines = true;
			this.lvBillDetail.Location = new System.Drawing.Point(430, 95);
			this.lvBillDetail.Name = "lvBillDetail";
			this.lvBillDetail.Size = new System.Drawing.Size(356, 326);
			this.lvBillDetail.TabIndex = 3;
			this.lvBillDetail.UseCompatibleStateImageBehavior = false;
			this.lvBillDetail.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên món ăn";
			this.columnHeader1.Width = 164;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số lượng";
			this.columnHeader2.Width = 55;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Đơn giá";
			this.columnHeader3.Width = 62;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thành tiền";
			this.columnHeader4.Width = 69;
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.Location = new System.Drawing.Point(699, 440);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(87, 51);
			this.btnCheckOut.TabIndex = 4;
			this.btnCheckOut.Text = "Thanh toán";
			this.btnCheckOut.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(495, 446);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tổng số tiền";
			// 
			// txtAmount
			// 
			this.txtAmount.Enabled = false;
			this.txtAmount.Location = new System.Drawing.Point(567, 444);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(132, 20);
			this.txtAmount.TabIndex = 6;
			this.txtAmount.Text = "200000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(495, 471);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Giảm giá";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(567, 471);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(129, 20);
			this.numericUpDown1.TabIndex = 7;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tsmiAccount});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(798, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiAdmin
			// 
			this.tsmiAdmin.Name = "tsmiAdmin";
			this.tsmiAdmin.Size = new System.Drawing.Size(62, 20);
			this.tsmiAdmin.Text = "Quản trị";
			this.tsmiAdmin.Click += new System.EventHandler(this.tsmiAdmin_Click);
			// 
			// tsmiAccount
			// 
			this.tsmiAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem});
			this.tsmiAccount.Name = "tsmiAccount";
			this.tsmiAccount.Size = new System.Drawing.Size(86, 20);
			this.tsmiAccount.Text = "QL tài khoản";
			// 
			// xemThôngTinToolStripMenuItem
			// 
			this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
			this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
			// 
			// thayĐổiMậtKhẩuToolStripMenuItem
			// 
			this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
			this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay đổi mật khẩu";
			// 
			// frmMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 506);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCheckOut);
			this.Controls.Add(this.lvBillDetail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbbFood);
			this.Controls.Add(this.cbbCategory);
			this.Controls.Add(this.flpTable);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý";
			this.Load += new System.EventHandler(this.frmMainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpTable;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbFood;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lvBillDetail;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button btnCheckOut;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
		private System.Windows.Forms.ToolStripMenuItem tsmiAccount;
		private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
	}
}

