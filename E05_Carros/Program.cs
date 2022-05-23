using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            string control = string.Empty;
            Car newCar01 = new Car();

            while (control != "x" && control != "X")
            {
                Console.Clear();
                Car.MainMenu();
                control = Console.ReadLine();
                Car.Run(newCar01, control);
            } 
        }
    }
}
