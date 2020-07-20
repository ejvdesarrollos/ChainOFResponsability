using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOFResponsability
{
    class Responsable2 : IResponsabilidades
    {
        //Siendo el máximo no necesito siguiente.
        public int Vender(int cantidad)
        {
            int total = cantidad * 100;

            return total;
        }
    }
}
