using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class VentanaRegistroCliente : Form
    {
        ControladorCliente objCC;
        public VentanaRegistroCliente()
        {
            InitializeComponent();
        }

        private void VentanaRegistroCliente_Load(object sender, EventArgs e)
        {
            objCC = new ControladorCliente();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtRFC.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                objCC.Insertar(txtNombre.Text,txtApellido.Text,txtRFC.Text,
                    txtDireccion.Text,txtCorreo.Text);
                MessageBox.Show("Se insertó correctamente");
                LimpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los datos correspondientes");
            }

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                errorP.SetError(txtNombre, "Ingresa un nombre");
                txtNombre.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellido.Text.Trim() == "")
            {
                errorP.SetError(txtApellido, "Ingresa un apellido");
                txtApellido.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtRFC_Validating(object sender, CancelEventArgs e)
        {
            if (txtRFC.Text.Trim() == "")
            {
                errorP.SetError(txtRFC, "Ingresa un RFC");
                txtRFC.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

       

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {
                errorP.SetError(txtDireccion, "Ingresa una dirección");
                txtDireccion.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                errorP.SetError(txtCorreo, "Ingresa un E-mail");
                txtCorreo.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }
    }
}
