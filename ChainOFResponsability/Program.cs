using System;

namespace ChainOFResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo clases para indicar cada una de ellas una responsabilidad superior
            Responsable2 Jefe = new Responsable2();
            //En el constructor reciben el inmediato superior
            Responsable1 empleado = new Responsable1(Jefe);
            //Puedo tener tantos niveles como quiera
            //pero se crean desde el más elevado al mas bajo para enviarlo como parámetro en el constructor del siguiente.

            Console.Write(empleado.Vender(200));
        }
    }
}
