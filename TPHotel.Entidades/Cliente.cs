using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades
{
    public abstract class Cliente
    {
        int _id;
        DateTime _fechaAlta;
        bool _activo;

        public Cliente(int id, DateTime fechaAlta, bool activo)
        {
            _id = id;
            _fechaAlta = fechaAlta;
            _activo = activo;
        }

        public int ID { get => _id; set => _id = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
