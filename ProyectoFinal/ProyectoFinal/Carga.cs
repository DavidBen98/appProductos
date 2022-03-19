using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreria_lacteos;

namespace ProyectoFinal
{
    public partial class FCarga : Form
    {
        public string nombre , estado, tipo, proveedor;
        public int codigo;
        public DateTime fecha;
        public double peso, precio;
        public bool esNacional;
        public List<string> lista;

        public FCarga()
        {
            InitializeComponent();
            dtFecha.MinDate = DateTime.Today;
        }
        private void Lacteos_Load(object sender, EventArgs e)
        {
            cbProveedores.Items.Clear();
            foreach (string nombre in lista)
                cbProveedores.Items.Add(nombre); 

            if (estado == "Agregar")
            {
                Text = "Nuevo..";
                bAceptar.Text = "&Agregar";
                pLacteos.BackColor = Color.FromArgb(0, 173, 140);
            }
            else
            {
                Text = "Modificar..";
                pLacteos.BackColor = Color.FromArgb(255, 164, 32);
                bAceptar.Text = "&Modificar";
                mtCodigo.Enabled = false;
                tNombre.Text = nombre;
                mtCodigo.Text = codigo.ToString();
                dtFecha.Value = fecha;
                mtPeso.Text = peso.ToString();
                mtPrecio.Text = precio.ToString();
                cbProveedores.Text = proveedor;
                checkNacional.Checked = esNacional;
            }

            if (tipo == "Bebible")
                lPeso.Text = "Mililitros: ";
            else
                lPeso.Text = "Gramos: ";
        }
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tNombre.Text.Trim() == "")
            {
                MessageBox.Show("Falta completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tNombre.Focus();
            }
            else if (!mtCodigo.MaskCompleted)
            {
                MessageBox.Show("Falta completar Código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCodigo.Focus();
            }
            else if (!mtPeso.MaskCompleted || mtPeso.Text == "")
            {
                MessageBox.Show("Falta completar peso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtPeso.Focus();
            }
            else if (!mtPrecio.MaskCompleted || mtPrecio.Text == "")
            {
                MessageBox.Show("Falta completar precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtPrecio.Focus();
            }
            else if (cbProveedores.Text == "")
            {
                MessageBox.Show("Falta completar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbProveedores.Focus();
            }
            else
            {
                nombre = tNombre.Text.Trim().ToLower();
                codigo = Convert.ToInt32(mtCodigo.Text);
                fecha = dtFecha.Value;
                peso = Convert.ToInt32(mtPeso.Text);
                precio = Convert.ToInt32(mtPrecio.Text);
                proveedor = cbProveedores.SelectedItem.ToString();
                esNacional = checkNacional.Checked;
                DialogResult = DialogResult.OK;
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #region Error provider
        private void tNombre_Validating(object sender, CancelEventArgs e)
        {
            if (tNombre.Text == "")
                epValidar.SetError(tNombre, "Campo incompleto");
        }

        private void mtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (!mtCodigo.MaskFull)
                epValidar.SetError(mtCodigo, "Campo incompleto");
        }

        private void mtPeso_Validating(object sender, CancelEventArgs e)
        {
            if (!mtPeso.MaskCompleted)
                epValidar.SetError(mtPeso, "Campo incompleto");
        }

        private void mtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (!mtPrecio.MaskCompleted)
                epValidar.SetError(mtPrecio, "Campo incompleto");
        }
        #endregion
    }
}