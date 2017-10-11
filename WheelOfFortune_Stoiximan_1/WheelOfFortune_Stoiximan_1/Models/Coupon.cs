using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfFortune_Stoiximan_1.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public float Value { get; set; }
        public string CouponCode { get; set; }

        //below vars can be ignored if we make the coupons usable only once....
        public int Uses { get; set; }
        public virtual ICollection<PerCouponEligibleUsers> Pceu { get; set; }
        public bool Flag_OnlyUseOncePerUser { get; set; }


    }
}
