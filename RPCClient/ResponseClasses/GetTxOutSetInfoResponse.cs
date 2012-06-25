using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET.RPCClient
{
	public class GetTxOutSetInfoResponse
	{
		public string bestblock;
		public long transactions;
		public long txouts;
		public long bytes_serialized;
	}
}
