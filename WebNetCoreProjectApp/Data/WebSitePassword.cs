using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCoreProjectApp.Data
{
    public class WebSitePassword
    {
        public class UserNameEmptyException : Exception
        {
            public UserNameEmptyException() : base("Kullanıcı adı boş geçilemez")
            {

            }
        }

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string WebSite { get; set; }
        public string WebSiteUrl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int CopyCount { get; private set; }

        public ICollection<WebSitePasswordHistory> PasswordHistories { get; set; }

        public void IncreaseCopyCount()
        {
            CopyCount++;
        }

        public void ChangeUserName(string newUserName)
        {
            if (string.IsNullOrEmpty(newUserName))
            {
                throw new UserNameEmptyException();
            }
            else
            {
                UserName = newUserName.Trim();
            }
        }
    }
}
