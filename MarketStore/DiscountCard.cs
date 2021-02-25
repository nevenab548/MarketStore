using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
     abstract class DiscountCard
    {
        #region Attributes
        protected string _owner;
        protected float _turnover;
        protected float _valueOfPurchase;
        protected float _discountRate;
        protected float _discount;
        protected float _total;
        #endregion

        #region Properties
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        public float Turnover
        {
            get { return _turnover; }
            set { _turnover = value; }
        }
        public float PurchaseValue
        {
            get { return _valueOfPurchase; }
            set { _valueOfPurchase = value; }
        }
        public abstract float DiscountRate
        {
            get;
        }
        public float Discount
        {
            get { return _discount = DiscountRate * PurchaseValue; }
        }
        public float Total
        {
            get { return _total = PurchaseValue - Discount; ; }
        }
        #endregion

        #region Constructors
        public DiscountCard(float t, float p)
        {
            if (t < 0 || p < 0)
                throw new Exception("Values cannot be less than 0$");
            this.Turnover = t;
            this.PurchaseValue = p;
        }
        #endregion

        #region Methods
        public void Output()
        {
            Console.WriteLine("Purchase value: $" + this.PurchaseValue.ToString("0.00") + "\n\n");
            Console.WriteLine("Discount rate: " + (this.DiscountRate*100).ToString("0.0") + "%\n\n");
            Console.WriteLine("Discount: $" + this.Discount.ToString("0.00") + "\n\n");
            Console.WriteLine("Total: $" + this.Total.ToString("0.00") + "\n\n");
        }
        #endregion
    }
}
