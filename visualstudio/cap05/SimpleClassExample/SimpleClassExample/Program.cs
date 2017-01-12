using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            // Chamando constructor Default Motorcycle
            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();

            // Chamando constructor Default
            // Chuck 10 MPH
            Car chuck = new Car();
            chuck.PrintState();

            // Mary 0 MPH
            Car mary = new Car("Mary");
            mary.PrintState();

            // Daisy 75 MPH
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Console.WriteLine("\n");
            
            // Aloque e configure um objeto Car.
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            // Aumenta a velocidade de car algumas vezes e imprime o novo estado
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.ReadLine();
        }
    }
}
