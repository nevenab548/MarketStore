using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DiscountCard b = new BronzeCard(0, 150);
                b.Output();
                DiscountCard s = new SilverCard(600, 850);
                s.Output();
                DiscountCard g = new GoldCard(1500, 1300);
                g.Output();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
