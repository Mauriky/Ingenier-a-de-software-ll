using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ModeloCliente
    {
        private Conexion conexion = new Conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();

        public void Insertar(string nombre,string apellido,string rfc,string direccion,string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@rfc", rfc);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public String DameNombre(int id)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select nombre from clientes where id = " + id;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla.Rows[0]["nombre"].ToString();
            }
            catch (Exception)
            {
                return "No existe";
            }
        } 
    }
}
