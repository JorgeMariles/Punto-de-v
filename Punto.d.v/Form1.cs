using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;//instalado
using System.IO;
using System.Diagnostics;
using System.Drawing.Text;
using CsvHelper;//instalado
using System.Globalization;
using System.Runtime.InteropServices;



namespace Punto.d.v
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            openChildform(new Form3());

        }
        private Form activeform = null;
       private void openChildform(Form childfomr)
        {
            if (activeform != null)
            
                activeform.Close();
                activeform = childfomr;
                childfomr.TopLevel = false;
                childfomr.FormBorderStyle = FormBorderStyle.None;
                childfomr.Dock = DockStyle.Fill;
                panelchilds.Controls.Add(childfomr);
                panelchilds.Tag = childfomr;
                childfomr.BringToFront();
                childfomr.Show();
            
        }

       
        private void Venta_Click(object sender, EventArgs e)
        {
            openChildform(new Form3());
        }

        private void menos_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cuadro_Click(object sender, EventArgs e)
        {
           //WindowState = FormWindowState.Maximized;
        }

        private void Equis_Click(object sender, EventArgs e)
        {
            Close();
        }



        //dragable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelchilds_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
