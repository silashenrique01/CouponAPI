using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponAPI.Models
{
    public class CouponContext : DbContext
    {
        public CouponContext(DbContextOptions<CouponContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Coupon> Coupons { get; set; }
    }
}
