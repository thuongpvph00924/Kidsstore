using KidsStore.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsStore.Model.DAO
{
   public class UserDao
    {
        
        KidsStoreDBContext db = null;
        public UserDao()
        {
            db = new KidsStoreDBContext();
        }
        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public bool Login(String UserName, string PassWord)
        {
            var res = db.Users.Count(x => x.UserName == UserName && x.Password ==PassWord);
        if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public User GetByID(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
        public bool CheckUserName(string userName)
        {
            return db.Users.Count(x => x.UserName == userName) > 0;
        }
        
       
    }
}