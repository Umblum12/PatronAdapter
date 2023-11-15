using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class MotorDisel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Motor disel acelerando");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Motor disel arrancando");
        }

        public override void CargarConbustible()
        {
            Console.WriteLine("Motor disel cargando combustible");
        }

        public override void Detener()
        {
            Console.WriteLine("Motor disel deteniendo");
        }
    }
}
