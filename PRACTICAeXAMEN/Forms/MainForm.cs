using PRACTICAeXAMEN.Clases;
using PRACTICAeXAMEN.Forms;


namespace PRACTICAeXAMEN
{
    public partial class MainForm : Form
    {
        VerRegistro? verRegistroForm;
        VerHistorial? VerHistorialForm;
        ControladorPaciente controlador = new ControladorPaciente();

        public MainForm()
        {
            InitializeComponent();
            VerHistorialForm = new VerHistorial(controlador);
            verRegistroForm = new VerRegistro(controlador);
            MostrarFormenTabPage(verRegistroForm, tabPageRegistro);
        }

        private void MostrarFormenTabPage(Form formulario, TabPage tabPage)
        {
            tabPage.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();

            tabControl1.SelectedTab = tabPage;
        }

        private void AñadiralRegistro(object sender, EventArgs e)
        {
            MostrarFormenTabPage(verRegistroForm, tabPageRegistro);
            if (!validarcampos()) return;

            // Obtener el valor del sexo basado en el botón de radio seleccionado
            Sexo sexo = new Sexo();
            if (rbtMasculino.Checked)
            {
                sexo = Sexo.Masculino; // Asigna el valor correspondiente
            }
            else if (rbtFemenino.Checked)
            {
                sexo = Sexo.Femenino; // Asigna el valor correspondiente
            }

            string apellido = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string fecha = mtbFecha.Text; // Asegúrate de que este formato sea válido
            string peso = mtbPeso.Text;
            string altura = mtbAltura.Text; // Cambiado a mtbAltura
            string direccion = txtDirección.Text;
            string telefono = mtbTelefono.Text;
            string motivo = txtConsulta.Text;
            DateTime fechaconsulta = dateTimePicker1.Value;

            var paciente = new Paciente(apellido, nombres, fecha, sexo, peso, altura, direccion, telefono, motivo, fechaconsulta);
            controlador.RegistrarPaciente(paciente);
            verRegistroForm.LlenarDatGriedview(controlador.ObtenerPaceintes());
        }


        private bool validarcampos()
        {
            if (string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(mtbFecha.Text) || string.IsNullOrEmpty(mtbPeso.Text) || string.IsNullOrEmpty(mtbAltura.Text) || string.IsNullOrEmpty(txtDirección.Text) || string.IsNullOrEmpty(mtbTelefono.Text) || string.IsNullOrEmpty(txtConsulta.Text) || !rbtFemenino.Checked && !rbtMasculino.Checked)
            {
                MessageBox.Show("Rellene todo los campos requeridos", "Rellene los campos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private void LimpiarCampos(object sender, EventArgs e)
        {
            txtApellidos.Clear();
            txtNombres.Clear();
            rbtFemenino.Checked = false;
            rbtMasculino.Checked = false;
            mtbFecha.Clear();
            mtbPeso.Clear();
            mtbAltura.Clear();
            txtConsulta.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtDirección.Clear();

        }

        private void Mostrarstatus(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Presione para guardar en Registro";
        }

        private void MostrarStatus(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Presione para guardar en Historal Medico";
        }

        private void mostrarStatus(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Presione para limpiar los campos";
        }

        private void MostrarForm(object sender, EventArgs e)
        {
            // Verificar si el tab seleccionado es el de historial
            if (tabControl1.SelectedTab == tabPageVerHistorial)
            {
                MostrarFormenTabPage(VerHistorialForm, tabPageVerHistorial);
                VerHistorialForm.LlenarDataGriedview(controlador.ObtenerPaceintes()); // Llenar el DataGridView
            }
        }

        private void Salirdeprograma()
        {
            DialogResult respues = MessageBox.Show("Esta seguro que quiere salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respues == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }

        private void salir(object sender, EventArgs e)
        {
            Salirdeprograma();
        }

        private void MostrarEstado(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Presione para salir del sistema";
        }
    }


}
