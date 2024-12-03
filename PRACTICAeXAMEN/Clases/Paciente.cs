using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAeXAMEN.Clases
{
    public class Paciente
    {
        public string Apellido {  get; set; }
        public string Nombre { get; set; }
        public string FechaDeNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string Dirección { get; set; }
        public string Telefono { get; set; }
        public string Motivo { get; set; }
        public DateTime Fechadecosulta {  get; set; }

        public Paciente(string apellido, string nombre, string fechaDeNacimiento, Sexo sexo, string peso, string altura, string dirección, string telefono, string motivo, DateTime fechadecosulta)
        {
            Apellido = apellido;
            Nombre = nombre;
            FechaDeNacimiento = fechaDeNacimiento;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
            Dirección = dirección;
            Telefono = telefono;
            Motivo = motivo;
            Fechadecosulta = fechadecosulta;
        }

    }

    public enum Sexo
    {
        Masculino, 
        Femenino
    }
}
