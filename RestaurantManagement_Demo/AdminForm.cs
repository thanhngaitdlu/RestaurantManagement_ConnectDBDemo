using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement_Demo
{
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			LoadCategoryList();
			AddBinding();
			//LoadFoodPage();
			//dgvFoodList.Columns["CategoryId"].Visible = false;
			//AddFoodBinding();
		}

		private void LoadCategoryList()
		{
			string conString = "server=.; database=RestaurantManagement; Integrated Security = true;";
			SqlConnection conn = new SqlConnection(conString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "select * from Category";

			conn.Open();

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable("Category");
			
			da.Fill(dt);

			dgvCategoryList.DataSource = dt;

			conn.Close();
		}

		private void AddBinding()
		{
			txtCategoryID.DataBindings.Add("Text", dgvCategoryList.DataSource, "ID", true, DataSourceUpdateMode.Never);
			txtCategoryName.DataBindings.Add("Text", dgvCategoryList.DataSource, "Name", true, DataSourceUpdateMode.Never);
			cbbType.DataBindings.Add("SelectedIndex", dgvCategoryList.DataSource, "Type", true, DataSourceUpdateMode.Never);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			string name = txtCategoryName.Text;
			int type = cbbType.SelectedIndex;

			try
			{
				bool result = CategoryDAO.Instance.AddCategory(name, type);
				if (result == true)
				{
					lblMessage.Text = "Thêm thành công.";
					LoadCategoryList();
				}

				else throw new Exception("Có lỗi xảy ra trong quá trình thêm");
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void LoadFoodPage()
		{
			var result = new List<Food>();
			result = FoodDAO.Instance.GetFoodList();

			dgvFoodList.DataSource = result;

			var result1 = new List<Category>();
			result1 = CategoryDAO.Instance.GetCategoryList();

			cbbCategory.DataSource = result1;
			cbbType.DisplayMember = "Name";
			cbbType.ValueMember = "Id";

		}

		private void AddFoodBinding()
		{
			txtFoodID.DataBindings.Add("Text", dgvFoodList.DataSource, "ID", true, DataSourceUpdateMode.Never);
			txtFoodName.DataBindings.Add("Text", dgvFoodList.DataSource, "Name", true, DataSourceUpdateMode.Never);
			cbbCategory.DataBindings.Add("SelectedIndex", dgvFoodList.DataSource, "CategoryID", true, DataSourceUpdateMode.Never);
			txtUnit.DataBindings.Add("Text", dgvFoodList.DataSource, "Unit", true, DataSourceUpdateMode.Never);
			nudPrice.DataBindings.Add("Text", dgvFoodList.DataSource, "Price", true, DataSourceUpdateMode.Never);
			txtNote.DataBindings.Add("Text", dgvFoodList.DataSource, "Notes", true, DataSourceUpdateMode.Never);
		}


		private void btnViewBill_Click(object sender, EventArgs e)
		{
			var result = new List<Bill>();

			var fromDate = dateTimePicker1.Value;
			var toDate = dateTimePicker2.Value;
			 
			result = BillDAO.Instance.GetBillList(fromDate, toDate);

			dgvBillList.DataSource = result;

			CultureInfo culture = new CultureInfo("vi-VN");

			int sum = result.Sum(p => p.Amount);
			txtSumAmount.Text = sum.ToString("c0", culture);
			txtSumDiscount.Text = (sum*result.Sum(p => p.Discount)).ToString("c0", culture);
			txtSum.Text = (result.Sum(p => p.MustPay)).ToString("c0", culture);
		}
	}
}
