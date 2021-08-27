using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Leandro_Polano
{
    public class Persona
    {
        private string nombre;

        private string apellido;

        private string telefono;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Proveedor Proveedor
        {
            get => default;
            set
            {
            }
        }

        public Persona(string nombre, string apellido,string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;

        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

    }
}