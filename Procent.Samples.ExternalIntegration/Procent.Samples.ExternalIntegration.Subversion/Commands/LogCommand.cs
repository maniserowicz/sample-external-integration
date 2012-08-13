namespace Procent.Samples.ExternalIntegration.Subversion.Commands
{
	[CommandScope(CommandScopes.Remote)]
	public class LogCommand : SvnCommand
	{
		public override string GetArguments()
		{
			return ArgumentsFormatter.LOG + " " + _parentRepository.RemoteLocation;
		}

		public LogCommand(SvnRepository parentRepository)
			: base(parentRepository)
		{
		}
	}
}