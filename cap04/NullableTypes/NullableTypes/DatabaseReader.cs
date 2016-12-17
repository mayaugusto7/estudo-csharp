using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class DatabaseReader
    {
        // Campo de dados anulavel
        public int? numericValue = null;
        public bool? boolValue = true;

        // Note o tipo de retorno anulavel
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        // Note o tipo de retorno anulavel
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}
