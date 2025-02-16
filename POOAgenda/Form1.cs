using System.Diagnostics.Contracts;

namespace POOAgenda
{
    public partial class Form1 : Form
    {
        private Agenda _agenda;
        public Form1()
        {
            InitializeComponent();
            _agenda = new Agenda();
            DgvContactos.AutoGenerateColumns = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DgvContactos.DataSource = null;


            string nombre = TxtNombre.Text;
            string telefono = TxtTelefono.Text;
            Contacto nuevoContacto = new Contacto(nombre, telefono);
            _agenda.Agregar(nuevoContacto);

            Contacto[] contactos = _agenda.ObtenerContactos();

            DgvContactos.DataSource = contactos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

    internal class Agenda
    {
        public Agenda()
        {
        }

        internal void Agregar(Contacto nuevoContacto)
        {
            throw new NotImplementedException();
        }

        internal Contacto[] ObtenerContactos()
        {
            throw new NotImplementedException();
        }
    }

    internal class DgvContactos
    {
        internal static bool AutoGenerateColumns;

        public static Contacto[] DataSource { get; internal set; }
    }

    internal class Contacto
    {
        public Contacto(string nombre, string telefono)
        {
        }
    }
}