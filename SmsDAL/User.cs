using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmsDAL
{
   public  class User
    {
        [Key]
        public int Id { get; set; }

        public int RoleId { get; set; }
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "مقدار{.}را وارد کنید")]
        [MaxLength(11, ErrorMessage = "مقدار {0}نمی تواند بیشتر از {1}باشد")]
        public string Mobile { get; set; }
      
        [Display(Name = "کد فعال سازی")]
        [MaxLength(6, ErrorMessage = "مقدار {0}نمی تواند بیشتر از {1}باشد")]
        public string Code { get; set; }
        [Display(Name = "فعال/غیرفعال")]
        public bool IsActive { get; set; }
       
    }
}
