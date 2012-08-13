using System.Windows.Forms;
using Procent.Samples.ExternalIntegration.Subversion;
using Procent.Samples.ExternalIntegration.Subversion.Commands;

namespace SubversionIntegration.WinForms
{
	public partial class FrmMain : Form
	{
		SvnRepository _repository = new SvnRepository();

		public FrmMain()
		{
			InitializeComponent();
		}

		private void btnLog_Click(object sender, System.EventArgs e)
		{
			string result = new LogCommand(_repository).Execute();
			tbOutput.Text = result;
		}

		private void btnCheckout_Click(object sender, System.EventArgs e)
		{
			tbOutput.Text = new CheckoutCommand(_repository, true).Execute();
		}

		private void btnRepoSettings_Click(object sender, System.EventArgs e)
		{
			new FrmConfigureRepo(_repository).ShowDialog();
		}
	}
}
