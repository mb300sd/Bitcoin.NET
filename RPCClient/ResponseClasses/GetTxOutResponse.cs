using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET.RPCClient
{
	public class GetTxOutResponse
	{
		public class ScriptPubKey
		{
			public string asm;
			public string hex;
			public int reqSigs;
			public string type;
			public string[] addresses;
		}

		public string bestblock;
		public int confirmations;
		public decimal value;
		public ScriptPubKey scriptPubKey;
		public int version;
		public bool coinbase;
	}
}