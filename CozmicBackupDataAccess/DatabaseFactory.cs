namespace CozmicBackupDataAccess
{
    public class DatabaseFactory
    {
        #region Public Properties

        public static SystemRepository SystemRepositoryFactory { set; get; }

        #endregion Public Properties
    }

    public class RepositoryBase<T> : LinqGenericRepositoryLibrary.LinqRepository<T, BackupDataBaseDataContext>
        where T : class
    {
    }
}