using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Leandro_Polano
{
    public class Empleado : Persona
    {
        private int edad;

        private string sector;

        private decimal sueldo;

        public decimal Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public string Sector
        {
            get { return sector; }
            set { sector = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Empleado(int edad, string sector, string nombre, string apellido, string telefono):base(nombre, apellido, telefono)
        {
            Edad = edad;
            Sector = sector;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;

        }

        public override string ToString()
        {
            return $"{base.ToString()} \nEdad: {Edad} \nSector: {Sector} \nSueldo: {Sueldo}";
        }

    }
}