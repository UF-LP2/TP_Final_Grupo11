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
            this.SuspendLayout();
            // 
            // btn_recorrido
            // 
            this.btn_recorrido.Location = new System.Drawing.Point(108, 11);
            this.btn_recorrido.Name = "btn_recorrido";
            this.btn_recorrido.Size = new System.Drawing.Size(123, 43);
            this.btn_recorrido.TabIndex = 0;
            this.btn_recorrido.Text = "RECORRIDO FURGÓN";
            this.btn_recorrido.UseVisualStyleBackColor = true;
            this.btn_recorrido.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista_recorridos_tabla
            // 
            this.lista_recorridos_tabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lista_recorridos_tabla.Location = new System.Drawing.Point(108, 60);
            this.lista_recorridos_tabla.Name = "lista_recorridos_tabla";
            this.lista_recorridos_tabla.Size = new System.Drawing.Size(123, 378);
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
            this.button1.Location = new System.Drawing.Point(298, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "RECORRIDO FURGONETA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lista_furgoneta_view
            // 
            this.lista_furgoneta_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lista_furgoneta_view.Location = new System.Drawing.Point(299, 60);
            this.lista_furgoneta_view.Name = "lista_furgoneta_view";
            this.lista_furgoneta_view.Size = new System.Drawing.Size(122, 378);
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
            this.button2.Location = new System.Drawing.Point(502, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "RECORRIDO CAMIONETA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lista_camioneta_view
            // 
            this.lista_camioneta_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lista_camioneta_view.Location = new System.Drawing.Point(502, 60);
            this.lista_camioneta_view.Name = "lista_camioneta_view";
            this.lista_camioneta_view.Size = new System.Drawing.Size(122, 378);
            this.lista_camioneta_view.TabIndex = 5;
            this.lista_camioneta_view.UseCompatibleStateImageBehavior = false;
            this.lista_camioneta_view.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Recorrido Camioneta";
            this.columnHeader3.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
}
