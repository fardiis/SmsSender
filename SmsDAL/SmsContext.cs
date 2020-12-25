using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmsDAL
{
   public class SmsContext: DbContext
    {
        public SmsContext(DbContextOptions<SmsContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
