using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class ModeloLicor
    {
        private Conexion conexion = new Conexion();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();
       

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarLicores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre,string paisOrigen, string sabor, string color, 
            string porcentajAlcohol, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarLicor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@pais_origen", paisOrigen);
            comando.Parameters.AddWithValue("@sabor", sabor);
            comando.Parameters.AddWithValue("@color", color);
            comando.Parameters.AddWithValue("@porcentaje_alcohol", porcentajAlcohol);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public string Stock(int id)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select stock from licores where id = " + id;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla.Rows[0]["stock"].ToString();
            }
            catch (Exception)
            {
                //Se regresa un -1 dando a entender que no existe el producto
                return "-1";
            }
        }

        public DataTable ConsultaProducto(int id)
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id,nombre,pais_origen,precio  from licores where id = " + id;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.CerrarConexion();
            return table;
        }

        public void RestarProducto(int cantidad, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update licores set stock = "+ cantidad + " where id = "+id;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
