using System;

namespace BitcoinNET.RPCClient
{
	public class GetWorkResponse
	{
		[Obsolete]
		public string midstate;
		public string data;
		[Obsolete]
		public string hash1;
		public string target;
	}
}
