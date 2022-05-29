using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHotel.Entidades
{
    public class HotelEntidad
    {
        private int _estrellas;
        private string _nombre;
        private string _direccion;
        private bool _amenities;
        private int _usuario;
        

        public int Estrellas
        {
            get { return _estrellas; }
            set { _estrellas = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; } 
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public bool Amenities
        {
            get { return _amenities; }
            set { _amenities = value; }
        }

        public int Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public override string ToString()
        {
            return this.Estrellas + " " + this.Nombre + " " + this.Direccion + " " + this.Amenities + " " + this.Usuario;
        }
    }
}
