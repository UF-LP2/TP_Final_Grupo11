using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
       /* Comuna1=1,
        Comuna2=2,
        Comuna3=3,
        Comuna4=4,
        Comuna5=5,
        Comuna6=6,
        Comuna7=7,
        Comuna8=8,
        Comuna9=9,
        Comuna10=10,
        Comuna11=11,
        Comuna12=12,
        Comuna13=13,
        Comuna14=14,
        Comuna15=15,
        Avellaneda=16,
        Lanus=17,
        LomasZamora=18,
        LaMatanza=19,
        Moron=20,
        Ituzaingo=21,
        Hurlingham=22,
        TresFebrero=23,
        SanMartin=24,
        SanIsidro=25,
        VicenteLopez=26*/
    public class Vertex
    {
        int id; // el numero de cada comuna 
        string nombre;
        List<Edge> edge_list; //lista de adyacentes
        List<int> antysig_destino = new List<int>(); // id del ultimo edge al cual fue
        float dist_liniers; // distancia a liniers de cada vertice 


        public Vertex(int _id, string _nombre, List<Edge> _edge_list, float _dist_liniers)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.edge_list = _edge_list;
            dist_liniers = _dist_liniers;

        }   

        public int get_id()
        {
            return id;
        }
        public string get_nombre()
        {
            return nombre;
        }

        public List<Edge> get_lista_edge()
        {
            return edge_list;
        }
        public float get_dist_liniers()
        { 
            return dist_liniers;
        }
        public List<int> get_antysig_destino()
        {
            return antysig_destino;
        }
        

        
    }
}
