using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades
{
   public class Reserva
    {
        //"idHabitacion": 0,
        //"idCliente": 0,
        //"cantidadHuespedes": 0,
        //"fechaIngreso": "2022-05-25T22:13:30.285Z",
        //"fechaEgreso": "2022-05-25T22:13:30.285Z",
        //"id": 0

        private int _idHabitacion;
        private int _idCliente;
        private int _cantidadHuespedes;
        private DateTime _fechaIngreso;
        private DateTime __fechaEgreso;
        private int _id;

        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int CantidadHuespedes { get => _cantidadHuespedes; set => _cantidadHuespedes = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public DateTime FechaEgreso { get => __fechaEgreso; set => __fechaEgreso = value; }
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return this.IdHabitacion.ToString() + " " + this.IdCliente.ToString() + " " + this.CantidadHuespedes.ToString()
                + " " + FechaIngreso.ToString() + " " + this.FechaEgreso.ToString() + " " + this.Id.ToString();
        }
    }
}
