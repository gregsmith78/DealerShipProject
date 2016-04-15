using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class Customer : ITestable
    {
        private string name;
        private int id;

        public Customer(string _name, int _id)
        {
            this.Name = _name;
            this.ID = _id;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
         public bool Test (Vehicle vehicle)
        {
        if (vehicle.FluidLevel > 0)
        {
                Console.WriteLine("Good to go");
        }
            return true;
        }
        public double HaggleDownPrice(Vehicle vehicle, int _amount)
        {
            if (vehicle.Mileage > 50000)
            {
                vehicle.Price -= _amount;
            }
            else if (vehicle.Price > 60000)
            {
                vehicle.Price -= _amount;
            }
            return vehicle.Price;
        }
    }
}
