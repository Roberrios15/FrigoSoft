using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion.Reportes
{
    public partial class FormReporteVentas : Form
    {
        VentaService VentaService;
        public FormReporteVentas()
        {
            VentaService = new VentaService(ConfigConnection.connectionString);
            InitializeComponent();
            Cargar();
        }

        public DataTable PintarVentas(IList<Venta> ventas)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id Venta");
            tabla.Columns.Add("Total Venta");
            tabla.Columns.Add("Fecha Venta");

            foreach (var item in ventas)
            {
                DataRow fila = tabla.NewRow();
                fila["Id Venta"] = item.IdVenta;
                fila["Total Venta"] = string.Format(new CultureInfo("en-US"), "{0:C0}", item.TotalVenta);
                fila["Fecha Venta"] = item.FechaVenta;

                tabla.Rows.Add(fila);
            }

            return tabla;
        }

        public void Cargar()
        {
            gridVentas.DataSource = PintarVentas(VentaService.Consultar());
        }
    }
}
