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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (txtLoginName.Text == "" || txtPassword.Text == "")
			{
				lblMessage.Text = "Vui lòng nhập tên đăng nhập hoặc mật khẩu.";
			}
			else {
				if (txtLoginName.Text == "admin" && txtPassword.Text == "123")
				{
					this.DialogResult = DialogResult.OK;
				}
				else
				{
					lblMessage.Text = "Mật khẩu hoặc tên đăng nhập không đúng.";
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
