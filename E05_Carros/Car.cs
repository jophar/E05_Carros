using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carros
{
    class Car
    {
        /*
         * Carros Project
         * First alpha
         * **************************
         * - ENUM's created
         */

        public string ver = "0.1a";

        // Class Properties

        public string CarBrand { get; set; }
        public string CarModel{ get; set; }
        public string CarColor{ get; set; }
        public string CarLicPlate{ get; set; }
        public int CarCubicCapacity{ get; set; }   
        public double CarSpeed{ get; set; }
        public DateTime CarRegistryDate{ get; set; }

        // Class Constructors

        public Car()
        {
            CarBrand = string.Empty;
            CarModel = string.Empty;
            CarColor = string.Empty;
            CarLicPlate = string.Empty;
            CarCubicCapacity = 0;
            CarSpeed = 0;
            CarRegistryDate = new DateTime(0, 0, 0);
        }




        public enum Brand
        {
            Ford,
            Renault,
            Mercedes,
            BMW,
            Citroeen,
            Nissan
        }

        public enum Model
        {
            Fiesta,
            Mondeo,
            Megane,
            Clio,
            C250,
            C270,
            D320,
            D520,
            Catus,
            Berlingo,
            Primera,
            Leaf
        }

        public enum Color
        {
            White,
            Grey,
            Yellow,
            Red,
            Blue
        }


    }
}
