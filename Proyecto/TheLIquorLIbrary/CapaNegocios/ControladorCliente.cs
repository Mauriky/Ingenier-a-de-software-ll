using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocios
{
    public class ControladorCliente
    {
        private ModeloCliente objMC = new ModeloCliente();

        public void Insertar(string nombre, string apellido, string rfc, string direccion, string email)
        {
            objMC.Insertar(nombre, apellido, rfc, direccion, email);
        }

        public string DameNombre(string ids)
        {
            int id = Convert.ToInt32(ids);
            return objMC.DameNombre(id);
        }
    }
}
