using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SqlPairs = Jooom_Online.UserLibrary.SqlPairs;

namespace Jooom_Online
{
	public partial class StudentSignUp_Form : Form
	{
		private readonly string sqlCheckCommand = "SELECT * FROM Students AS s WHERE (s.student_login = @login AND s.student_password = @password)";
		private readonly string sqlSignUpCommand = "INSERT INTO Students VALUES (@name, @login, @password)";

		private string login, password1, password2, name;

		public StudentSignUp_Form()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			if (sender.Equals(Cancel_Button))
			{
				Close();
			}
			else if (sender.Equals(Proceed_Button))
			{
				ExecuteSqlQuerry();
			}
		}

		private void KeyPressHandler(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				ExecuteSqlQuerry();
			}
		}

		void ExecuteSqlQuerry()
		{
			name = nameBox.Text;
			login = loginBox.Text;
			password1 = passwordBox1.Text;
			password2 = passwordBox2.Text;

			if (password1 == password2)
			{
				List<SqlPairs> checkPairs = new List<SqlPairs>
				{
					new SqlPairs("@login", login),
					new SqlPairs("@password", password1)
				};

				List<SqlPairs> signUpPairs = new List<SqlPairs>
				{
					new SqlPairs("@name", name),
					new SqlPairs("@login", login),
					new SqlPairs("@password", password1)
				};

				if (UserLibrary.SelectThenInsertIntoDB(this, Program.connection, sqlCheckCommand, sqlSignUpCommand, checkPairs, signUpPairs))
				{
					DialogResult dialogResult = MessageBox.Show(this, "Студент успешно зарегистрирован!", "Успешная регистрация!", MessageBoxButtons.OK);

					if(dialogResult == DialogResult.OK)
					{
						this.Close();
					}
				}
				else
				{
					MessageBox.Show(this, String.Format("Студент с логином '{0}' уже существует в системе!", login), "Логин занят!");
				}

			}
			else
			{
				MessageBox.Show(this, "Пароли отличаются!", "Произошла ошибка!");
			}
		}
	}
}

