﻿using System;
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

        public Vehiculo(float _consumo, string _patente, float _cant_nafta, float _carga_max, float _vol_max, float _carga_actual, float _vol_actual)
        {
            this.consumo = _consumo;
            this.patente = _patente;
            this.cant_nafta = _cant_nafta;
            this.carga_max = _carga_max;
            this.vol_max = _vol_max;
            this.carga_actual = _carga_actual;
            this.vol_actual = _vol_actual;
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


        public List<Vertex> Reparticion_Greedy(Graph grafo_total, List<Vertex> destinos_avisitar) //le pasamos la lista de todos los electrodomesticos a entregar, le pasamos un grafo que determina todas las adyacencias y una lista de vertices que son los destinos a recorrer obligatoriamente
        {
            int k = 0;// inicializamos en 0 porque siempre parte de liniers

            List < Vertex > lista_aux= new List<Vertex>();
            Vertex vertice_actual = grafo_total.get_lista_vertices()[0];
            Vertex vertice_aux;

            while (destinos_avisitar.Count > 0)
            {
              
                    float min = 32768; //"valor muy grande de un float" que siempre va a superar nuestras distancias establecidas
                    int pos = -1;
                    
                    // comenzamos con el grafo en i=0 (liniers)
                    //recorremos los adyacentes del vertice para armar el recorrido
                    for (int j = 0; j < vertice_actual.get_lista_edge().Count; j++) 
                    {
                           // buscamos el adyacente con menor distancia
                           if (vertice_actual.get_lista_edge()[j].get_costo_camino() < min && vertice_actual.get_ult_destino()!= vertice_actual.get_lista_edge()[j].get_id_destino())
                           {
                             min = vertice_actual.get_lista_edge()[j].get_costo_camino(); //guardamos la distancia minima
                             pos = j; //nos guardamos la posicion del adyacente que se encuentra a menor distancia
                           
                             
                           }
 
                    }
                    vertice_actual.set_ultimo_destino(vertice_actual.get_lista_edge()[pos].get_id_destino());
                    lista_aux.Add(vertice_actual);// gurdamos en la lista auxiliar el recorrido
                    
                    // buscamos la localidad en el grafo (es nuestro destino final)
                    if (vertice_actual.get_lista_edge()[pos].get_id_destino() == destinos_avisitar[k].get_id())
                    {
                        destinos_avisitar.Remove(destinos_avisitar[k]); //eliminamos de la lista el nodo por el que ya pasamos
                        k++;// tenemos como destino final nuestro prox vertice 
                    } 
                   for(int i=0; i< grafo_total.get_lista_vertices().Count; i++)
                   {
                    if (grafo_total.get_lista_vertices()[i].get_id()== grafo_total.get_lista_vertices()[i].get_lista_edge()[pos].get_id_destino())
                    {
                        vertice_actual = grafo_total.get_lista_vertices()[i];
                        break;
                    }
                   }

            }// fin for i
            return lista_aux;
        }// fin while

        

    }
}

        



