using System;
using System.Windows.Forms;

namespace Jooom_Online
{
	public partial class Support_Form : Form
	{
		public Support_Form()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			if (sender.Equals(Cancel_Button))
			{
				this.Close();
			}
			else if (sender.Equals(Exit_Button))
			{
				Application.Exit();
			}
		}
	}
}
