using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ModeloReporteVenta
    {
        private Conexion conexion = new Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public void InsertarVenta(string formatoPago, string fecha, int cliente_id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@formatoPago", fecha);
            comando.Parameters.AddWithValue("@fecha", formatoPago);
            comando.Parameters.AddWithValue("@cliente_id", cliente_id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarDetalleVenta(int cantidad,int licor_id,int venta_id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarLicorVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@licor_id", licor_id);
            comando.Parameters.AddWithValue("@venta_id", venta_id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public string DameFolio()
        {
            try
            {
                DataTable table = new DataTable();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select id  from ventas";
                leer = comando.ExecuteReader();
                table.Load(leer);
                conexion.CerrarConexion();
                return table.Rows[0]["id"].ToString();
            }
            catch (Exception)
            {
                return "0";
            }
        }
    }
}
