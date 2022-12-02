using System;
using System.Windows.Forms;
using UserType = Jooom_Online.UserLibrary.UserType;


namespace Jooom_Online
{
	public partial class TeacherLogin_Form : Form
	{
		private readonly string sqlCommand = "SELECT * FROM Teachers AS t WHERE (t.teacher_login = @login AND t.teacher_password = @password)";

		private string login, password, name;
		private int? id;

		private readonly UserType Teacher = UserType.Teacher;

		public TeacherLogin_Form()
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
				UserLibrary.ExecuteLoginSqlQuerry(this, this, loginBox, passwordBox, sqlCommand, Teacher, ref id, ref name);
			}
		}

		private void KeyPressHandler(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				UserLibrary.ExecuteLoginSqlQuerry(this, this, loginBox, passwordBox, sqlCommand, Teacher, ref id, ref name);
			}
		}

	}
}
