using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET.RPCClient
{
	public class GetPeerInfoResponse
	{
		public string addr;
		public string services;
		public long lastsend;
		public long lastrecv;
		public long conntime;
		public int version;
		public string subver;
		public bool inbound;
		public long releasetime;
		public int startingheight;
		public int banscore;
	}
}
