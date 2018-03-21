namespace CozmicBackupDataAccess
{
    using System;
    using System.Linq;

    public class UserAccountRepository : RepositoryBase<CIS_UserAccount>
    {
        /// <summary>
        /// IsCredentialValid
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool IsCredentialValid(string username,string password, out CIS_UserAccount account)
        {
            account = this.SelectAllAsList()
                       .FirstOrDefault(
                           x => x.Username.Equals(username, StringComparison.CurrentCultureIgnoreCase)
                                && x.Password.Equals(password)) ;
            return account != null;
        }

        /// <summary>
        /// IsUsernameValid
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsUsernameValid(string username)
        {
            return this.SelectAllAsList()
                       .FirstOrDefault(x => x.Username.Equals(username, StringComparison.CurrentCultureIgnoreCase)) == null;
        }

        /// <summary>
        /// IsKeyValid
        /// </summary>
        /// <param name="key"></param>
        /// <param name="system"></param>
        /// <returns></returns>
        public bool IsKeyValid(Guid key , out CIS_System system)
        {
            var systemRepo = new SystemRepository();
            system = systemRepo.SelectAllAsList().FirstOrDefault(x => x.KeyValue.ToString().Equals(key.ToString()));
            if (system == null) return false;
            return true;
        }

        /// <summary>
        /// RegisterAccount
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public CIS_UserAccount RegisterAccount(string username, string password,Guid key)
        {
            var system = new CIS_System();

            if (!this.IsKeyValid(key, out system)) return null;

            var userAcc = new CIS_UserAccount()
                                          {
                                              UserAccountID = Guid.NewGuid(),
                                              Username = username,
                                              Password = password,
                                              Active = true,
                                              CreateDate = DateTime.Now,
                                              SID = system.KeyValue.Value,
                                              Status = 1
                                          };
            this.Insert(userAcc, true);
            return userAcc;
        }

    }
}