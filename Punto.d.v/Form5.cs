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
        public Form5()
        {
            InitializeComponent();
            createlista(fecha());
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

        }

        public List<VentaParameters> getventas(string fecha)
        {
            //search if day exist
            string[] FilesVenta = Directory.GetFiles(@"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Ventas");
            List<VentaParameters> ventas = new List<VentaParameters>();
            int count = 0;
            foreach (string Filename in FilesVenta)
            {
                if (Filename == @"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Ventas\" + fecha + ".csv")
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
                using (var writer = new StreamWriter(@"C:\Users\monit\Documents\GitHub\Punto-de-v\Punto.d.v\Ventas\" + fecha + ".csv"))
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
    }
}
