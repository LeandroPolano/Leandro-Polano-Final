using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Leandro_Polano
{
    public class Proveedor
    {
        private string nombreFantasia;

        public string NombreFantasia
        {
            get { return nombreFantasia; }
            set { nombreFantasia = value; }
        }

        public Persona persona { get; set; }

        public List<string> Telefonos { get; set; }

        public Proveedor(string nombreFantasia, Persona persona)
        {
            NombreFantasia = nombreFantasia;
            this.persona = persona;
        }
        public override string ToString()
        {
            return $" El Proveedor {NombreFantasia} \n {persona.ToString()}";
        }
        public void AgregarTelefonos(string telefono)
        {
            Telefonos.Add(telefono);
        }
    }
}