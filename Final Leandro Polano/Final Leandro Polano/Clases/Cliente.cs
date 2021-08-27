using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Leandro_Polano
{
    public class Cliente : Persona
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Cliente(string email,string nombre, string apellido, string telefono) : base(nombre, apellido, telefono)
        {
            Email = email;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nEmail: {Email}";
        }
    }
}