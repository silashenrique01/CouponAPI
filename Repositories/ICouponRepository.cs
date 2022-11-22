using CouponAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponAPI.Repositories
{
    public interface ICouponRepository
    {
        Task<IEnumerable<Coupon>> Get();
        Task<Coupon> Get(int id);
        Task<Coupon> Create(Coupon coupon);
        Task Update(Coupon coupon);
        Task Delete(int id);
    }
}
