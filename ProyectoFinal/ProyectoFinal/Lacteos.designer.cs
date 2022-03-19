
namespace ProyectoFinal
{
    partial class FPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msLacteos = new System.Windows.Forms.MenuStrip();
            this.miAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.miNuevoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.miNuevoBebible = new System.Windows.Forms.ToolStripMenuItem();
            this.miNuevoComestible = new System.Windows.Forms.ToolStripMenuItem();
            this.miNuevoProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.miModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifBebible = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifComestible = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarBebible = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarComestible = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.miAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.miSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.pLacteos = new System.Windows.Forms.Panel();
            this.lTotalLacteos = new System.Windows.Forms.Label();
            this.lCantListLacteos = new System.Windows.Forms.Label();
            this.lbLacteos = new System.Windows.Forms.ListBox();
            this.gbLacteos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaV = new System.Windows.Forms.DateTimePicker();
            this.rbNoBebibles = new System.Windows.Forms.RadioButton();
            this.rbBebibles = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.pProveedores = new System.Windows.Forms.Panel();
            this.lTotalProveedores = new System.Windows.Forms.Label();
            this.lCantListProveedores = new System.Windows.Forms.Label();
            this.lbProveedores = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbImportados = new System.Windows.Forms.RadioButton();
            this.rbNacionales = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.msLacteos.SuspendLayout();
            this.pLacteos.SuspendLayout();
            this.gbLacteos.SuspendLayout();
            this.pProveedores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msLacteos
            // 
            this.msLacteos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAgregar,
            this.miModificar,
            this.miEliminar,
            this.miAcercaDe,
            this.miSalir});
            this.msLacteos.Location = new System.Drawing.Point(0, 0);
            this.msLacteos.Name = "msLacteos";
            this.msLacteos.Size = new System.Drawing.Size(544, 24);
            this.msLacteos.TabIndex = 0;
            this.msLacteos.Text = "menuStrip1";
            // 
            // miAgregar
            // 
            this.miAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNuevoProducto,
            this.miNuevoProveedor});
            this.miAgregar.Name = "miAgregar";
            this.miAgregar.Size = new System.Drawing.Size(61, 20);
            this.miAgregar.Text = "Agregar";
            // 
            // miNuevoProducto
            // 
            this.miNuevoProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNuevoBebible,
            this.miNuevoComestible});
            this.miNuevoProducto.Name = "miNuevoProducto";
            this.miNuevoProducto.Size = new System.Drawing.Size(128, 22);
            this.miNuevoProducto.Text = "Producto";
            // 
            // miNuevoBebible
            // 
            this.miNuevoBebible.Name = "miNuevoBebible";
            this.miNuevoBebible.Size = new System.Drawing.Size(134, 22);
            this.miNuevoBebible.Text = "Bebible";
            this.miNuevoBebible.Click += new System.EventHandler(this.miNuevoBebible_Click);
            // 
            // miNuevoComestible
            // 
            this.miNuevoComestible.Name = "miNuevoComestible";
            this.miNuevoComestible.Size = new System.Drawing.Size(134, 22);
            this.miNuevoComestible.Text = "Comestible";
            this.miNuevoComestible.Click += new System.EventHandler(this.miNuevoComestible_Click);
            // 
            // miNuevoProveedor
            // 
            this.miNuevoProveedor.Name = "miNuevoProveedor";
            this.miNuevoProveedor.Size = new System.Drawing.Size(128, 22);
            this.miNuevoProveedor.Text = "Proveedor";
            this.miNuevoProveedor.Click += new System.EventHandler(this.miNuevoProveedor_Click);
            // 
            // miModificar
            // 
            this.miModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miModifProducto,
            this.miModifProveedor});
            this.miModificar.Name = "miModificar";
            this.miModificar.Size = new System.Drawing.Size(70, 20);
            this.miModificar.Text = "Modificar";
            // 
            // miModifProducto
            // 
            this.miModifProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miModifBebible,
            this.miModifComestible});
            this.miModifProducto.Name = "miModifProducto";
            this.miModifProducto.Size = new System.Drawing.Size(128, 22);
            this.miModifProducto.Text = "Producto";
            // 
            // miModifBebible
            // 
            this.miModifBebible.Name = "miModifBebible";
            this.miModifBebible.Size = new System.Drawing.Size(134, 22);
            this.miModifBebible.Text = "Bebible";
            this.miModifBebible.Click += new System.EventHandler(this.miModifBebible_Click);
            // 
            // miModifComestible
            // 
            this.miModifComestible.Name = "miModifComestible";
            this.miModifComestible.Size = new System.Drawing.Size(134, 22);
            this.miModifComestible.Text = "Comestible";
            this.miModifComestible.Click += new System.EventHandler(this.miModifComestible_Click);
            // 
            // miModifProveedor
            // 
            this.miModifProveedor.Name = "miModifProveedor";
            this.miModifProveedor.Size = new System.Drawing.Size(128, 22);
            this.miModifProveedor.Text = "Proveedor";
            this.miModifProveedor.Click += new System.EventHandler(this.miModifProveedor_Click);
            // 
            // miEliminar
            // 
            this.miEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEliminarProducto,
            this.miEliminarProveedor});
            this.miEliminar.Name = "miEliminar";
            this.miEliminar.Size = new System.Drawing.Size(62, 20);
            this.miEliminar.Text = "Eliminar";
            // 
            // miEliminarProducto
            // 
            this.miEliminarProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEliminarBebible,
            this.miEliminarComestible});
            this.miEliminarProducto.Name = "miEliminarProducto";
            this.miEliminarProducto.Size = new System.Drawing.Size(128, 22);
            this.miEliminarProducto.Text = "Producto";
            // 
            // miEliminarBebible
            // 
            this.miEliminarBebible.Name = "miEliminarBebible";
            this.miEliminarBebible.Size = new System.Drawing.Size(134, 22);
            this.miEliminarBebible.Text = "Bebible";
            this.miEliminarBebible.Click += new System.EventHandler(this.miEliminarBebible_Click);
            // 
            // miEliminarComestible
            // 
            this.miEliminarComestible.Name = "miEliminarComestible";
            this.miEliminarComestible.Size = new System.Drawing.Size(134, 22);
            this.miEliminarComestible.Text = "Comestible";
            this.miEliminarComestible.Click += new System.EventHandler(this.miEliminarComestible_Click);
            // 
            // miEliminarProveedor
            // 
            this.miEliminarProveedor.Name = "miEliminarProveedor";
            this.miEliminarProveedor.Size = new System.Drawing.Size(128, 22);
            this.miEliminarProveedor.Text = "Proveedor";
            this.miEliminarProveedor.Click += new System.EventHandler(this.miEliminarProveedor_Click);
            // 
            // miAcercaDe
            // 
            this.miAcercaDe.Name = "miAcercaDe";
            this.miAcercaDe.Size = new System.Drawing.Size(72, 20);
            this.miAcercaDe.Text = "Acerca De";
            this.miAcercaDe.Click += new System.EventHandler(this.miAcercaDe_Click);
            // 
            // miSalir
            // 
            this.miSalir.Name = "miSalir";
            this.miSalir.Size = new System.Drawing.Size(41, 20);
            this.miSalir.Text = "Salir";
            this.miSalir.Click += new System.EventHandler(this.miSalir_Click);
            // 
            // pLacteos
            // 
            this.pLacteos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(117)))));
            this.pLacteos.Controls.Add(this.lTotalLacteos);
            this.pLacteos.Controls.Add(this.lCantListLacteos);
            this.pLacteos.Controls.Add(this.lbLacteos);
            this.pLacteos.Controls.Add(this.gbLacteos);
            this.pLacteos.Location = new System.Drawing.Point(13, 28);
            this.pLacteos.Name = "pLacteos";
            this.pLacteos.Size = new System.Drawing.Size(519, 199);
            this.pLacteos.TabIndex = 1;
            // 
            // lTotalLacteos
            // 
            this.lTotalLacteos.AutoSize = true;
            this.lTotalLacteos.Location = new System.Drawing.Point(345, 182);
            this.lTotalLacteos.Name = "lTotalLacteos";
            this.lTotalLacteos.Size = new System.Drawing.Size(99, 13);
            this.lTotalLacteos.TabIndex = 3;
            this.lTotalLacteos.Text = "Total de productos:";
            // 
            // lCantListLacteos
            // 
            this.lCantListLacteos.AutoSize = true;
            this.lCantListLacteos.Location = new System.Drawing.Point(27, 183);
            this.lCantListLacteos.Name = "lCantListLacteos";
            this.lCantListLacteos.Size = new System.Drawing.Size(85, 13);
            this.lCantListLacteos.TabIndex = 2;
            this.lCantListLacteos.Text = "Cantidad listada:";
            // 
            // lbLacteos
            // 
            this.lbLacteos.FormattingEnabled = true;
            this.lbLacteos.Location = new System.Drawing.Point(17, 83);
            this.lbLacteos.Name = "lbLacteos";
            this.lbLacteos.Size = new System.Drawing.Size(478, 95);
            this.lbLacteos.TabIndex = 1;
            // 
            // gbLacteos
            // 
            this.gbLacteos.Controls.Add(this.label3);
            this.gbLacteos.Controls.Add(this.dtFechaV);
            this.gbLacteos.Controls.Add(this.rbNoBebibles);
            this.gbLacteos.Controls.Add(this.rbBebibles);
            this.gbLacteos.Controls.Add(this.label2);
            this.gbLacteos.Controls.Add(this.label1);
            this.gbLacteos.Controls.Add(this.cbNombre);
            this.gbLacteos.Controls.Add(this.cbProveedor);
            this.gbLacteos.Location = new System.Drawing.Point(17, 3);
            this.gbLacteos.Name = "gbLacteos";
            this.gbLacteos.Size = new System.Drawing.Size(478, 73);
            this.gbLacteos.TabIndex = 0;
            this.gbLacteos.TabStop = false;
            this.gbLacteos.Text = "Lácteos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vencim. despues de:";
            // 
            // dtFechaV
            // 
            this.dtFechaV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaV.Location = new System.Drawing.Point(397, 20);
            this.dtFechaV.Name = "dtFechaV";
            this.dtFechaV.Size = new System.Drawing.Size(77, 20);
            this.dtFechaV.TabIndex = 0;
            this.dtFechaV.ValueChanged += new System.EventHandler(this.dtFechaV_ValueChanged);
            // 
            // rbNoBebibles
            // 
            this.rbNoBebibles.AutoSize = true;
            this.rbNoBebibles.Location = new System.Drawing.Point(8, 46);
            this.rbNoBebibles.Name = "rbNoBebibles";
            this.rbNoBebibles.Size = new System.Drawing.Size(81, 17);
            this.rbNoBebibles.TabIndex = 2;
            this.rbNoBebibles.Text = "Comestibles";
            this.rbNoBebibles.UseVisualStyleBackColor = true;
            this.rbNoBebibles.CheckedChanged += new System.EventHandler(this.rbNoBebibles_CheckedChanged);
            // 
            // rbBebibles
            // 
            this.rbBebibles.AutoSize = true;
            this.rbBebibles.Checked = true;
            this.rbBebibles.Location = new System.Drawing.Point(8, 23);
            this.rbBebibles.Name = "rbBebibles";
            this.rbBebibles.Size = new System.Drawing.Size(65, 17);
            this.rbBebibles.TabIndex = 1;
            this.rbBebibles.TabStop = true;
            this.rbBebibles.Text = "Bebibles";
            this.rbBebibles.UseVisualStyleBackColor = true;
            this.rbBebibles.CheckedChanged += new System.EventHandler(this.rbBebibles_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proveedor:";
            // 
            // cbNombre
            // 
            this.cbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Items.AddRange(new object[] {
            "Todos"});
            this.cbNombre.Location = new System.Drawing.Point(170, 46);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(109, 21);
            this.cbNombre.TabIndex = 6;
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.cbNombre_SelectedIndexChanged);
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Items.AddRange(new object[] {
            "Todos"});
            this.cbProveedor.Location = new System.Drawing.Point(170, 20);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(109, 21);
            this.cbProveedor.TabIndex = 4;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // pProveedores
            // 
            this.pProveedores.BackColor = System.Drawing.Color.Silver;
            this.pProveedores.Controls.Add(this.lTotalProveedores);
            this.pProveedores.Controls.Add(this.lCantListProveedores);
            this.pProveedores.Controls.Add(this.lbProveedores);
            this.pProveedores.Controls.Add(this.groupBox1);
            this.pProveedores.Location = new System.Drawing.Point(13, 233);
            this.pProveedores.Name = "pProveedores";
            this.pProveedores.Size = new System.Drawing.Size(519, 179);
            this.pProveedores.TabIndex = 2;
            // 
            // lTotalProveedores
            // 
            this.lTotalProveedores.AutoSize = true;
            this.lTotalProveedores.Location = new System.Drawing.Point(348, 163);
            this.lTotalProveedores.Name = "lTotalProveedores";
            this.lTotalProveedores.Size = new System.Drawing.Size(120, 13);
            this.lTotalProveedores.TabIndex = 3;
            this.lTotalProveedores.Text = "Total de proveedores: 0";
            // 
            // lCantListProveedores
            // 
            this.lCantListProveedores.AutoSize = true;
            this.lCantListProveedores.Location = new System.Drawing.Point(27, 165);
            this.lCantListProveedores.Name = "lCantListProveedores";
            this.lCantListProveedores.Size = new System.Drawing.Size(94, 13);
            this.lCantListProveedores.TabIndex = 2;
            this.lCantListProveedores.Text = "Cantidad listada: 0";
            // 
            // lbProveedores
            // 
            this.lbProveedores.FormattingEnabled = true;
            this.lbProveedores.Location = new System.Drawing.Point(17, 67);
            this.lbProveedores.Name = "lbProveedores";
            this.lbProveedores.Size = new System.Drawing.Size(478, 95);
            this.lbProveedores.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbImportados);
            this.groupBox1.Controls.Add(this.rbNacionales);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedores";
            // 
            // rbImportados
            // 
            this.rbImportados.AutoSize = true;
            this.rbImportados.Location = new System.Drawing.Point(328, 18);
            this.rbImportados.Name = "rbImportados";
            this.rbImportados.Size = new System.Drawing.Size(77, 17);
            this.rbImportados.TabIndex = 2;
            this.rbImportados.Text = "Importados";
            this.rbImportados.UseVisualStyleBackColor = true;
            this.rbImportados.CheckedChanged += new System.EventHandler(this.rbImportados_CheckedChanged);
            // 
            // rbNacionales
            // 
            this.rbNacionales.AutoSize = true;
            this.rbNacionales.Location = new System.Drawing.Point(214, 18);
            this.rbNacionales.Name = "rbNacionales";
            this.rbNacionales.Size = new System.Drawing.Size(78, 17);
            this.rbNacionales.TabIndex = 1;
            this.rbNacionales.Text = "Nacionales";
            this.rbNacionales.UseVisualStyleBackColor = true;
            this.rbNacionales.CheckedChanged += new System.EventHandler(this.rbNacionales_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(95, 18);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 417);
            this.Controls.Add(this.pProveedores);
            this.Controls.Add(this.pLacteos);
            this.Controls.Add(this.msLacteos);
            this.MainMenuStrip = this.msLacteos;
            this.Name = "FPrincipal";
            this.Text = "Lacteos";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.msLacteos.ResumeLayout(false);
            this.msLacteos.PerformLayout();
            this.pLacteos.ResumeLayout(false);
            this.pLacteos.PerformLayout();
            this.gbLacteos.ResumeLayout(false);
            this.gbLacteos.PerformLayout();
            this.pProveedores.ResumeLayout(false);
            this.pProveedores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msLacteos;
        private System.Windows.Forms.ToolStripMenuItem miAgregar;
        private System.Windows.Forms.ToolStripMenuItem miModificar;
        private System.Windows.Forms.ToolStripMenuItem miEliminar;
        private System.Windows.Forms.ToolStripMenuItem miAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem miSalir;
        private System.Windows.Forms.Panel pLacteos;
        private System.Windows.Forms.GroupBox gbLacteos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Panel pProveedores;
        private System.Windows.Forms.RadioButton rbNoBebibles;
        private System.Windows.Forms.RadioButton rbBebibles;
        private System.Windows.Forms.ListBox lbLacteos;
        private System.Windows.Forms.Label lTotalLacteos;
        private System.Windows.Forms.Label lCantListLacteos;
        private System.Windows.Forms.Label lTotalProveedores;
        private System.Windows.Forms.Label lCantListProveedores;
        private System.Windows.Forms.ListBox lbProveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbImportados;
        private System.Windows.Forms.RadioButton rbNacionales;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.ToolStripMenuItem miNuevoProducto;
        private System.Windows.Forms.ToolStripMenuItem miNuevoBebible;
        private System.Windows.Forms.ToolStripMenuItem miNuevoComestible;
        private System.Windows.Forms.ToolStripMenuItem miNuevoProveedor;
        private System.Windows.Forms.ToolStripMenuItem miModifProducto;
        private System.Windows.Forms.ToolStripMenuItem miModifBebible;
        private System.Windows.Forms.ToolStripMenuItem miModifComestible;
        private System.Windows.Forms.ToolStripMenuItem miModifProveedor;
        private System.Windows.Forms.ToolStripMenuItem miEliminarProducto;
        private System.Windows.Forms.ToolStripMenuItem miEliminarBebible;
        private System.Windows.Forms.ToolStripMenuItem miEliminarComestible;
        private System.Windows.Forms.ToolStripMenuItem miEliminarProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechaV;
    }
}

