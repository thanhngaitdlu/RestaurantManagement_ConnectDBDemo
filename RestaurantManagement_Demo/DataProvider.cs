using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement_Demo
{
	public class DataProvider
	{
		private static DataProvider _instance;

		public static DataProvider Instance => _instance ??  new DataProvider();
		//public static DataProvider Instance
		//{
		//	get
		//	{
		//		if (_instance == null)
		//			_instance = new DataProvider();

		//		return _instance;
		//	}
		//}

		private DataProvider() { }

		string connectionString = @"server=.; database=RestaurantManagement; Integrated Security = true;";

		public DataTable ExecuteQuery(string query, object[] param = null)
		{
			var connection = new SqlConnection(connectionString);

			connection.Open();

			var command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = query;

			string[] parts = query.Split(' ');
			int index = 0;

			if (param != null)
				foreach (string part in parts)
				{
					if (part.StartsWith("@"))
					{
						command.Parameters.AddWithValue(part, param[index]);
						index += 1;
					}
				}

			DataTable table = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(table);

			connection.Close();
			connection.Dispose();

			return table;
		}

		public int ExecuteNonQuery(string query, object[] param = null)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			connection.Open();

			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = query;

			string[] parts = query.Split(' ');
			int index = 0;

			if (param != null)
				foreach (string part in parts)
				{
					if (part.StartsWith("@"))
					{
						command.Parameters.AddWithValue(part, param[index]);
						index += 1;
					}
				}

			int rows = command.ExecuteNonQuery();

			connection.Close();
			connection.Dispose();

			return rows;
		}

		public object ExecuteScalar(string query, object[] param = null)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			connection.Open();

			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = query;

			string[] parts = query.Split(' ');
			int index = 0;

			if (param != null)
				foreach (string part in parts)
				{
					if (part.StartsWith("@"))
					{
						command.Parameters.AddWithValue(part, param[index]);
						index += 1;
					}
				}

			object result = command.ExecuteScalar();

			connection.Close();
			connection.Dispose();

			return result;
		}
	}
}
