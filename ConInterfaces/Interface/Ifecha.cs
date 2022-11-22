using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConInterfaces.Interface
{
    internal interface Ifecha
    {
        DateTime Fecha
        {
            get;set;
        }
        string fechaConLetra();
    }
}
