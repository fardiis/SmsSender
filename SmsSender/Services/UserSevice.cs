using SmsDAL;
using SmsSender.Interfaces;
using SmsSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsSender.Services
{
    public class UserSevice : IUser
    {
        SmsContext _context;
        public UserSevice(SmsContext context)
        {
            _context = context;
        }
        public bool ActiveUsre(string activeCode)
        {
            var user = _context.Users.FirstOrDefault(u => u.IsActive == false && u.Code == activeCode);
            if (user != null)
            {
                user.Code = CodeGenerators.ActiveCode();
                user.IsActive = true;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public bool IsMobileNumberExist(string mobile)
        {
            return _context.Users.Any(u => u.Mobile == mobile);
        }
    }
}
