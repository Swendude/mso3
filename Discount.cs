using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public static class Discount
    {
        // Once again I couldn't get the hashtable into my framework so I improvised with a switch!
        public static float getDiscount(UIDiscount discounttype)
        {
            switch (discounttype)
            {
                case UIDiscount.TwentyDiscount:
                    return 0.8f;
                case UIDiscount.FortyDiscount:
                    return 0.6f;
            }
            return 1.0f;
        }
        public static float calculateDiscountPrice(float total, UIDiscount discounttype)
        {
            return (float)Math.Round(total * getDiscount(discounttype),1);
        }
    }
}
