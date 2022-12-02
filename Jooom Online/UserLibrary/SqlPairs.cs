using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Jooom_Online
{
	public partial class UserLibrary
	{
		public class SqlPairs
		{
			private object name;
			private object data;
			public object Name { get => name; set => name = value; }
			public object Data { get => data; set => data = value; }

			public SqlPairs(object name, object data)
			{
				Name = name;
				Data = data;
			}
		}

		#region Поддерживающие методы
		public static bool Check(List<SqlPairs> parameterPairs)
		{
			bool start = false;

			foreach (var pair in parameterPairs)
			{
				if (pair.Data.ToString().Length < 1)
				{
					ShowMessage("Не все данные были заполнены!", "Произошла ошибка!");

					break;
				}

				start = true;
			}

			return start;
		}

		public static void SetParameters(object name, object data, SqlCommand sqlCommand)
		{
			sqlCommand.Parameters.AddWithValue(name.ToString(), data);
		}

		public static SqlCommand LoadParameters(string command,
																						SqlConnection sqlConnection,
																						List<SqlPairs>
																						sqlPairs)
		{
			SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

			foreach (var pair in sqlPairs)
			{
				SetParameters(pair.Name, pair.Data, sqlCommand);
			}

			return sqlCommand;
		}

		public static int CountRowsFromDB(SqlCommand sqlCommand)
		{
			sqlCommand.CommandText = String.Format("SELECT COUNT(*) FROM ({0}) t", sqlCommand.CommandText);

			int count = -1;

			using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
			{
				if (sqlReader.Read())
				{
					count = sqlReader.GetInt32(0);
				}
			}

			return count;
		}
		
		public static void ReadFromDB(SqlCommand sqlCommand,
																	ref List<object> dataList)
		{

			using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
			{
				if (sqlReader.Read())
				{
					for (int i = 0; i < sqlReader.FieldCount; i++)
					{
						dataList.Add(sqlReader.GetValue(i));
					}
				}
			}
		}
		#endregion

		public static bool SelectFromDB(IWin32Window IWindow,
																		string connection,
																		string command,
																		List<SqlPairs> sqlPairs,
																		ref List<object> dataList)
		{
			if (Check(sqlPairs))
			{
				using (SqlConnection sqlConnection = new SqlConnection(connection))
				{
					sqlConnection.Open();

					SqlCommand sqlCountCommand = LoadParameters(command, sqlConnection, sqlPairs);

					try
					{
						if (CountRowsFromDB(sqlCountCommand) > 0)
						{

							SqlCommand sqlSelectCommand = LoadParameters(command, sqlConnection, sqlPairs);
							ReadFromDB(sqlSelectCommand, ref dataList);

							return true;
						}
						else
						{
							return false;
						}
					}
					catch (Exception)
					{
						ShowMessage(IWindow, "Проверьте правильность введенных данных!", "Произошла ошибка!");

						return false;
					}
				}
			}
			else
			{
				return false;
			}

		}

		public static bool SelectThenInsertIntoDB(IWin32Window IWindow, 
																							string connection, 
																							string checkCommand, 
																							string signUpCommand, 
																							List<SqlPairs> sqlCheckPairs, 
																							List<SqlPairs> sqlSignUpPairs)
		{
			if (Check(sqlCheckPairs) && Check(sqlSignUpPairs))
			{
				using (SqlConnection sqlConnection = new SqlConnection(connection))
				{
					sqlConnection.Open();

					SqlCommand sqlCheckCommand = LoadParameters(checkCommand, sqlConnection, sqlCheckPairs);

					try
					{
						if (CountRowsFromDB(sqlCheckCommand) < 1)
						{
							SqlCommand sqlSignUpCommand = LoadParameters(signUpCommand, sqlConnection, sqlSignUpPairs);

							sqlSignUpCommand.ExecuteNonQuery();
						}
						else
						{
							return false;
						}
					}
					catch (Exception)
					{
						ShowMessage(IWindow, "Проверьте правильность введенных данных!", "Произошла ошибка!");

						return false;
					}
				}
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool InsertThenSelectFromDB(IWin32Window IWindow, 
																							string connection, 
																							string insertCommand, 
																							string selectCommand,
																							List<SqlPairs> sqlInsertPairs, 
																							List<SqlPairs> sqlSelectPairs, 
																							ref List<object> dataList)
		{
			if (Check(sqlInsertPairs))
			{
				using (SqlConnection sqlConnection = new SqlConnection(connection))
				{
					sqlConnection.Open();

					SqlCommand sqlInsertCommand = LoadParameters(insertCommand, sqlConnection, sqlInsertPairs);

					try
					{
						sqlInsertCommand.ExecuteNonQuery();

						SqlCommand sqlSelectCommand = LoadParameters(selectCommand, sqlConnection, sqlSelectPairs);

						ReadFromDB(sqlSelectCommand, ref dataList);

						return true;
					}
					catch (Exception)
					{
						ShowMessage(IWindow, "Проверьте правильность введенных данных!", "Произошла ошибка!");

						return false;
					}
				}
			}
			else
			{
				return false;
			}
		}
	}
}

