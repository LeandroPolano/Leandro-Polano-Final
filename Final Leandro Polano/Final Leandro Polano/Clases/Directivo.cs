using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Leandro_Polano
{
    public class Directivo : Empleado
    {
        public string categorias { get; set; }

        public List<Persona> personas { get; set; }

        public Directivo(string categorias, int edad, string sector, string nombre, string apellido, string telefono) : base(edad, sector, nombre, apellido, telefono)
        {
            this.categorias = categorias;

            Edad = edad;
            Sector = sector;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

    }
}