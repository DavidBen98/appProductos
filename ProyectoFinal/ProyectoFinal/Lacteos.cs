using libreria_lacteos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FPrincipal : Form
    {
        Coleccion conexion_datos;
        public FPrincipal()
        {
            InitializeComponent();
        }
        private void FPrincipal_Load(object sender, EventArgs e)
        {
            conexion_datos = new Coleccion();
            dtFechaV.MinDate = DateTime.Today;
            dtFechaV.Value = DateTime.Today;
            cbNombre.SelectedIndex = 0;
            cbProveedor.SelectedIndex = 0;
            miNuevoProducto.Enabled = false;
            miModificar.Enabled = false;
            miEliminar.Enabled = false;
            pLacteos.Enabled = false;
            pProveedores.Enabled = false;
            miModifProducto.Enabled = false;
            miEliminarProducto.Enabled = false;
        }

        #region Metodos
        private void ActualizarLacteos()
        {
            lbLacteos.Items.Clear();
            List<string> lista = conexion_datos.Lacteos(rbBebibles.Checked, dtFechaV.Value, cbNombre.Text, cbProveedor.Text);

            foreach (string lacteo in lista)
            {
                lbLacteos.Items.Add(lacteo);
            }

            miModifBebible.Enabled = rbBebibles.Checked;
            miEliminarBebible.Enabled = rbBebibles.Checked;
            miModifComestible.Enabled = !rbBebibles.Checked;
            miEliminarComestible.Enabled = !rbBebibles.Checked;

            lCantListLacteos.Text = $"Cantidad listada: {lbLacteos.Items.Count}";
            lTotalLacteos.Text = $"Total de Lacteos: {conexion_datos.cantLacteos}";

            if (lbLacteos.Items.Count == 0)
            {
                miModifProducto.Enabled = false;
                miEliminarProducto.Enabled = false;
            }
            else
            {
                miModifProducto.Enabled = true;
                miEliminarProducto.Enabled = true;
                lbLacteos.SelectedIndex = 0;
            }

            if (conexion_datos.cantLacteos < 1)
                pLacteos.Enabled = false;
        }

        private void ActualizarProveedores()
        {
            List<string> lista, listaNombres;
            if (rbTodos.Checked)
                lista = conexion_datos.ListarProveedores();
            else if (rbNacionales.Checked)
                lista = conexion_datos.ListarProveedores(true);
            else
                lista = conexion_datos.ListarProveedores(false);

            lbProveedores.Items.Clear();
            foreach (string proveedor in lista)
                lbProveedores.Items.Add(proveedor);
            lCantListProveedores.Text = $"Cantidad listada: {lista.Count}";
            lTotalProveedores.Text = $"Total de proveedores: {conexion_datos.cantProveedores}";

            listaNombres = conexion_datos.ListarNombreProveedores();
            cbProveedor.Items.Clear();
            cbProveedor.Items.Add("Todos");
            foreach (string nombre in listaNombres)
                cbProveedor.Items.Add(nombre);
            cbProveedor.SelectedIndex = 0;

            if (conexion_datos.cantProveedores == 0)
            {
                miNuevoProducto.Enabled = false;
                miModifProveedor.Enabled = false;
                miEliminarProveedor.Enabled = false;
            }
            else
            {
                miNuevoProducto.Enabled = true;
                miModifProveedor.Enabled = true;
                miEliminarProveedor.Enabled = true;
                lbProveedores.SelectedIndex = lbProveedores.Items.Count - 1;
            }
        }

        private void ActualizarComboBox()
        {
            List<string> listaNombres;
            listaNombres = conexion_datos.ListaNombreLacteos();
            cbNombre.Items.Clear();
            cbNombre.Items.Add("Todos");
            foreach (string producto in listaNombres)
            {
                if (cbNombre.Items.IndexOf(producto) == -1)
                {
                    cbNombre.Items.Add(producto);
                }
            }
            cbNombre.SelectedIndex = 0;
        }
        #endregion

        #region Actualizar Listados
        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarProveedores();
        }
        private void rbNacionales_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarProveedores();
        }
        private void rbImportados_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarProveedores();
        }
        private void rbBebibles_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarLacteos();
        }
        private void rbNoBebibles_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarLacteos();
        }
        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLacteos();
        }
        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLacteos();
        }
        private void dtFechaV_ValueChanged(object sender, EventArgs e)
        {
            ActualizarLacteos();
        }
        #endregion

        #region Botones proveedores
        private void miNuevoProveedor_Click(object sender, EventArgs e)
        {
            FProveedores fCargarProv = new FProveedores();
            long cuit = 0;
            string nombre = "";
            bool esNacional = false;
            bool agregarProv = false;

            fCargarProv.estado = "Agregar";
            fCargarProv.cuit = 0;
            fCargarProv.razonSocial = "";
            fCargarProv.esNacional = false;

            do
            {
                fCargarProv.ShowDialog();
                if (fCargarProv.DialogResult == DialogResult.OK)
                {
                    cuit = Convert.ToInt64(fCargarProv.cuit);
                    nombre = fCargarProv.razonSocial;
                    esNacional = fCargarProv.esNacional;
                    if (conexion_datos.ExisteCuitProveedor(cuit))
                        MessageBox.Show("El cuit ingresado ya existe, reintente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (conexion_datos.ExisteRazonProveedor(nombre))
                        MessageBox.Show("La Razon Social ingresada ya existe, reintente con otra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        agregarProv = true;
                }
                else
                    MessageBox.Show("Se ha cancelado la carga del nuevo proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            while ((fCargarProv.DialogResult == DialogResult.OK) && (!agregarProv));

            if (agregarProv)
            {
                conexion_datos.AgregarProveedor(cuit, nombre, esNacional, -1);
                ActualizarProveedores();
                miNuevoProducto.Enabled = true;
                miModificar.Enabled = true;
                miEliminar.Enabled = true;
                pProveedores.Enabled = true;
                MessageBox.Show("Se ha agregado el proveedor", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void miModifProveedor_Click(object sender, EventArgs e)
        {
            FProveedores fModifProveedor = new FProveedores();
            long cuit = 0;
            string nombre = "";
            bool esNacional = false;
            bool modificarProv = false;

            if (lbProveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbProveedores.Focus();
            }
            else
            {
                List<string> lista = conexion_datos.Proveedores();
                cuit = conexion_datos.ObtenerCuitProveedor(lbProveedores.SelectedItem.ToString());
                nombre = conexion_datos.RecuperarRazonSocial(cuit);
                esNacional = conexion_datos.RecuperarOrigen(cuit);
                fModifProveedor.estado = "Modificar";
                fModifProveedor.cuit = cuit;
                fModifProveedor.razonSocial = nombre;
                fModifProveedor.esNacional = esNacional;

                do
                {
                    fModifProveedor.ShowDialog();
                    if (fModifProveedor.DialogResult == DialogResult.OK)
                    {
                        if ((fModifProveedor.razonSocial != nombre) && (conexion_datos.ExisteRazonProveedor(fModifProveedor.razonSocial)))
                            MessageBox.Show("La razon social ingresada ya existe, ingrese otra por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            cuit = Convert.ToInt64(fModifProveedor.cuit);
                            nombre = fModifProveedor.razonSocial;
                            esNacional = fModifProveedor.esNacional;
                            modificarProv = true;
                        }
                    }
                    else
                        MessageBox.Show("Se ha cancelado la modificacion del proveedor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                while ((fModifProveedor.DialogResult == DialogResult.OK) && (!modificarProv));

                if (modificarProv)
                {
                    conexion_datos.ModificarProveedor(cuit, nombre, esNacional);
                    ActualizarProveedores();
                    MessageBox.Show("Se ha modificado el proveedor correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void miEliminarProveedor_Click(object sender, EventArgs e)
        {
            long cuit = 0;

            if (lbProveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbProveedores.Focus();
            }
            else if (conexion_datos.ProductosXProveedor(conexion_datos.ObtenerCuitProveedor(lbProveedores.SelectedItem.ToString())).Count != 0)
            {
                MessageBox.Show("El proveedor tiene uno o más productos a su nombre cargados en el sistema. \nNo se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cuit = conexion_datos.ObtenerCuitProveedor(lbProveedores.SelectedItem.ToString());
                conexion_datos.EliminarElemento(cuit);
                ActualizarProveedores();
                if (conexion_datos.cantProveedores < 1)
                    pProveedores.Enabled = false;
                MessageBox.Show("Se ha eliminado el proveedor correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Agregar producto
        private void miNuevoBebible_Click(object sender, EventArgs e)
        {
            FCarga fCargarBebible = new FCarga();
            string nombre = "";
            int codigo = 0;
            DateTime fecha = DateTime.Today;
            double mililitros = 0;
            double precio = 0;
            bool nacional = false;
            string proveedor = "";
            bool agregarBebible = false;
            fCargarBebible.tipo = "Bebible";
            fCargarBebible.estado = "Agregar";
            fCargarBebible.lista = conexion_datos.ListarNombreProveedores();

            do
            {
                fCargarBebible.ShowDialog();
                if (fCargarBebible.DialogResult == DialogResult.OK)
                {
                    nombre = fCargarBebible.nombre;
                    codigo = Convert.ToInt32(fCargarBebible.codigo);
                    fecha = fCargarBebible.fecha;
                    mililitros = fCargarBebible.peso;
                    precio = fCargarBebible.precio;
                    nacional = fCargarBebible.esNacional;
                    proveedor = fCargarBebible.proveedor;
                    if (conexion_datos.BuscarLacteo(codigo))
                        MessageBox.Show("El codigo ingresado ya existe, reintente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        agregarBebible = true;
                }
                else
                    MessageBox.Show("Se ha cancelado la carga del producto bebible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            while ((fCargarBebible.DialogResult == DialogResult.OK) && (!agregarBebible));

            if (agregarBebible)
            {
                pLacteos.Enabled = true;
                miModifProducto.Enabled = true;
                miEliminarProducto.Enabled = true;
                long cuit = conexion_datos.RecuperarCuitProveedor(proveedor);
                conexion_datos.AgregarElemento(codigo, nombre, nacional, precio, fecha, true, mililitros, cuit);
                ActualizarComboBox();
                ActualizarLacteos();
                MessageBox.Show("Se ha añadido el producto bebible correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void miNuevoComestible_Click(object sender, EventArgs e)
        {
            FCarga fCargarComestible = new FCarga();
            string nombre = "";
            int codigo = 0;
            DateTime fecha = DateTime.Today;
            double peso = 0;
            double precio = 0;
            bool nacional = false;
            string proveedor = "";
            bool agregarLacteo = false;
            fCargarComestible.tipo = "Comestible";
            fCargarComestible.estado = "Agregar";
            fCargarComestible.lista = conexion_datos.ListarNombreProveedores();

            do
            {
                fCargarComestible.ShowDialog();
                if (fCargarComestible.DialogResult == DialogResult.OK)
                {
                    nombre = fCargarComestible.nombre;
                    codigo = Convert.ToInt32(fCargarComestible.codigo);
                    fecha = fCargarComestible.fecha;
                    peso = fCargarComestible.peso;
                    precio = fCargarComestible.precio;
                    nacional = fCargarComestible.esNacional;
                    proveedor = fCargarComestible.proveedor;

                    if (conexion_datos.BuscarLacteo(codigo))
                        MessageBox.Show("El codigo ingresado ya existe, reintente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        agregarLacteo = true;
                }
                else
                    MessageBox.Show("Se ha cancelado la carga del producto comestible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            while ((fCargarComestible.DialogResult == DialogResult.OK) && (!agregarLacteo));

            if (agregarLacteo)
            {
                pLacteos.Enabled = true;
                miModifProducto.Enabled = true;
                miEliminarProducto.Enabled = true;
                long cuit = conexion_datos.RecuperarCuitProveedor(proveedor);
                conexion_datos.AgregarElemento(codigo, nombre, nacional, precio, fecha, false, peso, cuit);
                ActualizarComboBox();
                ActualizarLacteos();
                MessageBox.Show("Se ha añadido el producto comestible correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Modificar producto
        private void miModifBebible_Click(object sender, EventArgs e)
        {
            FCarga fModifBebible = new FCarga();
            string nombre = "";
            int codigo = 0;
            DateTime fecha = DateTime.Today;
            double mililitros = 0;
            double precio = 0;
            string proveedor = "";
            bool nacional = false;
            bool seModifico = false;
            fModifBebible.tipo = "Bebible";
            fModifBebible.lista = conexion_datos.ListarNombreProveedores();
            long cuit = 0;

            if (lbLacteos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto bebible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbLacteos.Focus();
            }
            else
            {
                codigo = conexion_datos.ObtenerCodigoLacteo(lbLacteos.SelectedItem.ToString());
                cuit = conexion_datos.RecuperarCuitProveedor(codigo);
                fModifBebible.nombre = conexion_datos.RecuperarNombre(codigo);
                fModifBebible.codigo = codigo;
                fModifBebible.fecha = conexion_datos.RecuperarFecha(codigo);
                fModifBebible.peso = conexion_datos.RecuperarMililitros(codigo);
                fModifBebible.precio = conexion_datos.RecuperarPrecio(codigo);               
                fModifBebible.esNacional = conexion_datos.RecuperarOrigen(codigo);
                fModifBebible.proveedor = conexion_datos.RecuperarRazonSocial(cuit);
                do
                {
                    fModifBebible.ShowDialog();
                    if (fModifBebible.DialogResult == DialogResult.OK)
                    {
                        nombre = fModifBebible.nombre;
                        codigo = fModifBebible.codigo;
                        fecha = fModifBebible.fecha;
                        mililitros = fModifBebible.peso;
                        precio = fModifBebible.precio;
                        nacional = fModifBebible.esNacional;
                        proveedor = fModifBebible.proveedor;
                        cuit = conexion_datos.RecuperarCuitProveedor(proveedor);
                        seModifico = true;
                        conexion_datos.ModificarBebible(codigo, nombre, nacional, precio, fecha, cuit, mililitros);
                        ActualizarProveedores();
                        ActualizarComboBox();
                        ActualizarLacteos();
                        MessageBox.Show("Se ha modificado el producto correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Se ha cancelado la modificacion del producto bebible", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                while (fModifBebible.DialogResult == DialogResult.OK && (!seModifico));
            }
        }
        private void miModifComestible_Click(object sender, EventArgs e)
        {
            FCarga fModifComestible = new FCarga();
            string nombre = "";
            int codigo = 0;
            DateTime fecha = DateTime.Today;
            double gramos = 0;
            double precio = 0;
            string proveedor = "";
            bool nacional = false;
            bool seModifico = false;
            fModifComestible.lista = conexion_datos.ListarNombreProveedores();
            long cuit = 0;

            if (lbLacteos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto comestible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbLacteos.Focus();
            }
            else
            {
                codigo = conexion_datos.ObtenerCodigoLacteo(lbLacteos.SelectedItem.ToString());
                cuit = conexion_datos.RecuperarCuitProveedor(codigo);
                fModifComestible.nombre = conexion_datos.RecuperarNombre(codigo);
                fModifComestible.codigo = codigo;
                fModifComestible.fecha = conexion_datos.RecuperarFecha(codigo);
                fModifComestible.peso = conexion_datos.RecuperarGramos(codigo);
                fModifComestible.precio = conexion_datos.RecuperarPrecio(codigo);
                fModifComestible.esNacional = conexion_datos.RecuperarOrigen(codigo);
                fModifComestible.proveedor = conexion_datos.RecuperarRazonSocial(cuit);
                do
                {
                    fModifComestible.ShowDialog();
                    if (fModifComestible.DialogResult == DialogResult.OK)
                    {
                        nombre = fModifComestible.nombre;
                        codigo = fModifComestible.codigo;
                        fecha = fModifComestible.fecha;
                        gramos = fModifComestible.peso;
                        precio = fModifComestible.precio;
                        nacional = fModifComestible.esNacional;
                        proveedor = fModifComestible.proveedor;
                        cuit = conexion_datos.RecuperarCuitProveedor(proveedor);
                        seModifico = true;
                        conexion_datos.ModificarComestible(codigo, nombre, nacional, precio, fecha, cuit, gramos);
                        ActualizarProveedores();
                        ActualizarComboBox();
                        ActualizarLacteos();
                        MessageBox.Show("Se ha modificado el producto correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Se ha cancelado la modificacion del producto comestible", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                while (fModifComestible.DialogResult == DialogResult.OK && (!seModifico));
            }
        }
        #endregion

        #region Eliminar producto
        private void miEliminarBebible_Click(object sender, EventArgs e)
        {
            int codigo = 0;

            if (lbLacteos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto bebible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbLacteos.Focus();
            }
            else
            {
                codigo = conexion_datos.ObtenerCodigoLacteo(lbLacteos.SelectedItem.ToString());
                conexion_datos.EliminarElemento(codigo);
                ActualizarLacteos();
                ActualizarComboBox();
                MessageBox.Show("Se ha eliminado el producto bebible correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void miEliminarComestible_Click(object sender, EventArgs e)
        {
            int codigo = 0;

            if (lbLacteos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto comestible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbLacteos.Focus();
            }
            else
            {
                codigo = conexion_datos.ObtenerCodigoLacteo(lbLacteos.SelectedItem.ToString());
                conexion_datos.EliminarElemento(codigo);
                ActualizarLacteos();
                ActualizarComboBox();
                MessageBox.Show("Se ha eliminado el producto comestible correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Acerca de
        private void miAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Integrantes del grupo: \n  Benedette, David\n  Pallottini, Alex", "Acerca de: Datos del grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Salir
        private void miSalir_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
                Close();
        }
        #endregion
    }
}