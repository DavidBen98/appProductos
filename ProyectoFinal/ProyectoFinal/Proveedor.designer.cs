
namespace ProyectoFinal
{
    partial class FProveedores
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
            this.pProveedores = new System.Windows.Forms.Panel();
            this.checkNacional = new System.Windows.Forms.CheckBox();
            this.tRazonSocial = new System.Windows.Forms.TextBox();
            this.mtCuit = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.epValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.pProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // pProveedores
            // 
            this.pProveedores.Controls.Add(this.checkNacional);
            this.pProveedores.Controls.Add(this.tRazonSocial);
            this.pProveedores.Controls.Add(this.mtCuit);
            this.pProveedores.Controls.Add(this.label2);
            this.pProveedores.Controls.Add(this.label1);
            this.pProveedores.Location = new System.Drawing.Point(12, 12);
            this.pProveedores.Name = "pProveedores";
            this.pProveedores.Size = new System.Drawing.Size(267, 100);
            this.pProveedores.TabIndex = 0;
            // 
            // checkNacional
            // 
            this.checkNacional.AutoSize = true;
            this.checkNacional.Location = new System.Drawing.Point(117, 74);
            this.checkNacional.Name = "checkNacional";
            this.checkNacional.Size = new System.Drawing.Size(111, 17);
            this.checkNacional.TabIndex = 4;
            this.checkNacional.Text = "Industria Nacional";
            this.checkNacional.UseVisualStyleBackColor = true;
            // 
            // tRazonSocial
            // 
            this.tRazonSocial.Location = new System.Drawing.Point(117, 47);
            this.tRazonSocial.Name = "tRazonSocial";
            this.tRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.tRazonSocial.TabIndex = 3;
            this.tRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.tRazonSocial_Validating);
            // 
            // mtCuit
            // 
            this.mtCuit.Location = new System.Drawing.Point(117, 18);
            this.mtCuit.Mask = "00000000000";
            this.mtCuit.Name = "mtCuit";
            this.mtCuit.Size = new System.Drawing.Size(100, 20);
            this.mtCuit.TabIndex = 1;
            this.mtCuit.Validating += new System.ComponentModel.CancelEventHandler(this.mtCuit_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIT:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(45, 118);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(176, 118);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // epValidar
            // 
            this.epValidar.ContainerControl = this;
            // 
            // FProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 150);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.pProveedores);
            this.Name = "FProveedores";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FProveedores_Load);
            this.pProveedores.ResumeLayout(false);
            this.pProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pProveedores;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.CheckBox checkNacional;
        private System.Windows.Forms.TextBox tRazonSocial;
        private System.Windows.Forms.MaskedTextBox mtCuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epValidar;
    }
}