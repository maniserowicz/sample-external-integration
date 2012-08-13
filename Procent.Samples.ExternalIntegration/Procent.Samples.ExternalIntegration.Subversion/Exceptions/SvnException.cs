using System;
using System.Runtime.Serialization;

namespace Procent.Samples.ExternalIntegration.Subversion
{
	[Serializable]
	public class SvnException : Exception
	{
		public string Arguments { get; set; }

		public SvnException()
		{
		}

		public SvnException(string message)
			: base(message)
		{
		}

		public SvnException(string message, Exception inner)
			: base(message, inner)
		{
		}

		protected SvnException(
			SerializationInfo info,
			StreamingContext context)
			: base(info, context)
		{
		}
	}
}