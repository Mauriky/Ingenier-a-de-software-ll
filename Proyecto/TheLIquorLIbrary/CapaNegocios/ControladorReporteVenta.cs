using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocios
{
    public class ControladorReporteVenta
    {
        private ModeloReporteVenta objRV = new ModeloReporteVenta();
        DataTable tabla = new DataTable();
        public void InsertarVenta(string formatoPago,string cliente_id)
        {
            DateTime fecha = DateTime.Today;
            int id = Convert.ToInt32(cliente_id);
            objRV.InsertarVenta(formatoPago,fecha.ToString(),id);
        }

        public void InsertarDetalleVenta(string cantidad,string licor_id,string venta_id)
        {
            int cant = Convert.ToInt32(cantidad);
            int licor = Convert.ToInt32(licor_id);
            int venta = Convert.ToInt32(venta_id);
            objRV.InsertarDetalleVenta(cant, licor, ++venta);
        }

        public string DameFolio()
        {
            return objRV.DameFolio();
        }

    }
}
