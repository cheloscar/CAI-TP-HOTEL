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
{ //hola
    public class ClienteDatos
    {
        public List<Cliente> TraerTodosLosClientes()
        {
            string json2 = WebHelper.Get("cliente/860540"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        public Cliente TraerClientePorID(int id)
        {
            string json2 = WebHelper.Get("cliente/" + id.ToString()); // trae un texto en formato json de una web
            Cliente resultado = MapObj(json2);
            return resultado;
        }
        public Cliente TraerPorTelefono(string telefono)
        {
            string json2 = WebHelper.Get("cliente/" + telefono + "/telefono"); // trae un texto en formato json de una web
            Cliente resultado = MapObj(json2);
            return resultado;
        }


        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json); // deserializacion
            return lst;
            //JsonConvert.D
        }

        private Cliente MapObj(string json)
        {
            Cliente lst = JsonConvert.DeserializeObject<Cliente>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente); //serializacion -> json

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Put("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.ID.ToString());
            n.Add("FechaAlta", cliente.FechaAlta.ToString("yyy-MM-dd"));
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));
            n.Add("Usuario", "860540");
            return n;
        }
    }
}

