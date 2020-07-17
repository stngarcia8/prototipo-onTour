using System;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Data.Connection
{
    public class ConectarOracle : IConectarOracle, IDisposable
    {

        // Miembros.
        private bool disposed = false;
        private OracleConnection coneccion;
        private OracleTransaction transaccion;
        private readonly string cadenaDeConeccion;


        // Constructor.
        private ConectarOracle()
        {
            cadenaDeConeccion = generarCadenaDeConeccion();
        }


        // Metodo de creacion del objeto.
        public static ConectarOracle crearConeccion()
        {
            return new ConectarOracle();
        }


        // Genera la cadena de coneccin a la base de datos.
        private string generarCadenaDeConeccion()
        {
            return string.Format("Data Source={0};User Id={1};Password={2};", "localhost", "ontour", "ontour");
        }


        //  Metodo que retorna el objeto de conección.
        public OracleConnection ObtenerConeccion()
        {
            if (coneccion == null)
            {
                InicializarObjetos();
            }
            return coneccion;
        }


        //  Metodo que retorna el objeto de transaccion.
        public OracleTransaction ObtenerTransaccion()
        {
            if (transaccion == null)
            {
                InicializarObjetos();
            }
            return transaccion;
        }


        //  Metodo que inicializa los objetos de conección.
        private void InicializarObjetos()
        {
            try
            {
                coneccion = new OracleConnection(cadenaDeConeccion);
                coneccion.Open();
                transaccion = coneccion.BeginTransaction();
            }
            catch
            {
                throw;
            }
        }



        // Metodo para hacer commit a la bdd.
        public void Commit()
        {
            if (transaccion != null) transaccion.Commit();
        }


        // Metodo para hacer rollback a la bdd.
        public void RollBack()
        {
            if (transaccion != null) transaccion.Rollback();
        }


        // Metodo que crea objetos de consulta de seleccion (SELECT)
        public IConsultaSeleccion CrearConsultaSeleccion(string sql)
        {
            try
            {
                var comando = ObtenerConeccion().CreateCommand();
                comando.CommandText = sql;
                comando.Transaction = transaccion;
                return ConsultaSeleccion.CrearConsulta(comando);
            }
            catch
            {
                throw;
            }
        }


        // Metodo que crea objetos de consulta de accion (INSERT, UPDATE, DELETE)
        public IConsultaAccion CrearConsultaAccion(string nombreProcedimientoAlmacenado)
        {
            try
            {
                var comando = ObtenerConeccion().CreateCommand();
                comando.CommandText = nombreProcedimientoAlmacenado;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Transaction = transaccion;
                return ConsultaAccion.CrearConsulta(comando);
            }
            catch
            {
                throw;
            }
        }


        // Metodo para cerrar los objetos de la bdd.
        public void cerrarConeccion()
        {
            if (transaccion != null)
            {
                transaccion.Dispose();
                transaccion = null;
            }
            if (coneccion != null)
            {
                coneccion.Dispose();
                coneccion = null;
            }
        }


        // Destructor.
        #region "Destructor."

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                if (transaccion != null)
                {
                    transaccion.Dispose();
                    transaccion = null;
                }
                if (coneccion != null)
                {
                    coneccion.Dispose();
                    coneccion = null;
                }
            }
            disposed = true;
        }

        ~ConectarOracle()
        {
            Dispose(false);
        }

        #endregion

    }
}
