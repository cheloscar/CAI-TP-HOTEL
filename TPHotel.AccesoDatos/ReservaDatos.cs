using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.AccesoDatos.Utilidades;
using TPHotel.Entidades;
using Newtonsoft.Json;

namespace TPHotel.AccesoDatos
{
    public class ReservaDatos
    {
        public List<Reserva> TraerReservas()
        {
            string json2 = WebHelper.Get("Hotel/Reservas");
            List<Reserva> reservas = MapList(json2);

            return reservas;
        }

        private List<Reserva> MapList(string json)
        {
            List<Reserva> reservas = JsonConvert.DeserializeObject<List<Reserva>>(json);

            return reservas;
        }

        public Reserva TraerReservaPorNumeroDeReserva(int idRegistro)
        {
            //string json2 = WebHelper.Get("Hotel/Reservas/" + idRegistro.ToString());
            string json2 = WebHelper.Get("Hotel/Reservas");
            List<Reserva> listares = MapList(json2);
            Reserva res = ReservaPorID(listares,idRegistro);

            //Reserva reserva = MapObj(json2);
            return res;
        }

        //Prueba...
        private Reserva ReservaPorID(List<Reserva> res, int idReg)
        {
            Reserva re = null;
            foreach (Reserva r in res)
            {
                if (r.Id == idReg)
                {
                    re = r;
                    break;
                }
            }

            if (re == null)
            {
                throw new Exception("La reserva no existe");
            }
            return re;
        }
        //Prueba..
        private Reserva MapObj(string json)
        {
            Reserva reserva = JsonConvert.DeserializeObject<Reserva>(json);

            return reserva;
        }
    }
}
