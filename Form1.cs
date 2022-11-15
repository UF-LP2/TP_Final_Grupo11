using csvfiles;
using System.Collections.Generic;
using TPfinal_LP2;

namespace tp_final;

public partial class Form1 : Form
{
    // declaracion de los caminos que conectan cada localidad
    Edge caminoLiniers_8;
    Edge caminoLiniers_7;
    Edge caminoLiniers_10;
    Edge caminoLiniers_9;
    Edge caminoLiniers_19;
    Edge caminoLiniers_23;
    Edge camino8_liniers;
    Edge camino7_liniers;
    Edge camino10_liniers;
    Edge camino9_liniers;
    Edge camino19_liniers;
    Edge camino23_liniers;

    Edge camino1_2;
    Edge camino1_3;
    Edge camino1_4;

    Edge camino2_1;
    Edge camino2_3;
    Edge camino2_5;
    Edge camino2_14;

    Edge camino3_1;
    Edge camino3_2;
    Edge camino3_4;
    Edge camino3_5;

    Edge camino4_1;
    Edge camino4_3;
    Edge camino4_5;
    Edge camino4_7;
    Edge camino4_8;
    Edge camino4_16;
    Edge camino4_17;

    Edge camino5_2;
    Edge camino5_3;
    Edge camino5_6;
    Edge camino5_7;
    Edge camino5_14;
    Edge camino5_15;

    Edge camino6_5;
    Edge camino6_7;
    Edge camino6_11;
    Edge camino6_15;

    Edge camino7_4;
    Edge camino7_5;
    Edge camino7_6;
    Edge camino7_8;
    Edge camino7_9;
    Edge camino7_10;
    Edge camino7_11;

    Edge camino8_4;
    Edge camino8_7;
    Edge camino8_9;
    Edge camino8_17;
    Edge camino8_18;
    Edge camino8_19;

    Edge camino9_7;
    Edge camino9_8;
    Edge camino9_10;
    Edge camino9_19;
    Edge camino9_23;

    Edge camino10_7;
    Edge camino10_9;
    Edge camino10_11;
    Edge camino10_23;

    Edge camino11_6;
    Edge camino11_7;
    Edge camino11_10;
    Edge camino11_12;
    Edge camino11_15;
    Edge camino11_23;
    Edge camino11_24;

    Edge camino12_11;
    Edge camino12_13;
    Edge camino12_15;
    Edge camino12_24;
    Edge camino12_26;

    Edge camino13_12;
    Edge camino13_14;
    Edge camino13_15;
    Edge camino13_26;

    Edge camino14_2;
    Edge camino14_5;
    Edge camino14_13;
    Edge camino14_15;

    Edge camino15_5;
    Edge camino15_6;
    Edge camino15_11;
    Edge camino15_12;
    Edge camino15_13;
    Edge camino15_14;

    Edge camino16_4;
    Edge camino16_17;

    Edge camino17_4;
    Edge camino17_8;
    Edge camino17_16;
    Edge camino17_18;

    Edge camino18_8;
    Edge camino18_17;
    Edge camino18_19;

    Edge camino19_8;
    Edge camino19_9;
    Edge camino19_18;
    Edge camino19_20;
    Edge camino19_23;

    Edge camino20_19;
    Edge camino20_21;
    Edge camino20_22;
    Edge camino20_23;

    Edge camino21_20;
    Edge camino21_22;

    Edge camino22_20;
    Edge camino22_21;
    Edge camino22_23;

    Edge camino23_9;
    Edge camino23_10;
    Edge camino23_11;
    Edge camino23_19;
    Edge camino23_20;
    Edge camino23_22;
    Edge camino23_24;

    Edge camino24_11;
    Edge camino24_12;
    Edge camino24_23;
    Edge camino24_25;
    Edge camino24_26;

    Edge camino25_24;
    Edge camino25_26;

    Edge camino26_12;
    Edge camino26_13;
    Edge camino26_24;
    Edge camino26_25;
    // declaracion listas
    List<Edge> lista_caminos_liniers;
    List<Edge> lista_caminos_com1;
    List<Edge> lista_caminos_com2;
    List<Edge> lista_caminos_com3;
    List<Edge> lista_caminos_com4;
    List<Edge> lista_caminos_com5;
    List<Edge> lista_caminos_com6;
    List<Edge> lista_caminos_com7;
    List<Edge> lista_caminos_com8;
    List<Edge> lista_caminos_com9;
    List<Edge> lista_caminos_com10;
    List<Edge> lista_caminos_com11;
    List<Edge> lista_caminos_com12;
    List<Edge> lista_caminos_com13;
    List<Edge> lista_caminos_com14;
    List<Edge> lista_caminos_com15;
    List<Edge> lista_caminos_com16;
    List<Edge> lista_caminos_com17;
    List<Edge> lista_caminos_com18;
    List<Edge> lista_caminos_com19;
    List<Edge> lista_caminos_com20;
    List<Edge> lista_caminos_com21;
    List<Edge> lista_caminos_com22;
    List<Edge> lista_caminos_com23;
    List<Edge> lista_caminos_com24;
    List<Edge> lista_caminos_com25;
    List<Edge> lista_caminos_com26;
    // declaracion vertices
    Vertex Liniers;
    Vertex comuna1;
    Vertex comuna2;
    Vertex comuna3;
    Vertex comuna4;
    Vertex comuna5;
    Vertex comuna6;
    Vertex comuna7;
    Vertex comuna8;
    Vertex comuna9;
    Vertex comuna10;
    Vertex comuna11;
    Vertex comuna12;
    Vertex comuna13;
    Vertex comuna14;
    Vertex comuna15;
    Vertex comuna16;
    Vertex comuna17;
    Vertex comuna18;
    Vertex comuna19;
    Vertex comuna20;
    Vertex comuna21;
    Vertex comuna22;
    Vertex comuna23;
    Vertex comuna24;
    Vertex comuna25;
    Vertex comuna26;

    // lista de todas las localidades
    List<Vertex> lista_vertices;

    // creacion del grafo
    Graph grafo;

    //declaracion clientes
    Cliente cliente1;
    Cliente cliente2;
    Cliente cliente3;
    Cliente cliente4;
    Cliente cliente5;
    Cliente cliente6;
    Cliente cliente7;

    // declaracion de los vehiculos
    Furgon furgon;
    Furgoneta furgoneta;
    Camioneta camioneta;

    List<Electrodomesticos> lista_el;
    List<Vehiculo> lista_vehiculos;

    // cocimundo
    Cocimundo cocimundo;

    Dimensiones d_cocina;
    LineaBlanca cocina;

    Dimensiones d_calefon;
    LineaBlanca calefon;

    Dimensiones d_termotanque;
    LineaBlanca termotanque;

    Dimensiones d_lavarropas;
    LineaBlanca lavarropas;

    Dimensiones d_secarropas;
    LineaBlanca secarropas;

    Dimensiones d_heladera;
    LineaBlanca heladera;

    Dimensiones d_microondas;
    LineaBlanca microondas;

    Dimensiones d_freezer;
    LineaBlanca freezer;

    Dimensiones d_laptop;
    Electronicos laptop;

    Dimensiones d_impresora;
    Electronicos impresora;

    Dimensiones d_televisores;
    Televisores televisores;

    Dimensiones d_licuadora;
    PeqElq licuadora;

    Dimensiones d_exprimidor;
    PeqElq exprimidor;

    Dimensiones d_rallador;
    PeqElq rallador;

    Dimensiones d_tostadora;
    PeqElq tostadora;

    Dimensiones d_cafetera;
    PeqElq cafetera;

    Dimensiones d_molinillo;
    PeqElq molinillo;

    List<Electrodomesticos> lista_furgon;
    List<Vertex> lista_vert_furg;
    List<Vertex> lista_recorrido_furgon;
    List<Electrodomesticos> lista_furgoneta;
    List<Vertex> lista_vert_furgn;
    List<Electrodomesticos> lista_camioneta;
    List<Vertex> lista_vert_cam;
    List<Vertex> lista_recorrido_camioneta;
    List<Vertex> lista_recorrido_furgoneta;

    List<Electrodomesticos> lista_;
    int value;

    int contador_camioneta;

    public Form1()
    {
        InitializeComponent();
        var csv_ = new csvfiles._csv();
        List<Pedido> Pedidos = csv_.read_csv();

        // declaracion de los caminos que conectan cada localidad
        caminoLiniers_8 = new Edge(1, 10.3F);
        caminoLiniers_7 = new Edge(7, 8.9F);
        caminoLiniers_10 = new Edge(10, 3.9F);
        caminoLiniers_9 = new Edge(9, 2.3F);
        caminoLiniers_19 = new Edge(19, 28.3F);
        caminoLiniers_23 = new Edge(23, 6F);
        camino8_liniers = new Edge(0, 10.3F);
        camino7_liniers = new Edge(0, 8.9F);
        camino10_liniers = new Edge(0, 3.9F);
        camino9_liniers = new Edge(0, 2.3F);
        camino19_liniers = new Edge(0, 28.3F);
        camino23_liniers = new Edge(0, 6F);

        camino1_2 = new Edge(2, 5.2f);
        camino1_3 = new Edge(3, 6.4F);
        camino1_4 = new Edge(4, 7F);

        camino2_1 = new Edge(1, 5.2f);
        camino2_3 = new Edge(3, 4.2F);
        camino2_5 = new Edge(5, 4.6F);
        camino2_14 = new Edge(14, 3.7F);

        camino3_1 = new Edge(1, 6.4F);
        camino3_2 = new Edge(3, 4.2F);
        camino3_4 = new Edge(4, 4.1F);
        camino3_5 = new Edge(5, 2.9F);

        camino4_1 = new Edge(1, 7F);
        camino4_3 = new Edge(3, 4.1F);
        camino4_5 = new Edge(5, 6.1F);
        camino4_7 = new Edge(7, 7.5F);
        camino4_8 = new Edge(8, 8.3F);
        camino4_16 = new Edge(16, 4.4F);
        camino4_17 = new Edge(17, 18.1F);

        camino5_2 = new Edge(2, 4.6F);
        camino5_3 = new Edge(3, 2.9F);
        camino5_6 = new Edge(6, 3.2F);
        camino5_7 = new Edge(7, 4.8F);
        camino5_14 = new Edge(14, 6.4F);
        camino5_15 = new Edge(15, 5.7F);

        camino6_5 = new Edge(5, 3.2F);
        camino6_7 = new Edge(7, 3F);
        camino6_11 = new Edge(11, 8.8F);
        camino6_15 = new Edge(15, 4.4F);

        camino7_4 = new Edge(4, 7.5F);
        camino7_5 = new Edge(5, 4.8F);
        camino7_6 = new Edge(6, 3F);
        camino7_8 = new Edge(8, 6.2F);
        camino7_9 = new Edge(9, 7.1F);
        camino7_10 = new Edge(10, 7.8F);
        camino7_11 = new Edge(11, 10.6F);

        camino8_4 = new Edge(4, 8.3F);
        camino8_7 = new Edge(7, 6.2F);
        camino8_9 = new Edge(9, 9.1F);
        camino8_17 = new Edge(17, 7.9F);
        camino8_18 = new Edge(18, 14.4F);
        camino8_19 = new Edge(19, 16.5F);

        camino9_7 = new Edge(7, 7.1F);
        camino9_8 = new Edge(8, 9.1F);
        camino9_10 = new Edge(10, 4.7F);
        camino9_19 = new Edge(19, 6.3F);
        camino9_23 = new Edge(23, 7.8F);

        camino10_7 = new Edge(7, 7.8F);
        camino10_9 = new Edge(9, 4.7F);
        camino10_11 = new Edge(11, 2.5F);
        camino10_23 = new Edge(23, 5.4F);

        camino11_6 = new Edge(6, 8.8F);
        camino11_7 = new Edge(7, 10.6F);
        camino11_10 = new Edge(10, 2.5F);
        camino11_12 = new Edge(12, 8.7F);
        camino11_15 = new Edge(15, 7.8F);
        camino11_23 = new Edge(23, 3.5F);
        camino11_24 = new Edge(24, 6.2F);

        camino12_11 = new Edge(11, 8.7F);
        camino12_13 = new Edge(13, 3.9F);
        camino12_15 = new Edge(15, 6.3F);
        camino12_24 = new Edge(24, 5.8F);
        camino12_26 = new Edge(26, 6.4F);

        camino13_12 = new Edge(12, 3.9F);
        camino13_14 = new Edge(14, 4.6F);
        camino13_15 = new Edge(15, 5.9F);
        camino13_26 = new Edge(26, 4.8F);

        camino14_2 = new Edge(2, 3.7F);
        camino14_5 = new Edge(5, 6.4F);
        camino14_13 = new Edge(13, 4.6F);
        camino14_15 = new Edge(15, 4.8F);

        camino15_5 = new Edge(5, 5.7F);
        camino15_6 = new Edge(6, 4.4F);
        camino15_11 = new Edge(11, 7.8F);
        camino15_12 = new Edge(12, 6.3F);
        camino15_13 = new Edge(13, 5.9F);
        camino15_14 = new Edge(14, 4.8F);

        camino16_4 = new Edge(4, 4.4F);
        camino16_17 = new Edge(17, 6.8F);

        camino17_4 = new Edge(4, 18.1F);
        camino17_8 = new Edge(8, 7.9F);
        camino17_16 = new Edge(16, 6.8F);
        camino17_18 = new Edge(18, 9F);

        camino18_8 = new Edge(8, 14.41F);
        camino18_17 = new Edge(17, 9F);
        camino18_19 = new Edge(19, 29.9F);

        camino19_8 = new Edge(8, 16.5F);
        camino19_9 = new Edge(9, 6.3F);
        camino19_18 = new Edge(18, 29.9F);
        camino19_20 = new Edge(20, 17.9F);
        camino19_23 = new Edge(23, 7.1F);

        camino20_19 = new Edge(19, 17.9F);
        camino20_21 = new Edge(21, 6.1F);
        camino20_22 = new Edge(22, 10F);
        camino20_23 = new Edge(23, 16.6F);

        camino21_20 = new Edge(20, 6.1F);
        camino21_22 = new Edge(22, 13.1F);

        camino22_20 = new Edge(20, 10F);
        camino22_21 = new Edge(21, 13.1F);
        camino22_23 = new Edge(23, 10.1F);

        camino23_9 = new Edge(9, 7.8F);
        camino23_10 = new Edge(10, 5.4F);
        camino23_11 = new Edge(11, 3.5F);
        camino23_19 = new Edge(19, 7.1F);
        camino23_20 = new Edge(20, 16.6F);
        camino23_22 = new Edge(22, 10.1F);
        camino23_24 = new Edge(24, 7.1F);

        camino24_11 = new Edge(11, 6.2F);
        camino24_12 = new Edge(12, 5.8F);
        camino24_23 = new Edge(23, 7.1F);
        camino24_25 = new Edge(25, 19.6F);
        camino24_26 = new Edge(26, 11.3F);

        camino25_24 = new Edge(24, 19.6F);
        camino25_26 = new Edge(26, 9.8F);

        camino26_12 = new Edge(12, 6.4F);
        camino26_13 = new Edge(13, 4.8F);
        camino26_24 = new Edge(24, 11.3F);
        camino26_25 = new Edge(25, 9.8F);

        lista_caminos_liniers = new List<Edge>();
        lista_caminos_liniers.Add(caminoLiniers_8);
        lista_caminos_liniers.Add(caminoLiniers_7);
        lista_caminos_liniers.Add(caminoLiniers_10);
        lista_caminos_liniers.Add(caminoLiniers_9);
        lista_caminos_liniers.Add(caminoLiniers_19);
        lista_caminos_liniers.Add(caminoLiniers_23);

        lista_caminos_com1 = new List<Edge>();
        lista_caminos_com1.Add(camino1_2);
        lista_caminos_com1.Add(camino1_3);
        lista_caminos_com1.Add(camino1_4);

        lista_caminos_com2 = new List<Edge>();
        lista_caminos_com2.Add(camino2_1);
        lista_caminos_com2.Add(camino2_3);
        lista_caminos_com2.Add(camino2_5);
        lista_caminos_com2.Add(camino2_14);

        lista_caminos_com3 = new List<Edge>();
        lista_caminos_com3.Add(camino3_1);
        lista_caminos_com3.Add(camino3_2);
        lista_caminos_com3.Add(camino3_4);
        lista_caminos_com3.Add(camino3_5);

        lista_caminos_com4 = new List<Edge>();
        lista_caminos_com4.Add(camino4_1);
        lista_caminos_com4.Add(camino4_3);
        lista_caminos_com4.Add(camino4_5);
        lista_caminos_com4.Add(camino4_7);
        lista_caminos_com4.Add(camino4_8);
        lista_caminos_com4.Add(camino4_16);
        lista_caminos_com4.Add(camino4_17);

        lista_caminos_com5 = new List<Edge>();
        lista_caminos_com5.Add(camino5_2);
        lista_caminos_com5.Add(camino5_3);
        lista_caminos_com5.Add(camino5_6);
        lista_caminos_com5.Add(camino5_7);
        lista_caminos_com5.Add(camino5_14);
        lista_caminos_com5.Add(camino5_15);

        lista_caminos_com6 = new List<Edge>();
        lista_caminos_com6.Add(camino6_5);
        lista_caminos_com6.Add(camino6_7);
        lista_caminos_com6.Add(camino6_11);
        lista_caminos_com6.Add(camino6_15);

        lista_caminos_com7 = new List<Edge>();
        lista_caminos_com7.Add(camino7_4);
        lista_caminos_com7.Add(camino7_5);
        lista_caminos_com7.Add(camino7_6);
        lista_caminos_com7.Add(camino7_8);
        lista_caminos_com7.Add(camino7_9);
        lista_caminos_com7.Add(camino7_10);
        lista_caminos_com7.Add(camino7_11);
        lista_caminos_com7.Add(camino7_liniers);



        lista_caminos_com8 = new List<Edge>();
        lista_caminos_com8.Add(camino8_4);
        lista_caminos_com8.Add(camino8_7);
        lista_caminos_com8.Add(camino8_9);
        lista_caminos_com8.Add(camino8_17);
        lista_caminos_com8.Add(camino8_18);
        lista_caminos_com8.Add(camino8_19);
        lista_caminos_com8.Add(camino8_liniers);

        lista_caminos_com9 = new List<Edge>();
        lista_caminos_com9.Add(camino9_7);
        lista_caminos_com9.Add(camino9_8);
        lista_caminos_com9.Add(camino9_10);
        lista_caminos_com9.Add(camino9_19);
        lista_caminos_com9.Add(camino9_23);
        lista_caminos_com9.Add(camino9_liniers);

        lista_caminos_com10 = new List<Edge>();
        lista_caminos_com10.Add(camino10_7);
        lista_caminos_com10.Add(camino10_9);
        lista_caminos_com10.Add(camino10_11);
        lista_caminos_com10.Add(camino10_23);
        lista_caminos_com10.Add(camino10_liniers);

        lista_caminos_com11 = new List<Edge>();
        lista_caminos_com11.Add(camino11_6);
        lista_caminos_com11.Add(camino11_7);
        lista_caminos_com11.Add(camino11_10);
        lista_caminos_com11.Add(camino11_12);
        lista_caminos_com11.Add(camino11_15);
        lista_caminos_com11.Add(camino11_23);
        lista_caminos_com11.Add(camino11_24);

        lista_caminos_com12 = new List<Edge>();
        lista_caminos_com12.Add(camino12_11);
        lista_caminos_com12.Add(camino12_13);
        lista_caminos_com12.Add(camino12_15);
        lista_caminos_com12.Add(camino12_24);
        lista_caminos_com12.Add(camino12_26);

        lista_caminos_com13 = new List<Edge>();
        lista_caminos_com13.Add(camino13_12);
        lista_caminos_com13.Add(camino13_14);
        lista_caminos_com13.Add(camino13_15);
        lista_caminos_com13.Add(camino13_26);

        lista_caminos_com14 = new List<Edge>();
        lista_caminos_com14.Add(camino14_2);
        lista_caminos_com14.Add(camino14_5);
        lista_caminos_com14.Add(camino14_13);
        lista_caminos_com14.Add(camino14_15);

        lista_caminos_com15 = new List<Edge>();
        lista_caminos_com15.Add(camino15_5);
        lista_caminos_com15.Add(camino15_6);
        lista_caminos_com15.Add(camino15_11);
        lista_caminos_com15.Add(camino15_12);
        lista_caminos_com15.Add(camino15_13);
        lista_caminos_com15.Add(camino15_14);

        lista_caminos_com16 = new List<Edge>();
        lista_caminos_com16.Add(camino16_4);
        lista_caminos_com16.Add(camino16_17);

        lista_caminos_com17 = new List<Edge>();
        lista_caminos_com17.Add(camino17_4);
        lista_caminos_com17.Add(camino17_8);
        lista_caminos_com17.Add(camino17_16);
        lista_caminos_com17.Add(camino17_18);

        lista_caminos_com18 = new List<Edge>();
        lista_caminos_com18.Add(camino18_8);
        lista_caminos_com18.Add(camino18_17);
        lista_caminos_com18.Add(camino18_19);

        lista_caminos_com19 = new List<Edge>();
        lista_caminos_com19.Add(camino19_8);
        lista_caminos_com19.Add(camino19_9);
        lista_caminos_com19.Add(camino19_18);
        lista_caminos_com19.Add(camino19_20);
        lista_caminos_com19.Add(camino19_23);
        lista_caminos_com19.Add(camino19_liniers);

        lista_caminos_com20 = new List<Edge>();
        lista_caminos_com20.Add(camino20_19);
        lista_caminos_com20.Add(camino20_21);
        lista_caminos_com20.Add(camino20_22);
        lista_caminos_com20.Add(camino20_23);

        lista_caminos_com21 = new List<Edge>();
        lista_caminos_com21.Add(camino21_20);
        lista_caminos_com21.Add(camino21_20);

        lista_caminos_com22 = new List<Edge>();
        lista_caminos_com22.Add(camino22_20);
        lista_caminos_com22.Add(camino22_21);
        lista_caminos_com22.Add(camino22_23);

        lista_caminos_com23 = new List<Edge>();
        lista_caminos_com23.Add(camino23_9);
        lista_caminos_com23.Add(camino23_10);
        lista_caminos_com23.Add(camino23_11);
        lista_caminos_com23.Add(camino23_19);
        lista_caminos_com23.Add(camino23_20);
        lista_caminos_com23.Add(camino23_22);
        lista_caminos_com23.Add(camino23_24);
        lista_caminos_com23.Add(camino23_liniers);

        lista_caminos_com24 = new List<Edge>();
        lista_caminos_com24.Add(camino24_11);
        lista_caminos_com24.Add(camino24_12);
        lista_caminos_com24.Add(camino24_23);
        lista_caminos_com24.Add(camino24_25);
        lista_caminos_com24.Add(camino24_26);

        lista_caminos_com25 = new List<Edge>();
        lista_caminos_com25.Add(camino25_24);
        lista_caminos_com25.Add(camino25_24);

        lista_caminos_com26 = new List<Edge>();
        lista_caminos_com26.Add(camino26_12);
        lista_caminos_com26.Add(camino26_13);
        lista_caminos_com26.Add(camino26_24);
        lista_caminos_com26.Add(camino26_25);

        Liniers = new Vertex(0, "Liniers", lista_caminos_liniers, 0F);
        comuna1 = new Vertex(1, "Comuna1", lista_caminos_com1, 20.9F);
        comuna2 = new Vertex(2, "Comuna2", lista_caminos_com2, 26.6F);
        comuna3 = new Vertex(3, "Comuna3", lista_caminos_com3, 17.1F);
        comuna4 = new Vertex(4, "Comuna4", lista_caminos_com4, 21.1F);
        comuna5 = new Vertex(5, "Comuna5", lista_caminos_com5, 16.1F);
        comuna6 = new Vertex(6, "Comuna6", lista_caminos_com6, 9.4F);
        comuna7 = new Vertex(7, "Comuna7", lista_caminos_com7, 12.3F);
        comuna8 = new Vertex(8, "Comuna8", lista_caminos_com8, 13F);
        comuna9 = new Vertex(9, "Comuna9", lista_caminos_com9, 2.3F);
        comuna10 = new Vertex(10, "Comuna10", lista_caminos_com10, 3.9F);
        comuna11 = new Vertex(11, "Comuna11", lista_caminos_com11, 6F);
        comuna12 = new Vertex(12, "Comuna12", lista_caminos_com12, 12.3F);
        comuna13 = new Vertex(13, "Comuna13", lista_caminos_com13, 19.4F);
        comuna14 = new Vertex(14, "Comuna14", lista_caminos_com14, 23.4F);
        comuna15 = new Vertex(15, "Comuna15", lista_caminos_com15, 10F);
        comuna16 = new Vertex(16, "Comuna16", lista_caminos_com16, 22.7F);
        comuna17 = new Vertex(17, "Comuna17", lista_caminos_com17, 17.3F);
        comuna18 = new Vertex(18, "Comuna18", lista_caminos_com18, 17.4F);
        comuna19 = new Vertex(19, "Comuna19", lista_caminos_com19, 21.7F);
        comuna20 = new Vertex(20, "Comuna20", lista_caminos_com20, 14F);
        comuna21 = new Vertex(21, "Comuna21", lista_caminos_com21, 19.2F);
        comuna22 = new Vertex(22, "Comuna22", lista_caminos_com22, 14.1F);
        comuna23 = new Vertex(23, "Comuna23", lista_caminos_com23, 6F);
        comuna24 = new Vertex(24, "Comuna24", lista_caminos_com24, 11F);
        comuna25 = new Vertex(25, "Comuna25", lista_caminos_com25, 26.5F);
        comuna26 = new Vertex(26, "Comuna26", lista_caminos_com26, 17.1F);

        lista_vertices = new List<Vertex>();
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
        grafo = new Graph(lista_vertices);

        //declaracion clientes
        cliente1 = new Cliente("Juan", "Perez", "22516675", comuna5);
        cliente2 = new Cliente("Julieta", "Fernandez", "20785362", comuna18);
        cliente3 = new Cliente("Ramiro", "Gomez", "13403269", comuna26);
        cliente4 = new Cliente("Lucas", "Martinez", "30498875", comuna10);
        cliente5 = new Cliente("Maximiliano", "Bentiez", "40256398", comuna1);
        cliente6 = new Cliente("Bruno", "Sanchez", "14526998", Liniers);
        cliente7 = new Cliente("Fran", "Gutierrez", "41256633", comuna20);

        // declaracion de los vehiculos
        furgon = new Furgon(4900F, 10F, 14.84F, "AA123BZ", 70F, 7000F, 50F, 0F, 0F);
        furgoneta = new Furgoneta(10F, 6.9F, "AB456ZZ", 84F, 3500F, 17F, 0F, 0F);
        camioneta = new Camioneta(1.17F, 1.86F, 7.6F, "AD137GH", 50F, 750F, 30F, 0F, 0F);

        d_cocina = new Dimensiones(5, 5, 8, 35);
        cocina = new LineaBlanca("Lenovo", 3256, d_cocina, 2, comuna5, cliente1, 9, 11, 2022);

        d_calefon = new Dimensiones(3, 3, 1, 35);
        calefon = new LineaBlanca("Philco", 3233, d_calefon, 1, comuna26, cliente3, 12, 11, 2022);

        d_termotanque = new Dimensiones(9, 4, 4, 30);
        termotanque = new LineaBlanca("Philco", 3225, d_termotanque, 2, comuna5, cliente1, 10, 11, 2022);

        d_lavarropas = new Dimensiones(8, 6, 4, 62);
        lavarropas = new LineaBlanca("Philips", 3285, d_lavarropas, 3, comuna10, cliente4, 11, 11, 2022);

        d_secarropas = new Dimensiones(8, 5, 5, 7);
        LineaBlanca secarropas = new LineaBlanca("Philips", 3286, d_secarropas, 3, comuna10, cliente4, 11, 11, 2022);

        d_heladera = new Dimensiones(4, 6, 6, 47);
        heladera = new LineaBlanca("Philco", 3201, d_heladera, 1, comuna20, cliente7, 10, 11, 2022);

        d_microondas = new Dimensiones(3, 5, 4, 15);
        microondas = new LineaBlanca("Samsung", 3210, d_microondas, 2, comuna1, cliente5, 12, 11, 2022);

        d_freezer = new Dimensiones(8, 9, 5, 33);
        freezer = new LineaBlanca("Samsung", 3202, d_freezer, 3, comuna26, cliente3, 10, 11, 2022);
        d_laptop = new Dimensiones(4, 2, 2, 2);
        laptop = new Electronicos("HP", 2015, d_laptop, 1, comuna1, cliente5, 10, 11, 2022);

        d_impresora = new Dimensiones(4, 4, 4, 8);
        impresora = new Electronicos("HP", 2010, d_impresora, 3, Liniers, cliente6, 10, 11, 2022);

        d_televisores = new Dimensiones(11, 6, 2, 10);
        televisores = new Televisores("Samsung", 1023, d_televisores, 1, comuna10, cliente4, 12, 11, 2022);

        d_licuadora = new Dimensiones(2, 2, 2, 1);
        licuadora = new PeqElq("Philco", 4069, d_licuadora, 2, comuna18, cliente2, 12, 11, 2022);

        d_exprimidor = new Dimensiones(2, 3, 3, 2);
        exprimidor = new PeqElq("Samsung", 4023, d_exprimidor, 2, comuna20, cliente7, 11, 11, 2022);

        d_rallador = new Dimensiones(2, 2, 5, 2);
        rallador = new PeqElq("Philips", 4098, d_rallador, 3, comuna10, cliente4, 10, 11, 2022);

        d_tostadora = new Dimensiones(1, 2, 1, 1);
        tostadora = new PeqElq("Philco", 4052, d_tostadora, 3, comuna1, cliente5, 10, 11, 2022);

        d_cafetera = new Dimensiones(2, 3, 3, 3);
        cafetera = new PeqElq("Philco", 4020, d_cafetera, 3, comuna1, cliente5, 12, 11, 2022);

        d_molinillo = new Dimensiones(1, 1, 1, 1);
        molinillo = new PeqElq("Samsung", 4021, d_molinillo, 3, comuna26, cliente3, 11, 11, 2022);


        // lista electrodomesticos
        lista_el = new List<Electrodomesticos>();
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
        lista_vehiculos = new List<Vehiculo>();
        lista_vehiculos.Add(furgon);
        lista_vehiculos.Add(furgon);
        lista_vehiculos.Add(camioneta);


        contador_camioneta = 0;

        // cocimundo
        cocimundo = new Cocimundo(lista_el, lista_vehiculos);
        //ordenamos la lista por linea y prioridad
        lista_el = cocimundo.ordenar_lista_electrodomesticos(lista_el);
        // ordenamos la lista por cliente
        lista_el = cocimundo.ordenar_por_cliente(lista_el);
        // calculamos el beneficio
        cocimundo.Beneficio(lista_el);

        // calculamos el llenado optimo del camion y el camino a recorrer
        lista_furgon = cocimundo.llenado_dinamico_(ref lista_el, furgon);
        lista_vert_furg = cocimundo.ordenar_pordistancia(lista_furgon, Liniers);
        lista_recorrido_furgon = furgon.Reparticion_Greedy(grafo, lista_vert_furg);


        lista_furgoneta = cocimundo.llenado_dinamico_(ref lista_el, furgoneta);
        lista_vert_furgn = cocimundo.ordenar_pordistancia(lista_furgoneta, Liniers);
        lista_recorrido_furgoneta = furgoneta.Reparticion_Greedy(grafo, lista_vert_furgn);


        lista_camioneta = cocimundo.llenado_dinamico_(ref lista_el, camioneta);
        lista_vert_cam = cocimundo.ordenar_pordistancia(lista_camioneta, Liniers);
        lista_recorrido_camioneta = camioneta.Reparticion_Greedy(grafo, lista_vert_cam);
       
        /* camioneta.Entregar_Productos(lista_camioneta, lista_vert_cam);
        lista_ = new List<Electrodomesticos>();
        if (lista_el.Count != 0)
        {
            foreach (Electrodomesticos item in lista_el)
            {
                value = DateTime.Compare(item.get_datetime(), DateTime.Now);
                if (item.get_prioridad() == 1 && value < 0)// es el dia de su entrega pero no se hizo
                {
                    lista_.Add(item);// lista de lementos con prioridad 1
                    lista_vert_cam.Add(item.get_destino_entrega());
                }
                else if (item.get_prioridad() == 2 && value < 0)
                {
                    item.set_prioridad(1);
                }
                else if (item.get_prioridad() == 3 && value < 0)
                {
                    item.set_prioridad(2);
                }
            }
        }
        
        int k = 0;
        while (k != 3 && lista_.Count != 0)
        {
            lista_vert_cam = cocimundo.ordenar_pordistancia(lista_camioneta, Liniers);
            lista_camioneta = cocimundo.llenado_dinamico_(ref lista_, camioneta);
            lista_recorrido_camioneta = camioneta.Reparticion_Greedy(grafo, lista_vert_cam);
            camioneta.Entregar_Productos(lista_, lista_recorrido_camioneta);
            k++;
        }*/

    }

    private void button1_Click(object sender, EventArgs e)
    {
       foreach(Vertex item in lista_recorrido_furgon)
        {
            ListViewItem lista_forms = new ListViewItem(item.get_nombre());
            lista_recorridos_tabla.Items.Add(lista_forms);
        }

        furgon.Entregar_Productos(lista_furgon, lista_vert_furg);

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void lista_recorridos_tabla_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        foreach (Vertex item in lista_recorrido_furgoneta)
        {
            ListViewItem lista_forms = new ListViewItem(item.get_nombre());
            lista_furgoneta_view.Items.Add(lista_forms);
        }

        furgoneta.Entregar_Productos(lista_furgoneta, lista_vert_furg);


    }

    private void button2_Click(object sender, EventArgs e)
    {

        switch(contador_camioneta)
        {
                case 0:
                {
                    foreach (Vertex item in lista_recorrido_camioneta)
                    {
                        ListViewItem lista_forms = new ListViewItem(item.get_nombre());
                        lista_camioneta_view.Items.Add(lista_forms);
                    }
                    
                    camioneta.Entregar_Productos(lista_camioneta, lista_vert_cam);

                    lista_ = new List<Electrodomesticos>();
                    if (lista_el.Count != 0)
                    {
                        foreach (Electrodomesticos item in lista_el)
                        {
                            value = DateTime.Compare(item.get_datetime(), DateTime.Now);
                            if (item.get_prioridad() == 1 && value < 0 || item.get_prioridad() == 1 && value == 0)// es el dia de su entrega pero no se hizo
                            {
                                lista_.Add(item);// lista de elementos con prioridad 1
                                lista_vert_cam.Add(item.get_destino_entrega());
                            }
                            else if (item.get_prioridad() == 2 && value < 0)
                            {
                                item.set_prioridad(1);
                            }
                            else if (item.get_prioridad() == 3 && value < 0)
                            {
                                item.set_prioridad(2);
                            }
                        }

                    }

                    lista_camioneta = cocimundo.llenado_dinamico_(ref lista_, camioneta);
                    lista_vert_cam = cocimundo.ordenar_pordistancia(lista_camioneta, Liniers);
                    lista_recorrido_camioneta = camioneta.Reparticion_Greedy(grafo, lista_vert_cam);
                    
                    contador_camioneta++;

                    break;
                }

                case 1:
                {
                    lista_camioneta_view.Items.Clear();
                    foreach (Vertex item in lista_recorrido_camioneta)
                    {
                        ListViewItem lista_forms = new ListViewItem(item.get_nombre());
                        lista_camioneta_view.Items.Add(lista_forms);
                    }
                    
                    camioneta.Entregar_Productos(lista_camioneta, lista_vert_cam);

                    lista_ = new List<Electrodomesticos>();
                    if (lista_el.Count != 0)
                    {
                        foreach (Electrodomesticos item in lista_el)
                        {
                            value = DateTime.Compare(item.get_datetime(), DateTime.Now);
                            if (item.get_prioridad() == 1 && value < 0 || item.get_prioridad() == 1 && value == 0)// es el dia de su entrega pero no se hizo
                            {
                                lista_.Add(item);// lista de lementos con prioridad 1
                                lista_vert_cam.Add(item.get_destino_entrega());
                            }
                            else if (item.get_prioridad() == 2 && value < 0)
                            {
                                item.set_prioridad(1);
                            }
                            else if (item.get_prioridad() == 3 && value < 0)
                            {
                                item.set_prioridad(2);
                            }
                        }

                    }

                    lista_camioneta = cocimundo.llenado_dinamico_(ref lista_, camioneta);
                    lista_vert_cam = cocimundo.ordenar_pordistancia(lista_camioneta, Liniers);
                    lista_recorrido_camioneta = camioneta.Reparticion_Greedy(grafo, lista_vert_cam);

                    contador_camioneta++;

                    break;
                }

                case 2:
                {
                    lista_camioneta_view.Items.Clear();
                    foreach (Vertex item in lista_recorrido_camioneta)
                    {
                        ListViewItem lista_forms = new ListViewItem(item.get_nombre());
                        lista_camioneta_view.Items.Add(lista_forms);
                    }

                    camioneta.Entregar_Productos(lista_camioneta, lista_vert_cam);

                    lista_ = new List<Electrodomesticos>();
                    if (lista_el.Count != 0)
                    {
                        foreach (Electrodomesticos item in lista_el)
                        {
                            value = DateTime.Compare(item.get_datetime(), DateTime.Now);
                            if (item.get_prioridad() == 1 && value < 0 || item.get_prioridad() == 1 && value == 0)// es el dia de su entrega pero no se hizo
                            {
                                lista_.Add(item);// lista de lementos con prioridad 1
                                lista_vert_cam.Add(item.get_destino_entrega());
                            }
                            else if (item.get_prioridad() == 2 && value < 0)
                            {
                                item.set_prioridad(1);
                            }
                            else if (item.get_prioridad() == 3 && value < 0)
                            {
                                item.set_prioridad(2);
                            }
                        }

                    }

                    lista_camioneta = cocimundo.llenado_dinamico_(ref lista_, camioneta);
                    lista_vert_cam = cocimundo.ordenar_pordistancia(lista_camioneta, Liniers);
                    lista_recorrido_camioneta = camioneta.Reparticion_Greedy(grafo, lista_vert_cam);

                    contador_camioneta++;
                    break;
                }

                case 3:
                {
                    lista_camioneta_view.Items.Clear();
                    foreach (Vertex item in lista_recorrido_camioneta)
                    {
                        ListViewItem lista_forms = new ListViewItem(item.get_nombre());
                        lista_camioneta_view.Items.Add(lista_forms);
                    }

                    camioneta.Entregar_Productos(lista_camioneta, lista_vert_cam);

                    lista_ = new List<Electrodomesticos>();
                    if (lista_el.Count != 0)
                    {
                        foreach (Electrodomesticos item in lista_el)
                        {
                            value = DateTime.Compare(item.get_datetime(), DateTime.Now);
                            if (item.get_prioridad() == 1 && value < 0 || item.get_prioridad() == 1 && value == 0)// es el dia de su entrega pero no se hizo
                            {
                                lista_.Add(item);// lista de lementos con prioridad 1
                                lista_vert_cam.Add(item.get_destino_entrega());
                            }
                            else if (item.get_prioridad() == 2 && value < 0)
                            {
                                item.set_prioridad(1);
                            }
                            else if (item.get_prioridad() == 3 && value < 0)
                            {
                                item.set_prioridad(2);
                            }
                        }

                    }

                    lista_camioneta = cocimundo.llenado_dinamico_(ref lista_, camioneta);
                    lista_vert_cam = cocimundo.ordenar_pordistancia(lista_camioneta, Liniers);
                    lista_recorrido_camioneta = camioneta.Reparticion_Greedy(grafo, lista_vert_cam);

                    contador_camioneta++;
                    break;
                }

                default:
                {
                    lista_camioneta_view.Items.Clear();
                    break;
                }
        }
        
    }
}

