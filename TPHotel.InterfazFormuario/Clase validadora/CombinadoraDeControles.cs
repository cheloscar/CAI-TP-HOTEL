using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPHotel.InterfazFormuario.Clase_validadora
{
    public class CombinadoraDeControles
    {
       private TextBox _cajaDeTexto;
       private Label _etiqueta;

        public CombinadoraDeControles(TextBox t, Label l)

        {
            _cajaDeTexto = t;
            _etiqueta = l;
        }
       public TextBox CajaDeTexto
        {
            get { return _cajaDeTexto; }
            set { _cajaDeTexto = value; }
        }

        public Label Etiqueta
        {
            get { return _etiqueta; }
            set { _etiqueta = value; } 
        }

        public override string ToString()
        {
            return this.CajaDeTexto.Text;
        }
    }
}
