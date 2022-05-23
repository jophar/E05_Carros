using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carros
{
    internal class Car
    {
        /*
         * 
         * Falta implementar controlo no código
         * 
         */
       
        // Class Properties

        public Brand? CarBrand { get; set; } // ? nullable
        public Model? CarModel{ get; set; }
        public Color? CarColor{ get; set; }
        public string CarLicPlate{ get; set; }
        public string CarCubicCapacity{ get; set; }   
        public double CarSpeed{ get; set; }
        public DateTime CarRegistryDate{ get; set; }

        // Class Constructors

        public Car()
        {
            CarBrand = null;
            CarModel = null;
            CarColor = null;
            CarLicPlate = string.Empty;
            CarCubicCapacity = string.Empty;
            CarSpeed = 0;
            CarRegistryDate = DateTime.MinValue;
        }

        public Car(Color c,string lp, int spd, DateTime rd)
        {
            CarBrand = Brand.Bolide;
            CarModel = Model.NovoBolide;
            CarColor = c;
            CarLicPlate = lp;
            CarCubicCapacity = "1000";
            CarSpeed = spd;
            CarRegistryDate = rd;
        }

        public Car(Brand cb, Model cm, Color cc, string lp, string ccc, double cs, DateTime rd)
        {
            CarBrand = cb;
            CarModel = cm;
            CarColor = cc;
            CarLicPlate = lp;
            CarCubicCapacity = ccc;
            CarSpeed = cs;
            CarRegistryDate = rd;
        }

        // Enum's

        public enum Brand
        {
            Bolide,
            Renault,
            Mercedes,
            BMW,
            Citroeen,
            Nissan
        }

        public enum Model
        {
            NovoBolide,
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

        // Class Methods

        internal static void CarBrandMenu()
        {
            Console.WriteLine("Chose a car brand from menu: ");
            foreach (Brand brand in Enum.GetValues(typeof(Brand)))
            {
                Console.WriteLine($"({(int)brand}) -> {brand}");
            }
        }

        internal static void CarModelMenu()
        {
            Console.WriteLine("Chose the car model from menu: ");
            foreach (Model model in Enum.GetValues(typeof(Model)))
            {
                Console.WriteLine($"({(int)model}) -> {model}");
            }
        }

        internal static void CarColorMenu()
        {
            Console.WriteLine("Chose the car color from menu: ");
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine($"({(int)color}) -> {color}");
            }
        }

        internal static void MainMenu()
        {
            Queue<string> menu = new Queue<string>();

            menu.Enqueue("Car Menu");
            menu.Enqueue("******************");
            menu.Enqueue("[1] Add New Car");
            menu.Enqueue("[2] Set New Speed");
            menu.Enqueue("[3] Set Speed Zero");
            menu.Enqueue("[4] Print Car");
            menu.Enqueue("[X] Exit");

            foreach (string item in menu)
            {
                Console.WriteLine($"{item}");
            }
        }

        // eu sei que está horrivel com switch mas quero acompanhar o resto da malta
        internal static Car Run(Car c, string s)
        {
            double speed = 0;

            switch (s)
            {
                case "1": 
                    {
                        ReadValuesToObject(c); 
                        return c; 
                    } 

                case "2":
                    {
                        Console.Clear();
                        Console.Write("Speed Aceleration: ");
                        speed = Convert.ToDouble(Console.ReadLine());
                        c = SetCarSpeedAccel(c, speed);
                        Console.WriteLine($"New speed setted to {c.CarSpeed}");
                        Console.ReadKey();
                        return c;
                    } 

                case "3":
                    {
                        Console.Clear();
                        c = SetZeroSpeed(c);
                        Console.Write("Speed setted to zero");
                        return c;
                    }
                case "4":
                    {
                        Console.Clear();
                        PrintCar(c);
                        return c;
                    }
                default: return c;
            }
        }

        public static Car ReadValuesToObject(Car c)
        {
            Console.Clear();
            CarBrandMenu();
            c.CarBrand = (Brand)(int.Parse(Console.ReadLine()));
            Console.Clear();
            CarModelMenu();
            c.CarModel = (Model)(int.Parse(Console.ReadLine()));
            Console.Clear();
            CarColorMenu();
            c.CarColor = (Color)(int.Parse(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine($"Brand: {c.CarBrand}");
            Console.WriteLine($"Model: {c.CarModel}");
            Console.WriteLine($"Color: {c.CarColor}");
            Console.Write("License Plate: ");
            c.CarLicPlate = Console.ReadLine();
            Console.Write("Cubic Capacity: ");
            c.CarCubicCapacity = Console.ReadLine();
            Console.Write("Speed: ");
            c.CarSpeed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Registry Date (yyyy-mm-dd): ");
            string dateRead = Console.ReadLine();
            DateTime date = Convert.ToDateTime(dateRead);
            c.CarRegistryDate = new DateTime(date.Year, date.Month, date.Day);
           
            return c;
        }

        public static Car SetZeroSpeed(Car c)
        {
            c.CarSpeed = 0;

            return c;
        }

        public static Car SetCarSpeedAccel(Car c, double spd)
        {
            c.CarSpeed += spd;

            return c;
        }

        public Car SetCarSpeedDecel(Car c, double spd)
        {
            c.CarSpeed -= spd;

            return c;
        }

        public static void PrintCar(Car c)
        {
            Console.WriteLine();
            Console.WriteLine($"Brand: {c.CarBrand}");
            Console.WriteLine($"Model: {c.CarModel}"); 
            Console.WriteLine($"Color: {c.CarColor}"); 
            Console.WriteLine($"License Plate: {c.CarLicPlate}");
            Console.WriteLine($"Cubic Capacity: {c.CarCubicCapacity}");
            Console.WriteLine($"Car Speed: {c.CarSpeed}");
            Console.WriteLine($"Registry Date: {c.CarRegistryDate.ToShortDateString()}");
        }

        // Destructor

        ~Car()  //
        {
            Console.WriteLine("the car is destroyed!");
        }

    }
}
