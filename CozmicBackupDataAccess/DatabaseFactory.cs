namespace CozmicBackupDataAccess
{
    public class DatabaseFactory
    {
        public static SystemRepository SystemRepositoryFactory { set; get; }
    
    }

    public class RepositoryBase<T> : LinqGenericRepositoryLibrary.LinqRepository<T, BackupDataBaseDataContext>
        where T : class
    {

    }
}