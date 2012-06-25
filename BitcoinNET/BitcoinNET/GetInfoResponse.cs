using System;
using System.Collections.Generic;

namespace BitcoinNET.RPCClient
{
	public class GetInfoResponse
	{
		public int version;
		public int protocolversion;
		public int walletversion;
		public decimal balance;
		public long blocks;
		public int connections;
		public string proxy;
		public decimal difficulty;
		public bool testnet;
		public long keypoololdest;
		public string keypoolsize;
		public decimal paytxfee;
		public string errors;
	}
}
