using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaiThi1.Models
{
    public class BaiThi1Context : DbContext
    {
        public BaiThi1Context (DbContextOptions<BaiThi1Context> options)
            : base(options)
        {
        }

        public DbSet<BaiThi1.Models.Student> Student { get; set; }
    }
}
