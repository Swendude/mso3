using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Trip
    {
        public String dep_station;
        public String arr_station;
        public int tarief_eenheden;
        public float price;
        public Trip(String dep, String arr)
        {
            dep_station = dep;
            arr_station = arr;
        }
        public int getDistance()
        {
            tarief_eenheden = Tariefeenheden.getTariefeenheden(dep_station, arr_station);
            return tarief_eenheden;
        } 
        // This had to change, it should also consider the class!
        public float getPrice(int tfe, UIClass typeClass)
        {
            switch (typeClass)
            {
                case UIClass.FirstClass:
                    return PricingTable.getPrice(tfe, 3);
                default:
                    return PricingTable.getPrice(tfe, 0);
            }
        }
    }
}
