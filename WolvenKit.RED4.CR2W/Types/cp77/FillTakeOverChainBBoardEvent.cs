using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FillTakeOverChainBBoardEvent : redEvent
	{
		private gamePersistentID _requesterID;

		[Ordinal(0)] 
		[RED("requesterID")] 
		public gamePersistentID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		public FillTakeOverChainBBoardEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
