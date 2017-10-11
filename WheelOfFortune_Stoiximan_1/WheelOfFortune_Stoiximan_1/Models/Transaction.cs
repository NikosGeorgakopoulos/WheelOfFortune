using System.Collections;
using System.Collections.Generic;

namespace WheelOfFortune_Stoiximan_1.Models
{
    public class Transaction
    {
      public enum Action
        {
            TopUp_ViaCoupon,
            TopUp_ViaPaymentMethodA,
            PlayedGame_SpinToWin,
        };

        public int Id { get; set; }

        public User TUser { get; set; }
        public IEnumerable<Action> TAction{ get; set; }
        public int CouponID { get; set; }// the id field of the coupon that was used for the transaction if any coupon was used. -1 to mark if it wasn't used?

        //we could deduct from these two below if the player won or lost. Example:
        //If Action == PlayedGame_SpinToWin && AmountPaid > AmountReceived then the player played and he lost .
        //If Action == TopUp_ViaCoupon then AmountPaid should be 0 and  AmountReceived should be the values of the coupon.
        public float AmountPaid { get; set; }
        public float AmountReceived { get; set; }
    }
}
