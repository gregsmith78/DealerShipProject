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
            Car bmw = new Car("BMW", "7Series", 2016, 12994494, 30000);
            DealerShip dealership = new DealerShip();
            dealership.RaisePrice(bmw);
            dealership.AddCar(dealership.carList, bmw);
        }
    }
}