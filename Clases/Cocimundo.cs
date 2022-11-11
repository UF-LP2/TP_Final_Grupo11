using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    internal class Cocimundo
    {
        List<Electrodomesticos> lista_electrodomesticos;
        List<Vehiculo> lista_vehiculos;

       public Cocimundo(List<Electrodomesticos> _lista_electrodomesticos, List<Vehiculo> _lista_vehiculos)
        {
            lista_electrodomesticos = _lista_electrodomesticos;
            lista_vehiculos = _lista_vehiculos;
        }

        public List<Electrodomesticos> ordenar_lista_electrodomesticos(List<Electrodomesticos> lista)
        {
           int n = lista.Count;
           List<Electrodomesticos> lineablanca = new List<Electrodomesticos>();
           List<Electrodomesticos> pequenios_el = new List<Electrodomesticos>();
           List<Electrodomesticos> electronicos = new List<Electrodomesticos>();
           List<Electrodomesticos> televisores = new List<Electrodomesticos>();
            
            // gurdamos en cada sub lista el elemento que le corresponde
            for (int i = 0; i < n; i++)
            {
                //dynamic cast para saber que hijo es

                if (lista[i] is LineaBlanca)
                {
                    lineablanca.Add((LineaBlanca)lista[i]);
                }
                if (lista[i] is PeqElq)
                {
                    pequenios_el.Add((PeqElq)lista[i]);
                }
                if (lista[i] is Electronicos)
                {
                    electronicos.Add((Electronicos)lista[i]);
                }
                if (lista[i] is Televisores)
                {
                    televisores.Add((Televisores)lista[i]);
                }
            }

            //ordenamos segun la prioridad para que en cada lista queden las prioridades: 1 2 3
            lineablanca = lineablanca.OrderBy(Electrodomesticos => Electrodomesticos.get_prioridad()).ToList();
            pequenios_el = pequenios_el.OrderBy(Electrodomesticos => Electrodomesticos.get_prioridad()).ToList();
            electronicos = electronicos.OrderBy(Electrodomesticos => Electrodomesticos.get_prioridad()).ToList();
            televisores = televisores.OrderBy(Electrodomesticos => Electrodomesticos.get_prioridad()).ToList();

           
            //unificamos las listas ordenadas en una sola (por prioridad y tipo de electrodomestico)
            lineablanca.AddRange(televisores);
            lineablanca.AddRange(electronicos);
            lineablanca.AddRange(pequenios_el);
                   
            return lineablanca;
        }
        public List<Electrodomesticos> ordenar_por_cliente(List<Electrodomesticos> lista)
        {
            List<Electrodomesticos> lista_aux = new List<Electrodomesticos>();
            

            for(int i = 0; i < lista.Count; i++) //en la lista_aux vamos poniendo en posiciones contiguas a los electrodomesticos que tienen el mismo cliente asociado
            {
                
                for(int k=0;k<lista.Count;k++)
                {
                    // si son el mismo cliente
                    if (lista[i].get_cliente() == lista[k].get_cliente() && !lista_aux.Contains(lista[k]))
                    {
                        lista_aux.Add(lista[k]);
                        
                                                                       
                    }
                    
                }
            }

            return lista_aux ;
        }

        public List<Electrodomesticos> llenado_dinamico_(List<Electrodomesticos> lista, Vehiculo vehiculo)
        {
            float[,] matriz = new float[lista.Count, (int)vehiculo.get_volmax()];
           
            List<Electrodomesticos> lista_aux= new List<Electrodomesticos> ();
            int j = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                if (vehiculo.get_cargaactual() == vehiculo.get_cargamax() || vehiculo.get_volactual() == vehiculo.get_volmax())
                {
                    break;
                }
                for (int k = 0; k < (int)vehiculo.get_volmax(); k++) {
                    if (i == 0 || k == 0)
                    {
                        matriz[i, k] = 0;
                    }
                    // verificamos que el elemento entra en el vehiculo
                   else if ((lista[i].get_dimensiones().get_peso() + vehiculo.get_cargaactual()) < vehiculo.get_cargamax() && (lista[i].get_dimensiones().get_volumen() + vehiculo.get_volactual()) < vehiculo.get_volmax())
                    {
                        vehiculo.set_volactual(lista[i].get_dimensiones().get_volumen());
                        vehiculo.set_cargaactual(lista[i].get_dimensiones().get_peso());
                        matriz[i, k] = maximo(lista[i].get_beneficio() + matriz[i - 1, k - 1], matriz[i - 1, k]);
                        if (matriz[i, k] > matriz[1 - 1, k - 1])
                        {
                            lista_aux.Add(lista[i]);
                        }
                   }
                    else 
                        matriz[i, k] = matriz[i - 1, k];

                }
            }
            return lista_aux;

        }

        public List<Vertex> ordenar_pordistancia(List<Electrodomesticos> lista)
        {
            List<Vertex> lista_aux= new List<Vertex> ();
            lista=lista.OrderBy(Electrodomesticos => Electrodomesticos.get_vertice_entrega().get_dist_liniers()).ToList();
            for(int i=0; i<lista.Count; i++)
            {
                lista_aux.Add(lista[i].get_vertice_entrega());// nos creamos una lista de vertices ordenados segun su distancia a liniers
            }
            return lista_aux;

        }

        public float maximo(float a, float b)
        {
            return (a > b) ? a : b;
        }

        public void Beneficio(List<Electrodomesticos> lista)
        { 
            if (lista != null)
            {
                int n = lista.Count();
                // cada pos del array corresponde a una localidad
                int[] contadores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                //para cada localidad sumamos 1 al contador (muchos if?)
                for (int i = 0; i < n; i++)
                {
                    switch (lista[i].get_vertice_entrega().get_id())
                    {
                        case 0:
                            {
                                contadores[0]+=1;
                                break;
                            }
                        case 1:
                            {
                                contadores[1] += 1;
                                break;
                            }
                            case 2:
                            {
                                contadores[2] += 1;
                                break;
                            }
                        case 3:
                            {
                                contadores[3] += 1;
                                break;
                            }
                        case 4:
                            {
                                contadores[4] += 1;
                                break;
                            }
                        case 5:
                            {
                                contadores[5] += 1;
                                break;
                            }
                        case 6:
                            {
                                contadores[6] += 1;
                                break;
                            }
                        case 7:
                            {
                                contadores[7] += 1;
                                break;
                            }
                        case 8:
                            {
                                contadores[8] += 1;
                                break;
                            }
                        case 9:
                            {
                                contadores[9] += 1;
                                break;
                            }
                        case 10:
                            {
                                contadores[10] += 1;
                                break;
                            }
                        case 11:
                            {
                                contadores[11] += 1;
                                break;
                            }
                        case 12:
                            {
                                contadores[12] += 1;
                                break;
                            }
                        case 13:
                            {
                                contadores[13] += 1;
                                break;
                            }
                        case 14:
                            {
                                contadores[14] += 1;
                                break;
                            }
                        case 15:
                            {
                                contadores[15] += 1;
                                break;
                            }
                        case 16:
                            {
                                contadores[16] += 1;
                                break;
                            }
                        case 17:
                            {
                                contadores[17] += 1;
                                break;
                            }
                          case 18:
                            {
                                contadores[18] += 1;
                                break;

                            }
                        case 19:
                            {
                                contadores[19] += 1;
                                break;
                            }
                        case 20:
                            {
                                contadores[20] += 1;
                                break;
                            }
                        case 21:
                            {
                                contadores[21] += 1;
                                break;
                            }
                        case 22:
                            {
                                contadores[22] += 1;
                                break;
                            }
                        case 23:
                            {
                                contadores[23] += 1;
                                break;
                            }
                        case 24:
                            {
                                contadores[24] += 1;
                                break;
                            }
                         case 25:
                            {
                                contadores[25] += 1;
                                break;
                            }
                        case 26:
                            {
                                contadores[26] += 1;
                                break;
                            }
                    }                        
                }

                // a cada contador obtenido hay q dividirlo por su distancia a liniers
                for(int i=0; i<17; i++)
                {
                    lista[i].set_beneficio(contadores[lista[i].get_vertice_entrega().get_id()] / lista[i].get_vertice_entrega().get_dist_liniers());// seteamos el beneficio para cada producto
                   
                }

            }

        }




    }
}
   
