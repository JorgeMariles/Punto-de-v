namespace Punto.d.v
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inventario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Unidades = new System.Windows.Forms.TextBox();
            this.Kg_unidades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cambio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.agregarlabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.Costo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inventario
            // 
            this.Inventario.AutoSize = true;
            this.Inventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Inventario.Location = new System.Drawing.Point(140, 80);
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(56, 21);
            this.Inventario.TabIndex = 0;
            this.Inventario.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(109, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Nombre.Location = new System.Drawing.Point(273, 103);
            this.Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(110, 23);
            this.Nombre.TabIndex = 2;
            // 
            // Unidades
            // 
            this.Unidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Unidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Unidades.Location = new System.Drawing.Point(621, 103);
            this.Unidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(110, 23);
            this.Unidades.TabIndex = 5;
            this.Unidades.TextChanged += new System.EventHandler(this.Unidades_TextChanged);
            // 
            // Kg_unidades
            // 
            this.Kg_unidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Kg_unidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Kg_unidades.Location = new System.Drawing.Point(737, 103);
            this.Kg_unidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kg_unidades.Name = "Kg_unidades";
            this.Kg_unidades.Size = new System.Drawing.Size(110, 23);
            this.Kg_unidades.TabIndex = 6;
            this.Kg_unidades.TextChanged += new System.EventHandler(this.Kg_unidades_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(293, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // Precio
            // 
            this.Precio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Precio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Precio.Location = new System.Drawing.Point(505, 103);
            this.Precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(110, 23);
            this.Precio.TabIndex = 4;
            this.Precio.TextChanged += new System.EventHandler(this.Precio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(535, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(737, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kg o Unidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(637, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unidades ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Cambio
            // 
            this.Cambio.BackColor = System.Drawing.Color.GreenYellow;
            this.Cambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cambio.Location = new System.Drawing.Point(882, 91);
            this.Cambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(86, 43);
            this.Cambio.TabIndex = 2;
            this.Cambio.TabStop = false;
            this.Cambio.Text = "Hacer cambio";
            this.Cambio.UseVisualStyleBackColor = false;
            this.Cambio.Click += new System.EventHandler(this.Cambio_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(996, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(-1, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 5);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // agregarlabel
            // 
            this.agregarlabel.Location = new System.Drawing.Point(0, 0);
            this.agregarlabel.Name = "agregarlabel";
            this.agregarlabel.Size = new System.Drawing.Size(100, 23);
            this.agregarlabel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GreenYellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(882, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 42);
            this.button3.TabIndex = 7;
            this.button3.TabStop = false;
            this.button3.Text = "Crear nuevo elemento";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(996, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 8;
            this.button4.TabStop = false;
            this.button4.Text = "Eliminar elemento";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidades Disp";
            this.columnHeader3.Width = 100;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(208, 261);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(704, 544);
            this.listView1.TabIndex = 0;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Costo";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kg o Unidades";
            this.columnHeader4.Width = 100;
            // 
            // Costo
            // 
            this.Costo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Costo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Costo.Location = new System.Drawing.Point(389, 103);
            this.Costo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(110, 23);
            this.Costo.TabIndex = 3;
            this.Costo.TextChanged += new System.EventHandler(this.Precio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(419, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Costo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "ULTIMO DIA DE CORTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(43, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1116, 817);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.agregarlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kg_unidades);
            this.Controls.Add(this.Unidades);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Inventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Precio";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inventario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Unidades;
        private System.Windows.Forms.TextBox Kg_unidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cambio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label agregarlabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}