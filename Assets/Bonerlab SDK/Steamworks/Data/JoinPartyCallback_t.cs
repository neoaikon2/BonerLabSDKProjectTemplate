using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 276)]
	internal struct JoinPartyCallback_t : ICallbackData
	{
		internal Result Result;

		internal ulong BeaconID;

		internal ulong SteamIDBeaconOwner;

		internal byte[] ConnectString;

		public static int _datasize;

		public int DataSize
		{
			get
			{
				return default(int);
			}
		}

		public CallbackType CallbackType
		{
			get
			{
				return default(CallbackType);
			}
		}
	}
}
