using System;
using System.Collections.Generic;

namespace BitcoinNET
{
	public struct GetMemoryPoolResponse
	{
		public int version;
		public string previousblockhash;
		public IEnumerable<string> transactions;
		public long coinbasevalue;
		public string coinbaseflags;
		public long time;
		public long mintime;
		public long curtime;
		public string bits;
	}
}
