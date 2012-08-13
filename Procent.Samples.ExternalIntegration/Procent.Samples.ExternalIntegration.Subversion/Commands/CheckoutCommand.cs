using System;
using System.IO;

namespace Procent.Samples.ExternalIntegration.Subversion.Commands
{
	[CommandScope(CommandScopes.Local | CommandScopes.Remote)]
	public class CheckoutCommand : SvnCommand
	{
		private readonly bool _createDirIfNotExists;

		public override string GetArguments()
		{
			return ArgumentsFormatter.CHECKOUT + " " + _parentRepository.RemoteLocation + " .";
		}

		public CheckoutCommand(SvnRepository parentRepository, bool createDirIfNotExists)
			: base(parentRepository)
		{
			_createDirIfNotExists = createDirIfNotExists;
		}

		protected override void BeforeExecute()
		{
			if (Directory.Exists(_parentRepository.WorkingCopyPath) == false)
			{
				if (_createDirIfNotExists)
					Directory.CreateDirectory(_parentRepository.WorkingCopyPath);
				else
					throw new InvalidOperationException("Directory " + _parentRepository.WorkingCopyPath + " does not exist!");
			}

			base.BeforeExecute();
		}
	}
}