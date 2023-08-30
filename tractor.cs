using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automoviles
{
    internal class tractor: transporte

    {
        //polimorfismo es override
        public tractor()
        {
            Console.WriteLine("creaste un tractor");
            MostrarProducto();
        }
    }
}

