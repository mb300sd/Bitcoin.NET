using System;
using System.Collections.Generic;

namespace BitcoinNET.RPCClient
{
	public class GetMiningInfoResponse
	{
		public long blocks;
		public int currentblocksize;
		public int currentblocktx;
		public decimal difficulty;
		public string errors;
		public bool generate;
		public int genproclimit;
		public int hashespersec;
		public int pooledtx;
		public bool testnet;
	}
}
