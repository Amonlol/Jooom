using System;
using System.Windows.Forms;
using UserType = Jooom_Online.UserLibrary.UserType;

namespace Jooom_Online
{

	public partial class StudentLogin_Form : Form
	{
		private readonly string sqlCommand = "SELECT * FROM Students AS s WHERE (s.student_login = @login AND s.student_password = @password)";

		private string login, password, name;
		private int? id;

		private readonly UserType Student = UserType.Student;

		public StudentLogin_Form()
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
				UserLibrary.ExecuteLoginSqlQuerry(this, this, loginBox, passwordBox, sqlCommand, Student, ref id, ref name);
			}
		}

		private void KeyPressHandler(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				UserLibrary.ExecuteLoginSqlQuerry(this, this, loginBox, passwordBox, sqlCommand, Student, ref id, ref name);
			}
		}

	}
}
