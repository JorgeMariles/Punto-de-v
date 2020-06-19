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
            label3.Text = "0" + "$";
            Pago.Text = "0";
            cambiol.Text = "0" + "$";
       
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
            public string Nombre { get; set; }
            public string Unidad_Kg { get; set; }
            public string Precio { get; set; }
            public string Inventario { get; set; }
        }


        //auto completar
        public void autocomplete()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            for (int i = 0; i < Inventarioglob.Inventario.Count; i++) {
                data.Add(Inventarioglob.Inventario[i].Nombre);
            }
            textBox1.AutoCompleteCustomSource = data;
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
            // display the selected object to the listview, exclude new entries if it already exist, check price on inventary csv
            bool pivot = false;
            for (int z = 0; z < listView1.Items.Count; z++)
            {
                if (listView1.Items[z].SubItems[0].Text == textBox1.Text)
                {
                    double pre1 = Convert.ToDouble(listView1.Items[z].SubItems[2].Text) + Convert.ToDouble(cantidades.Text);
                    listView1.Items[z].SubItems[2].Text = pre1.ToString();
                    pivot = true;
                }

            }

            if (pivot == false)
            {
                ListViewItem item = new ListViewItem(textBox1.Text);
                for (int i = 0; i < Inventarioglob.Inventario.Count; i++)
                {
                    if (textBox1.Text == Inventarioglob.Inventario[i].Nombre)
                    {
                        string Price = Inventarioglob.Inventario[i].Precio;
                        item.SubItems.Add(Price);
                        break;
                    }
                }
                item.SubItems.Add(cantidades.Text);
                listView1.Items.Add(item);
            }
            //////////----------------------- Button1 clean service -------------------------
            textBox1.Clear();
            this.ActiveControl = textBox1;
            textBox1.Focus();
            cantidades.Text = "1";
            double total = 0;
            for (int x = 0; x < listView1.Items.Count; x++)
            {
                double precio = Convert.ToDouble(listView1.Items[x].SubItems[1].Text);
                double unidades = Convert.ToDouble(listView1.Items[x].SubItems[2].Text);
                total = (precio * unidades) + total;
            }
            total = Math.Round(total, 2);
            label3.Text = total.ToString() + "$";

            if (remove_unwanted(Pago.Text) != "0"& remove_unwanted(Pago.Text) != "")
            {
                double cambio = 0;
                cambio = Convert.ToDouble(Pago.Text) - total;
                if (cambio < 0)
                {
                    cambiol.Text = "0" + "$";
                }
                else
                {
                    cambio = Math.Round(cambio, 2);
                    cambiol.Text = cambio.ToString() + "$";
                }

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pago_TextChanged(object sender, EventArgs e)
        {
            //if 

            double total = Convert.ToDouble(remove_unwanted(label3.Text));

            if (remove_unwanted(Pago.Text) != "0"& remove_unwanted(Pago.Text) != "")
            {
                double cambio = 0;
                cambio = Convert.ToDouble(remove_unwanted(Pago.Text)) - total;
                if (cambio < 0)
                {
                    cambiol.Text = "0" + "$";
                }
                else
                {
                    cambio = Math.Round(cambio, 2);
                    cambiol.Text = cambio.ToString() + "$";
                }

            }


        }
        public string remove_unwanted (string s){
            string result = string.Empty;
            foreach (var c in s)
            {
                int ascii = (int)c;
                if ((ascii >= 48 && ascii <= 57) || ascii == 44 || ascii == 46)
                    result += c;
            }
            return result;
            }


    }
    
}
