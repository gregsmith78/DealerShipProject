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
        private double checkBook;

        public Customer(string _name, int _id, double _checkBook)
        {
            this.Name = _name;
            this.ID = _id;
            this.CheckBook = _checkBook;
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

        public double CheckBook
        {
            get
            {
                return checkBook;
            }

            set
            {
                checkBook = value;
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
        public double HaggleDownPrice(Vehicle vehicle)
        {

            if (vehicle.Mileage > 50000)
                { 
                    vehicle.Price -= 500;
                }
                else if (vehicle.Mileage > 60000)
                {
                     vehicle.Price -= 1500;
                }
            
            return vehicle.Price;
        }
            
     }
           
 }

    

