using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement_Demo
{
	public class CategoryDAO
	{
		private static CategoryDAO _instance = null;

		public static CategoryDAO Instance => _instance ?? (_instance = new CategoryDAO());

		private CategoryDAO()
		{
		}

		public List<Category> GetCategoryList()
		{
			List<Category> result = new List<Category>()
				;
			DataTable dt = new DataTable("Category");
			string query = "SELECT * FROM Category";

			dt = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in dt.Rows)
			{
				result.Add(new Category(row));
			}

			
			return result;
		}

		public bool AddCategory(string name, int type)
		{
			if(string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("Tên đề tài không được để trống");

			string query = "EXEC InsertCategory @Name , @Type";
			object[] param = new object[] {name, type};

			int rows = DataProvider.Instance.ExecuteNonQuery(query, param);

			return rows > 0;
		}
	}
}
