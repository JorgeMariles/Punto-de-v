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
using System.Threading;

namespace Punto.d.v
{
    public partial class Form4 : Form
    {
        string ruta_inv = @"C:\Punto_DV\Inventario\";
        string ruta_ventas = @"C:\Punto_DV\Ventas\";
        string inventario_csv = @"C:\Punto_DV\Inventario\Inventario.csv";
        string last_corte = @"C:\Punto_DV\Inventario\LastCorte.txt";
        public Form4()
        {
            InitializeComponent();
            autocomplete();
            this.ActiveControl = textBox1;
            textBox1.Focus();
            lista();
            string daito = "";
            using (StreamReader sr = File.OpenText(last_corte))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    daito = s;
                }
            }
            DateTime final=Convert.ToDateTime(daito).AddDays(1);     
            label7.Text = final.ToString("dd,MM,yyyy");
        }

        private void Inventario_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<SearchParameters> Inventario = getitems();
            Nombre.Text = textBox1.Text;
            for (int i = 0; i < Inventario.Count; i++)
            {
                if (Inventario[i].Nombre == textBox1.Text)
                    write(i);
            }
        }
        public List<SearchParameters> getitems()
        {

            var csvTable = new DataTable();
            using (var csvReader = new LumenWorks.Framework.IO.Csv.CsvReader(new StreamReader(System.IO.File.OpenRead(inventario_csv)), false))
            {
                csvTable.Load(csvReader);
            }
            List<SearchParameters> Inventario = new List<SearchParameters>();
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                Inventario.Add(new SearchParameters { Nombre = csvTable.Rows[i][0].ToString(), Unidad_Kg = csvTable.Rows[i][1].ToString(), Precio = csvTable.Rows[i][2].ToString(), Inventario = csvTable.Rows[i][3].ToString(), Costo = csvTable.Rows[i][4].ToString() });

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
            public string Costo { get; set; }
        }

        public void write(int i)
        {
            List<SearchParameters> Inventario = getitems();
            Costo.Text= Inventario[i].Costo;
            Precio.Text = Inventario[i].Precio;
            Unidades.Text = Inventario[i].Inventario;
            Kg_unidades.Text = Inventario[i].Unidad_Kg;
        }

        public void autocomplete()
        {
            List<SearchParameters> Inventario = getitems();
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            for (int i = 0; i < Inventario.Count; i++)
            {
                data.Add(Inventario[i].Nombre);
            }
            textBox1.AutoCompleteCustomSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<SearchParameters> Inventario = getitems();
            Nombre.Text = textBox1.Text;
            for (int i = 0; i < Inventario.Count; i++)
            {
                if (Inventario[i].Nombre == textBox1.Text)
                    write(i);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Cambio_Click(object sender, EventArgs e)
        {
            List<SearchParameters> Inventario = getitems();
            List<SearchParameters> InventarioNew = new List<SearchParameters>();
            int Cant = 0;
            double products = 0;
            for (int i = 0; i < Inventario.Count; i++)
            {
                if (Inventario[i].Nombre == Nombre.Text)
                {
                    products = Convert.ToDouble(Inventario[i].Inventario) + Convert.ToDouble(remove_unwanted(Unidades.Text));
                    InventarioNew.Add(new SearchParameters { Nombre = Nombre.Text, Precio = remove_unwanted(Precio.Text), Unidad_Kg = Kg_unidades.Text, Inventario = products.ToString(),Costo= remove_unwanted(Costo.Text) });
                }
                else
                {
                    InventarioNew.Add(new SearchParameters { Nombre = Inventario[i].Nombre, Precio = Inventario[i].Precio, Unidad_Kg = Inventario[i].Unidad_Kg, Inventario = Inventario[i].Inventario,Costo= Inventario[i].Costo });
                    Cant++;
                }

            }
            if (Cant == InventarioNew.Count)
            {
                MessageBox.Show("No se hizo ningun cambio");
            }

            else
            {
                MessageBox.Show("Cambio realizado");
            }
            InventarioNew.RemoveAt(0);

            using (var writer = new StreamWriter(inventario_csv))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(InventarioNew);
            }
            clear();
        }

        private void clear()
        {
            textBox1.Clear();
            Costo.Clear();
            Precio.Clear();
            Unidades.Clear();
            Kg_unidades.Clear();
            Nombre.Clear();
            textBox1.Clear();
            autocomplete();
            lista();
        }

        // ignore unwanted characters from number only text boxes in order to stop crashes in operations
        public string remove_unwanted(string s)
        {
            string result = string.Empty;
            foreach (var c in s)
            {
                int ascii = (int)c;
                if ((ascii >= 48 && ascii <= 57) || ascii == 44 || ascii == 46|| ascii==45)
                    result += c;
            }
            return result;
        }

        private void Unidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kg_unidades_TextChanged(object sender, EventArgs e)
        {

        }
        //eliminar elemento
        private void button4_Click(object sender, EventArgs e)
        {
            List<SearchParameters> Inventario = getitems();
            List<SearchParameters> InventarioNew = new List<SearchParameters>();
            int count = 0;
            for (int i = 0; i < Inventario.Count; i++)
            {
                if (Inventario[i].Nombre != textBox1.Text)
                {
                    InventarioNew.Add(new SearchParameters { Nombre = Inventario[i].Nombre, Precio = Inventario[i].Precio, Unidad_Kg = Inventario[i].Unidad_Kg, Inventario = Inventario[i].Inventario, Costo = Inventario[i].Costo });
                    count++;
                }
            }
            InventarioNew.RemoveAt(0);
            using (var writer = new StreamWriter(inventario_csv))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(InventarioNew);
            }
            MessageBox.Show("Elemento " + textBox1.Text + " fue" + " eliminado");
            clear();


        }

        //crear nuevo elemento
        private void button3_Click(object sender, EventArgs e)
        {
            if (Nombre.Text != "")
            {
                List<SearchParameters> Inventario = getitems();
                List<SearchParameters> InventarioNew = new List<SearchParameters>();
                for (int i = 0; i < Inventario.Count; i++)
                {
                    InventarioNew.Add(new SearchParameters { Nombre = Inventario[i].Nombre, Precio = Inventario[i].Precio, Unidad_Kg = Inventario[i].Unidad_Kg, Inventario = Inventario[i].Inventario, Costo = Inventario[i].Costo });
                }
                InventarioNew.Add(new SearchParameters { Nombre = Nombre.Text, Precio = remove_unwanted(Precio.Text), Unidad_Kg = Kg_unidades.Text, Inventario = remove_unwanted(Unidades.Text),Costo=remove_unwanted(Costo.Text) });
                InventarioNew.RemoveAt(0);
                using (var writer = new StreamWriter(inventario_csv))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(InventarioNew);
                }
                MessageBox.Show("Elemento " + textBox1.Text + " fue" + " creado");
                clear();
            }
            else
                MessageBox.Show("el elemento no pudo ser creado");
        }

        private void lista()
        {
            List<SearchParameters> Inventario = getitems();
            listView1.Items.Clear();
            for (int i = 1; i < Inventario.Count; i++)
            {
                ListViewItem item2 = new ListViewItem(Inventario[i].Nombre);
                item2.SubItems.Add(Inventario[i].Costo + " $");
                item2.SubItems.Add(Inventario[i].Precio + " $");
                item2.SubItems.Add(Inventario[i].Inventario);
                item2.SubItems.Add(Inventario[i].Unidad_Kg);
                listView1.Items.Add(item2);
            }
            listView1.View = View.Details;
            listView1.Sorting = SortOrder.Ascending;
        }
        


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string buscar = listView1.SelectedItems[0].SubItems[0].Text;
                Nombre.Text = buscar;
                List<SearchParameters> Inventario = getitems();
                for (int i = 0; i < Inventario.Count; i++)
                {
                    if (buscar == Inventario[i].Nombre)
                        write(i);
                }
                listView1.SelectedItems.Clear();
            }

        }

       
    }
    }

