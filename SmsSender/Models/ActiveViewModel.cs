using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmsSender.Models
{
    public class ActiveViewModel
    {
        [Display(Name = "کد فعالسازی ")]
     
        public string Code { get; set; }
    }
}
