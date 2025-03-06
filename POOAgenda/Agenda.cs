
namespace POOAgenda
{
    internal class Agenda
    {
        // Estos son campos con atributos de caracter privado
        private Contacto[] _contactos; //este almacena los contactos
        private int _tope; //Este otro nos ayuda a saber la cantidad de contactos registrados

        public Agenda()
        {
            _contactos = new Contacto[50];
            _tope = 0;
        }
        //metodo es void
        public void Agregar(Contacto contacto)
        {
            _contactos[_tope] = contacto;
            _tope++;
        }
        //_contactos es mi arreglo, tenemos dos metodos uno para agregar y otro para regresarlos y imprimirlos.
        public Contacto[] ObtenerContactos()
        {
            return _contactos;
        }
    }
}
