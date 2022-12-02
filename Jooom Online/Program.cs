using System;
using System.Windows.Forms;

namespace Jooom_Online
{
	static class Program
	{
		public static UserLibrary.IUser CurrentUser = new UserLibrary.User();
		public static string connection = @"Persist Security Info = False; Integrated Security = true; Initial Catalog = JOOOM; Server = (localdb)\MSSQLLocalDB";

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new StartMenu_Form());
		}
	}
}
