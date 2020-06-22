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
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            textBox1.Focus();

        }
       
        private void Form2_Load_1(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "6030")
            {
                label1.Visible = false;
                // The password is ok.
                
                //Form1.inventarioopen();
            }
            else
            {
                // The password is invalid.
                textBox1.Clear();
                label1.Show();
                textBox1.Focus();
            }

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
