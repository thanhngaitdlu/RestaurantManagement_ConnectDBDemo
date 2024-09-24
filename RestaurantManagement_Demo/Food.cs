using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement_Demo
{
	public class Food
	{
		// ID của bảng Food
		public int ID { get; set; }

		// Tên loại đồ ăn, thức uống
		public string Name { get; set; }
		// Đơn vị tính
		public string Unit { get; set; }
		//Loại thức ăn, ứng với bảng ở trên
		public int CategoryId { get; set; }
		// Giá 
		public int Price { get; set; }
		// Ghi chú
		public string Notes { get; set; }

		public string CategoryName { get; set; }



		public Food(DataRow row)
		{
			ID = Convert.ToInt32(row["ID"]);
			Name = row["Name"].ToString();
			Unit = row["Unit"].ToString();
			CategoryId = Convert.ToInt32(row["FoodCategoryID"]);
			Price = Convert.ToInt32(row["Price"]);
			Notes = row["Notes"].ToString();
			CategoryName = row["CategoryName"].ToString();

		}
	}
}
