using System.Windows.Forms;
using Procent.Samples.ExternalIntegration.Subversion;

namespace SubversionIntegration.WinForms
{
	public partial class FrmConfigureRepo : Form
	{
		public FrmConfigureRepo(SvnRepository repository)
		{
			InitializeComponent();

			svnRepositoryBindingSource.DataSource = repository;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
