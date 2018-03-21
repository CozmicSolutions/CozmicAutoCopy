namespace CozmicBackupDataAccess
{
    //public class UserAccount
    //{
    //    public Guid AccountID { set; get; }
    //    public string Username { set; get; }
    //    public string Password { set; get; }
    //    public bool Active { set; get; }
    //    public AccountMode Mode { set; get; }
    //    public DateTime CreateDate { set; get; }

    //}

    public enum AccountMode
    {
        None = 0,
        Active = 1,
        InActive = 2,
        Demo = 3
    }
}