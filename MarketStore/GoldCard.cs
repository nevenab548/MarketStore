using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class GoldCard : DiscountCard
    {
        #region Properties
        public override float DiscountRate
        {
            get
            {
                if (_turnover < 100) return _discountRate = 0.02f;
                else if (_turnover <= 800)
                    return _discountRate = 0.02f+(0.01f*(int)(_turnover/100));
                else
                    return _discountRate = 0.1f;
            }
        }
        #endregion

        #region Constructors
        public GoldCard(float t, float p)
            :base(t,p) { }
        #endregion
    }
}
