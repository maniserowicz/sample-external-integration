namespace Procent.Samples.ExternalIntegration.Subversion
{
	/// <summary>
	/// Represents a local copy of Subvesion repository.
	/// </summary>
	public class SvnRepository
	{
		/// <summary>
		/// Location of the remote repository.
		/// </summary>
		public string RemoteLocation { get; set; }

		/// <summary>
		/// Path to the local working copy of the repository.
		/// </summary>
		public string WorkingCopyPath { get; set; }

		public string UserName { get; set; }

		public string Password { get; set; }
	}
}