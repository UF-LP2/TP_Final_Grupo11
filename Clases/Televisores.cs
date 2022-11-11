using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    internal class Televisores : Electrodomesticos
    {
        public Televisores(string _marca, int _codigo, Dimensiones _dimensiones, int _prioridad, Vertex _vertice, Cliente _cliente) : base(_marca, _codigo, _dimensiones, _prioridad, _vertice, _cliente)
        {

        }
    }
}
