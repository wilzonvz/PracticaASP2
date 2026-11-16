using System;

namespace WebApplication2.Models
{
    public class Alumno
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Pension { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }

        public Alumno(int pCodigo, string pNombre, double pPension, DateTime pFechaNacimiento)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Pension = pPension;
            FechaNacimiento = pFechaNacimiento;
            Activo = true;
        }
    }
}
