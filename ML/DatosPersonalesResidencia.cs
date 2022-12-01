using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class DatosPersonalesResidencia
    {
        public int IdCandidato { get; set; }
        public string NombreCompleto { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Calle { get; set; }
        public int NoExt { get; set; }
        public int NoInt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public ML.Carrera Carrera { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
        public int VidaAcademica { get; set; }
        public int NoCreditos { get; set; }
        public string ConstanciaTerminoServicioSocial { get; set; }
    }
}
