using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal_LP2
{
    internal class Program
    {
        /* liniers=0
       Comuna1=1,
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
        static void Main(string[] args)
        {
            // declaracion de los caminos que conectan cada localidad
            Edge caminoLiniers_8 = new Edge(1, 10.3F);
            Edge caminoLiniers_7 = new Edge(7, 8.9F);
            Edge caminoLiniers_10 = new Edge(10, 3.9F);
            Edge caminoLiniers_9 = new Edge(9, 2.3F);
            Edge caminoLiniers_19 = new Edge(19, 28.3F);
            Edge caminoLiniers_23 = new Edge(23, 6F);
            Edge camino8_liniers = new Edge(0, 10.3F);
            Edge camino7_liniers = new Edge(0, 8.9F);
            Edge camino10_liniers = new Edge(0, 3.9F);
            Edge camino9_liniers = new Edge(0, 2.3F);
            Edge camino19_liniers = new Edge(0, 28.3F);
            Edge camino23_liniers = new Edge(0, 6F);

            Edge camino1_2 = new Edge(2, 5.2f);
            Edge camino1_3 = new Edge(3, 6.4F);
            Edge camino1_4 = new Edge(4, 7F);

            Edge camino2_1 = new Edge(1, 5.2f);
            Edge camino2_3 = new Edge(3, 4.2F);
            Edge camino2_5 = new Edge(5, 4.6F);
            Edge camino2_14 = new Edge(14, 3.7F);

            Edge camino3_1 = new Edge(1, 6.4F);
            Edge camino3_2 = new Edge(3, 4.2F);
            Edge camino3_4 = new Edge(4, 4.1F);
            Edge camino3_5 = new Edge(5, 2.9F);

            Edge camino4_1 = new Edge(1, 7F);
            Edge camino4_3 = new Edge(3, 4.1F);
            Edge camino4_5 = new Edge(5, 6.1F);
            Edge camino4_7 = new Edge(7, 7.5F);
            Edge camino4_8 = new Edge(8, 8.3F);
            Edge camino4_16 = new Edge(16, 4.4F);
            Edge camino4_17 = new Edge(17, 18.1F);

            Edge camino5_2 = new Edge(2, 4.6F);
            Edge camino5_3 = new Edge(3, 2.9F);
            Edge camino5_6 = new Edge(6, 3.2F);
            Edge camino5_7 = new Edge(7, 4.8F);
            Edge camino5_14 = new Edge(14, 6.4F);
            Edge camino5_15 = new Edge(15, 5.7F);

            Edge camino6_5 = new Edge(5, 3.2F);
            Edge camino6_7 = new Edge(7, 3F);
            Edge camino6_11 = new Edge(11, 8.8F);
            Edge camino6_15 = new Edge(15, 4.4F);

            Edge camino7_4 = new Edge(4, 7.5F);
            Edge camino7_5 = new Edge(5, 4.8F);
            Edge camino7_6 = new Edge(6, 3F);
            Edge camino7_8 = new Edge(8, 6.2F);
            Edge camino7_9 = new Edge(9, 7.1F);
            Edge camino7_10 = new Edge(10, 7.8F);
            Edge camino7_11 = new Edge(11, 10.6F);

            Edge camino8_4 = new Edge(4, 8.3F);
            Edge camino8_7 = new Edge(7, 6.2F);
            Edge camino8_9 = new Edge(9, 9.1F);
            Edge camino8_17 = new Edge(17, 7.9F);
            Edge camino8_18 = new Edge(18, 14.4F);
            Edge camino8_19 = new Edge(19, 16.5F);

            Edge camino9_7 = new Edge(7, 7.1F);
            Edge camino9_8 = new Edge(8, 9.1F);
            Edge camino9_10 = new Edge(10, 4.7F);
            Edge camino9_19 = new Edge(19, 6.3F);
            Edge camino9_23 = new Edge(23, 7.8F);

            Edge camino10_7 = new Edge(7, 7.8F);
            Edge camino10_9 = new Edge(9, 4.7F);
            Edge camino10_11 = new Edge(11, 2.5F);
            Edge camino10_23 = new Edge(23, 5.4F);

            Edge camino11_6 = new Edge(6, 8.8F);
            Edge camino11_7 = new Edge(7, 10.6F);
            Edge camino11_10 = new Edge(10, 2.5F);
            Edge camino11_12 = new Edge(12, 8.7F);
            Edge camino11_15 = new Edge(15, 7.8F);
            Edge camino11_23 = new Edge(23, 3.5F);
            Edge camino11_24 = new Edge(24, 6.2F);

            Edge camino12_11 = new Edge(11, 8.7F);
            Edge camino12_13 = new Edge(13, 3.9F);
            Edge camino12_15 = new Edge(15, 6.3F);
            Edge camino12_24 = new Edge(24, 5.8F);
            Edge camino12_26 = new Edge(26, 6.4F);

            Edge camino13_12 = new Edge(12, 3.9F);
            Edge camino13_14 = new Edge(14, 4.6F);
            Edge camino13_15 = new Edge(15, 5.9F);
            Edge camino13_26 = new Edge(26, 4.8F);

            Edge camino14_2 = new Edge(2, 3.7F);
            Edge camino14_5 = new Edge(5, 6.4F);
            Edge camino14_13 = new Edge(13, 4.6F);
            Edge camino14_15 = new Edge(15, 4.8F);

            Edge camino15_5 = new Edge(5, 5.7F);
            Edge camino15_6 = new Edge(6, 4.4F);
            Edge camino15_11 = new Edge(11, 7.8F);
            Edge camino15_12 = new Edge(12, 6.3F);
            Edge camino15_13 = new Edge(13, 5.9F);
            Edge camino15_14 = new Edge(14, 4.8F);

            Edge camino16_4 = new Edge(4, 4.4F);
            Edge camino16_17 = new Edge(17, 6.8F);

            Edge camino17_4 = new Edge(4, 18.1F);
            Edge camino17_8 = new Edge(8, 7.9F);
            Edge camino17_16 = new Edge(16, 6.8F);
            Edge camino17_18 = new Edge(18, 9F);

            Edge camino18_8 = new Edge(8, 14.41F);
            Edge camino18_17 = new Edge(17, 9F);
            Edge camino18_19 = new Edge(19, 29.9F);

            Edge camino19_8 = new Edge(8, 16.5F);
            Edge camino19_9 = new Edge(9, 6.3F);
            Edge camino19_18 = new Edge(18, 29.9F);
            Edge camino19_20 = new Edge(20, 17.9F);
            Edge camino19_23 = new Edge(23, 7.1F);

            Edge camino20_19 = new Edge(19, 17.9F);
            Edge camino20_21 = new Edge(21, 6.1F);
            Edge camino20_22 = new Edge(22, 10F);
            Edge camino20_23 = new Edge(23, 16.6F);

            Edge camino21_20 = new Edge(20, 6.1F);
            Edge camino21_22 = new Edge(22, 13.1F);

            Edge camino22_20 = new Edge(20, 10F);
            Edge camino22_21 = new Edge(21, 13.1F);
            Edge camino22_23 = new Edge(23, 10.1F);

            Edge camino23_9 = new Edge(9, 7.8F);
            Edge camino23_10 = new Edge(10, 5.4F);
            Edge camino23_11 = new Edge(11, 3.5F);
            Edge camino23_19 = new Edge(19, 7.1F);
            Edge camino23_20 = new Edge(20, 16.6F);
            Edge camino23_22 = new Edge(22, 10.1F);
            Edge camino23_24 = new Edge(24, 7.1F);

            Edge camino24_11 = new Edge(11, 6.2F);
            Edge camino24_12 = new Edge(12, 5.8F);
            Edge camino24_23 = new Edge(23, 7.1F);
            Edge camino24_25 = new Edge(25, 19.6F);
            Edge camino24_26 = new Edge(26, 11.3F);

            Edge camino25_24 = new Edge(24, 19.6F);
            Edge camino25_26 = new Edge(26, 9.8F);

            Edge camino26_12 = new Edge(12, 6.4F);
            Edge camino26_13 = new Edge(13, 4.8F);
            Edge camino26_24 = new Edge(24, 11.3F);
            Edge camino26_25 = new Edge(25, 9.8F);
            // lista de los caminos con sus costos
            List<Edge> lista_caminos_liniers = new List<Edge>();
            lista_caminos_liniers.Add(caminoLiniers_8);
            lista_caminos_liniers.Add(caminoLiniers_7);
            lista_caminos_liniers.Add(caminoLiniers_10);
            lista_caminos_liniers.Add(caminoLiniers_9);
            lista_caminos_liniers.Add(caminoLiniers_19);
            lista_caminos_liniers.Add(caminoLiniers_23);

            List<Edge> lista_caminos_com1 = new List<Edge>();
            lista_caminos_com1.Add(camino1_2);
            lista_caminos_com1.Add(camino1_3);
            lista_caminos_com1.Add(camino1_4);

            List<Edge> lista_caminos_com2 = new List<Edge>();
            lista_caminos_com2.Add(camino2_1);
            lista_caminos_com2.Add(camino2_3);
            lista_caminos_com2.Add(camino2_5);
            lista_caminos_com2.Add(camino2_14);

            List<Edge> lista_caminos_com3 = new List<Edge>();
            lista_caminos_com3.Add(camino3_1);
            lista_caminos_com3.Add(camino3_2);
            lista_caminos_com3.Add(camino3_4);
            lista_caminos_com3.Add(camino3_5);

            List<Edge> lista_caminos_com4 = new List<Edge>();
            lista_caminos_com4.Add(camino4_1);
            lista_caminos_com4.Add(camino4_3);
            lista_caminos_com4.Add(camino4_5);
            lista_caminos_com4.Add(camino4_7);
            lista_caminos_com4.Add(camino4_8);
            lista_caminos_com4.Add(camino4_16);
            lista_caminos_com4.Add(camino4_17);

            List<Edge> lista_caminos_com5 = new List<Edge>();
            lista_caminos_com5.Add(camino5_2);
            lista_caminos_com5.Add(camino5_3);
            lista_caminos_com5.Add(camino5_6);
            lista_caminos_com5.Add(camino5_7);
            lista_caminos_com5.Add(camino5_14);
            lista_caminos_com5.Add(camino5_15);

            List<Edge> lista_caminos_com6 = new List<Edge>();
            lista_caminos_com6.Add(camino6_5);
            lista_caminos_com6.Add(camino6_7);
            lista_caminos_com6.Add(camino6_11);
            lista_caminos_com6.Add(camino6_15);

            List<Edge> lista_caminos_com7 = new List<Edge>();
            lista_caminos_com7.Add(camino7_4);
            lista_caminos_com7.Add(camino7_5);
            lista_caminos_com7.Add(camino7_6);
            lista_caminos_com7.Add(camino7_8);
            lista_caminos_com7.Add(camino7_9);
            lista_caminos_com7.Add(camino7_10);
            lista_caminos_com7.Add(camino7_11);
            lista_caminos_com7.Add(camino7_liniers);


            List<Edge> lista_caminos_com8 = new List<Edge>();
            lista_caminos_com8.Add(camino8_4);
            lista_caminos_com8.Add(camino8_7);
            lista_caminos_com8.Add(camino8_9);
            lista_caminos_com8.Add(camino8_17);
            lista_caminos_com8.Add(camino8_18);
            lista_caminos_com8.Add(camino8_19);
            lista_caminos_com8.Add(camino8_liniers);

            List<Edge> lista_caminos_com9 = new List<Edge>();
            lista_caminos_com9.Add(camino9_7);
            lista_caminos_com9.Add(camino9_8);
            lista_caminos_com9.Add(camino9_10);
            lista_caminos_com9.Add(camino9_19);
            lista_caminos_com9.Add(camino9_23);
            lista_caminos_com9.Add(camino9_liniers);

            List<Edge> lista_caminos_com10 = new List<Edge>();
            lista_caminos_com10.Add(camino10_7);
            lista_caminos_com10.Add(camino10_9);
            lista_caminos_com10.Add(camino10_11);
            lista_caminos_com10.Add(camino10_23);
            lista_caminos_com10.Add(camino10_liniers);

            List<Edge> lista_caminos_com11 = new List<Edge>();
            lista_caminos_com11.Add(camino11_6);
            lista_caminos_com11.Add(camino11_7);
            lista_caminos_com11.Add(camino11_10);
            lista_caminos_com11.Add(camino11_12);
            lista_caminos_com11.Add(camino11_15);
            lista_caminos_com11.Add(camino11_23);
            lista_caminos_com11.Add(camino11_24);

            List<Edge> lista_caminos_com12 = new List<Edge>();
            lista_caminos_com12.Add(camino12_11);
            lista_caminos_com12.Add(camino12_13);
            lista_caminos_com12.Add(camino12_15);
            lista_caminos_com12.Add(camino12_24);
            lista_caminos_com12.Add(camino12_26);

            List<Edge> lista_caminos_com13 = new List<Edge>();
            lista_caminos_com13.Add(camino13_12);
            lista_caminos_com13.Add(camino13_14);
            lista_caminos_com13.Add(camino13_15);
            lista_caminos_com13.Add(camino13_26);

            List<Edge> lista_caminos_com14 = new List<Edge>();
            lista_caminos_com14.Add(camino14_2);
            lista_caminos_com14.Add(camino14_5);
            lista_caminos_com14.Add(camino14_13);
            lista_caminos_com14.Add(camino14_15);

            List<Edge> lista_caminos_com15 = new List<Edge>();
            lista_caminos_com15.Add(camino15_5);
            lista_caminos_com15.Add(camino15_6);
            lista_caminos_com15.Add(camino15_11);
            lista_caminos_com15.Add(camino15_12);
            lista_caminos_com15.Add(camino15_13);
            lista_caminos_com15.Add(camino15_14);

            List<Edge> lista_caminos_com16 = new List<Edge>();
            lista_caminos_com16.Add(camino16_4);
            lista_caminos_com16.Add(camino16_4);

            List<Edge> lista_caminos_com17 = new List<Edge>();
            lista_caminos_com17.Add(camino17_4);
            lista_caminos_com17.Add(camino17_8);
            lista_caminos_com17.Add(camino17_16);
            lista_caminos_com17.Add(camino17_18);

            List<Edge> lista_caminos_com18 = new List<Edge>();
            lista_caminos_com18.Add(camino18_8);
            lista_caminos_com18.Add(camino18_17);
            lista_caminos_com18.Add(camino18_19);

            List<Edge> lista_caminos_com19 = new List<Edge>();
            lista_caminos_com19.Add(camino19_8);
            lista_caminos_com19.Add(camino19_9);
            lista_caminos_com19.Add(camino19_18);
            lista_caminos_com19.Add(camino19_20);
            lista_caminos_com19.Add(camino19_23);
            lista_caminos_com19.Add(camino19_liniers);

            List<Edge> lista_caminos_com20 = new List<Edge>();
            lista_caminos_com20.Add(camino20_19);
            lista_caminos_com20.Add(camino20_21);
            lista_caminos_com20.Add(camino20_22);
            lista_caminos_com20.Add(camino20_23);

            List<Edge> lista_caminos_com21 = new List<Edge>();
            lista_caminos_com21.Add(camino21_20);
            lista_caminos_com21.Add(camino21_20);

            List<Edge> lista_caminos_com22 = new List<Edge>();
            lista_caminos_com22.Add(camino22_20);
            lista_caminos_com22.Add(camino22_21);
            lista_caminos_com22.Add(camino22_23);

            List<Edge> lista_caminos_com23 = new List<Edge>();
            lista_caminos_com23.Add(camino23_9);
            lista_caminos_com23.Add(camino23_10);
            lista_caminos_com23.Add(camino23_11);
            lista_caminos_com23.Add(camino23_19);
            lista_caminos_com23.Add(camino23_20);
            lista_caminos_com23.Add(camino23_22);
            lista_caminos_com23.Add(camino23_24);
            lista_caminos_com23.Add(camino23_liniers);

            List<Edge> lista_caminos_com24 = new List<Edge>();
            lista_caminos_com24.Add(camino24_11);
            lista_caminos_com24.Add(camino24_12);
            lista_caminos_com24.Add(camino24_23);
            lista_caminos_com24.Add(camino24_25);
            lista_caminos_com24.Add(camino24_26);

            List<Edge> lista_caminos_com25 = new List<Edge>();
            lista_caminos_com25.Add(camino25_24);
            lista_caminos_com25.Add(camino25_24);

            List<Edge> lista_caminos_com26 = new List<Edge>();
            lista_caminos_com26.Add(camino26_12);
            lista_caminos_com26.Add(camino26_13);
            lista_caminos_com26.Add(camino26_24);
            lista_caminos_com26.Add(camino26_25);

            Vertex Liniers = new Vertex(0, "Liniers", lista_caminos_liniers, 0F);
            Vertex comuna1 = new Vertex(1, "Comuna1", lista_caminos_com1, 20.9F);
            Vertex comuna2 = new Vertex(2, "Comuna2", lista_caminos_com2, 26.6F);
            Vertex comuna3 = new Vertex(3, "Comuna3", lista_caminos_com3, 17.1F);
            Vertex comuna4 = new Vertex(4, "Comuna4", lista_caminos_com4, 21.1F);
            Vertex comuna5 = new Vertex(5, "Comuna5", lista_caminos_com5, 16.1F);
            Vertex comuna6 = new Vertex(6, "Comuna6", lista_caminos_com6, 9.4F);
            Vertex comuna7 = new Vertex(7, "Comuna7", lista_caminos_com7, 12.3F);
            Vertex comuna8 = new Vertex(8, "Comuna8", lista_caminos_com8, 13F);
            Vertex comuna9 = new Vertex(9, "Comuna9", lista_caminos_com9, 2.3F);
            Vertex comuna10 = new Vertex(10, "Comuna10", lista_caminos_com10, 3.9F);
            Vertex comuna11 = new Vertex(11, "Comuna11", lista_caminos_com11, 6F);
            Vertex comuna12 = new Vertex(12, "Comuna12", lista_caminos_com12, 12.3F);
            Vertex comuna13 = new Vertex(13, "Comuna13", lista_caminos_com13, 19.4F);
            Vertex comuna14 = new Vertex(14, "Comuna14", lista_caminos_com14, 23.4F);
            Vertex comuna15 = new Vertex(15, "Comuna15", lista_caminos_com15, 10F);
            Vertex comuna16 = new Vertex(16, "Comuna16", lista_caminos_com16, 22.7F);
            Vertex comuna17 = new Vertex(17, "Comuna17", lista_caminos_com17, 17.3F);
            Vertex comuna18 = new Vertex(18, "Comuna18", lista_caminos_com18, 17.4F);
            Vertex comuna19 = new Vertex(19, "Comuna19", lista_caminos_com19, 21.7F);
            Vertex comuna20 = new Vertex(20, "Comuna20", lista_caminos_com20, 14F);
            Vertex comuna21 = new Vertex(21, "Comuna21", lista_caminos_com21, 19.2F);
            Vertex comuna22 = new Vertex(22, "Comuna22", lista_caminos_com22, 14.1F);
            Vertex comuna23 = new Vertex(23, "Comuna23", lista_caminos_com23, 6F);
            Vertex comuna24 = new Vertex(24, "Comuna24", lista_caminos_com24, 11F);
            Vertex comuna25 = new Vertex(25, "Comuna25", lista_caminos_com25, 26.5F);
            Vertex comuna26 = new Vertex(26, "Comuna26", lista_caminos_com26, 17.1F);
            // lista de todas las localidades
            List<Vertex> lista_vertices = new List<Vertex>();
            lista_vertices.Add(Liniers);
            lista_vertices.Add(comuna1);
            lista_vertices.Add(comuna2);
            lista_vertices.Add(comuna3);
            lista_vertices.Add(comuna4);
            lista_vertices.Add(comuna5);
            lista_vertices.Add(comuna6);
            lista_vertices.Add(comuna7);
            lista_vertices.Add(comuna8);
            lista_vertices.Add(comuna9);
            lista_vertices.Add(comuna10);
            lista_vertices.Add(comuna11);
            lista_vertices.Add(comuna12);
            lista_vertices.Add(comuna13);
            lista_vertices.Add(comuna14);
            lista_vertices.Add(comuna15);
            lista_vertices.Add(comuna16);
            lista_vertices.Add(comuna17);
            lista_vertices.Add(comuna18);
            lista_vertices.Add(comuna19);
            lista_vertices.Add(comuna20);
            lista_vertices.Add(comuna21);
            lista_vertices.Add(comuna22);
            lista_vertices.Add(comuna23);
            lista_vertices.Add(comuna24);
            lista_vertices.Add(comuna25);
            lista_vertices.Add(comuna26);
            // creacion del grafo
            Graph grafo = new Graph(lista_vertices);
            //declaracion clientes
            Cliente cliente1 = new Cliente("Juan", "Perez", "22516675", comuna5);
            Cliente cliente2 = new Cliente("Julieta", "Fernandez", "20785362", comuna18);
            Cliente cliente3 = new Cliente("Ramiro", "Gomez", "13403269", comuna26);
            Cliente cliente4 = new Cliente("Lucas", "Martinez", "30498875", comuna10);
            Cliente cliente5 = new Cliente("Maximiliano", "Bentiez", "40256398", comuna1);
            Cliente cliente6 = new Cliente("Bruno", "Sanchez", "14526998", Liniers);
            Cliente cliente7 = new Cliente("Fran", "Gutierrez", "41256633", comuna20);
            // declaracion productos
            Dimensiones d_cocina = new Dimensiones(0.54F, 0.50F, 0.85F, 35F);
            LineaBlanca cocina = new LineaBlanca("Lenovo", 3256, d_cocina, 2, comuna5, cliente1);

            Dimensiones d_calefon = new Dimensiones(0.54F, 0.50F, 0.85F, 35F);
            LineaBlanca calefon = new LineaBlanca("Philco", 3233, d_calefon, 1, comuna26, cliente3);

            Dimensiones d_termotanque = new Dimensiones(0.92F, 0.43F, 0.43F, 30F);
            LineaBlanca termotanque = new LineaBlanca("Philco", 3225, d_termotanque, 2, comuna5, cliente1);

            Dimensiones d_lavarropas = new Dimensiones(0.85F, 0.60F, 0.42F, 62F);
            LineaBlanca lavarropas = new LineaBlanca("Philips", 3285, d_lavarropas, 3, comuna10, cliente4);

            Dimensiones d_secarropas = new Dimensiones(0.84F, 0.59F, 0.55F, 7F);
            LineaBlanca secarropas = new LineaBlanca("Philips", 3286, d_secarropas, 3, comuna10, cliente4);

            Dimensiones d_heladera = new Dimensiones(1.42F, 0.61F, 0.62F, 47F);
            LineaBlanca heladera = new LineaBlanca("Philco", 3201, d_heladera, 1, comuna20, cliente7);

            Dimensiones d_microondas = new Dimensiones(0.29F, 0.49F, 0.40F, 15.3F);
            LineaBlanca microondas = new LineaBlanca("Samsung", 3210, d_microondas, 2, comuna1, cliente5);

            Dimensiones d_freezer = new Dimensiones(0.85F, 0.94F, 0.52F, 33F);
            LineaBlanca freezer = new LineaBlanca("Samsung", 3202, d_freezer, 3, comuna26, cliente3);


            Dimensiones d_laptop = new Dimensiones(0.36F, 0.25F, 0.19F, 1.7F);
            Electronicos laptop = new Electronicos("HP", 2015, d_laptop, 1, comuna1, cliente5);

            Dimensiones d_impresora = new Dimensiones(0.42F, 0.36F, 0.41F, 8F);
            Electronicos impresora = new Electronicos("HP", 2010, d_impresora, 3, Liniers, cliente6);

            Dimensiones d_televisores = new Dimensiones(1.12F, 0.64F, 0.25F, 10.2F);
            Televisores televisores = new Televisores("Samsung", 1023, d_televisores, 1, comuna10, cliente4);

            Dimensiones d_licuadora = new Dimensiones(0.23F, 0.22F, 0.16F, 1.4F);
            PeqElq licuadora = new PeqElq("Philco", 4069, d_licuadora, 2, comuna18, cliente2);

            Dimensiones d_exprimidor = new Dimensiones(0.23F, 0.9F, 0.9F, 2F);
            PeqElq exprimidor = new PeqElq("Samsung", 4023, d_exprimidor, 2, comuna20, cliente7);

            Dimensiones d_rallador = new Dimensiones(0.23F, 0.27F, 0.48F, 2F);
            PeqElq rallador = new PeqElq("Philips", 4098, d_rallador, 3, comuna10, cliente4);

            Dimensiones d_tostadora = new Dimensiones(0.12F, 0.21F, 0.16F, 1F);
            PeqElq tostadora = new PeqElq("Philco", 4052, d_tostadora, 3, comuna1, cliente5);

            Dimensiones d_cafetera = new Dimensiones(0.20F, 0.27F, 0.29F, 2.7F);
            PeqElq cafetera = new PeqElq("Philco", 4020, d_cafetera, 3, comuna1, cliente5);

            Dimensiones d_molinillo = new Dimensiones(0.11F, 0.13F, 0.13F, 1F);
            PeqElq molinillo = new PeqElq("Samsung", 4021, d_molinillo, 3, comuna26, cliente3);

            // declaracion de los vehiculos
            Furgon furgon = new Furgon(4900F, 10F, 14.84F, "AA123BZ", 70F, 7000, 10.8F, 0F, 0F);
            Furgoneta furgoneta = new Furgoneta(10F, 6.9F, "AB456ZZ", 84F, 3500F, 17F, 0F, 0F);
            Camioneta camioneta = new Camioneta(1.17F, 1.86F, 7.6F, "AD137GH", 50F, 750F, 5.9F, 0F, 0F);

            //lista electrodomesticos
            List<Electrodomesticos> lista_el = new List<Electrodomesticos>();
            lista_el.Add(cocina);
            lista_el.Add(calefon);
            lista_el.Add(termotanque);
            lista_el.Add(lavarropas);
            lista_el.Add(secarropas);
            lista_el.Add(heladera);
            lista_el.Add(microondas);
            lista_el.Add(freezer);
            lista_el.Add(laptop);
            lista_el.Add(impresora);
            lista_el.Add(televisores);
            lista_el.Add(licuadora);
            lista_el.Add(exprimidor);
            lista_el.Add(rallador);
            lista_el.Add(tostadora);
            lista_el.Add(cafetera);
            lista_el.Add(molinillo);

            // lista vehiculos
            List<Vehiculo> lista_vehiculos = new List<Vehiculo>();
            lista_vehiculos.Add(furgon);
            lista_vehiculos.Add(furgon);
            lista_vehiculos.Add(camioneta);

            // cocimundo
            Cocimundo cocimundo = new Cocimundo(lista_el, lista_vehiculos);
            int h = 4;
            //ordenamos la lista por linea y prioridad
            lista_el = cocimundo.ordenar_lista_electrodomesticos(lista_el);
            // ordenamos la lista por cliente
            lista_el=cocimundo.ordenar_por_cliente(lista_el);
            // calculamos el beneficio
            cocimundo.Beneficio(lista_el);

            List<Electrodomesticos> lista = cocimundo.llenado_dinamico_(lista_el, furgon);
            
            List<Vertex> lista_vertices_entrega = cocimundo.ordenar_pordistancia(lista_el);

            List<Vertex> lista_aux_vert = new List<Vertex>();
            lista_aux_vert.Add(Liniers);
            lista_aux_vert.Add(comuna7);
            lista_aux_vert.Add(comuna10);
            lista_aux_vert.Add(comuna11);


            List<Vertex> lista_recorrido = furgon.Reparticion_Greedy(grafo, lista_aux_vert);
            
        }
    }
}
