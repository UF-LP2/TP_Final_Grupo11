using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPfinal_LP2
{
    public class Vehiculo
    {
        float consumo;// lo que consume cada 100km
        string patente;
        float cant_nafta;// cantidad de nafta actual
        float carga_max; // en litros
        float vol_max;// metros cubicos
        float carga_actual;
        float vol_actual;
        bool vehiculo_lleno;
        float peso_elevador;

        public Vehiculo(float _consumo, string _patente, float _cant_nafta, float _carga_max, float _vol_max, float _carga_actual, float _vol_actual)
        {
            this.consumo = _consumo;
            this.patente = _patente;
            this.cant_nafta = _cant_nafta;
            this.carga_max = _carga_max;
            this.vol_max = _vol_max;
            this.carga_actual = _carga_actual;
            this.vol_actual = _vol_actual;
            this.peso_elevador = 30F;// siempre pesa lo mismo
        }

        public float get_cargamax()
        {
            return carga_max;
        }
        public float get_volmax()
        {
            return vol_max;
        }
        public float get_cargaactual()
        {
            return carga_actual;
        }
        public float get_volactual()
        {
            return vol_actual;
        }

        public void set_cargaactual(float peso)
        {
            carga_actual = carga_actual + peso;
        }
        public void set_volactual(float vol)
        {
            vol_actual = vol_actual + vol;
        }
        public void set_vehiculolleno(bool i)
        {
            vehiculo_lleno=i;
        }
        public float get_pesoelevador()
        {
            return peso_elevador;
        }

        //le pasamos un grafo que determina todas las adyacencias y una lista de vertices que son los destinos a recorrer obligatoriamente
        public List<Vertex> Reparticion_Greedy(Graph grafo_total, List<Vertex> destinos_avisitar) 
        {
            List<Vertex> lista_aux = new List<Vertex>();
            Vertex vertice_actual = grafo_total.get_lista_vertices()[0];
            Vertex Liniers = grafo_total.get_lista_vertices()[0];// siempre nuestra primer entrega es liniers

            lista_aux.Add(Liniers);
            while (destinos_avisitar.Count > 0)
            {
                int pos = BuscarAdyacente(vertice_actual);
                lista_aux.Add(vertice_actual);// gurdamos en la lista auxiliar el recorrido
                
                if (pos == -1)// si no pudo acceder a sus adyacentes
                {
                    vertice_actual.get_antysig_destino().Clear();// seteamos a cero todas sus localidades visitadas
                  
                    pos = BuscarAdyacente(vertice_actual);

                }
                vertice_actual.get_antysig_destino().Add(vertice_actual.get_lista_edge()[pos].get_id_destino());
 
                

                // buscamos la localidad en el grafo (es nuestro destino final)
                if (vertice_actual.get_id() == destinos_avisitar[0].get_id())
                {
                    destinos_avisitar.Remove(destinos_avisitar[0]); //eliminamos de la lista el nodo por el que ya pasamos
                }

                vertice_actual = ModificarVerticeActual(vertice_actual, grafo_total, pos);
            }
            return lista_aux;
        }
        
        public Vertex ModificarVerticeActual(Vertex vertice_actual, Graph grafo_total, int pos)
        {

            Vertex aux;

            for (int i = 0; i < grafo_total.get_lista_vertices().Count; i++)
            {
                if (grafo_total.get_lista_vertices()[i].get_id() == vertice_actual.get_lista_edge()[pos].get_id_destino())
                {
                    aux = vertice_actual;
                    vertice_actual = grafo_total.get_lista_vertices()[i];
                    vertice_actual.get_antysig_destino().Add(aux.get_id());

                    return vertice_actual;
                }
            }

            return vertice_actual;

        }
        public int BuscarAdyacente(Vertex vertice_actual)
        {
            float min = 32768; //"valor muy grande de un float" que siempre va a superar nuestras distancias establecidas
            int pos = -1;

            // comenzamos con el grafo en i=0 (liniers)
            //recorremos los adyacentes del vertice para armar el recorrido
            for (int j = 0; j < vertice_actual.get_lista_edge().Count; j++)
            {


                // buscamos el adyacente con menor distancia
                if (vertice_actual.get_lista_edge()[j].get_costo_camino() < min)
                {


                    if (vertice_actual.get_antysig_destino().Contains(vertice_actual.get_lista_edge()[j].get_id_destino()) != true)
                    {
                        min = vertice_actual.get_lista_edge()[j].get_costo_camino(); //guardamos la distancia minima
                        pos = j; //nos guardamos la posicion del adyacente que se encuentra a menor distancia
                    }

                }
            }

            return pos;
        }

        public void Entregar_Productos(List<Electrodomesticos> lista_electrodomesticos, List<Vertex> lista_recorrido)
        {
            for(int i=0;i<lista_recorrido.Count;i++)
            {
                for(int j=0;j<lista_electrodomesticos.Count();j++)
                {
                    if (lista_electrodomesticos[j].get_destino_entrega() == lista_recorrido[i])
                    {
                        lista_electrodomesticos.Remove(lista_electrodomesticos[j]);
                    }
                }
            }
            set_vehiculolleno(false);
        }

    }
}

        



