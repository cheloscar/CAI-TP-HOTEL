using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades.Excepciones
{
    public class IdNoPositivoExcepcion : Exception
    {
        public IdNoPositivoExcepcion() : base ("El id no puede ser menor o igual que cero o contener cadenas de texto")  
        {
        }
    }
}
