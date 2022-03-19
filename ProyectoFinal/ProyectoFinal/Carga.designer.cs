
namespace ProyectoFinal
{
    partial class FCarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.mtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lPeso = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.mtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.pLacteos = new System.Windows.Forms.Panel();
            this.checkNacional = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.mtPeso = new System.Windows.Forms.MaskedTextBox();
            this.epValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.pLacteos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(147, 7);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 1;
            this.tNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tNombre_Validating);
            // 
            // mtCodigo
            // 
            this.mtCodigo.Location = new System.Drawing.Point(147, 39);
            this.mtCodigo.Mask = "000";
            this.mtCodigo.Name = "mtCodigo";
            this.mtCodigo.Size = new System.Drawing.Size(100, 20);
            this.mtCodigo.TabIndex = 3;
            this.mtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.mtCodigo_Validating);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(147, 70);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Vencimiento:";
            // 
            // lPeso
            // 
            this.lPeso.AutoSize = true;
            this.lPeso.Location = new System.Drawing.Point(82, 103);
            this.lPeso.Name = "lPeso";
            this.lPeso.Size = new System.Drawing.Size(46, 13);
            this.lPeso.TabIndex = 6;
            this.lPeso.Text = "Gramos:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(160, 242);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(259, 242);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // mtPrecio
            // 
            this.mtPrecio.Location = new System.Drawing.Point(147, 127);
            this.mtPrecio.Mask = "99999";
            this.mtPrecio.Name = "mtPrecio";
            this.mtPrecio.Size = new System.Drawing.Size(100, 20);
            this.mtPrecio.TabIndex = 9;
            this.mtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.mtPrecio_Validating);
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(94, 130);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 13);
            this.lPrecio.TabIndex = 8;
            this.lPrecio.Text = "Precio:";
            // 
            // pLacteos
            // 
            this.pLacteos.Controls.Add(this.checkNacional);
            this.pLacteos.Controls.Add(this.label4);
            this.pLacteos.Controls.Add(this.cbProveedores);
            this.pLacteos.Controls.Add(this.mtPeso);
            this.pLacteos.Controls.Add(this.label1);
            this.pLacteos.Controls.Add(this.lPrecio);
            this.pLacteos.Controls.Add(this.tNombre);
            this.pLacteos.Controls.Add(this.mtPrecio);
            this.pLacteos.Controls.Add(this.mtCodigo);
            this.pLacteos.Controls.Add(this.dtFecha);
            this.pLacteos.Controls.Add(this.lPeso);
            this.pLacteos.Controls.Add(this.label3);
            this.pLacteos.Controls.Add(this.label2);
            this.pLacteos.Location = new System.Drawing.Point(13, 13);
            this.pLacteos.Name = "pLacteos";
            this.pLacteos.Size = new System.Drawing.Size(333, 211);
            this.pLacteos.TabIndex = 0;
            // 
            // checkNacional
            // 
            this.checkNacional.AutoSize = true;
            this.checkNacional.Location = new System.Drawing.Point(147, 191);
            this.checkNacional.Name = "checkNacional";
            this.checkNacional.Size = new System.Drawing.Size(111, 17);
            this.checkNacional.TabIndex = 12;
            this.checkNacional.Text = "Industria Nacional";
            this.checkNacional.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proveedor:";
            // 
            // cbProveedores
            // 
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(147, 163);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(100, 21);
            this.cbProveedores.TabIndex = 11;
            // 
            // mtPeso
            // 
            this.mtPeso.Location = new System.Drawing.Point(147, 100);
            this.mtPeso.Mask = "999999";
            this.mtPeso.Name = "mtPeso";
            this.mtPeso.Size = new System.Drawing.Size(100, 20);
            this.mtPeso.TabIndex = 7;
            this.mtPeso.Validating += new System.ComponentModel.CancelEventHandler(this.mtPeso_Validating);
            // 
            // epValidar
            // 
            this.epValidar.ContainerControl = this;
            // 
            // FCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 277);
            this.Controls.Add(this.pLacteos);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Name = "FCarga";
            this.Text = "Lacteos";
            this.Load += new System.EventHandler(this.Lacteos_Load);
            this.pLacteos.ResumeLayout(false);
            this.pLacteos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.MaskedTextBox mtCodigo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lPeso;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.MaskedTextBox mtPrecio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Panel pLacteos;
        private System.Windows.Forms.MaskedTextBox mtPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.CheckBox checkNacional;
        private System.Windows.Forms.ErrorProvider epValidar;
    }
}