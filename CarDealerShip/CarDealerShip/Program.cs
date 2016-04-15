﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW", "7Series", 2016, 12994494, 75000);
            DealerShip dealership = new DealerShip();
            dealership.SetPrice(bmw, 43000);
            dealership.RaisePrice(bmw, 1500);
            dealership.LowerPrice(bmw, 2000);
            dealership.AddFluid(bmw, 112);
            dealership.AddVehicle(dealership.vehicleList, bmw);
            Customer jo = new Customer("Joe", 11);
            jo.Test(bmw);
            jo.HaggleDownPrice(bmw, 3000);
          
        }
    }
}
