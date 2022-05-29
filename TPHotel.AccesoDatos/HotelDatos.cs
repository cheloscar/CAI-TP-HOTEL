
using TPHotel.AccesoDatos.Utilidades;
using TPHotel.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace TPHotel.AccesoDatos
{
    public class HotelDatos
    {

        public  List<HotelEntidad> TraerHoteles()
        {
            string json2 = WebHelper.Get("Hotel/Hoteles/860540"); // trae un texto en formato json de una web
            List<HotelEntidad> resultado = MapList(json2);
            return resultado;
        }

        public  List<HotelEntidad> Traer(int usuario)
        {
            string json2 = WebHelper.Get("Hotel/Hoteles/" + usuario.ToString()); // trae un texto en formato json de una web
            List<HotelEntidad> resultado = MapList(json2);
            return resultado;
        }

        private  List<HotelEntidad> MapList(string json)
        {
            List<HotelEntidad> lst = JsonConvert.DeserializeObject<List<HotelEntidad>>(json); // deserializacion
            return lst;
            //JsonConvert.D
        }

        private  HotelEntidad MapObj(string json)
        {
            HotelEntidad lst = JsonConvert.DeserializeObject<HotelEntidad>(json); // deserializacion
            return lst;
        }

        public  TransactionResult Insertar(HotelEntidad hotel)
        {
            NameValueCollection obj = ReverseMap(hotel); //serializacion -> json

            string json = WebHelper.Post("Hotel/Hoteles", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public  TransactionResult Actualizar(HotelEntidad hotel)
        {
            NameValueCollection obj = ReverseMap(hotel);

            string json = WebHelper.Put("Hotel/Hoteles", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private  NameValueCollection ReverseMap(HotelEntidad hotel)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Estrellas", hotel.Estrellas.ToString());
            n.Add("Nombre", hotel.Nombre);
            n.Add("Direccion", hotel.Direccion);
            n.Add("Amenities", hotel.Amenities.ToString());
            n.Add("ID", hotel.ID.ToString());
            n.Add("Usuario", "860540");
            return n;
        }
    }
}
