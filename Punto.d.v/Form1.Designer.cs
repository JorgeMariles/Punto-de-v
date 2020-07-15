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
            this.components = new System.ComponentModel.Container();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.corte_menu = new System.Windows.Forms.Button();
            this.inventario_menu = new System.Windows.Forms.Button();
            this.vender_menu = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.menos = new System.Windows.Forms.Label();
            this.cuadro = new System.Windows.Forms.Label();
            this.Equis = new System.Windows.Forms.Label();
            this.panelchilds = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SidePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.inventario_menu.Click += new System.EventHandler(this.inventario_menu_Click);
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
            this.vender_menu.Click += new System.EventHandler(this.vender_menu_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TopPanel.AutoSize = true;
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
            this.menos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menos.Location = new System.Drawing.Point(1031, 9);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(21, 32);
            this.menos.TabIndex = 0;
            this.menos.Text = "_";
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // cuadro
            // 
            this.cuadro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuadro.AutoSize = true;
            this.cuadro.Location = new System.Drawing.Point(1058, 9);
            this.cuadro.Name = "cuadro";
            this.cuadro.Size = new System.Drawing.Size(18, 15);
            this.cuadro.TabIndex = 0;
            this.cuadro.Text = "❏";
            this.cuadro.Click += new System.EventHandler(this.cuadro_Click);
            // 
            // Equis
            // 
            this.Equis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Equis.AutoSize = true;
            this.Equis.Location = new System.Drawing.Point(1086, 9);
            this.Equis.Name = "Equis";
            this.Equis.Size = new System.Drawing.Size(14, 15);
            this.Equis.TabIndex = 0;
            this.Equis.Text = "X";
            this.Equis.Click += new System.EventHandler(this.Equis_Click);
            // 
            // panelchilds
            // 
            this.panelchilds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelchilds.Location = new System.Drawing.Point(137, 0);
            this.panelchilds.Name = "panelchilds";
            this.panelchilds.Size = new System.Drawing.Size(1116, 817);
            this.panelchilds.TabIndex = 15;
            this.panelchilds.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchilds_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1253, 858);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panelchilds);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SidePanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

       
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button vender_menu;
        private System.Windows.Forms.Button corte_menu;
        private System.Windows.Forms.Button inventario_menu;
        private System.Windows.Forms.Label menos;
        private System.Windows.Forms.Label cuadro;
        private System.Windows.Forms.Label Equis;
        private System.Windows.Forms.Panel panelchilds;
        public System.Windows.Forms.Timer timer1;
    }
}

