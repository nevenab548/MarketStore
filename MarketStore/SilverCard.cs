using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class SilverCard : DiscountCard
    {
        #region Properties
        public override float DiscountRate
        {
            get
            {
                if (_turnover <= 300) return _discountRate = 0.02f;
                else
                    return _discountRate = 0.035f;
            }
        }
        #endregion

        #region Constructors
        public SilverCard(float t,float p)
            : base(t, p) { }
        #endregion
    }
}
