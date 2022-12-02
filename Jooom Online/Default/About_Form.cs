using System;
using System.Windows.Forms;

namespace Jooom_Online
{
   public partial class About_Form : Form
   {
      public About_Form()
      {
         InitializeComponent();
      }

		private void Button_Click(object sender, EventArgs e)
		{
			if (sender.Equals(Cancel_Button))
			{
				Close();
			}
			else if (sender.Equals(Exit_Button))
			{
				Application.Exit();
			}
		}
	}
}
