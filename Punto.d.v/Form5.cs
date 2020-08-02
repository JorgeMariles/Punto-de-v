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
    public partial class Form5 : Form
    {
        string ruta_inv = @"C:\Punto_DV\Inventario\";
        string ruta_ventas = @"C:\Punto_DV\Ventas\";
        string inventario_csv = @"C:\Punto_DV\Inventario\Inventario.csv";
        string last_corte = @"C:\Punto_DV\Inventario\LastCorte.txt";
        public Form5()
        {
            InitializeComponent();
            createlista(fecha());
            corte();
        }

        public void corte()
        {
            string daito = "";
            using (StreamReader sr = File.OpenText(last_corte))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    daito = s;
                }
            }
                    List<SearchParameters> inventario = getitems();
                    foreach (DateTime day in EachDay(Convert.ToDateTime(daito), Convert.ToDateTime(fecha()))) 
                    {
                        List<VentaParameters> ventas = getventas(day.ToString(("dd,MM,yyyy")));
                        
                        for (int i = 0; i < ventas.Count; i++)
                        {
                            if (ventas[i].corte== "false")
                            {
                                for (int x = 0; x < inventario.Count; x++)
                                {
                                    if (ventas[i].Nombre == inventario[x].Nombre)
                                    {
                                        inventario[x].Inventario = (Convert.ToDouble(inventario[x].Inventario) - Convert.ToDouble(ventas[i].Cantidades)).ToString();
                                    }
                                }
                                ventas[i].corte = "true";
                            }
                        }

                        ventas.RemoveAt(0);
                        using (var writer = new StreamWriter(ruta_ventas + day.ToString(("dd,MM,yyyy")) + ".csv"))
                        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csv.WriteRecords(ventas);
                        }

                    }
                    inventario.RemoveAt(0);
                    using (var writer = new StreamWriter(inventario_csv))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(inventario);
                    }

                //File.Create(last_corte).Close();
                DateTime yest = DateTime.Today.AddDays(0);

                using (StreamWriter sw = File.CreateText(last_corte))
                {
                    sw.WriteLine(yest.ToString("dd,MM,yyyy"));
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
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        static string fecha()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string date = dateTime.ToString("dd,MM,yyyy");
            return date;
        }

        //venta lista
        public class VentaParameters
        {
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public string Cantidades { get; set; }
            public string Costo { get; set; }
            public string hora { get; set; }
            public string corte { get; set; }

        }


        public List<VentaParameters> getventas(string fecha)
        {

            //search if day exist
            string[] FilesVenta = Directory.GetFiles(ruta_ventas);
            List<VentaParameters> ventas = new List<VentaParameters>();
            int count = 0;
            foreach (string Filename in FilesVenta)
            {
                if (Filename == ruta_ventas + fecha + ".csv")
                {
                    var csvTable = new DataTable();
                    using (var csvReader = new LumenWorks.Framework.IO.Csv.CsvReader(new StreamReader(System.IO.File.OpenRead(ruta_ventas + fecha + ".csv")), false))
                    {
                        csvTable.Load(csvReader);
                    }

                    for (int i = 0; i < csvTable.Rows.Count; i++)
                    {
                        ventas.Add(new VentaParameters { Nombre = csvTable.Rows[i][0].ToString(), Precio = csvTable.Rows[i][1].ToString(), Cantidades = csvTable.Rows[i][2].ToString(), Costo = csvTable.Rows[i][3].ToString(), hora = csvTable.Rows[i][4].ToString(), corte = csvTable.Rows[i][5].ToString() });

                    }
                }
                else
                    count++;

            }
            if (count == FilesVenta.Length)
            {
                List<VentaParameters> ventasinicial = new List<VentaParameters>();
                using (var writer = new StreamWriter(ruta_ventas + fecha + ".csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(ventasinicial);
                }
            }
            return ventas;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           string date=monthCalendar1.SelectionRange.Start.ToString("dd,MM,yyyy");
            createlista(date);
        }

        private void createlista(string fecha)
        {
            List<VentaParameters> ventas = getventas(fecha);
            listView1.Items.Clear();
            double total = 0;
            double plusvalor = 0;
            for (int i = 1; i < ventas.Count; i++)
            {
                ListViewItem item3 = new ListViewItem(ventas[i].Nombre);
                item3.SubItems.Add(ventas[i].Precio + " $");
                item3.SubItems.Add(ventas[i].Costo + " $");
                item3.SubItems.Add(ventas[i].Cantidades);
                item3.SubItems.Add(ventas[i].hora);
                item3.SubItems.Add(ventas[i].corte);
                listView1.Items.Add(item3);
                total = total + (Convert.ToDouble(ventas[i].Precio) * Convert.ToDouble(ventas[i].Cantidades));
                plusvalor = plusvalor + (Convert.ToDouble(ventas[i].Precio) * Convert.ToDouble(ventas[i].Cantidades) - (Convert.ToDouble(ventas[i].Costo) * Convert.ToDouble(ventas[i].Cantidades)));
                
            }
            totallab.Text = total.ToString()+" $";
            gain.Text = plusvalor.ToString()+ "$";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
