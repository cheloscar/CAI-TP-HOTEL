using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.Entidades;
using TPHotel.AccesoDatos.Utilidades;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace TPHotel.AccesoDatos
{
    public class PersonaDatos
    {
        public static List<ClientePersona> TraerTodos()
        {
            string json2 = WebHelper.Get("cliente/860540"); // trae un texto en formato json de una web
            List<ClientePersona> resultado = MapList(json2);
            return resultado;
        }

        public static List<ClientePersona> Traer(int usuario)
        {
            string json2 = WebHelper.Get("cliente/" + usuario.ToString()); // trae un texto en formato json de una web
            List<ClientePersona> resultado = MapList(json2);
            return resultado;
        }
        public static ClientePersona TraerPorTelefono(string telefono)
        {
            string json2 = WebHelper.Get("cliente/" + telefono + "/telefono"); // trae un texto en formato json de una web
            ClientePersona resultado = MapObj(json2);
            return resultado;
        }


        private static List<ClientePersona> MapList(string json)
        {
            List<ClientePersona> lst = JsonConvert.DeserializeObject<List<ClientePersona>>(json); // deserializacion
            return lst;
            //JsonConvert.D
        }

        private static ClientePersona MapObj(string json)
        {
            ClientePersona lst = JsonConvert.DeserializeObject<ClientePersona>(json); // deserializacion
            return lst;
        }

        public static TransactionResult Insertar(ClientePersona persona)
        {
            NameValueCollection obj = ReverseMap(persona); //serializacion -> json

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public static TransactionResult Actualizar(ClientePersona persona)
        {
            NameValueCollection obj = ReverseMap(persona);

            string json = WebHelper.Put("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private static NameValueCollection ReverseMap(ClientePersona persona)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", persona.ID.ToString());
            n.Add("FechaAlta", persona.FechaAlta.ToString("yyy-MM-dd"));
            n.Add("Activo", persona.Activo.ToString());
            n.Add("Nombre", persona.Nombre);
            n.Add("Apellido", persona.Apellido);
            n.Add("Direccion", persona.Direccion);
            n.Add("Telefono", persona.Telefono);
            n.Add("FechaNacimiento", persona.FechaNacimiento.ToString("yyyy-MM-dd"));
            n.Add("Usuario", "860540");
            n.Add("Host", persona.Host);
            return n;
        }
    }
}
