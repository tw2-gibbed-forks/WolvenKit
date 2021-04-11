namespace WolvenKit.RED4.TweakDB.Types
{
    public partial class gamedataVehicleFxCollision_Record : gamedataTweakDBRecord
    {
        [RED("materials")]
        public CArray<TweakDBID> Materials
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
    }
}
