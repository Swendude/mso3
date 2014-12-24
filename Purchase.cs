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
        // Creates and stores a new trip objects
        public Trip makeTrip(String arr, String dep)
        {
            trip = new Trip(dep, arr);
            return trip;
        }
        // Calculates the total price of the purchase
        public float calculateTotal()
        {
            int tariefeenheden = trip.getDistance();
            float baseprice = trip.getPrice(tariefeenheden);
            float discountprice = discount.calculateDiscountPrice(baseprice, discountstring);
            total = discountprice * amount_tickets;
            float totalwithpayment = Paymentfee.calculatePaymentPrice(total, paymentType);
            return totalwithpayment;
        }
        //public Payment askPayment()
        // This function can't be implemented because of the UI's implementation, it should have asked for a payment type but it already knows this.
        
        // This starts the payment and checks if it's completed
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
