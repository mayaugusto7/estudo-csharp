using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Construtor Padrao revisado
/// </summary>
namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;

        /// <summary>
        /// Construtor padrao explicito porque existe um construtor personalizado
        /// </summary>
        public Motorcycle() { }

        /// <summary>
        /// Construtor personalizado com um parametro
        /// </summary>
        /// <param name="intensity"></param>
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaaeeeewwww");
            }

        }

    }
}
