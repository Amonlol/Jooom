using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SqlPairs = Jooom_Online.UserLibrary.SqlPairs;

namespace Jooom_Online
{
	public partial class Watch_Form : Form
	{
		private readonly string selectCommand = "SELECT * FROM Webinars as w WHERE (w.webinar_id = @id)";
		private string webinarCode, webinarName = "", filePath = "";
		private int? id;

		public Watch_Form()
		{
			InitializeComponent();

			Name_Box.Text = Program.CurrentUser.Name;
		}

		private void Button_Click(object sender, EventArgs e)
		{
			if (sender.Equals(Exit_Button))
			{
				Application.Exit();
			}
			else if (sender.Equals(Cancel_Button))
			{
				this.DialogResult = DialogResult.Cancel;
			}
			else if (sender.Equals(Watch_Button))
			{
				webinarCode = WebinarCode_Box.Text;

				if(webinarCode.Length < 1)
				{
					MessageBox.Show("Введите код доступа к вебинару!", "Ошибка!");
				}
				else
				{
					id = ResetHexCode(webinarCode);

					List<SqlPairs> selectPairs = new List<SqlPairs>()
					{
						new SqlPairs("@id", id)
					};

					List<object> dataList = new List<object>();

					if(UserLibrary.SelectFromDB(this, Program.connection, selectCommand, selectPairs, ref dataList))
					{
						UserLibrary.SetData(dataList, 1, ref webinarName);
						UserLibrary.SetData(dataList, 3, ref filePath);

						WebinarName_Box.Text = webinarName;
						WMP.URL = filePath;
					}
					else
					{
						MessageBox.Show("Вебинара с указанным кодом доступа не существует!", "Произошла ошибка!");
					}
				}
			}
		}


		private int ResetHexCode(string hexNumber)
		{
			int number = Convert.ToInt32(hexNumber, 16);

			return number;
		}
	}
}
