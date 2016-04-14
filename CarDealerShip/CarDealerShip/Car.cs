using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class Car : Vehicle
    {

        public Car (string _make, string _model, int _year, int _vinNumber, double _price)
        {
            this.Make = _make;
            this.Model = _model;
            this.Year = _year;
            this.VinNumber = _vinNumber;
            this.Price = _price;
        }
        public Car (int _fluidLevel)
        {
            this.fluidLevel = _fluidLevel;
        }
    }
}
