using System;
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
            bmw.fluidLevel = 12;
            Customer jo = new Customer("Joe", 11);
            jo.Test(bmw);
            DealerShip dealership = new DealerShip();
            dealership.RaisePrice(bmw);
            dealership.AddCar(dealership.vehicleList, bmw);
        }
    }
}
