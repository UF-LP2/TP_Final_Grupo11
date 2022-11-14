using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        DateTime fecha_compra; //fecha compra

        public Electrodomesticos(string _marca, int _codigo, Dimensiones _dimensiones, int _prioridad, Vertex _vertice, Cliente _cliente, int d, int m, int a)
        {
            this.marca = _marca;
            this.codigo = _codigo;
            this.dimensiones = _dimensiones;
            this.prioridad = _prioridad;
            this.cliente = _cliente;
            this.vertice_entrega = _vertice;
            this.fecha_compra=new DateTime(a, m, d, 0, 0, 0);
        }

        public int get_prioridad()
        {
            return prioridad;
        }

        public void set_prioridad( int a)
        {
            prioridad = a;
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

        internal Vertex get_destino_entrega()
        {
            return vertice_entrega;
        }
        public DateTime get_datetime()
        {
            return fecha_compra;
        }
    }

}

   

