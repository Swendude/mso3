using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public static class Paymentfee
    {
        //This should be a hastable, but I couldn't get the import to work on the Mono framework so I used a switch
        public static float getFee(UIPayment payment)
        {
            if (payment == UIPayment.CreditCard) {
                return 0.50f;
            }
            return 0.00f;
        }
        // Calculates the total prices based on the type of payment
        public static float calculatePaymentPrice(float total, UIPayment payment)
        {
            return total + getFee(payment);
        }
    }
}
