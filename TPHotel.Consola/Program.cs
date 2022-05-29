using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.Entidades;
using TPHotel.Negocio;

namespace TPHotel.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelNegocio hotel = new HotelNegocio();


            Console.WriteLine("Ingrese número de reserva");
            int id = Convert.ToInt32(Console.ReadLine());


            Cliente cli = hotel.TraerClientePorNumeroDeReserva(id);

            Console.WriteLine(cli.ToString());
        }
    }
}
