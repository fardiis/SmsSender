using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmsDAL;
using SmsSender.Interfaces;
using SmsSender.Models;

namespace SmsSender.Controllers
{
    public class AccountController : Controller
    {
        private IUser _iuser;
        public AccountController(IUser iuser)
        {
            _iuser = iuser;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                if (_iuser.IsMobileNumberExist(register.Mobile))
                {
                    ModelState.AddModelError("Mobile", "شما قبلا ثبت نام کرده اید");
                    return View();
                }
                else
                {
                    User user = new User()
                    {
                        IsActive=false,
                        Mobile=register.Mobile,
                        Code = CodeGenerators.ActiveCode(),
                    };
                    _iuser.AddUser(user);
                    SMS sms = new SMS();
                    sms.Send(user.Mobile, "ثبت نام شما انجام شده و کد فعالسازی:" + user.Code);
                    return RedirectToAction("Active");
                }
            }
            else
            {
                return View(register);
            }
           
        }

    }
}
