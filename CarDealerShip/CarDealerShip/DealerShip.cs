﻿using System;
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


        public double RaisePrice(Vehicle vehicle, double _amount)
        {
            vehicle.Price += _amount;
            return vehicle.Price;
        }


        public double LowerPrice(Vehicle vehicle, double _amount)
        {
            vehicle.Price -= _amount;
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


        public double AcceptPayment(Customer customer, Vehicle vehicle)
        {
            customer.CheckBook -= vehicle.Price;
            return customer.CheckBook;
        }



        public void OwnerShip(Customer customer, Vehicle vehicle)
        {
            Console.WriteLine("Here are your papers!!");
            Console.WriteLine(customer.Name + " now owns a " + vehicle.Make +" " + vehicle.Model + "!!");
        }
    }

}
