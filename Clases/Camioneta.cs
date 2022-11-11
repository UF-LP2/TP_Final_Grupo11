using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    public class Camioneta : Vehiculo
    {
        float aperturapuerta;// ancho de apertura en metros
        float distsuelo;// distancia del suelo a la camineta vacia, si se llena disminuye

        public Camioneta(float _aperturapuerta, float _distsuelo, float _consumo, string _patente, float _cant_nafta, float _carga_max, float _vol_max, float _carga_actual, float _vol_actual) : base(_consumo, _patente, _cant_nafta, _carga_max, _vol_max, _carga_actual, _vol_actual)
        {
            this.aperturapuerta = _aperturapuerta;
            this.distsuelo = _distsuelo;
        }
    }
}
