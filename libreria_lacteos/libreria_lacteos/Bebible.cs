using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_lacteos
{
    public class Bebible : Lacteo
    {
        
        #region Atributos
        protected double mililitros;
        #endregion
        
        #region Propiedades
        public double Mililitros
        {
            get { return mililitros; }
            set
            {
                if (value > 0)
                    mililitros = value;
            }
        }
        #endregion
        
        #region Constructores
        public Bebible() : base()
        {
            mililitros = 0.1;
        }
        public Bebible(int codigo):base(codigo)
        {
            mililitros = 0.1;
        }
        public Bebible(int codigo, string nombre, bool importado, double precio, DateTime fechaVenc, Proveedor proveedor, double mililitros) : base(codigo, nombre, importado, precio, fechaVenc, proveedor)
        {
            this.mililitros = mililitros > 0 ? mililitros : 0.1;
        }
        #endregion

        #region Consultas
        
        #region Redefinicion
        public override bool Equals(object obj)
        {
            if (obj == null)
                return true;
            else if (this.GetType() != obj.GetType())
                return false;
            else
            {
                Bebible b = (Bebible)obj;
                return (codigo == b.codigo);
            }
        }

        public override string ToString()
        {
            string toReturn = base.ToString();
            toReturn += $" - Volumen: {mililitros}ml - Proveedor: {proveedor.RazonSocial}";
            return toReturn;
        }

        public override int GetHashCode()
        {
            return codigo * 1000;
        }
        #endregion
        
        #region Resto
        public override string TipoDeLacteo()
        {
            return $"Es un Lácteo bebible: {nombre}";
        }
        #endregion
        #endregion
    }
}