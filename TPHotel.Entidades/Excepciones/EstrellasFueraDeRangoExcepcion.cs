using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades.Excepciones
{
    public class EstrellasFueraDeRangoExcepcion : Exception
    {
        public EstrellasFueraDeRangoExcepcion() : base("El rango debe ser entre 1 y 5 estrellas.")
        {
        }
    }
}
