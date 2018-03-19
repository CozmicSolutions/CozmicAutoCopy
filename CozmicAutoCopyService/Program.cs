namespace CozmicAutoCopyService
{
    using Topshelf;
    using Topshelf.Ninject;

    internal class Program
    {
        #region Private Methods

        private static void Main()
        {
            HostFactory.Run(c =>
                {
                    c.UseNinject(new AutoCopyModule());

                    c.Service<AutoCopyService>(s =>
                        {
                            s.ConstructUsingNinject();
                            s.WhenStarted((service, control) => service.Start());
                            s.WhenStopped((service, control) => service.Stop());
                        });
                });
        }

        #endregion Private Methods
    }
}