
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

        public List<HotelEntidad> TraerHoteles()
        {
            string json2 = WebHelper.Get("Hotel/Hoteles");
            List<HotelEntidad> hoteles = MapList(json2);

            return hoteles;
        }

        public HotelEntidad TraerHotelPorNumeroDeReserva(int idRegistro)
        {
            string json2 = WebHelper.Get("Cliente/" + idRegistro);
            HotelEntidad hotel = MapObj(json2);
            return hotel;
        }
        private List<HotelEntidad> MapList(string json)
        {
            List<HotelEntidad> hoteles = JsonConvert.DeserializeObject<List<HotelEntidad>>(json);

            return hoteles;
        }

        private HotelEntidad MapObj(string json)
        {
            HotelEntidad hotel = JsonConvert.DeserializeObject<HotelEntidad>(json);

            return hotel;
        }
    }
}
