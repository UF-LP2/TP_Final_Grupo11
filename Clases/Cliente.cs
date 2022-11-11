using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    public class Cliente
    {
        string nombre;
        string apellido;
        string Dni;
        Vertex destino;

        public Cliente(string nombre_, string apellido_, string dni_, Vertex _destino)
        {
            nombre = nombre_;
            apellido = apellido_;
            Dni = dni_;
            destino = _destino;
        }
    }
   
}
