using System;

namespace SmsSender.Models
{
    public class CodeGenerators
    {
        public static string ActiveCode()
        {
            //این تابع یک طولانی میده ابتدا به رشته تبدیل کن
            //سپس هر جا دش بود خالی بذار در نهایت از انتها کد 6 تا رار برگردون

            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);
        }
    }
}
