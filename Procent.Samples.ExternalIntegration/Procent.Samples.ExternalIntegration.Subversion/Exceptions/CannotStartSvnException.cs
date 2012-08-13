using System;
using System.Runtime.Serialization;

namespace Procent.Samples.ExternalIntegration.Subversion
{
	[Serializable]
	public class CannotStartSvnException : SvnException
	{
		public CannotStartSvnException()
		{
		}

		public CannotStartSvnException(string message)
			: base(message)
		{
		}

		public CannotStartSvnException(string message, Exception inner)
			: base(message, inner)
		{
		}

		protected CannotStartSvnException(
			SerializationInfo info,
			StreamingContext context)
			: base(info, context)
		{
		}
	}
}