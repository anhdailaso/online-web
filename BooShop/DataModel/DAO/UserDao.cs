using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.EF;
using PagedList;

namespace DataModel.Dao
{
    public class UserDao : BooShopContext
    {
       
        /// <summary>
        /// lấy user người sử dụng hiện tại
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public User GetUser(string UserName)
        {
            return Context.Users.Where(x => x.UserName == UserName).FirstOrDefault();
        }
        /// <summary>
        /// đếm tất cả user hiện có trọng database
        /// </summary>
        /// <returns></returns>
        public int Usercount()
        {
            return Context.Users.Count();
        }
        /// <summary>
        /// đăng nhập hệ thống
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="PassWord"></param>
        /// <returns></returns>
        public int Login(string Username, string PassWord)
        {
            var status = Context.Users.Where(x => x.UserName == Username).Select(x => x.Status).FirstOrDefault();
            var result = Context.Users.Count(x => x.UserName == Username && x.Password == PassWord);
            if (result == 1)
            {
                if (status == true)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }

            }
            return 0;

        }
        public IEnumerable<User> GetListUser(int page, int size)
        {
            return Context.Users.OrderByDescending(p=>p.CreatedDate).ToPagedList(page, size);
        }
    }
}
