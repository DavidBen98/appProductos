    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria_lacteos
{
    public class Coleccion
    {
        #region Atributos
        protected List<Lacteo> listaLacteos;
        protected List<Proveedor> listaProveedores;
        #endregion 

        #region Propiedades
        public int cantLacteos
        {
            get { return listaLacteos.Count; }
        }

        public int cantProveedores
        {
            get { return listaProveedores.Count; }
        }
        #endregion

        #region Constructores
        public Coleccion()
        {
            listaLacteos = new List<Lacteo>();
            listaProveedores = new List<Proveedor>();
        }
        #endregion

        #region Comandos
        public void AgregarElemento(int codigo, string nombre, bool importado, double precio, DateTime fechaVenc, bool bebible, double peso, long prov_cuit, int pos = -1)
        {
            Proveedor proveedor = RecuperarProveedor(prov_cuit);
            Lacteo lacteo;

            if (bebible)
                lacteo = new Bebible(codigo,nombre,importado,precio,fechaVenc,proveedor,peso);
            else
                lacteo = new Comestible(codigo, nombre, importado, precio, fechaVenc, proveedor, peso);

            if (pos <= -1)
                listaLacteos.Add(lacteo);
            else
                listaLacteos.Insert(pos, lacteo);
        }

        public void AgregarProveedor(long cuit, string razonSocial, bool esNacional, int pos)
        {
            Proveedor proveedor = new Proveedor(cuit, razonSocial, esNacional);

            if (pos <= -1)
                listaProveedores.Add(proveedor);
            else
                listaProveedores.Insert(pos, proveedor);
        }

        public void EliminarElemento(int codigo)
        {
            if (Lacteo.CodigoValido(codigo))
            {
                foreach (Lacteo lacteo in listaLacteos) 
                {
                    if (lacteo.Codigo == codigo)
                    {
                        listaLacteos.Remove(lacteo);
                        break;
                    }
                }
            }
        }

        public void EliminarElemento(long cuit)
        {
            if (Proveedor.CuitValido(cuit))
            {
                foreach (Proveedor proveedor in listaProveedores)
                {
                    if (proveedor.Cuit == cuit)
                    {
                        listaProveedores.Remove(proveedor);
                        break;
                    }
                }
            }
        }

        public void EliminarElementoLacteo(int pos)
        {
            listaLacteos.RemoveAt(pos);
        }

        public void EliminarElementoProveedor(int pos)
        {
            listaProveedores.RemoveAt(pos);
        }

        public void ModificarProveedor (long cuit, string nombre, bool nacional)
        {
            Proveedor p = new Proveedor(cuit,nombre,nacional);
            int posicion = listaProveedores.IndexOf(p);
            if (posicion >= 0)
            {
                listaProveedores.RemoveAt(posicion);
                listaProveedores.Insert(posicion, p);
            }
        }

        public void ModificarBebible(int codigo, string nombre, bool importado, double precio, DateTime fechaVenc, long prov_cuit, double mililitros)
        {
            Proveedor proveedor = RecuperarProveedor(prov_cuit);
            Bebible l = new Bebible(codigo,nombre,importado,precio,fechaVenc,proveedor,mililitros);
            int posicion = listaLacteos.IndexOf(l);
            if (posicion >= 0)
            {
                listaLacteos.RemoveAt(posicion);
                listaLacteos.Insert(posicion, l);
            }
        }

        public void ModificarComestible(int codigo, string nombre, bool importado, double precio, DateTime fechaVenc, long prov_cuit, double mililitros)
        {
            Proveedor proveedor = RecuperarProveedor(prov_cuit);
            Comestible l = new Comestible(codigo, nombre, importado, precio, fechaVenc, proveedor, mililitros);
            int posicion = listaLacteos.IndexOf(l);
            if (posicion >= 0)
            {
                listaLacteos.RemoveAt(posicion);
                listaLacteos.Insert(posicion, l);
            }
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
                Coleccion c = (Coleccion)obj;
                List<string> listaL = Lacteos();
                List<string> listaP = Proveedores();
                return (listaL.Equals(c.Lacteos()) && listaP.Equals(c.Proveedores()));
            }
        }

        public override string ToString()
        {
            string toReturn = "Lácteos:";

            foreach(Lacteo lacteo in listaLacteos)
            {
                toReturn += $"\n :{lacteo.ToString()}";
            }

            toReturn += "\n--------------------------";

            foreach(Proveedor proveedor in listaProveedores)
            {
                toReturn += $"\n :{proveedor.ToString()}";
            }

            return toReturn;
        }

        public override int GetHashCode()
        {
            return (listaLacteos.Count * listaProveedores.Count * 100);
        }
        #endregion

        #region Consultas Proveedores

        private Proveedor RecuperarProveedor(string razonSocial)
        {
            foreach(Proveedor proveedor in listaProveedores)
            {
                if (proveedor.RazonSocial == razonSocial)
                    return proveedor;
            }
            return new Proveedor(razonSocial);
        }

        private Proveedor RecuperarProveedor(long cuit)
        {
            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor.Cuit == cuit)
                    return proveedor;
            }
            return new Proveedor(cuit);
        }

        public string RecuperarRazonSocial (long cuit)
        {
            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor.Cuit == cuit)
                    return proveedor.RazonSocial;
            }
            return "";
        }

        public bool RecuperarOrigen (long cuit)
        {
            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor.Cuit == cuit)
                    return proveedor.EsNacional;
            }
            return false;
        }

        public bool ExisteCuitProveedor(long cuit)
        {
            foreach(Proveedor proveedor in listaProveedores)
            {
                if (proveedor.Cuit == cuit)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ExisteRazonProveedor(string razonSocial)
        {
            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor.RazonSocial == razonSocial)
                {
                    return true;
                }
            }
            return false;
        }

        public List<string> ListarProveedores()
        {
            List<string> listaP = new List<string>();
            foreach (Proveedor p in listaProveedores)
                listaP.Add(p.ToString());
            return listaP;
        }

        public List<string> ListarProveedores(bool esNacional)
        {
            List<string> lista = new List<string>();
            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor.EsNacional == esNacional)
                {
                    lista.Add(proveedor.ToString());
                }
            }
            return lista;
        }

        public List<string> ListarNombreProveedores()
        {
            List<string> listaNombre = new List<string>();
            foreach (Proveedor p in listaProveedores)
                listaNombre.Add(p.RazonSocial);
            return listaNombre;
        }

        public List<string> ProductosXProveedor(long cuit)
        {
            List<string> toReturn = new List<string>();

            foreach(Lacteo lacteo in listaLacteos)
            {
                if (lacteo.Proveedor.Cuit == cuit)
                {
                    toReturn.Add(lacteo.ToString());
                }
            }

            return toReturn;
        }

        public long ObtenerCuitProveedor (string datos)
        {
            long cuit = 0;
            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor.ToString () == datos)
                {
                    cuit = proveedor.Cuit;
                    break;
                }
            }
            return cuit;
        }

        public long RecuperarCuitProveedor(string razonSocial)
        {
            long cuit = 0;
            foreach (Proveedor proveedor in listaProveedores)
            {
                if (proveedor.RazonSocial == razonSocial)
                {
                    cuit = proveedor.Cuit;
                    break;
                }
            }
            return cuit;
        }

        public int ObtenerCodigoLacteo(string datos)
        {
            int codigo = 0;
            foreach (Lacteo lacteo in listaLacteos)
            {
                if (lacteo.ToString() == datos)
                {
                    codigo = lacteo.Codigo;
                    break;
                }
            }
            return codigo;
        }

        #endregion

        #region Consultas Lacteos

        public bool BuscarLacteo(int codigo)
        {
            foreach(Lacteo lacteo in listaLacteos)
            {
                if(lacteo.Codigo == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        public bool BuscarLacteo(string nombre)
        {
            foreach(Lacteo lacteo in listaLacteos)
            {
                if (lacteo.Nombre == nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public double RecuperarMililitros(int codigo)
        {
            foreach (Lacteo lacteo in listaLacteos)
            {
                if (lacteo.GetType() == typeof(Bebible) && (lacteo.Codigo == codigo))
                {
                    Bebible bebible = (Bebible)lacteo;
                    return bebible.Mililitros;
                }
            }
            return -1;
        }

        public double RecuperarGramos(int codigo)
        {
            foreach (Lacteo lacteo in listaLacteos)
            {
                if (lacteo.GetType() == typeof(Comestible) && (lacteo.Codigo == codigo))
                {
                    Comestible comestible = (Comestible)lacteo;
                    return comestible.Gramos;
                }
            }
            return -1;
        }

        public string RecuperarNombre(int codigo)
        {
            foreach (Lacteo lacteo in listaLacteos)
            {
                if (lacteo.Codigo == codigo)
                    return lacteo.Nombre;
            }
            return "";
        }

        public bool RecuperarOrigen(int codigo)
        {
            foreach (Lacteo lacteo in listaLacteos)
            {
                if (lacteo.Codigo == codigo)
                    return lacteo.Nacional;
            }
            return false;
        }

        public double RecuperarPrecio(int codigo)
        {
            foreach (Lacteo lacteo in listaLacteos)
            {
                if (lacteo.Codigo == codigo)
                    return lacteo.Precio;
            }
            return -1;
        }

        public long RecuperarCuitProveedor(int codigo)
        {
            foreach (Lacteo lacteo in listaLacteos)
            {
                if (lacteo.Codigo == codigo)
                    return lacteo.Proveedor.Cuit;
            }
            return -1;
        }

        public DateTime RecuperarFecha(int codigo)
        {
            foreach (Lacteo lacteo in listaLacteos)
            {
                if (lacteo.Codigo == codigo)
                    return lacteo.FechaVenc;
            }
            return DateTime.MinValue;
        }

        public List<string> ListaNombreLacteos()
        {
            List<string> listaNombre = new List<string>();
            foreach (Lacteo lacteo in listaLacteos)
                listaNombre.Add(lacteo.Nombre);
            return listaNombre;
        }

        public List<string> Lacteos()
        {
            List<string> nuevaLista = new List<string>();
            foreach(Lacteo lacteo in listaLacteos)
            {
                nuevaLista.Add(lacteo.ToString());
            }
            return nuevaLista;
        }

        public List<string> Lacteos(bool filtroEsBebible, DateTime filtroFechaVenc, string filtroNombre = "Todos", string filtroRazonSocial = "Todos")
        {
            List<string> nuevaLista = new List<string>();
            Type filtroTipoBebible = filtroEsBebible ? typeof(Bebible) : typeof(Comestible);
            foreach(Lacteo lacteo in listaLacteos)
            {
                if ((lacteo.GetType() == filtroTipoBebible) && (filtroFechaVenc <= lacteo.FechaVenc) && (filtroNombre == "Todos" || filtroNombre == lacteo.Nombre) && (filtroRazonSocial == "Todos" || filtroRazonSocial == lacteo.Proveedor.RazonSocial))
                {
                    nuevaLista.Add(lacteo.ToString());
                }
            }

            return nuevaLista;
        }

        public List<string> Proveedores()
        {
            List<string> nuevaLista = new List<string>();
            foreach (Proveedor proveedor in listaProveedores)
            {
                nuevaLista.Add(proveedor.ToString());
            }
            return nuevaLista;
        }
        #endregion

        #endregion
    }
}