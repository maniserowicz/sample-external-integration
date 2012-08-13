using System;
using System.Diagnostics;

namespace Procent.Samples.ExternalIntegration.Subversion.Commands
{
	/// <summary>
	/// Base class for all commands. Containt basic logic for starting the target SVN client and arguments management.
	/// </summary>
	public abstract class SvnCommand
	{
		const string SVN_EXE_PATH = "svn";

		#region ArgumentsFormatter

		protected static class ArgumentsFormatter
		{
			public const string UPDATE = "update";
			public const string CHECKOUT = "checkout";
			public const string COMMIT = "commit";
			public const string ADD = "add";
			public const string REVERT = "revert";
			public const string LOG = "log";
			public const string USERNAME = "--username";
			public const string PASSWORD = "--password";
			public const string NO_AUTH_CACHE = "--no-auth-cache";

			/// <summary>
			/// Creates a string with values appropriate for subversion credentials.
			/// </summary>
			public static string GetCredentialsArguments(string userName, string password)
			{
				return string.Format("{0} {1} {2} {3} {4}",
					 USERNAME, userName,
					 PASSWORD, password,
					 NO_AUTH_CACHE);
			}
		}

		#endregion

		protected SvnRepository _parentRepository;

		public abstract string GetArguments();

		#region Initialization

		protected SvnCommand(SvnRepository parentRepository)
		{
			if (parentRepository == null)
				throw new ArgumentNullException("parentRepository");

			_parentRepository = parentRepository;

			// each command type must be decorated with CommandScope attribute
			Type commandType = this.GetType();
			if (commandType.IsDefined(typeof(CommandScopeAttribute), false) == false)
				throw new InvalidOperationException(string.Format("Command {0} does not have a CommandScopeAttribute applied.", commandType.Name));
		}

		#endregion

		#region Execution

		/// <summary>
		/// An extensions point allowing child commands to perform some operations before actual execution begins.
		/// </summary>
		protected virtual void BeforeExecute()
		{
		}

		/// <summary>
		/// Runs "svn" client with appropriate arguments.
		/// </summary>
		/// <returns>Output information from the "svn" client process.</returns>
		/// <exception cref="InvalidOperationException">Thrown when the <see cref="SvnRepository"/> instance is not configured with enough data.</exception>
		/// <exception cref="CannotStartSvnException">Thrown when the "svn" shell command cannot be called.</exception>
		/// <exception cref="SvnException">Thrown when an error occurs during execution of the svn command.</exception>
		public string Execute()
		{
			CommandScopeAttribute scopeAttribute = (CommandScopeAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(CommandScopeAttribute));

			ValidateScopeInformation(scopeAttribute);

			BeforeExecute();

			string arguments = this.GetArguments();

			if ((scopeAttribute.Scope & CommandScopes.Remote) > 0)
				arguments += " " + ArgumentsFormatter.GetCredentialsArguments(_parentRepository.UserName, _parentRepository.Password);

			Process process = new Process();

			process.Configure(SVN_EXE_PATH, arguments, _parentRepository.WorkingCopyPath);

			try
			{
				process.Start();
			}
			catch (Exception exc)
			{
				CannotStartSvnException csse = new CannotStartSvnException("Cannot start SVN process. Make sure that Subversion is intalled." + Environment.NewLine + exc.Message, exc);
				csse.Arguments = GetArguments();
				throw csse;
			}

			// calling WaitForExit before StandardOutput.ReadToEnd can cause deadlocks when the child process's output is longer than 1024 buffer
			string output = process.StandardOutput.ReadToEnd();

			process.WaitForExit();

			// ExitCode different than 0 means that an error occured in SVN client
			if (process.ExitCode != 0)
			{
				SvnException se = new SvnException(process.StandardError.ReadToEnd());
				se.Arguments = GetArguments();
				throw se;
			}
			return output;
		}

		/// <summary>
		/// Validates that all required information has been supplied.
		/// </summary>
		private void ValidateScopeInformation(CommandScopeAttribute scopeAttribute)
		{
			// local commands need workingCopyPath
			if ((scopeAttribute.Scope & CommandScopes.Local) > 0)
			{
				if (string.IsNullOrEmpty(_parentRepository.WorkingCopyPath))
					throw new InvalidOperationException("Working copy path has not been set!");
			}

			// remote commands need credentials and remote repository location
			if ((scopeAttribute.Scope & CommandScopes.Remote) > 0)
			{
				string commandName = this.GetType().Name;

				if (string.IsNullOrEmpty(_parentRepository.UserName) || string.IsNullOrEmpty(_parentRepository.Password))
					throw new InvalidOperationException(string.Format("A command {0} needs to contact remote repository but credentials are not set.", commandName));

				if (string.IsNullOrEmpty(_parentRepository.RemoteLocation))
					throw new InvalidOperationException(string.Format("A command {0} needs to contact remote repository but the remote location is not set.", commandName));
			}
		}

		#endregion
	}
}