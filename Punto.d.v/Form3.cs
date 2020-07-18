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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            autocomplete();
            this.ActiveControl = textBox1;
            textBox1.Focus();
            cantidades.Text = "1";
            label3.Text = "0" + "$";
            Pago.Text = "0";
            cambiol.Text = "0" + "$";
            getventas(fecha());
        }
        static string fecha()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string date = dateTime.ToString("dd,MM,yyyy");
            
            return date;
        }
        //lista get lista
        public List<SearchParameters> getitems()
        {

            var csvTable = new DataTable();
            using (var csvReader = new LumenWorks.Framework.IO.Csv.CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Inventario\Inventario.csv")), false))
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

        //venta lista
        public class VentaParameters
        {
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public string Cantidades { get; set; }
            public string Costo { get; set; }
            
        }
      
        public List<VentaParameters> getventas(string fecha)
        {
            //search if day exist
            string[] FilesVenta = Directory.GetFiles(@"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Ventas");
            List<VentaParameters> ventas = new List<VentaParameters>();
            int count = 0;
            foreach(string Filename in FilesVenta)
            {
                if (Filename == fecha)
                {
                    var csvTable = new DataTable();
                    using (var csvReader = new LumenWorks.Framework.IO.Csv.CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Ventas\" + fecha + ".csv")), false))
                    {
                        csvTable.Load(csvReader);
                    }
                    
                    for (int i = 0; i < csvTable.Rows.Count; i++)
                    {
                        ventas.Add(new VentaParameters { Nombre = csvTable.Rows[i][0].ToString(), Precio = csvTable.Rows[i][1].ToString(), Cantidades = csvTable.Rows[i][2].ToString(), Costo = csvTable.Rows[i][3].ToString() });

                    }
                }
                else
                  count++;

            }
            if (count == FilesVenta.Length)
            {
                List<VentaParameters> ventasinicial = new List<VentaParameters>();
                using (var writer = new StreamWriter(@"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Ventas\" + fecha+ ".csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(ventasinicial);
                }
            }
            return ventas;
        }

        //auto completar
        // Inventario.Count;
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
            if (Convert.ToDouble(remove_unwanted(Pago.Text)) >= Convert.ToDouble(remove_unwanted(label3.Text)) & listView1.Items.Count > 0)
            {
                List<VentaParameters> Venta = new List<VentaParameters>();
                for (int x = 0; x < listView1.Items.Count; x++)
                {

                    List<SearchParameters> Inventario = getitems();
                    List<SearchParameters> InventarioNew = new List<SearchParameters>();
                    for (int i = 0; i < Inventario.Count; i++)
                    {
                        if (Inventario[i].Nombre == listView1.Items[x].SubItems[0].Text)
                        {
                            double num = Convert.ToDouble(Inventario[i].Inventario) - Convert.ToDouble(listView1.Items[x].SubItems[2].Text);
                            InventarioNew.Add(new SearchParameters { Nombre = Inventario[i].Nombre, Precio = Inventario[i].Precio, Unidad_Kg = Inventario[i].Unidad_Kg, Inventario = num.ToString(), Costo = Inventario[i].Costo });
                        }
                        else
                        {
                            InventarioNew.Add(new SearchParameters { Nombre = Inventario[i].Nombre, Precio = Inventario[i].Precio, Unidad_Kg = Inventario[i].Unidad_Kg, Inventario = Inventario[i].Inventario, Costo = Inventario[i].Costo });
                        }
                    }

                    InventarioNew.RemoveAt(0);

                    using (var writer = new StreamWriter(@"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Inventario\Inventario.csv"))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(InventarioNew);
                    }

                }
                MessageBox.Show("Venta Exitosa");
                Limpiaservice();


            }
            else if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Ingrese productos");

            }
            else
            {
                MessageBox.Show("Ingrese pago");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            if (textBox1.Text != "")
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
                        encontrado = true;
                    }
                }

                if (pivot == false)
                {
                    List<SearchParameters> Inventario = getitems();
                    ListViewItem item = new ListViewItem(textBox1.Text);
                    for (int i = 0; i < Inventario.Count; i++)
                    {
                        if (textBox1.Text == Inventario[i].Nombre)
                        {
                            string Price = Inventario[i].Precio;
                            item.SubItems.Add(Price);
                            encontrado = true;
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
                if (encontrado == true)
                {
                    totalncambio();

                }
                else
                {
                    listView1.Items.RemoveAt(listView1.Items.Count - 1);
                    MessageBox.Show("Ingrese producto valido");
                }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void cantidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void cambiarC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Pago_TextChanged(object sender, EventArgs e)
        {

            double total = Convert.ToDouble(remove_unwanted(label3.Text));
            if (remove_unwanted(Pago.Text) != "0" & remove_unwanted(Pago.Text) != "")
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

        // ignore unwanted characters from number only text boxes in order to stop crashes in operations
        public string remove_unwanted(string s)
        {
            string result = string.Empty;
            foreach (var c in s)
            {
                int ascii = (int)c;
                if ((ascii >= 48 && ascii <= 57) || ascii == 44 || ascii == 46)
                    result += c;
            }
            return result;
        }

        //changes value from item selected 
        private void cambiarC_TextChanged(object sender, EventArgs e)
        {
            if (remove_unwanted(cambiarC.Text) != "" & listView1.SelectedItems.Count > 0 & remove_unwanted(cambiarC.Text) != ".")
            {
                double num = Convert.ToDouble(remove_unwanted(cambiarC.Text));
                listView1.SelectedItems[0].SubItems[2].Text = num.ToString();
            }
            if (remove_unwanted(cambiarC.Text) == "" & listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[2].Text = "0";
            }
            totalncambio();
        }
        //total and chenge service routine 
        private void totalncambio()
        {
            double total = 0;
            for (int x = 0; x < listView1.Items.Count; x++)
            {
                double precio = Convert.ToDouble(listView1.Items[x].SubItems[1].Text);
                double unidades = Convert.ToDouble(listView1.Items[x].SubItems[2].Text);
                total = (precio * unidades) + total;
            }
            total = Math.Round(total, 2);
            label3.Text = total.ToString() + "$";

            if (remove_unwanted(Pago.Text) != "0" & remove_unwanted(Pago.Text) != "")
            {
                double cambio = 0;
                cambio = Convert.ToDouble(Pago.Text) - total;
                if (cambio <= 0)
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


        private void Limpiar_Click(object sender, EventArgs e)
        {
            Limpiaservice();
        }

        public void Limpiaservice()
        {
            cambiarC.Text = "0";
            listView1.Items.Clear();
            this.ActiveControl = textBox1;
            textBox1.Focus();
            cantidades.Text = "1";
            label3.Text = "0" + "$";
            Pago.Text = "0";
            cambiol.Text = "0" + "$";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
    
}
