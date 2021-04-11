namespace WolvenKit.RED4.TweakDB.Types
{
    public partial class gamedataActionPayment_Record : gamedataTweakDBRecord
    {
        [RED("priority")]
        public CFloat Priority
        {
            get => GetProperty<CFloat>();
            set => SetProperty<CFloat>(value);
        }
        
        [RED("completionEffects")]
        public CArray<TweakDBID> CompletionEffects
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("interactionLayer")]
        public CName InteractionLayer
        {
            get => GetProperty<CName>();
            set => SetProperty<CName>(value);
        }
        
        [RED("cooldown")]
        public TweakDBID Cooldown
        {
            get => GetProperty<TweakDBID>();
            set => SetProperty<TweakDBID>(value);
        }
        
        [RED("objectActionType")]
        public TweakDBID ObjectActionType
        {
            get => GetProperty<TweakDBID>();
            set => SetProperty<TweakDBID>(value);
        }
        
        [RED("activationTime")]
        public CArray<TweakDBID> ActivationTime
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("hackCategory")]
        public TweakDBID HackCategory
        {
            get => GetProperty<TweakDBID>();
            set => SetProperty<TweakDBID>(value);
        }
        
        [RED("startEffects")]
        public CArray<TweakDBID> StartEffects
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("instigatorActivePrereqs")]
        public CArray<TweakDBID> InstigatorActivePrereqs
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("objectActionUI")]
        public TweakDBID ObjectActionUI
        {
            get => GetProperty<TweakDBID>();
            set => SetProperty<TweakDBID>(value);
        }
        
        [RED("targetPrereqs")]
        public CArray<TweakDBID> TargetPrereqs
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("rewards")]
        public CArray<TweakDBID> Rewards
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("costs")]
        public CArray<TweakDBID> Costs
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("instigatorPrereqs")]
        public CArray<TweakDBID> InstigatorPrereqs
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("targetActivePrereqs")]
        public CArray<TweakDBID> TargetActivePrereqs
        {
            get => GetProperty<CArray<TweakDBID>>();
            set => SetProperty<CArray<TweakDBID>>(value);
        }
        
        [RED("gameplayCategory")]
        public TweakDBID GameplayCategory
        {
            get => GetProperty<TweakDBID>();
            set => SetProperty<TweakDBID>(value);
        }
        
        [RED("actionName")]
        public CName ActionName
        {
            get => GetProperty<CName>();
            set => SetProperty<CName>(value);
        }
    }
}
