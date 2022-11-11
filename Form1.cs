using csvfiles;
using TPfinal_LP2;

namespace tp_final;

public partial class Form1 : Form
{
    Vehiculo camion_1;
    public Form1()
    {
        InitializeComponent();
        var csv_ = new csvfiles._csv();
        List<Pedido> Pedidos = csv_.read_csv();
        
    }
}
