using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ontour.Business.Validation
{
public    class RutValidator:Validador,IValidador
    {


        private string rut;


private RutValidator(string rut) : base()
        {
            this.rut = rut;
        }


        public static RutValidator CrearValidador(string rutQueValidar)
        {
            return new RutValidator(rutQueValidar);
        }


        public void Validar()
        {
            this.ValidarVacio("rut", this.rut);
            this.ValidarFormato("rut", this.rut, this.rutExpresionRegular);
            this.ValidarRut();
        }


        private void ValidarRut()
        {
            if (this.ErrorValidacion) return;
            string myRut = this.rut.Replace(".", "").ToUpper();
            string[] rutTemp = myRut.Split('-');
            string verificadorTemp = this.obtenerDigitoVerificador(int.Parse(rutTemp[0].ToString()));
            if (rutTemp[1].ToString().Equals(verificadorTemp))
            {
                this.ErrorValidacion = false;
                this.MensajeError = string.Empty;
                return;
            }
            this.ErrorValidacion = true;
            this.MensajeError = "El rut ingresado es incorrecto";
        }


        private string obtenerDigitoVerificador(int nroRut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (nroRut != 0)
            {
                multiplicador++;
                if (multiplicador == 8) multiplicador = 2;
                suma += (nroRut % 10) * multiplicador;
                nroRut = nroRut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }





    }
}
