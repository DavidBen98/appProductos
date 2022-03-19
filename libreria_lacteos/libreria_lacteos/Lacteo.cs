using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_lacteos
{
    public abstract class Lacteo
    {

        #region Atributos
        protected int codigo;
        protected string nombre;
        protected bool nacional;
        protected double precio;
        protected DateTime fechaVenc;
        protected Proveedor proveedor;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != "")
                    nombre = value;
            }
        }

        public int Codigo
        {
            get { return codigo; }
            set
            {
                if (value > 0 && value < 1000)
                    codigo = value;
            }
        }

        public bool Nacional
        {
            get { return nacional; }
            set { nacional = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
            }
        }

        public DateTime FechaVenc
        {
            get { return fechaVenc; }
            set { fechaVenc = value; }
        }

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set
            {
                if (value != null)
                    proveedor = value;
            }
        }
        #endregion

        #region Constructores
        public Lacteo()
        {
            codigo = 001;
            nombre = "";
            nacional = false;
            precio = 0.1;
            fechaVenc = DateTime.Today;
            proveedor = new Proveedor();
        }

        public Lacteo(int codigo)
        {
            codigo = CodigoValido(codigo) ? codigo : 001;
            nombre = "";
            nacional = false;
            precio = 0.1;
            fechaVenc = DateTime.Today;
            proveedor = new Proveedor();
        }

        public Lacteo(int codigo, string nombre, bool nacional, double precio, DateTime fechaVenc, Proveedor proveedor)
        {
            this.codigo = codigo > 0 && codigo < 1000 ? codigo : 001;
            this.nombre = nombre;
            this.nacional = nacional;
            this.precio = precio > 0 ? precio : 0.1;
            this.fechaVenc = fechaVenc >= DateTime.Today ? fechaVenc : DateTime.Today;
            this.proveedor = proveedor != null ? proveedor : new Proveedor();
        }
        #endregion

        #region Consultas
        
        #region Redefinición
        public override bool Equals(object obj)
        {
            if (obj == null)
                return true;
            else if (this.GetType() != obj.GetType())
                return false;
            else
            {
                Lacteo l = (Lacteo)obj;
                return (codigo == l.codigo);
            }
        }

        public override string ToString()
        {
            string toReturn = "";
            toReturn += $"{nombre}: Código - {codigo.ToString("000")} ";
            toReturn += $"- Precio: ${precio.ToString("00")} ";
            string definirOrigen = nacional ? "Nacional" : "Importado";
            toReturn += $"Origen: {definirOrigen} ";
            return toReturn;
        }

        public override int GetHashCode()
        {
            return codigo * 10;
        }
        #endregion
        
        #region Resto
        public bool ProductoVencido()
        {
            return (fechaVenc < DateTime.Today);
        }

        public static bool CodigoValido(int codigo)
        {
            if (codigo > 0 && codigo < 1000)
            {
                return true;
            }

            return false;
        }

        public abstract string TipoDeLacteo();
        #endregion
        #endregion
    }
}