using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Jooom_Online
{
	partial class UserLibrary
	{
		public static void ShowMessage(string message, string windowName)
		{
			MessageBox.Show(message, windowName);
		}
		public static void ShowMessage(IWin32Window IWindow, string message, string windowName)
		{
			MessageBox.Show(IWindow, message, windowName);
		}
		public static void SetData<T>(List<object> dataList, int pointer, ref T o)
		{
			o = (T)dataList[pointer];
		}
		public static void ExecuteLoginSqlQuerry(IWin32Window window, Form form, TextBox loginBox, TextBox passwordBox, string sqlCommand, UserType userType, ref int? id, ref string name)
		{
			string login, password;

			login = loginBox.Text;
			password = passwordBox.Text;

			List<SqlPairs> parameterPairs = new List<SqlPairs>
				{
					new SqlPairs("@login", login),
					new SqlPairs("@password", password)
				};

			List<object> dataList = new List<object>();

			if (SelectFromDB(window, Program.connection, sqlCommand, parameterPairs, ref dataList))
			{
				SetData(dataList, 0, ref id);
				SetData(dataList, 1, ref name);

				Program.CurrentUser.ChangeUserData(id, name, userType);

				DialogResult dialogResult = MessageBox.Show(window, String.Format("Добро пожаловать, {0}", name), "Успешно!", MessageBoxButtons.OK);

				if (dialogResult == DialogResult.OK)
				{
					form.DialogResult = DialogResult.OK;
				}
			}
			else
			{
				MessageBox.Show(window, String.Format("Пользователя с логином {0} не существует в системе!",login), "Произошла ошибка!");
			}
		}

	}
}
