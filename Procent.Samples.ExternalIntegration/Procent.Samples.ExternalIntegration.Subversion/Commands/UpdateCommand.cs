namespace Procent.Samples.ExternalIntegration.Subversion.Commands
{
	[CommandScope(CommandScopes.Local | CommandScopes.Remote)]
	public class UpdateCommand : SvnCommand
	{
		private string _path;
		public string Path
		{
			get { return _path; }
			set { _path = value; }
		}

		public override string GetArguments()
		{
			return ArgumentsFormatter.UPDATE + " " + _path;
		}

		public UpdateCommand(SvnRepository parentRepository, string path)
			: base(parentRepository)
		{
			_path = path;
		}
	}
}