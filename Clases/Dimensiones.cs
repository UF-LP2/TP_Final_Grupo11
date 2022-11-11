using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    public class Dimensiones
    {
        float alto, ancho, profundidad;
        float peso;

        public Dimensiones(float _alto, float _ancho, float _profundidad, float _peso)
        {
            this.alto = _alto;
            this.ancho = _ancho;
            this.profundidad = _profundidad;
            this.peso = _peso;
        }

        internal float get_peso()
        {
            return peso;
        }

        internal float get_volumen()
        {
            return alto * ancho * profundidad;
        }
    }
}
