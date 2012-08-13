namespace System.Diagnostics
{
	public static class ProcessExtensions
	{
		/// <summary>
		/// Configures a <see cref="Process"/> so that it is ready to properly call the SVN client.
		/// </summary>
		/// <param name="exe">Name of the exe file to call.</param>
		/// <param name="arguments">Argunents passed to the new process.</param>
		/// <param name="workingDirectory">Start directory of the new process.</param>
		public static void Configure(this Process instance, string exe, string arguments, string workingDirectory)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo(exe, arguments);

			startInfo.WorkingDirectory = workingDirectory;
			startInfo.CreateNoWindow = true;

			// redirecting output and error streams so that they do not get flushed to console
			startInfo.UseShellExecute = false;
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;

			instance.StartInfo = startInfo;
		}
	}
}