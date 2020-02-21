using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;


namespace Models
{
    public class AccountModel
    {

        private OnlineShopDBContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDBContext();
        }

        public bool Login(string userName, string password)
        {
            object[] sqlParams =
             {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@Password",password)
            };
            var res = context.Database.SqlQuery<bool>("sp_account_login,@UserName,@Password", sqlParams).SingleOrDefault();
            return res;

        }
    }
}
