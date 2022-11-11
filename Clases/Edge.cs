using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    public class Edge
    {
        int id_vertice_destino;
        float costo_camino;

       public  Edge(int _id_vertice_destino, float _costo_camino)
        {
            this.id_vertice_destino = _id_vertice_destino;
            this.costo_camino = _costo_camino;
        }

      
        public int get_id_destino()
        {
            return id_vertice_destino;
        }

        public float get_costo_camino()
        {
            return costo_camino;
        }
    }
}
