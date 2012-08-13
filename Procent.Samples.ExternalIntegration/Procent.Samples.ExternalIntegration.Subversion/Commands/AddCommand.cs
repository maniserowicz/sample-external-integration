namespace Procent.Samples.ExternalIntegration.Subversion.Commands
{
	[CommandScope(CommandScopes.Local)]
	public class AddCommand : SvnCommand
	{
		private string _filePath;
		public string FilePath
		{
			get { return _filePath; }
			set { _filePath = value; }
		}

		public override string GetArguments()
		{
			return ArgumentsFormatter.ADD + " " + _filePath;
		}

		public AddCommand(SvnRepository parentRepository, string filePath)
			: base(parentRepository)
		{
			_filePath = filePath;
		}
	}
}