using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOFResponsability
{
    class Responsable1 : IResponsabilidades
    {
        //Necesito sabe quién es el que sigue en mi cadena de responsabilidad.
        private IResponsabilidades proximoResponsable = null;
        public Responsable1(IResponsabilidades proximo)
        {
            this.proximoResponsable = proximo;

        }
        public int Vender(int cantidad)
        {
            int total = 0;
            if (cantidad >100)
            {
                //si la condición de decisión me supera, voy al siguiente.
                total = this.proximoResponsable.Vender(cantidad);
            }
            else
            {
                total = cantidad * 50;
            }

            return total;
        }
    }
}
