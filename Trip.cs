using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Trip
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
        public float getPrice()
        {
            // We always take the first column and calculate a discount percentage afterwards!
            return PricingTable.getPrice(tarief_eenheden,0);
        }
    }
}
