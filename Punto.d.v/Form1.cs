using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using System.Diagnostics;

namespace Punto.d.v
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            autocomplete();
            this.ActiveControl = textBox1;
            textBox1.Focus();
            cantidades.Text = "1";
            label3.Text = "0";

        }
        //no se hacerlo de otra manera 
        static class Inventarioglob
        {
            public static List<SearchParameters> Inventario = getitems();
        }

        //lista global
        public static List<SearchParameters> getitems()
        {
            
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Inventario\Inventario.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            List<SearchParameters> Inventario = new List<SearchParameters>();
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                Inventario.Add(new SearchParameters { Nombre = csvTable.Rows[i][0].ToString(), Unidad_Kg = csvTable.Rows[i][1].ToString(), Precio = csvTable.Rows[i][2].ToString(), Inventario = csvTable.Rows[i][2].ToString() });
               
            }
            return Inventario;
        }
        //lista type
        public class SearchParameters
        {
            public string Nombre{ get; set; }
            public string Unidad_Kg { get; set; }
            public string Precio { get; set; }
            public string Inventario { get; set; }
        }


        //auto completar
        public void autocomplete()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            for(int i=0; i< Inventarioglob.Inventario.Count; i++) {
                data.Add(Inventarioglob.Inventario[i].Nombre);
            }
            textBox1.AutoCompleteCustomSource = data;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            ListViewItem item = new ListViewItem(textBox1.Text);
            for (int i = 0; i < Inventarioglob.Inventario.Count; i++) {
                if (textBox1.Text == Inventarioglob.Inventario[i].Nombre)
                {
                    string Price = Inventarioglob.Inventario[i].Precio;
                    item.SubItems.Add(Price);
                    break;
                }
            }
            item.SubItems.Add(cantidades.Text);
            listView1.Items.Add(item);
            textBox1.Clear();
            this.ActiveControl = textBox1;
            textBox1.Focus();
            cantidades.Text = "1";
            //label3.Text = 

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
