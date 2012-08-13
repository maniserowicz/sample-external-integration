using System;

namespace Procent.Samples.ExternalIntegration.Subversion
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public class CommandScopeAttribute : Attribute
	{
		private CommandScopes _scope;
		public CommandScopes Scope
		{
			get { return _scope; }
		}

		public CommandScopeAttribute(CommandScopes commandScope)
		{
			_scope = commandScope;
		}
	}

	/// <summary>
	/// Describes the type of actions a command is performing.
	/// </summary>
	[Flags]
	public enum CommandScopes
	{
		/// <summary>
		/// Operation is local -> it does not need to contant the remote repository.
		/// </summary>
		Local = 1,
		/// <summary>
		/// Operation is remote -> contacting remote repository is necessary.
		/// </summary>
		Remote = 2
	}
}