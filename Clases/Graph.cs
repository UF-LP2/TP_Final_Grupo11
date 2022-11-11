using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    public class Graph
    {
        List<Vertex> vertices;

        public Graph(List<Vertex> _vertices)
        {
            this.vertices = _vertices;
        }

       public  List<Vertex> get_lista_vertices()
        {
            return vertices;
        }
    }
}
