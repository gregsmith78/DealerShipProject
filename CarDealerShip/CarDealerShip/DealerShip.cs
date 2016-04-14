using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class DealerShip
    {
        public List<Vehicle> vehicleList;

        public DealerShip()
        {
            vehicleList = new List<Vehicle>();
        }
        public double SetPrice(Vehicle vehicle, int _amount)
        {
            vehicle.Price = _amount;
            return vehicle.Price;
        }
        
        public List<Vehicle> AddVehicle(List<Vehicle> fleet, Vehicle vehicle)
        {
            fleet.Add(vehicle);
            return fleet;
        }
       
        public double RaisePrice(Vehicle vehicle)
        {
            vehicle.Price += 1000;
            return vehicle.Price;
        }
        public int AddFluid(Vehicle vehicle, int fluid_amount)
        {
            vehicle.FluidLevel += fluid_amount;

            if (vehicle.FluidLevel < 0)
        {
                vehicle.FluidLevel = 0;
        }
        else if (vehicle.FluidLevel > 100)
        {
                vehicle.FluidLevel = 100;
        }
        
           
            return vehicle.FluidLevel;
        }
    }
}
