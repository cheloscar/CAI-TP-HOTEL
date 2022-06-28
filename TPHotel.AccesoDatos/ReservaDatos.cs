using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.AccesoDatos.Utilidades;
using TPHotel.Entidades;
using Newtonsoft.Json;
using System.Collections.Specialized;


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

        public Reserva TraerReservaPorNumeroDeReserva(int idRegistro)
        {
            //string json2 = WebHelper.Get("Hotel/Reservas/" + idRegistro.ToString());
            string json2 = WebHelper.Get("Hotel/Reservas");
            List<Reserva> listaRes = MapList(json2);
            Reserva res = ReservaPorID(listaRes,idRegistro);

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
        
        private List<Reserva> MapList(string json)
        {
            List<Reserva> lst = JsonConvert.DeserializeObject<List<Reserva>>(json); // deserializacion
            return lst;
            //JsonConvert.D
        }

        private Reserva MapObj(string json)
        {
            Reserva lst = JsonConvert.DeserializeObject<Reserva>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Reserva reserva)
        {
            NameValueCollection obj = ReverseMap(reserva); //serializacion -> json

            string json = WebHelper.Post("Hotel/Reservas", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Reserva reserva)
        {
            NameValueCollection obj = ReverseMap(reserva);

            string json = WebHelper.Put("Hotel/Reservas", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Reserva reserva)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", reserva.Id.ToString());
            n.Add("idHabitacion", reserva.IdHabitacion.ToString());
            n.Add("idCliente", reserva.IdCliente.ToString());
            n.Add("fechaIngreso", reserva.FechaIngreso.ToString());
            n.Add("fechaEgreso", reserva.FechaEgreso.ToString());
            n.Add("cantidadHuespedes", reserva.CantidadHuespedes.ToString());
            return n;
        }
    }
}
