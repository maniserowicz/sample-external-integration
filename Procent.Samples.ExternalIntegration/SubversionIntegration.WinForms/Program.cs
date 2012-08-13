using System;
using System.Windows.Forms;

namespace SubversionIntegration.WinForms
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.ThreadException += (s, e) => MessageBox.Show("An unhandled error occured:" + Environment.NewLine + Environment.NewLine + e.Exception.Message);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain());
		}
	}
}
