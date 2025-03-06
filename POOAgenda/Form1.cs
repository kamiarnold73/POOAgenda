namespace POOAgenda
{
    //herencia
    public partial class Form1 : Form
    {
        //Instancia y Campo de Agenda
        private Agenda _agenda;
        public Form1()
        {
            InitializeComponent();
            _agenda = new Agenda();
            DgvContactos.AutoGenerateColumns = false;
        }


        //Método de void
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtNombre.Text + "-" + TxtTelefono.Text);
        }


        private void Telefono(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DgvContactos.DataSource = null;


            string nombre = TxtNombre.Text;
            string telefono = TxtTelefono.Text;

            //Este es otro CAMPO
            // Contacto nuevoContacto = new Contacto(nombre, telefono);
            ContactoConEmail nuevoContactoConEmail = new ContactoConEmail(nombre, telefono);


            //Este nos ayuda a agregar un CONTACTO, y tambien esta el METODO DE ENCAPSULAR
            //_agenda.Agregar(nuevoContacto);
            _agenda.Agregar(nuevoContactoConEmail);

            //Este es un ARREGLO
            Contacto[] contactos = _agenda.ObtenerContactos();

            DgvContactos.DataSource = contactos;

        }

        private void DgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}