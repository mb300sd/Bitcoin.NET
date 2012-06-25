using System;
using System.Collections.Generic;

namespace BitcoinNET
{
	public struct GetWorkResponse
	{
		[Obsolete]
		public string midstate;
		public string data;
		[Obsolete]
		public string hash1;
		public string target;
	}
}
