using TPfinal_LP2;

namespace tp_final;
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

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btn_recorrido = new System.Windows.Forms.Button();
            this.lista_recorridos_tabla = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.lista_furgoneta_view = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.lista_camioneta_view = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lista_prod_furgon = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.lista_prod_furgoneta = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lista_prod_camioneta = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btn_recorrido
            // 
            this.btn_recorrido.Location = new System.Drawing.Point(23, 11);
            this.btn_recorrido.Name = "btn_recorrido";
            this.btn_recorrido.Size = new System.Drawing.Size(199, 43);
            this.btn_recorrido.TabIndex = 0;
            this.btn_recorrido.Text = "RECORRIDO FURGÓN";
            this.btn_recorrido.UseVisualStyleBackColor = true;
            this.btn_recorrido.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista_recorridos_tabla
            // 
            this.lista_recorridos_tabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lista_recorridos_tabla.Location = new System.Drawing.Point(23, 60);
            this.lista_recorridos_tabla.Name = "lista_recorridos_tabla";
            this.lista_recorridos_tabla.Size = new System.Drawing.Size(199, 183);
            this.lista_recorridos_tabla.TabIndex = 1;
            this.lista_recorridos_tabla.UseCompatibleStateImageBehavior = false;
            this.lista_recorridos_tabla.View = System.Windows.Forms.View.Details;
            this.lista_recorridos_tabla.SelectedIndexChanged += new System.EventHandler(this.lista_recorridos_tabla_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Recorrido Furgón";
            this.columnHeader1.Width = 110;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "RECORRIDO FURGONETA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lista_furgoneta_view
            // 
            this.lista_furgoneta_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lista_furgoneta_view.Location = new System.Drawing.Point(282, 60);
            this.lista_furgoneta_view.Name = "lista_furgoneta_view";
            this.lista_furgoneta_view.Size = new System.Drawing.Size(214, 183);
            this.lista_furgoneta_view.TabIndex = 3;
            this.lista_furgoneta_view.UseCompatibleStateImageBehavior = false;
            this.lista_furgoneta_view.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Recorrido Furgoneta";
            this.columnHeader2.Width = 120;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "RECORRIDO CAMIONETA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lista_camioneta_view
            // 
            this.lista_camioneta_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lista_camioneta_view.Location = new System.Drawing.Point(563, 60);
            this.lista_camioneta_view.Name = "lista_camioneta_view";
            this.lista_camioneta_view.Size = new System.Drawing.Size(202, 183);
            this.lista_camioneta_view.TabIndex = 5;
            this.lista_camioneta_view.UseCompatibleStateImageBehavior = false;
            this.lista_camioneta_view.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Recorrido Camioneta";
            this.columnHeader3.Width = 130;
            // 
            // lista_prod_furgon
            // 
            this.lista_prod_furgon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lista_prod_furgon.Location = new System.Drawing.Point(23, 271);
            this.lista_prod_furgon.Name = "lista_prod_furgon";
            this.lista_prod_furgon.Size = new System.Drawing.Size(199, 167);
            this.lista_prod_furgon.TabIndex = 6;
            this.lista_prod_furgon.UseCompatibleStateImageBehavior = false;
            this.lista_prod_furgon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Productos Furgón (códigos)";
            this.columnHeader4.Width = 300;
            // 
            // lista_prod_furgoneta
            // 
            this.lista_prod_furgoneta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lista_prod_furgoneta.Location = new System.Drawing.Point(281, 271);
            this.lista_prod_furgoneta.Name = "lista_prod_furgoneta";
            this.lista_prod_furgoneta.Size = new System.Drawing.Size(215, 167);
            this.lista_prod_furgoneta.TabIndex = 7;
            this.lista_prod_furgoneta.UseCompatibleStateImageBehavior = false;
            this.lista_prod_furgoneta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Productos Furgonte (códigos)";
            this.columnHeader5.Width = 300;
            // 
            // lista_prod_camioneta
            // 
            this.lista_prod_camioneta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lista_prod_camioneta.Location = new System.Drawing.Point(563, 271);
            this.lista_prod_camioneta.Name = "lista_prod_camioneta";
            this.lista_prod_camioneta.Size = new System.Drawing.Size(202, 167);
            this.lista_prod_camioneta.TabIndex = 8;
            this.lista_prod_camioneta.UseCompatibleStateImageBehavior = false;
            this.lista_prod_camioneta.View = System.Windows.Forms.View.Details;
            this.lista_prod_camioneta.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Productos Camioneta (códigos)";
            this.columnHeader6.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista_prod_camioneta);
            this.Controls.Add(this.lista_prod_furgoneta);
            this.Controls.Add(this.lista_prod_furgon);
            this.Controls.Add(this.lista_camioneta_view);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lista_furgoneta_view);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista_recorridos_tabla);
            this.Controls.Add(this.btn_recorrido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private Button btn_recorrido;
    private ListView lista_recorridos_tabla;
    private ColumnHeader columnHeader1;
    private Button button1;
    private ListView lista_furgoneta_view;
    private ColumnHeader columnHeader2;
    private Button button2;
    private ListView lista_camioneta_view;
    private ColumnHeader columnHeader3;
    private ListView lista_prod_furgon;
    private ColumnHeader columnHeader4;
    private ListView lista_prod_furgoneta;
    private ColumnHeader columnHeader5;
    private ListView lista_prod_camioneta;
    private ColumnHeader columnHeader6;
}
