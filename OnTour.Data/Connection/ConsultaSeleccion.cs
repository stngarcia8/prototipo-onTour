﻿using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace OnTour.Data.Connection
{
    public class ConsultaSeleccion:Consulta,IConsultaSeleccion
    {

        private ConsultaSeleccion(OracleCommand comando):base(comando) {}


        public static ConsultaSeleccion CrearConsulta(OracleCommand comando)
        {
            return new ConsultaSeleccion(comando);
        }


        public DataTable EjecutarConsulta()
        {
            DataTable myDataTable = new DataTable();
            try
            {
                OracleDataAdapter myAdapter = new OracleDataAdapter();
                myAdapter.SelectCommand = comando;
                myAdapter.Fill(myDataTable);
            }
            catch 
            {
                throw;
            }
            return myDataTable;
        }


        public void LimpiarParametros()
        {
            base.ClearParameters();
        }






    }
}
