// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputPeerNotifyEventsEmpty : TLInputPeerNotifyEventsBase 
	{
		public TLInputPeerNotifyEventsEmpty() { }
		public TLInputPeerNotifyEventsEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPeerNotifyEventsEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF03064D8);
		}
	}
}