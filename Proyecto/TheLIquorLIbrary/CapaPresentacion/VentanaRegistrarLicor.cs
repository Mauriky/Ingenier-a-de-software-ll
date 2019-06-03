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
    public partial class VentanaRegistrarLicor : Form
    {
        private ControladorLicor objCL;
        public VentanaRegistrarLicor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objCL = new ControladorLicor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                objCL.Insertar(txtNombre.Text, txtPaisOrigen.Text, txtSabor.Text,
                    txtColor.Text, txtAlcohol.Text, txtPrecio.Text, txtStock.Text);
                MessageBox.Show("Se insertó correctamente");
                LimpiarCampos();
            }catch(Exception )
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPaisOrigen.Clear();
            txtColor.Clear();
            txtAlcohol.Clear();
            txtPrecio.Clear();
            txtSabor.Clear();
            txtStock.Clear();
        }

        private void txtPaisOrigen_Validating(object sender, CancelEventArgs e)
        {
            if(txtPaisOrigen.Text.Trim() == "")
            {
                errorP.SetError(txtPaisOrigen, "Ingresa un país de origen");
                txtPaisOrigen.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtSabor_Validating(object sender, CancelEventArgs e)
        {
            if(txtSabor.Text.Trim() == "")
            {
                errorP.SetError(txtSabor, "Ingresa un sabor");
                txtSabor.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtColor_Validating(object sender, CancelEventArgs e)
        {
            if(txtColor.Text.Trim() == "")
            {
                errorP.SetError(txtColor, "Ingrese un color");
                txtColor.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtAlcohol_Validating(object sender, CancelEventArgs e)
        {
            if(txtAlcohol.Text.Trim() == "")
            {
                errorP.SetError(txtAlcohol, "Ingrese el % de alcohol");
                txtAlcohol.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if(txtPrecio.Text.Trim() == "")
            {
                errorP.SetError(txtPrecio,"Ingresa el precio");
                txtPrecio.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            if(txtStock.Text.Trim() == "")
            {
                errorP.SetError(txtStock, "Ingresa el stock");
                txtStock.Focus();
            }
            else
            {
                errorP.Clear();
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
    }
}
