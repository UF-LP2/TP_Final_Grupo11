using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    internal class LineaBlanca : Electrodomesticos
    {
        public LineaBlanca(string _marca, int _codigo, Dimensiones _dimensiones, int _prioridad, Vertex _vertice, Cliente _cliente, int d, int m, int a) : base(_marca, _codigo, _dimensiones, _prioridad, _vertice, _cliente, d, m, a)
        {

        }
    }
}
