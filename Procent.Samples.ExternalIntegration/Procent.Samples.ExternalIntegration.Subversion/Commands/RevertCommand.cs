namespace Procent.Samples.ExternalIntegration.Subversion.Commands
{
	[CommandScope(CommandScopes.Local)]
	public class RevertCommand : SvnCommand
	{
		private string _filePath;
		public string FilePath
		{
			get { return _filePath; }
			set { _filePath = value; }
		}

		public override string GetArguments()
		{
			return ArgumentsFormatter.REVERT + " " + _filePath;
		}

		public RevertCommand(SvnRepository parentRepository, string filePath)
			: base(parentRepository)
		{
			_filePath = filePath;
		}
	}
}