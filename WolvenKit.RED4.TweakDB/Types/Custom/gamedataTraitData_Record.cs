namespace WolvenKit.RED4.TweakDB.Types
{
    public partial class gamedataTraitData_Record : gamedataTweakDBRecord
    {
        [RED("loc_desc_key")]
        public CString Loc_desc_key
        {
            get => GetProperty<CString>();
            set => SetProperty<CString>(value);
        }
        
        [RED("statusEffect")]
        public TweakDBID StatusEffect
        {
            get => GetProperty<TweakDBID>();
            set => SetProperty<TweakDBID>(value);
        }
        
        [RED("loc_name_key")]
        public CString Loc_name_key
        {
            get => GetProperty<CString>();
            set => SetProperty<CString>(value);
        }
        
        [RED("dataPackage")]
        public TweakDBID DataPackage
        {
            get => GetProperty<TweakDBID>();
            set => SetProperty<TweakDBID>(value);
        }
    }
}
