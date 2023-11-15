using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class MotorElectrico
    {
        bool _moviendo, _concectado, _activo;
        public void Conectar()
        {
            if (_concectado)
            {
            Console.WriteLine("El motor ya esta conectado");
            }
            else
            {
                Console.WriteLine("Motor conectado");
            }
        }
        public void Activar()
        {
            if (_concectado)
            {
                Console.WriteLine("Se tiene que conectar el motor");
            }
            else
            {
                Console.WriteLine("Activado");
            }
        }
        public void Mover()
        {
            if (_concectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Parando vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("El motor no esta en movimiento");
            }
        }
        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Parando vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("El motor no esta en movimiento");
            }
        }
        public void Desconectar()
        {
            if (_concectado)
            {
                _concectado = false;
                Console.WriteLine("Motor desconectado");
            }
            else
            {
                Console.WriteLine("El motor se desconecto");
            }
        }
        public void Desactivar()
        {
            if (_activo)
            {
                _activo = false;
                Console.WriteLine("Motor desactivado");
            }
            else
            {
                Console.WriteLine("El motor ya esta desactivado");
            }
        }
        public void Enchufar()
        {
            if (!_activo)
            {
                _activo = false;
                Console.WriteLine("Motor cargando");
            }else
            {
                Console.WriteLine("Ocupa desactivar el motor");
            }
        }
    }
}
