using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades.Excepciones
{
    public class ReservaInexistenteExcepcion : Exception
    {
        public ReservaInexistenteExcepcion() : base ("La reserva no existe.")
        { }
    }
}
