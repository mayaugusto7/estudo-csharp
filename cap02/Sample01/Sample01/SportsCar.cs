using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample01
{
    public class SportsCar : Car
    {
       public string GetPetName()
        {
            petName = "Fred";
            return petName;
        }
    }
}