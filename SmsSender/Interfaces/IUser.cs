using SmsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsSender.Interfaces
{
  public  interface IUser
    {
        //چک کردن تکراری نبودن شماره موبایل
        bool IsMobileNumberExist(string mobile);
        int AddUser(User user);
        bool ActiveUsre(string activeCode);
    }
}
