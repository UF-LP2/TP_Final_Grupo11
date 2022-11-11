using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    public class Furgoneta : Vehiculo
    {
        float peso_elevador;

       public  Furgoneta(float _peso_elevador, float _consumo, string _patente, float _cant_nafta, float _carga_max, float _vol_max, float _carga_actual, float _vol_actual) :base(_consumo, _patente, _cant_nafta, _carga_max, _vol_max, _carga_actual, _vol_actual)
        {
            this.peso_elevador = _peso_elevador;

        }

        public float get_peso_elevador()
        {
            return peso_elevador;
        }
    }
}
