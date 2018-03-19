namespace CozmicAutoCopyService
{
    using Ninject.Modules;

    public class AutoCopyModule : NinjectModule
    {
        #region Public Methods

        public override void Load()
        {
            this.Bind<IAutoCopyDependency>().To<AutoCopyDependency>();
        }

        #endregion Public Methods
    }
}