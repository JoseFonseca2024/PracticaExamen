using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAeXAMEN.Clases
{
    public class ControladorPaciente
    {
        private List<Paciente> pacientes;

        public ControladorPaciente()
        {
            pacientes = new List<Paciente>();
        }

        public void RegistrarPaciente (Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public IEnumerable<Paciente> ObtenerPaceintes ()
        {
            return pacientes;
        }
    }
}
