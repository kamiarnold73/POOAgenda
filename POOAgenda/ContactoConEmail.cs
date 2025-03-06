using System.Diagnostics.Contracts;

namespace POOAgenda
{
    //el constructor es un metodo especial, se debe llamar igual que la clase
    class ContactoConEmail : Contacto
    {
        public ContactoConEmail(string nombre, string telefono)
            : base(nombre, telefono)

        {
        }
    }

    internal class Contacto
    {
        public Contacto(string nombre, string telefono)
        {
        }
    }
}