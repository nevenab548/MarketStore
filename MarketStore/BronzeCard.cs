using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class BronzeCard : DiscountCard
    {
        #region Properties
        public override float DiscountRate
        {
            get { if (_turnover < 100) return _discountRate = 0;
                else if (_turnover >= 100 && _turnover <= 300)
                   return _discountRate = 0.01f;
                else
                    return _discountRate = 0.025f;
            }
        }
        #endregion

        #region Constructors
        public BronzeCard(float t, float p)
            : base(t, p) { }
        #endregion
    }
}
