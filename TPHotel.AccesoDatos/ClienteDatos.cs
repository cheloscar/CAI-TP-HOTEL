using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.Entidades;
using TPHotel.AccesoDatos.Utilidades;
using Newtonsoft.Json;

namespace TPHotel.AccesoDatos
{
    public class ClienteDatos
    {
        public List<Cliente> TraerTodosLosClientes()
        {
            string json2 = WebHelper.Get("cliente");
            List<Cliente> clientes = MapList(json2);
            return clientes;
        }

        public Cliente TraerClientePorID(int idCliente)
        {
            //string json2 = WebHelper.Get("Cliente/"+ idCliente);
            string json2 = WebHelper.Get("Cliente/");
            List<Cliente> clientes = MapList(json2);
            Cliente cli = ClientePorID(clientes, idCliente);
            //Cliente cliente = MapObj(json2);
            return cli;
        }

        //Prueba
        private Cliente ClientePorID(List<Cliente> clientes, int id)
        {
            Cliente c = null;
            foreach (Cliente cli in clientes)
            {
                if (cli.ID == id)
                {
                    c = cli;
                    break;
                }
            }
            if(c == null)
            { 
                 throw new Exception("El cliente no existe");
            }
            return c;
        }
    
        
        //rueba
        private List<Cliente> MapList(string json)
         {
            List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return clientes;
         }

        private Cliente MapObj(string json)
        {
            Cliente cliente = JsonConvert.DeserializeObject<Cliente>(json);
            return cliente;
        }
    }
}

