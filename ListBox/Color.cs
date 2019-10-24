using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox
{
    class Color
    {
        public string Nombre { get; set; }
        public string Hexadecimal { get; set; }
        public string RGB { get; set; }

        public Color(string nombre, string hexadecimal, string rgb)
        {
            Nombre = nombre;
            Hexadecimal = hexadecimal;
            RGB = rgb;
        }

        public override string ToString()
        {
            return this.Nombre + " (" + this.Hexadecimal + ") ";
        }


    }
}
