using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoCursoDetalle : Dao
    {



        private DaoCursoDetalle() : base() { }


        public static DaoCursoDetalle CrearDao()
        {
            return new DaoCursoDetalle();
        }


                public int Limpiar(int idCurso)
        {
            try
            {
                var myQuery = this.DefinirObjetoConsultaAccion("spProcesarCurso_limpiar");
                myQuery.AgregarParametro(":pIdCurso", idCurso, DbType.Int32);
                return myQuery.EjecutarConsulta();
            }
            catch
            {
                throw;
            }
        }










    }
}
