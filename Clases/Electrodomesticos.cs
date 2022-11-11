using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FIJARSE QUE NO ES PUBLIC, HAY QUE HACERLO FRIEND PARA QUE COCIMUNDO PUEDA ACCEDER!!!!!

namespace TPfinal_LP2
{
    public class Electrodomesticos
    {
        
        string marca;
        int codigo;// hacer const
        Dimensiones dimensiones;// cada electrodomestico tiene sus dimensiones propias
        int prioridad; // 1 24 hs 2 72hs 3 96hs
        Cliente cliente;
        float beneficio;
        Vertex vertice_entrega; //lugar al que debe ser entregado el producto

        public Electrodomesticos(string _marca, int _codigo, Dimensiones _dimensiones, int _prioridad, Vertex _vertice, Cliente _cliente)
        {
            this.marca = _marca;
            this.codigo = _codigo;
            this.dimensiones = _dimensiones;
            this.prioridad = _prioridad;
            this.cliente = _cliente;
            this.vertice_entrega = _vertice;
        }

        public int get_prioridad()
        {
            return prioridad;
        }

        public Vertex get_vertice_entrega()
        {
            return vertice_entrega;
        }
       
        internal Cliente get_cliente()
        {
            return cliente;
        }

        internal Dimensiones get_dimensiones()
        {
            return dimensiones;
        }
        internal float get_beneficio()
        {
            return beneficio;
        }
        internal void set_beneficio(float a)
        {
            beneficio = a;
        }
    }
}

   

