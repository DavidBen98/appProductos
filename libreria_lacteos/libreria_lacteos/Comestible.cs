using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_lacteos
{
    public class Comestible : Lacteo
    {
      
        #region Atributos
        protected double gramos;
        #endregion
        
        #region Propiedades
        public double Gramos
        {
            get { return gramos; }
            set
            {
                if (value > 0)
                    gramos = value;
            }
        }
        #endregion
       
        #region Constructores
        public Comestible() : base()
        {
            gramos = 0.1;
        }

        public Comestible(int codigo) : base(codigo)
        {
            gramos = 0.1;
        }
        public Comestible(int codigo, string nombre, bool importado, double precio, DateTime fechaVenc, Proveedor proveedor, double gramos) : base(codigo, nombre, importado, precio, fechaVenc, proveedor)
        {
            this.gramos = gramos > 0 ? gramos : 0.1;
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
                Comestible c = (Comestible)obj;
                return (codigo == c.codigo);
            }
        }

        public override string ToString()
        {
            string toReturn = base.ToString();
            toReturn += $"- Volumen: {gramos}grs - Proveedor: {proveedor.RazonSocial}";
            return toReturn;
        }

        public override int GetHashCode()
        {
            return codigo * 100;
        }
        #endregion
        
        #region Resto
        public override string TipoDeLacteo()
        {
            return $"Es un Lácteo comestible: {nombre}";
        }
        #endregion

        #endregion
    }
}