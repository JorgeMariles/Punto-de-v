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
            this.SuspendLayout();
            // 
            // Inventario
            // 
            this.Inventario.AutoSize = true;
            this.Inventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Inventario.Location = new System.Drawing.Point(115, 107);
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(68, 28);
            this.Inventario.TabIndex = 0;
            this.Inventario.Text = "Buscar";
            this.Inventario.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(83, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Nombre.Location = new System.Drawing.Point(254, 138);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(125, 27);
            this.Nombre.TabIndex = 1;
            this.Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Unidades
            // 
            this.Unidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Unidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Unidades.Location = new System.Drawing.Point(516, 138);
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(125, 27);
            this.Unidades.TabIndex = 1;
            this.Unidades.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Kg_unidades
            // 
            this.Kg_unidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Kg_unidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Kg_unidades.Location = new System.Drawing.Point(647, 138);
            this.Kg_unidades.Name = "Kg_unidades";
            this.Kg_unidades.Size = new System.Drawing.Size(125, 27);
            this.Kg_unidades.TabIndex = 1;
            this.Kg_unidades.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // Precio
            // 
            this.Precio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Precio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Precio.Location = new System.Drawing.Point(385, 138);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(125, 27);
            this.Precio.TabIndex = 1;
            this.Precio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(412, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio";
            this.label2.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(647, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kg o unidades";
            this.label3.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(527, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unidades";
            this.label4.Click += new System.EventHandler(this.Inventario_Click);
            // 
            // Cambio
            // 
            this.Cambio.BackColor = System.Drawing.Color.GreenYellow;
            this.Cambio.Location = new System.Drawing.Point(790, 131);
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(123, 41);
            this.Cambio.TabIndex = 2;
            this.Cambio.Text = "Hacer cambio";
            this.Cambio.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(930, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 811);
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
            this.Name = "Form4";
            this.Text = "Precio";
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
    }
}