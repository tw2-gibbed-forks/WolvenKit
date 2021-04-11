namespace WolvenKit.RED4.TweakDB.Types
{
    public partial class gamedataWidgetDefinition_Record : gamedataTweakDBRecord
    {
        [RED("useContentRatio")]
        public CBool UseContentRatio
        {
            get => GetProperty<CBool>();
            set => SetProperty<CBool>(value);
        }
        
        [RED("libraryID")]
        public CString LibraryID
        {
            get => GetProperty<CString>();
            set => SetProperty<CString>(value);
        }
        
        [RED("libraryPath")]
        public raRef<CResource> LibraryPath
        {
            get => GetProperty<raRef<CResource>>();
            set => SetProperty<raRef<CResource>>(value);
        }
        
        [RED("styles")]
        public CArray<TweakDBID> Styles
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("ratios")]
        public CArray<TweakDBID> Ratios
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
    }
}
