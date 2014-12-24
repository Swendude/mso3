using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Purchase
    {
        public Trip trip;
        //public int amount_tickets; //Not used by this GUI
        public Payment payment;
        public UIPayment paymentType;
        public UIClass classtype;
        public String dep_station;
        public String arr_station;
        public float total;
        //public String ticketprinter;//There is no ticketprinter, otherwise is would be here
        public UIDiscount discounttype;
        
        public Purchase(String arr, String dep, UIDiscount discountt, UIClass class_t, UIPayment paymenttype)
        {
            dep_station = dep;
            arr_station = arr;
            discounttype = discountt;
            classtype = class_t;
            paymentType = paymenttype;
        }
        // Creates and stores a new trip objects
        public Trip makeTrip(String arr, String dep)
        {
            trip = new Trip(dep, arr);
            return trip;
        }
        // Calculates the total price of the purchase
        public float calculateTotal(bool way)
        {
            int tariefeenheden = trip.getDistance();
            float baseprice = trip.getPrice(tariefeenheden, classtype);
            float discountprice = Discount.calculateDiscountPrice(baseprice, discounttype);
            total = discountprice; //* amount_tickets;
            // return ticket
            if (way)
            {
                total = total * 2;
            }
            float totalwithpayment = Paymentfee.calculatePaymentPrice(total, paymentType);
            return totalwithpayment;
        }
        //public Payment askPayment()
        // This function can't be implemented because of the UI's implementation, it should have asked for a payment type but it already knows this.
        
        // This starts the payment and checks if it's completed
        public bool processPayment(float Total)
        {
            payment = new Payment(paymentType);
            bool paymentComplete = payment.startPayment(Total);
            return paymentComplete;
        }  
        //public void print()
        // There is no printer!
    }
}
