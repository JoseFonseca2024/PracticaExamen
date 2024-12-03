using PRACTICAeXAMEN.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICAeXAMEN
{
    public partial class VerRegistro : Form
    {
        private ControladorPaciente controlador;
        public VerRegistro(ControladorPaciente controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        public void LlenarDatGriedview (IEnumerable<Paciente> pacientes)
        {
            dataGridView1.Rows.Clear();

            foreach (var paciente in pacientes)
            {
                dataGridView1.Rows.Add(paciente.Apellido, paciente.Nombre, paciente.FechaDeNacimiento, paciente.Dirección, paciente.Telefono);
            }
        }
    }
}
