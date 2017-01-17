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

            Console.WriteLine("\n");

            Motorcycle c = new Motorcycle(5);
            c.setDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name);// Imprime nome vazio

            Console.WriteLine("\n");
            MakeSomeBikes();

            Console.ReadLine();
        }

        /// <summary>
        /// Chamada de construtores com argumentos opcionais
        /// Motorcycle02
        /// </summary>
        static void MakeSomeBikes()
        {
            // driveName = "", driverIntensity = 0
            Motorcycle02 m1 = new Motorcycle02();
            Console.WriteLine("Name= {0}, Intensity= {1}", m1.driverName, m1.driverIntensity);

            // driveName = "Tiny", driverIntensity = 0
            Motorcycle02 m2 = new Motorcycle02(name: "Tiny");
            Console.WriteLine("Name= {0}, Intensity= {1}", m2.driverName, m2.driverIntensity);

            // driveName = "", driverIntensity = 7
            Motorcycle02 m3 = new Motorcycle02(7);
            Console.WriteLine("Name= {0}, Intensity= {1}", m3.driverName, m3.driverIntensity);

            Console.WriteLine("\n");
        }
    }
}
