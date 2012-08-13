namespace Procent.Samples.ExternalIntegration.Subversion.Commands
{
	[CommandScope(CommandScopes.Local | CommandScopes.Remote)]
	public class CommitCommand : SvnCommand
	{
		private string _path;
		public string Path
		{
			get { return _path; }
			set { _path = value; }
		}

		private string _logMessage;
		public string LogMessage
		{
			get { return _logMessage; }
			set { _logMessage = value; }
		}

		public override string GetArguments()
		{
			return ArgumentsFormatter.COMMIT + " " + _path + " -m \"" + _logMessage + "\"";
		}

		public CommitCommand(SvnRepository parentRepository, string path, string logMessage)
			: base(parentRepository)
		{
			_path = path;
			_logMessage = logMessage;
		}
	}
}