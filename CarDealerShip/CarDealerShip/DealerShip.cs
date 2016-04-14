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
        
        public List<Car> AddCar(List<Car> fleet, Car car)
        {
            carList.Add(car);
            vehicleList.Add(car);
            return carList;
        }
        public List<Truck> AddTruck(List<Truck> fleet, Truck truck)
        {
            truckList.Add(truck);
            vehicleList.Add(truck);
            return truckList;
        }
        public List<Van> AddVan(List<Van> fleet, Van van)
        {
            vanList.Add(van);
            vehicleList.Add(van);
            return vanList;
        }
        public List<SportsUtility> AddSUV(List<SportsUtility> fleet, SportsUtility sportsUtilityVehicle)
        {
            sportsUtilityList.Add(sportsUtilityVehicle);
            vehicleList.Add(sportsUtilityVehicle);
            return sportsUtilityList;
        }
        public double RaisePrice(Vehicle vehicle)
        {
            vehicle.Price += 1000;
            return vehicle.Price;
        }
    }
}
