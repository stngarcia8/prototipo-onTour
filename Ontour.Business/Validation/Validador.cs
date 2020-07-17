using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ontour.Business.Validation
{
public abstract    class Validador
    {


        protected string rutExpresionRegular = "^([0-9]+-[0-9K])$";
        protected string emailExpresionRegular = @"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$";
        public bool ErrorValidacion { get; set; }
        public string MensajeError { get; set; }


        protected Validador()
        {
            this.ErrorValidacion = false;
            this.MensajeError = string.Empty;
        }


        protected void ValidarVacio(string unNombreDeValidador, string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                this.ErrorValidacion = true;
                this.MensajeError = "El " + unNombreDeValidador + " esta vacío";
            }
        }


        protected void ValidarFormato(string unNombreValidador, string valor, string unaExpresionRegular)
        {
            if (this.ErrorValidacion) return;
            Regex expresion = new Regex(unaExpresionRegular);
            if (!expresion.IsMatch(valor))
            {
                this.ErrorValidacion = true;
                this.MensajeError = "Formato de " + unNombreValidador + " inválido";
                return;
            }
            this.ErrorValidacion = false;
            this.MensajeError = string.Empty;
        }


        public override string ToString()
        {
            return (string.IsNullOrEmpty(this.MensajeError)?string.Empty:this.MensajeError);
        }



    }
}
