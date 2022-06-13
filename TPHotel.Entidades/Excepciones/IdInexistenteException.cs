using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades.Excepciones
{
    public class IdInexistenteException :Exception
    {
        public IdInexistenteException() : base("El cliente específicado con dicho ID es inexistente")
        { 
        }
    }
}
