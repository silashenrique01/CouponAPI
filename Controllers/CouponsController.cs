using CouponAPI.Models;
using CouponAPI.Repositories;
using CouponAPI.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly CouponService _couponService;

        public CouponsController(CouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet]
        public IEnumerable<Coupon> GetCoupons()
        {
            return _couponService.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Coupon> GetCoupons(string id)
        {
            return _couponService.Get(id);
        }

        [HttpPost]
        public ActionResult<Coupon> PostCoupons([FromBody] Coupon coupon)
        {
            var newCoupon = _couponService.Create(coupon);
            return CreatedAtAction(nameof(GetCoupons), new { id = newCoupon.Id }, newCoupon);
        }

        [HttpPut]
        public ActionResult PutCoupons(string id, [FromBody] Coupon coupon)
        {
            if(id != coupon.Id)
            {
                return BadRequest();
            }

            _couponService.Update(id, coupon);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete (string id)
        {
            var couponToDelete = _couponService.Get(id);
            if (couponToDelete == null)
                return NotFound();

            _couponService.Remove(couponToDelete);
            return NoContent();
        }
    }
}
