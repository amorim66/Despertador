using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despertador
{
    class Horas
    {
        private Int32 hora;
        private Int32 minuto;
        private Int32 segundo;

        public Horas()
        {
        }

        public int Minuto { get => minuto; set => minuto = value; }
        public int Segundo { get => segundo; set => segundo = value; }
        public int Hora { get => hora; set => hora = value; }
    }
}
