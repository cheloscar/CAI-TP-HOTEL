using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades.Excepciones
{
    public class ErrorEnTransaccionExcepcion : Exception
    {
        public ErrorEnTransaccionExcepcion(string message) : base(message)
        {
        }
    }
}
