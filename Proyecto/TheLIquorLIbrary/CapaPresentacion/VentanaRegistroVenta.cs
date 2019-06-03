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
using System.Data;

namespace CapaPresentacion
{
    public partial class VentanaRegistroVenta : Form
    {
        private ControladorReporteVenta objCRV = new ControladorReporteVenta();
        private int posicion;
        
        public VentanaRegistroVenta()
        {
            InitializeComponent();
        }

        private void txtClienteID_Enter(object sender, EventArgs e)
        {
            if (txtClienteID.Text == "Ingresa ID")
            {
                txtClienteID.Text = "";
                txtClienteID.ForeColor = Color.Black;
            }
        }

        private void txtClienteID_Leave(object sender, EventArgs e)
        {
            if (txtClienteID.Text == "")
            {
                txtClienteID.Text = "Ingresa ID";
                txtClienteID.ForeColor = Color.LightGray;
            }
        }

        private void txtLicorID_Enter(object sender, EventArgs e)
        {
            if(txtLicorID.Text == "Ingresa ID")
            {
                txtLicorID.Text = "";
                txtLicorID.ForeColor = Color.Black;
            }
        }

        private void txtLicorID_Leave(object sender, EventArgs e)
        {
            if(txtLicorID.Text == "")
            {
                txtLicorID.Text = "Ingresa ID";
                txtLicorID.ForeColor = Color.LightGray;
            }
        }

        private void btnFijarCliente_Click(object sender, EventArgs e)
        {
            if (txtClienteID.Text != "Ingresa ID") {
                ControladorCliente objCC = new ControladorCliente();
                string nombre = objCC.DameNombre(txtClienteID.Text);
                if (nombre != "No existe")
                {
                    txtNombre.Text = nombre;
                    MessageBox.Show("CLIENTE FIJADO");
                }
                else
                {
                    MessageBox.Show(nombre + " el cliente con id " + txtClienteID.Text);
                }
            }
            else
            {
                MessageBox.Show("INGRESA EL ID DEL CLIENTE");
            }
        }

        private void btnAgregarLicor_Click(object sender, EventArgs e)
        {
            if (txtLicorID.Text != "Ingresa ID")
            {
                ControladorLicor objCL = new ControladorLicor();
                int stock = objCL.Stock(txtLicorID.Text);
                int cantidad = Convert.ToInt32(nUpDown.Value);
                if (stock != -1)
                {
                    if (cantidad > stock)
                    {
                        MessageBox.Show("SOLO EXISTEN " + stock + " EN ALMACEN");
                    }
                    else
                    {
                        if (ExisteProductoDGV())
                        {
                            cantidad+=Convert.ToInt32(dGV.Rows[posicion].Cells[4].Value.ToString());
                            if (cantidad > stock)
                            {
                                MessageBox.Show("YA NO HAY MÁS PRODUCTO EN EXISTENCIA");
                            }
                            else
                            {
                                dGV.Rows[posicion].Cells[4].Value = cantidad;
                            }
                        }
                        else
                        {
                            AgregarDatosDGV(objCL,cantidad);
                        }
                        txtLicorID.Text = "Ingresa ID";
                        txtLicorID.ForeColor = Color.LightGray;
                    }
                }
                else if (stock == 0)
                {
                    MessageBox.Show("YA NO HAY EN EXISTENCIA");
                }
                else
                {
                    MessageBox.Show("EL PRODUCTO CON EL ID [" + txtLicorID.Text + "] NO EXISTE");
                }
            }
            else
            {
                MessageBox.Show("INGRESA ID DEL PRODUCTO");
            }
        }

        private Boolean ExisteProductoDGV()
        {
            Boolean existe = false;
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                if (txtLicorID.Text == dGV.Rows[i].Cells[0].Value.ToString())
                {
                    existe = true;
                    posicion = i;
                }
            }
            return existe;
        }

        private void AgregarDatosDGV(ControladorLicor objCL, int cantidad)
        {
            DataTable tabla = new DataTable();
            tabla = objCL.ConsultaProducto(txtLicorID.Text);
            //agregamos un nuevo renglon al dataGridView
            int n = dGV.Rows.Add();
            //Ingresamos la información
            dGV.Rows[n].Cells[0].Value = tabla.Rows[0]["id"].ToString();
            dGV.Rows[n].Cells[1].Value = tabla.Rows[0]["nombre"].ToString();
            dGV.Rows[n].Cells[2].Value = tabla.Rows[0]["pais_origen"].ToString();
            dGV.Rows[n].Cells[3].Value = tabla.Rows[0]["precio"].ToString();
            dGV.Rows[n].Cells[4].Value = cantidad.ToString();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (dGV.RowCount!=1)
                {
                    if (comboBox1.Text != "...")
                    {
                        string formato = comboBox1.SelectedItem.ToString();
                        string licor_id, cantidad;
                        string venta_id = objCRV.DameFolio();                       
                        objCRV.InsertarVenta(formato, txtClienteID.Text);
                        for (int i = 0; i < dGV.RowCount - 1; i++)
                        {
                            ControladorLicor licor = new ControladorLicor();
                            licor_id = dGV.Rows[i].Cells[0].Value.ToString();
                            cantidad = dGV.Rows[i].Cells[4].Value.ToString();
                            objCRV.InsertarDetalleVenta(cantidad, licor_id, venta_id);
                            licor.RestarProducto(cantidad,licor.Stock(licor_id),licor_id);
                        }
                        MessageBox.Show("VENTA REALIZADA CORRECTAMENTE");
                    }
                    else
                    {
                        MessageBox.Show("INGRESE UNA FORMA DE PAGO");
                    }
                }
                else
                {
                    MessageBox.Show("INGRESE PRODUCTOS PARA LA VENTA");
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN CLIENTE A LA VENTA");
            }
        }
        
    }
}
