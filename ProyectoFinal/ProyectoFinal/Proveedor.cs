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
    public partial class FProveedores : Form
    {
        public string estado, razonSocial;
        public long cuit;
        public bool esNacional;
        public FProveedores()
        {
            InitializeComponent();
        }
        private void FProveedores_Load(object sender, EventArgs e)
        {
            if (estado == "Agregar")
            {
                Text = "Nuevo..";
                pProveedores.BackColor = Color.FromArgb(0,173,140);
                bAceptar.Text = "&Agregar";
            }
            else
            {
                Text = "Modificar..";
                pProveedores.BackColor = Color.FromArgb(255, 164, 32);
                bAceptar.Text = "&Modificar";
                mtCuit.Enabled = false;
                mtCuit.Text = cuit.ToString();
                tRazonSocial.Text = razonSocial;
                checkNacional.Checked = esNacional;
            }

        }
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!mtCuit.MaskCompleted)
            {
                MessageBox.Show("Falta completar CUIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCuit.Focus();
            }
            else if (!Proveedor.CuitValido(Convert.ToInt64(mtCuit.Text)))
            {
                MessageBox.Show("El CUIT ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCuit.Focus();
            }
            else if (tRazonSocial.Text.Trim() == "")
            {
                MessageBox.Show("Falta completar Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tRazonSocial.Focus();
            }
            else
            {
                cuit = Convert.ToInt64(mtCuit.Text);
                razonSocial = tRazonSocial.Text.Trim().ToLower();
                esNacional = checkNacional.Checked;
                DialogResult = DialogResult.OK;
            }
        }

        #region Error provider
        private void mtCuit_Validating(object sender, CancelEventArgs e)
        {
            if (!mtCuit.MaskFull)
                epValidar.SetError(mtCuit, "Campo incompleto");
        }

        private void tRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            if (tRazonSocial.Text == "")
                epValidar.SetError(tRazonSocial, "Campo incompleto");
        }
        #endregion

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}