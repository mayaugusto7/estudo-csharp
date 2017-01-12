using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        //state car
        public string petName;
        public int currSpeed;

        /// <summary>
        /// constructor default
        /// </summary>
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        /// <summary>
        /// currSpeed default 0 
        /// </summary>
        /// <param name="pn"></param>
        public Car(string pn)
        {
            petName = pn;
        }
       
        /// <summary>
        /// O Solicitante define o estado completo de Car
        /// </summary>
        /// <param name="pn"></param>
        /// <param name="cs"></param>
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
        
        //funcionalidade, metodo comportamentos
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }


    }
}
