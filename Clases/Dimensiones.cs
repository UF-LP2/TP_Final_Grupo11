using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    public class Dimensiones
    {
        int alto, ancho, profundidad;
        int peso;

        public Dimensiones(int _alto, int _ancho, int _profundidad, int _peso)
        {
            this.alto = _alto;
            this.ancho = _ancho;
            this.profundidad = _profundidad;
            this.peso = _peso;
        }

        internal int get_peso()
        {
            return peso;
        }

        internal int get_volumen()
        {
            return (alto * ancho * profundidad);
        }
    }
}
