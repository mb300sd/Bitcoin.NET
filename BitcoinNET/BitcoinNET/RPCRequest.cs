using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BitcoinNET
{
	[JsonObject(MemberSerialization=MemberSerialization.Fields)]
	public class RPCRequest
	{
		string jsonrpc = "1.0";
		int id = 1;
		string method;

		[JsonProperty(PropertyName="params", NullValueHandling=NullValueHandling.Ignore)]
		IList<Object> requestParams = null;

		public RPCRequest(string method, IList<Object> requestParams = null)
		{
			this.method = method;
			this.requestParams = requestParams;
		}
	}
}
