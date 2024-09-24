using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement_Demo
{
	public partial class frmMainForm : Form
	{
		public frmMainForm()
		{
			InitializeComponent();
		}

		public void LoadTableList()
		{
			for (int i = 1; i <= 30; i++)
			{
				Button btn = new Button();

				btn.Text = "Bàn " + i;
				
				btn.Height = 40;
				btn.Width = 90;
			
				if(i % 5 == 0)
					btn.BackColor = Color.Aqua;
				else
				{
					btn.BackColor = Color.DarkCyan;
				}

				flpTable.Controls.Add(btn);
			} 
		}

		private void frmMainForm_Load(object sender, EventArgs e)
		{
			

			LoadTableList();
		}

		private void tsmiAdmin_Click(object sender, EventArgs e)
		{
			var dialog = new AdminForm();
			dialog.ShowDialog();
		}
	}
}
