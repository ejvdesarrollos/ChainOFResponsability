using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOFResponsability
{
    public interface IResponsabilidades
    {
        //La interfaz es para poder llamarlo con la misma acción a todos intermanente.
        //Quizás se puede evaluar generar métodos diferentes.
        int Vender(int cantidad);
    }
}
