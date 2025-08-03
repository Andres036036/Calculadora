using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.net
{
    internal class Persona
    {
        private String name { get; set; }
        private String email { get; set; }
        private String phone { get; set; }

        public Persona(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
        public string mostrarpersona ()
            {
            return "Nombre: "+name+" Correo: "+email+" Telefono: "+phone;
            }
    }
}
