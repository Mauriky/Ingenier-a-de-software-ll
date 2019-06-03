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
    public class ControladorLicor
    {
        private ModeloLicor objML = new ModeloLicor();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objML.Mostrar();
            return tabla;
        }

        public void Insertar(string nombre, string paisOrigen, string sabor, string color,
            string porcentajAlcohol, string precio, string stock)
        {
            double p = Convert.ToDouble(precio);
            int s = Convert.ToInt32(stock);
            objML.Insertar(nombre, paisOrigen, sabor, color, porcentajAlcohol, p, s);
        }

        public int Stock(string idProducto)
        {
            int idPro = Convert.ToInt32(idProducto);
            int stock = Convert.ToInt32(objML.Stock(idPro));
            return stock;
        }

        public DataTable ConsultaProducto(string ids)
        {
            int id = Convert.ToInt32(ids);
            return objML.ConsultaProducto(id);
        }

        public void RestarProducto(string cantidad,int stock ,string ids)
        {
            int cant = Convert.ToInt32(cantidad);
            stock -= cant;
            int id = Convert.ToInt32(ids);
            objML.RestarProducto(stock,id);
        }
    }
}
