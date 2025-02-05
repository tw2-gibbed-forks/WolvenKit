using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddPingedSquadRequest : gameScriptableSystemRequest
	{
		private CName _squadName;

		[Ordinal(0)] 
		[RED("squadName")] 
		public CName SquadName
		{
			get => GetProperty(ref _squadName);
			set => SetProperty(ref _squadName, value);
		}

		public AddPingedSquadRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
