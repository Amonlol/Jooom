using System;
using System.Windows.Forms;

namespace Jooom_Online {
	public partial class StartMenu_Form : Form {
		public StartMenu_Form()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			if (sender.Equals(About_Button))
			{
				About_Form about = new About_Form();
				about.ShowDialog();
			}
			else if (sender.Equals(Support_Button))
			{
				Support_Form support = new Support_Form();
				support.ShowDialog();
			}
			else if (sender.Equals(Exit_Button))
			{
				Application.Exit();
			}
			else if (sender.Equals(LoginStudent_Button))
			{
				using (StudentLogin_Form studentLogin = new StudentLogin_Form())
				{
					DialogResult studentResult = studentLogin.ShowDialog();

					if (studentResult == DialogResult.OK)
					{
						studentLogin.Close();
						this.Hide();

						using (Watch_Form watch_Form = new Watch_Form())
						{
							DialogResult watchResult = watch_Form.ShowDialog();

							if (watchResult == DialogResult.Cancel)
							{
								Program.CurrentUser.ResetUserData();

								try
								{
									watch_Form.Close();
									this.Show();
								}
								catch (Exception)
								{

								}
							}
						}

					}
				}
			}
			else if (sender.Equals(LoginTeacher_Button))
			{
				using (TeacherLogin_Form teacherLogin = new TeacherLogin_Form())
				{
					DialogResult teacherResult = teacherLogin.ShowDialog();

					if (teacherResult == DialogResult.OK)
					{
						teacherLogin.Close();
						this.Hide();

						using (Download_Form download_Form = new Download_Form())
						{
							DialogResult downloadResult = download_Form.ShowDialog();

							if (downloadResult == DialogResult.Cancel)
							{
								Program.CurrentUser.ResetUserData();

								try
								{
									download_Form.Close();
									this.Show();
								}
								catch (Exception)
								{

								}

							}
						}

					}
				}
			}
			else if (sender.Equals(RegisterStudent_Button))
			{
				StudentSignUp_Form studentSignUp = new StudentSignUp_Form();
				studentSignUp.ShowDialog();
			}
			else if (sender.Equals(RegisterTeacher_Button))
			{
				TeacherSignUp_Form teacherSignUp = new TeacherSignUp_Form();
				teacherSignUp.ShowDialog();
			}
		}
	}
}
