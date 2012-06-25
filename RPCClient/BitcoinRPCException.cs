using System;

namespace BitcoinNET.RPCClient
{
	class BitcoinRPCException : Exception
	{
		public RPCError Error
		{
			get;
			private set;
		}

		public BitcoinRPCException(RPCError rpcError)
			: base (rpcError.message)
		{
			Error = rpcError;
		}

		public BitcoinRPCException(RPCError rpcError, Exception innerException)
			: base(rpcError.message, innerException)
		{
			Error = rpcError;
		}
	}
}
