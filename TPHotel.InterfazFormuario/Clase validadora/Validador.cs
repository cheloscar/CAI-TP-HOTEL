using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPHotel.InterfazFormuario.Clase_validadora
{
    public static class Validador
    {
        public static string pedirString(TextBox tx, Label lbl)
        { 
           if (tx.Text == string.Empty)
           {
               throw new Exception("El campo " + lbl.Text + "no puede estar vacío" );       
           }
            return tx.Text;
        }

        public static string PedirStringLista(List<CombinadoraDeControles> lstCombinadora)
        {
            string todojunto = "";
            
            
            List<string> lstEx = new List<string>();
            lstEx.Add("El/los siguientes campos No debe / deben quedar vacio /s" + "\n");
            foreach (CombinadoraDeControles cdc in lstCombinadora)
            {
                
                if (cdc.CajaDeTexto.Text == string.Empty)
                {
                    lstEx.Add(cdc.Etiqueta.Text);
                    cdc.Etiqueta.BackColor = System.Drawing.Color.Red;
                }

                else if(cdc.Etiqueta.Text != string.Empty)
                {
                    cdc.Etiqueta.BackColor = System.Drawing.Color.White;
                }
            }
           

            foreach (var s in lstEx)
            {
                todojunto = todojunto + s.ToString() + "\n";
            }
            return todojunto;

           // throw new Exception();
            
        }
        public static int pedirInteger(TextBox numero, Label lb)
        {
            bool pudeConvertir;
            int numeroSalida;
            pudeConvertir = int.TryParse(numero.Text, out numeroSalida);


            if (pudeConvertir == false)
            {
                //MessageBox.Show("El campo " + lb.Text + "debe ser numérico");

                //numero.Text = string.Empty;
                //throw new Exception("El campo " + lb.Text + "debe ser numérico");

                numeroSalida = -1;
            }

            else if(numero.Text == string.Empty)
            {
                numeroSalida = 0;
                //numero.Text = string.Empty;
            }
            return numeroSalida;
        }

        public static bool pedirBool(TextBox parametro, Label lb)
        {
            bool campo;
            bool pudeConvertir = bool.TryParse(parametro.Text, out campo);
            if (pudeConvertir == false)
            {
                MessageBox.Show("El campo " + lb.Text.ToString() + "debe ser false o true");

            }
            return pudeConvertir;
        }
        public static double pedirDouble(string numero)
        {
            double retorno = 0;
            bool pudeConvertir;
         
                pudeConvertir = Double.TryParse(numero, out retorno);
               
                if (!pudeConvertir)
                {
                   throw new Exception();
                }
             
            return retorno;
        }

        public static DateTime pedirFecha(string parametro)
        {
            DateTime retorno;
            bool pudeConvertir;
           

            pudeConvertir = DateTime.TryParse(parametro,out retorno);
            if (!pudeConvertir)
            {
                return retorno;
            }
            return retorno;
        }

        public static void Vaciar(TextBox tx)
        {
            tx.Text = string.Empty;
        }
    }
}
