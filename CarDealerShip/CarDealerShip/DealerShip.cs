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
        public List<Car> carList;
        public List<Truck> truckList;
        public List<SportsUtility> sportsUtilityList;
        public List<Van> vanList;

        public DealerShip()
        {
            vehicleList = new List<Vehicle>();
            carList = new List<Car>();
            truckList = new List<Truck>();
            sportsUtilityList = new List<SportsUtility>();
            vanList = new List<Van>();
        }
        
        public List<Vehicle> AddCar(List<Vehicle> fleet, Vehicle vehicle)
        {
            fleet.Add(vehicle);
            return fleet;
        }
       
        public double RaisePrice(Vehicle vehicle)
        {
            vehicle.Price += 1000;
            return vehicle.Price;
        }
    }
}
