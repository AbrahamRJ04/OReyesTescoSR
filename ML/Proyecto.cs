using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public ML.ModalidadResidencias ModalidadResidencias { get; set; }
        public string NombreIntegranteUno { get; set; }
        public string NombreIntegranteDos { get; set; }
        public string MatriculaIntegranteUno { get; set; }
        public string MatriculaIntegranteDos { get; set; }
        public string NombreProyecto { get; set; }
        public string NombreAsesorTesco { get; set; }
        public string NombreAsesorDependencia { get; set; }
        public ML.DatosPersonalesResidencia Candidato { get; set; }
        public ML.EmpresaResidencias EmpresaResidencias { get; set; }
    }
}
