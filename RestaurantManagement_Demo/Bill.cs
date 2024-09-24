using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement_Demo
{
	public class Bill
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int TableId { get; set; }

		public string TableName { get; set; }

		public int Amount { get; set; }

		public double Discount { get; set; }

		public bool BillStatus { get; set; }

		public DateTime CheckOutDate { get; set; }

		public string Account { get; set; }

		public int MustPay { get; set; }

		public Bill(DataRow row)
		{
			Id = Convert.ToInt32(row["ID"]);
			Name = row["Name"].ToString();
			//TableName = row["TableID"].ToString();
			TableId = Convert.ToInt32(row["TableId"]);
			Amount = Convert.ToInt32(row["Amount"]);
			Discount = Convert.ToDouble(row["Discount"]);
			BillStatus = Convert.ToBoolean(row["Status"]);
			CheckOutDate = (DateTime) row["CheckOutDate"];
			Account = row["Account"].ToString();
			MustPay = Amount - Convert.ToInt32(Amount * Discount);
		}
	}
}
