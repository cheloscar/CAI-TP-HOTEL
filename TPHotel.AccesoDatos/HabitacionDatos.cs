using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using TPHotel.AccesoDatos.Utilidades;
using TPHotel.Entidades;


namespace TPHotel.AccesoDatos
{
    internal class HabitacionDatos
    {
        public List<Habitacion> TraerTodasPorHotel(int hotel)
        {
            string json2 = WebHelper.Get("habitaciones/" + hotel.ToString()); // trae un texto en formato json de una web
            List<Habitacion> resultado = MapList(json2);
            return resultado;
        }

        private List<Habitacion> MapList(string json)
        {
            List<Habitacion> lst = JsonConvert.DeserializeObject<List<Habitacion>>(json); // deserializacion
            return lst;
            //JsonConvert.D
        }

        private Habitacion MapObj(string json)
        {
            Habitacion lst = JsonConvert.DeserializeObject<Habitacion>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Habitacion habitacion)
        {
            NameValueCollection obj = ReverseMap(habitacion); //serializacion -> json

            string json = WebHelper.Post("habitaciones", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Habitacion habitacion)
        {
            NameValueCollection obj = ReverseMap(habitacion);

            string json = WebHelper.Put("habitaciones", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Habitacion habitacion)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", habitacion.IdHabitacion.ToString());
            n.Add("idHotel", habitacion.IdHotel.ToString());
            n.Add("cantidadPlazas", habitacion.CantidadPlazas.ToString());
            n.Add("categoria", habitacion.Categoria);
            n.Add("cancelable", habitacion.Cancelable.ToString());
            n.Add("precio", habitacion.Precio.ToString());
            return n;
        }
    }
}
