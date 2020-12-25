using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmsSender.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "شماره موبایل")]
        //[RegularExpression(@"09[1 9 3 0]\d{8}", ErrorMessage = "شماره نامعتبر است")]
        public string Mobile { get; set; }
        public string Code { get; set; }
    }
}
