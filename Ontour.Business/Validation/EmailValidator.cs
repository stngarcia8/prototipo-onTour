using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ontour.Business.Validation
{
public    class EmailValidator:Validador, IValidador
    {


        private string email;


        private EmailValidator(string email) : base()
        {
            this.email = email;
        }


        public static EmailValidator CrearValidador(string email)
        {
            return new EmailValidator(email );
        }


        public void Validar()
        {
this.ValidarVacio("email",this.email);
            this.ValidarFormato("email", this.email, this.emailExpresionRegular);
        }







    }
}
