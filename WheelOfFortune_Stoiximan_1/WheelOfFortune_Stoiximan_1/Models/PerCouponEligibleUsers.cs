using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfFortune_Stoiximan_1.Models
{
    public class PerCouponEligibleUsers
    {
        public int Id { get; set; }

        public string UserEmail { get; set; }
        public int CouponId { get; set; }
    }
}
