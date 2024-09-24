using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement_Demo
{
	public class Category
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public string  Type { get; set; }

		public Category(int id, string name, string type)
		{
			ID = id;
			Name = name;
			Type = type;
		}

		public Category(DataRow row)
		{
			ID = Convert.ToInt32(row["ID"]);
			Name = row["Name"].ToString();
			int type = Convert.ToInt32(row["Type"]);
			Type = type == 0 ? "Thức uống" : "Đồ ăn";
		}
	}
}
