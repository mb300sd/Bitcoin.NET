using System;
using System.Collections.Generic;

namespace BitcoinNET.RPCClient
{
	public class GetBlockResponse
	{
		public string hash;
		public long confirmations;
		public int size;
		public long height;
		public int version;
		public string merkleroot;
		public IEnumerable<string> tx;
		public long time;
		public long nonce;
		public string bits;
		public decimal difficulty;
		public string previousblockhash;
		public string nextblockhash;
	}
}
