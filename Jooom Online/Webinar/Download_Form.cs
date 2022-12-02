using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SqlPairs = Jooom_Online.UserLibrary.SqlPairs;

namespace Jooom_Online
{
	public partial class Download_Form : Form
	{
		private readonly string fileFilter = "Windows Media formats (*.asf;*.wma;*.wmv;*.wm)|*.asf;*.wma;*.wmv;*.wm|Windows Media Metafiles (*.asx;*.wax;*.wvx;*.wmx;*wpl)|*.asx;*.wax;*.wvx;*.wmx;*.wpl|Audio Visual Interleave (*.avi)|*.avi|Moving Pictures Experts Group (*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u)|*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u|QuickTime Movie file (*.mov)|*.mov|MP4 Video file (*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp)|*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp";
		private readonly string insertCommand = "INSERT INTO Webinars VALUES (@name, @date, @path)";
		private readonly string selectCommand = "SELECT w.webinar_id FROM Webinars as w WHERE (w.webinar_path = @path)";

		private string filePath = "", webinarName, webinarCode;
		private int id;

		public Download_Form()
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
			else if (sender.Equals(ChooseFile_Button))
			{
				filePath = OpenFile();
			}
			else if (sender.Equals(Download_Button))
			{
				webinarName = WebinarName_Box.Text;

				if (filePath.Equals(""))
				{
					MessageBox.Show(this, "Сначала выберите файл!", "Ошибка!");
				}
				else if (webinarName.Equals(""))
				{
					MessageBox.Show(this, "Название вебинара не может быть пустым!", "Ошибка!");
				}
				else
				{
					ExecuteSqlQuerry();
				}
			}
		}

		private string OpenFile()
		{
			OpenFileDialog file = new OpenFileDialog
			{
				Filter = fileFilter,
				FilterIndex = 0,
				InitialDirectory = @"c:\",
				RestoreDirectory = true
			};

			DialogResult dialogResult = file.ShowDialog();

			if (dialogResult == DialogResult.OK)
			{
				filePath = file.FileName;
				WMP.URL = filePath;

				return filePath;
			}

			return null;
		}

		private string GenerateHexCode(int number)
		{
			string hexNumber = number.ToString("X");

			while (hexNumber.Length < 8)
			{
				hexNumber = "0" + hexNumber;
			}

			return hexNumber;
		}

		private void ExecuteSqlQuerry()
		{
			List<SqlPairs> insertPairs = new List<SqlPairs>()
					{
						new SqlPairs("@name", webinarName),
						new SqlPairs("@date", DateTime.Now),
						new SqlPairs("@path", filePath)
					};

			List<SqlPairs> selectPairs = new List<SqlPairs>()
					{
						new SqlPairs("@path", filePath)
					};

			List<object> dataList = new List<object>();

			if (UserLibrary.InsertThenSelectFromDB(this, Program.connection, insertCommand, selectCommand, insertPairs, selectPairs, ref dataList))
			{ 
				UserLibrary.SetData(dataList, 0, ref id);

				webinarCode = GenerateHexCode(id);

				WebinarCode_Box.Text = webinarCode;

				MessageBox.Show(String.Format("Код доступа к загруженному вебинару: '{0}'", webinarCode), "Успешная загрузка!");
			}
		}
	}
}
