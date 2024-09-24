using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement_Demo
{
	public class FoodDAO
	{

		private static FoodDAO _instance = null;

		public static FoodDAO Instance => _instance ?? (_instance = new FoodDAO());

		private FoodDAO()
		{
		}

		public List<Food> GetFoodList()
		{
			List<Food> result = new List<Food>()
				;
			DataTable dt = new DataTable("Food");
			string query = "EXEC [dbo].[Food_GetAllInCludeCategory]";

			dt = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in dt.Rows)
			{
				result.Add(new Food(row));
			}


			return result;
		}

	
	}
}
