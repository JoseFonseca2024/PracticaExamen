using PRACTICAeXAMEN.Clases;


namespace PRACTICAeXAMEN.Forms
{
    public partial class VerHistorial : Form
    {
        private ControladorPaciente controlador;
        public VerHistorial(ControladorPaciente controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        public void LlenarDataGriedview(IEnumerable<Paciente> pacientes)
        {
            dataGridView1.Rows.Clear();
            foreach (var paciente in pacientes) 
            {
                dataGridView1.Rows.Add(paciente.Apellido, paciente.Nombre, paciente.FechaDeNacimiento, paciente.Sexo, paciente.Peso, paciente.Altura, paciente.Motivo);
            }
        }
    }
}
