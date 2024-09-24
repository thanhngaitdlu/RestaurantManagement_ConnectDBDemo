using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement_Demo
{
	public class BillDAO
	{
		private static BillDAO _instance = null;

		public static BillDAO Instance => _instance ?? (_instance = new BillDAO());

		private BillDAO()
		{
		}

		public List<Bill> GetBillList(DateTime fromDate, DateTime toDate)
		{
			
			List<Bill> result = new List<Bill>();
			DataTable dt = new DataTable("Bill");
			string query = "EXEC GetBillInfo @fromDate , @toDate";
			object[] param = new object[] {fromDate, toDate};

			dt = DataProvider.Instance.ExecuteQuery(query,param);

			foreach (DataRow row in dt.Rows)
			{
				result.Add(new Bill(row));
			}


			return result;
		}

	}
}
