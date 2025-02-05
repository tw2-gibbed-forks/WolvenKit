using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAnyTargetIsLocked : redEvent
	{
		private CBool _wasSeen;

		[Ordinal(0)] 
		[RED("wasSeen")] 
		public CBool WasSeen
		{
			get => GetProperty(ref _wasSeen);
			set => SetProperty(ref _wasSeen, value);
		}

		public SetAnyTargetIsLocked(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
