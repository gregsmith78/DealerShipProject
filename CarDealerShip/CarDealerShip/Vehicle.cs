using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
   public class Vehicle
    {
        private string make;
        private string model;
        private int year;
        private int vinNumber;
        private double price;
        private int fluidLevel;


        public Vehicle()
        {

        }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public int VinNumber
        {
            get
            {
                return vinNumber;
            }
            set
            {
                vinNumber = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int FluidLevel
        {
            get
            {
                return fluidLevel;
            }

            set
            {
                //if (fluidLevel < 0)
                //    fluidLevel = 0;
                //else if (fluidLevel > 100)
                //    fluidLevel = 100;
                //else
                    fluidLevel = value;
            }
           
        }
       
       
    }
}
