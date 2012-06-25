using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET
{
	public class RPCResponse<T>
	{
		public T result;
		public RPCError error;
		public int id;
	}
}
