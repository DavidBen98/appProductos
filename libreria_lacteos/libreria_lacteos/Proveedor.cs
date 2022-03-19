using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_lacteos
{
    public class Proveedor
    {
        
        #region Atributos
        protected long cuit;
        private const long cuitDefault = 27280335148;
        protected string razonSocial;
        protected bool esNacional;
        #endregion
        
        #region Propiedades
        public long Cuit
        {
            get { return cuit; }
            set
            {
                if (CuitValido(value))
                    cuit = value;
            }
        }

        public string RazonSocial
        {
            get { return razonSocial; }
            set
            {
                if (value != "")
                    razonSocial = value;
            }
        }

        public bool EsNacional
        {
            get { return esNacional; }
            set { esNacional = value; }
        }
        #endregion
        
        #region Constructores
        public Proveedor()
        {
            cuit = cuitDefault;
            razonSocial = "";
            esNacional = false;
        }

        public Proveedor(long cuit)
        {
            this.cuit = CuitValido(cuit) ? cuit : cuitDefault;
            razonSocial = "";
            esNacional = false;
        }

        public Proveedor(long cuit, string razonSocial, bool esNacional)
        {
            this.cuit = CuitValido(cuit) ? cuit : cuitDefault;
            this.razonSocial = razonSocial;
            this.esNacional = esNacional;
        }

        public Proveedor(string razonSocial)
        {
            cuit = cuitDefault;
            this.razonSocial = razonSocial;
            esNacional = false;
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
                Proveedor p = (Proveedor)obj;
                return (cuit == p.Cuit);
            }
        }

        public override string ToString()
        {
            string cuitConLineas = Convert.ToString(cuit);
            string toShow = esNacional ? "Nacional":"Internacional";

            return $"Proveedor: {razonSocial}, Cuit: {cuitConLineas},  {toShow}";
        }

        public override int GetHashCode()
        {
            return (int)cuit / 10000;
        }
        #endregion
       
        #region Resto
        /// <summary>
        /// Determina si el cuit ingresado es válido
        /// </summary>
        /// <param name="cuit">El cuit a evaluar (Si no es de 11 caracteres, devuelve falso)</param>
        /// <returns></returns>
        public static bool CuitValido(long cuit)
        {
            bool toReturn = false;

            if (Convert.ToString(cuit).Length == 11)
            {
                long codigoVerificacion = 5432765432;
                long digitoVerificador = (cuit % 10);
                cuit /= 10;

                long valor1 = 0;
                long valor2, valor3;
                do
                {
                    valor1 += (cuit % 10) * (codigoVerificacion % 10);
                    cuit /= 10;
                    codigoVerificacion /= 10;
                }
                while (!(cuit == 0 && codigoVerificacion == 0));

                valor2 = valor1 % 11;
                valor3 = 11 - valor2;

                if ((valor3 == 11 && codigoVerificacion == 0) || (valor3 == 10 && codigoVerificacion == 9) || (valor3 == digitoVerificador))
                {
                    toReturn = true;
                }
            }

            return toReturn;
        }
        #endregion
        #endregion
    }
}