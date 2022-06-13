using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades.Excepciones
{
    public class CantidadDeHuespedesMayorAlLaPermitidaException :Exception
    {
        public CantidadDeHuespedesMayorAlLaPermitidaException() : base("No se permite dicha cantidad de huespedes")
        {
            
        }
    }
}
