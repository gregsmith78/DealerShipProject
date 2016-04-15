using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip
{
    public class Van : Vehicle
    {
        public Van (string _make, string _model, int _year, int _vinNumber, double _mileage)
        {

            this.Make = _make;
            this.Model = _model;
            this.Year = _year;
            this.VinNumber = _vinNumber;
            this.Mileage = _mileage;
           
        }

    }
}
