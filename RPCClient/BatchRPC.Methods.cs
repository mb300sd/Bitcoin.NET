using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET.RPCClient
{
	public partial class BatchRPC
	{
		public new uint AddMultiSigAddress(int NRequired, IEnumerable<string> Keys, string Account = "")
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("addmultisigaddress", new Object[] { NRequired, Keys, Account }, id));
			return id;
		}

		public new uint BackupWallet(string Destination)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("backupwallet", new Object[] { Destination }, id));
			return id;
		}

		public new uint DumpPrivKey(string BitcoinAddress)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("dumpprivkey", new Object[] { BitcoinAddress }, id));
			return id;
		}

		public new uint EncryptWallet(string Passphrase)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("encryptwallet", new Object[] { Passphrase }, id));
			return id;
		}

		public new uint GetAccount(string BitcoinAddress)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getaccount", new Object[] { BitcoinAddress }, id));
			return id;
		}

		public new uint GetAccountAddress(string Account)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getaccountaddress", new Object[] { Account }, id));
			return id;
		}

		public new uint GetAddressesByAccount(string Account)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getaddressesbyaccount", new Object[] { Account }, id));
			return id;
		}

		public new uint GetBalance(string Account = null, int MinConf = 1)
		{
			uint id = NewID;
			if (Account == null)
			{
				requests.Add
					(new RPCRequest("getbalance", null, id));
				return id;
			}
			requests.Add
				(new RPCRequest("getbalance", new Object[] { Account, MinConf }, id));
			return id;
		}

		public new uint GetBlock(string Hash)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getblock", new Object[] { Hash }, id));
			return id;
		}

		public new uint GetBlockCount()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getblockcount", null, id));
			return id;
		}

		public new uint GetBlockHash(long Index)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getblockhash", new Object[] { Index }, id));
			return id;
		}

		public new uint GetConnectionCount()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getconnectioncount", null, id));
			return id;
		}

		public new uint GetDifficulty()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getdifficulty", null, id));
			return id;
		}

		public new uint GetGenerate()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getgenerate", null, id));
			return id;
		}

		public new uint GetHashesPerSec()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("gethashespersec", null, id));
			return id;
		}

		public new uint GetInfo()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getinfo", null, id));
			return id;
		}

		public new uint GetMiningInfo()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getinfo", null, id));
			return id;
		}

		public new uint GetNewAddress(string Account = "")
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getnewaddress", new Object[] { Account }, id));
			return id;
		}

		public new uint GetReceivedByAccount(string Account, int MinConf = 1)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getreceivedbyaccount", new Object[] { Account, MinConf }, id));
			return id;
		}

		public new uint GetReceivedByAddress(string BitcoinAddress, int MinConf = 1)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getreceivedbyaddress", new Object[] { BitcoinAddress, MinConf }, id));
			return id;
		}

		public new uint GetTransaction(string TxID)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("gettransaction", new Object[] { TxID }, id));
			return id;
		}

		public new uint GetWork()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getwork", null, id));
			return id;
		}

		public new uint GetWork(string Data)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("getwork", new Object[] { Data }, id));
			return id;
		}

		public new uint Help(string Command = "")
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("help", new Object[] { Command }, id));
			return id;
		}

		public new uint ImportPrivKey(string BitcoinPrivKey, string Label = "", bool Rescan = true)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("importprivkey", new Object[] { BitcoinPrivKey, Label, Rescan }, id));
			return id;
		}

		public new uint KeyPoolRefill()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("keypoolrefill", null, id));
			return id;
		}

		public new uint ListAccounts(int MinConf = 1)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("listaccounts", new Object[] { MinConf }, id));
			return id;
		}

		public new uint ListAddressGroupings(bool showEmptyGroups = true, bool showEmptyAddresses = true)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("listaddressgroupings", new Object[] { showEmptyGroups, showEmptyAddresses }, id));
			return id;
		}

		public new uint ListReceivedByAccount(int MinConf = 1, bool IncludeEmpty = false)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("listreceivedbyaccount", new Object[] { MinConf, IncludeEmpty }, id));
			return id;
		}

		public new uint ListReceivedByAddress(int MinConf = 1, bool IncludeEmpty = false)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("listreceivedbyaddress", new Object[] { MinConf, IncludeEmpty }, id));
			return id;
		}

		public new uint ListSinceBlock(string BlockHash = null, int TargetConfirmations = 1)
		{
			uint id = NewID;
			if (BlockHash == null)
			{
				requests.Add
					(new RPCRequest("listsinceblock", null, id));
				return id;
			}
			requests.Add
				(new RPCRequest("listsinceblock", new Object[] { BlockHash, TargetConfirmations }, id));
			return id;
		}

		public new uint ListTransactions(string Account = "*", int Count = 10, int From = 0)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("listtransactions", new Object[] { Account, Count, From }, id));
			return id;
		}

		public new uint Move(string FromAccount, string ToAccount, decimal Amount, int MinConf = 1, string Comment = "")
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("move", new Object[] { FromAccount, ToAccount, Amount, MinConf, Comment }, id));
			return id;
		}

		public new uint SendFrom(string FromAccount, string ToBitcoinAddress, decimal Amount, int MinConf = 1, string Comment = "", string CommentTo = "")
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("sendfrom", new Object[] { FromAccount, ToBitcoinAddress, Amount, MinConf, Comment, CommentTo }, id));
			return id;
		}

		public new uint SendMany(string FromAccount, IDictionary<string, decimal> ToBitcoinAddresses, int MinConf = 1, string Comment = "")
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("sendmany", new Object[] { FromAccount, ToBitcoinAddresses, MinConf, Comment }, id));
			return id;
		}

		public new uint SendToAddress(string BitcoinAddress, decimal Amount, string Comment = "", string CommentTo = "")
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("sendtoaddress", new Object[] { BitcoinAddress, Amount, Comment, CommentTo }, id));
			return id;
		}

		public new uint SetAccount(string BitcoinAddress, string Account)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("setaccount", new Object[] { BitcoinAddress, Account }, id));
			return id;
		}

		public new uint SetGenerate(bool Generate, int GenProcLimit = 1)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("setgenerate", new Object[] { Generate, GenProcLimit }, id));
			return id;
		}

		public new uint SetTxFee(decimal Amount)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("settxfee", new Object[] { Amount }, id));
			return id;
		}

		public new uint SignMessage(string BitcoinAddress, string Message)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("signmessage", new Object[] { BitcoinAddress, Message }, id));
			return id;
		}

		public new uint Stop()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("stop", null, id));
			return id;
		}

		public new uint ValidateAddress(string Address)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("validateaddress", new Object[] { Address }, id));
			return id;
		}

		public new uint WalletLock()
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("walletlock", null, id));
			return id;
		}

		public new uint WalletPassphrase(string Passphrase, int Timeout)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("walletpassphrase", new Object[] { Passphrase, Timeout }, id));
			return id;
		}

		public new uint WalletPassphraseChange(string OldPassphrase, string NewPassphrase)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("walletpassphrasechange", new Object[] { OldPassphrase, NewPassphrase }, id));
			return id;
		}

		public new uint VerifyMessage(string BitcoinAddress, string Signature, string Message)
		{
			uint id = NewID;
			requests.Add
				(new RPCRequest("verifymessage", new Object[] { BitcoinAddress, Signature, Message }, id));
			return id;
		}
	}
}
