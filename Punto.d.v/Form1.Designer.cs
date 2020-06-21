namespace Punto.d.v
{
    public partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.cantidades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cambiol = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cambiarC = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.corte_menu = new System.Windows.Forms.Button();
            this.inventario_menu = new System.Windows.Forms.Button();
            this.vender_menu = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.menos = new System.Windows.Forms.Label();
            this.cuadro = new System.Windows.Forms.Label();
            this.Equis = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(543, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vender";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(207, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 27);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(737, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 481);
            this.listView1.TabIndex = 0;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidades/Kg";
            this.columnHeader3.Width = 100;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cantidades
            // 
            this.cantidades.Location = new System.Drawing.Point(391, 101);
            this.cantidades.Name = "cantidades";
            this.cantidades.Size = new System.Drawing.Size(81, 27);
            this.cantidades.TabIndex = 2;
            this.cantidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidades_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidades/Kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(636, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "0$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(571, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pago";
            // 
            // Pago
            // 
            this.Pago.Location = new System.Drawing.Point(342, 186);
            this.Pago.Name = "Pago";
            this.Pago.Size = new System.Drawing.Size(125, 27);
            this.Pago.TabIndex = 4;
            this.Pago.TextChanged += new System.EventHandler(this.Pago_TextChanged);
            this.Pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pago_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(541, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cambio:";
            // 
            // cambiol
            // 
            this.cambiol.AutoSize = true;
            this.cambiol.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cambiol.ForeColor = System.Drawing.Color.Black;
            this.cambiol.Location = new System.Drawing.Point(636, 189);
            this.cambiol.Name = "cambiol";
            this.cambiol.Size = new System.Drawing.Size(38, 31);
            this.cambiol.TabIndex = 7;
            this.cambiol.Text = "0$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(755, 595);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cambiar cantidad";
            // 
            // cambiarC
            // 
            this.cambiarC.Location = new System.Drawing.Point(946, 599);
            this.cambiarC.Name = "cambiarC";
            this.cambiarC.Size = new System.Drawing.Size(125, 27);
            this.cambiarC.TabIndex = 0;
            this.cambiarC.TabStop = false;
            this.cambiarC.TextChanged += new System.EventHandler(this.cambiarC_TextChanged);
            this.cambiarC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cambiarC_KeyPress);
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.OrangeRed;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.Location = new System.Drawing.Point(1103, 586);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(120, 47);
            this.Limpiar.TabIndex = 0;
            this.Limpiar.TabStop = false;
            this.Limpiar.Text = "Limpiar Lista";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SidePanel.Controls.Add(this.corte_menu);
            this.SidePanel.Controls.Add(this.inventario_menu);
            this.SidePanel.Controls.Add(this.vender_menu);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(137, 858);
            this.SidePanel.TabIndex = 13;
            // 
            // corte_menu
            // 
            this.corte_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.corte_menu.FlatAppearance.BorderSize = 0;
            this.corte_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.corte_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.corte_menu.Location = new System.Drawing.Point(0, 164);
            this.corte_menu.Name = "corte_menu";
            this.corte_menu.Size = new System.Drawing.Size(137, 69);
            this.corte_menu.TabIndex = 0;
            this.corte_menu.TabStop = false;
            this.corte_menu.Text = "CORTE";
            this.corte_menu.UseVisualStyleBackColor = false;
            this.corte_menu.Click += new System.EventHandler(this.Venta_Click);
            // 
            // inventario_menu
            // 
            this.inventario_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.inventario_menu.FlatAppearance.BorderSize = 0;
            this.inventario_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventario_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventario_menu.Location = new System.Drawing.Point(0, 99);
            this.inventario_menu.Name = "inventario_menu";
            this.inventario_menu.Size = new System.Drawing.Size(137, 69);
            this.inventario_menu.TabIndex = 0;
            this.inventario_menu.TabStop = false;
            this.inventario_menu.Text = "INVENTARIO";
            this.inventario_menu.UseVisualStyleBackColor = false;
            this.inventario_menu.Click += new System.EventHandler(this.Venta_Click);
            // 
            // vender_menu
            // 
            this.vender_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.vender_menu.FlatAppearance.BorderSize = 0;
            this.vender_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vender_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vender_menu.Location = new System.Drawing.Point(0, 38);
            this.vender_menu.Name = "vender_menu";
            this.vender_menu.Size = new System.Drawing.Size(137, 69);
            this.vender_menu.TabIndex = 0;
            this.vender_menu.TabStop = false;
            this.vender_menu.Text = "VENDER";
            this.vender_menu.UseVisualStyleBackColor = false;
            this.vender_menu.Click += new System.EventHandler(this.Venta_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(129)))), ((int)(((byte)(49)))));
            this.TopPanel.Controls.Add(this.menos);
            this.TopPanel.Controls.Add(this.cuadro);
            this.TopPanel.Controls.Add(this.Equis);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(137, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1116, 41);
            this.TopPanel.TabIndex = 14;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // menos
            // 
            this.menos.Location = new System.Drawing.Point(1031, 9);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(21, 32);
            this.menos.TabIndex = 0;
            this.menos.Text = "_";
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // cuadro
            // 
            this.cuadro.AutoSize = true;
            this.cuadro.Location = new System.Drawing.Point(1058, 9);
            this.cuadro.Name = "cuadro";
            this.cuadro.Size = new System.Drawing.Size(22, 20);
            this.cuadro.TabIndex = 0;
            this.cuadro.Text = "❏";
            this.cuadro.Click += new System.EventHandler(this.cuadro_Click);
            // 
            // Equis
            // 
            this.Equis.AutoSize = true;
            this.Equis.Location = new System.Drawing.Point(1086, 9);
            this.Equis.Name = "Equis";
            this.Equis.Size = new System.Drawing.Size(18, 20);
            this.Equis.TabIndex = 0;
            this.Equis.Text = "X";
            this.Equis.Click += new System.EventHandler(this.Equis_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1253, 858);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.cambiarC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cambiol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidades);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox cantidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cambiol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cambiarC;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button vender_menu;
        private System.Windows.Forms.Button corte_menu;
        private System.Windows.Forms.Button inventario_menu;
        private System.Windows.Forms.Label menos;
        private System.Windows.Forms.Label cuadro;
        private System.Windows.Forms.Label Equis;
    }
}

