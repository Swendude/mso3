using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Purchase
    {
        public Trip trip;
        public int class_type;
        public int amount_tickets;
        public Payment payment;
        public UIPayment paymentType;
        public String dep_station;
        public String arr_station;
        public float total;
        public String ticketprinter;//There is no ticketprinter, otherwise is would be here
        public Discount discount;
        public String discountstring;
        
        public Purchase(String arr, String dep, String discounttype, int class_t, UIPayment paymenttype)
        {
            dep_station = dep;
            arr_station = arr;
            discountstring = discounttype;
            class_type = class_t;
            paymentType = paymenttype;
        }
        public Trip makeTrip(String arr, String dep)
        {
            trip = new Trip(dep, arr);
            return trip;
        }
        public float calculateTotal()
        {
            int tariefeenheden = trip.getDistance();
            float baseprice = trip.getPrice(tariefeenheden);
            float discountprice = discount.calculateDiscountPrice(baseprice, discountstring);
            total = discountprice * amount_tickets;
            totalwithpayment = total + paymentFee.calculatePaymentPrice()
            return total;
        }
        //public Payment askPayment()
        // This function can't be implemented because of the UI's implementation, it should have asked for a payment type but it already knows this.
        public bool processPayment(float Total)
        {
            payment = new Payment(paymentType);
            bool paymentComplete = startPayment(Total);
            return paymentComplete;
        }  
        //public void print()
        // There is no printer!
    }
}
