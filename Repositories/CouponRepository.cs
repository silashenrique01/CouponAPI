using CouponAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponAPI.Repositories
{
    public class CouponRepository : ICouponRepository
    {
        private readonly CouponContext _context;

        public CouponRepository(CouponContext context)
        {
            _context = context;
        }

        public async Task<Coupon> Create(Coupon coupon)
        {
            _context.Coupons.Add(coupon);
            await _context.SaveChangesAsync();

            return coupon;
        }

        public async Task Delete(int id)
        {
            var couponToDelete = await _context.Coupons.FindAsync(id);
            _context.Coupons.Remove(couponToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Coupon>> Get()
        {
            return await _context.Coupons.ToListAsync();
        }

        public async Task<Coupon> Get(int id)
        {
            return await _context.Coupons.FindAsync(id);
        }

        public async Task Update(Coupon coupon)
        {
            _context.Entry(coupon).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
