using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades
{
   public class Habitacion
    {
        int _idHabitacion;
        int _idHotel;
        int _cantidadPlazas;
        string _categoria;
        bool _cancelable;
        decimal _precio;

        public Habitacion(int idHabitacion, int idHotel, int cantidadPlazas, string categoria, bool cancelable, decimal precio)
        {
            _idHabitacion = idHabitacion;
            _idHotel = idHotel;
            _cantidadPlazas = cantidadPlazas;
            _categoria = categoria;
            _cancelable = cancelable;
            _precio = precio;
        }

        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }
        public int IdHotel { get => _idHotel; set => _idHotel = value; }
        public int CantidadPlazas { get => _cantidadPlazas; set => _cantidadPlazas = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public bool Cancelable { get => _cancelable; set => _cancelable = value; }
        public decimal Precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
            return this.IdHabitacion.ToString() + this.IdHotel.ToString() + this.CantidadPlazas.ToString() + this.Categoria.ToString() + this.Cancelable.ToString() + this.Precio.ToString();
        }
    }
}
