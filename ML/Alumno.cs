using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Alumno
    {
        //  SELECT[IdAlumno]
        //,[Nombre]
        //,[ApellidoPaterno]
        //,[ApellidoMaterno]
        //,[CorreoInstitucional]
        //,[Telefono]
        //,[Edad]
        //,[Sexo]
        //,[IdCarrera]
        //,[Curp]
        //,[NumeroCreditos]
        //,[VidaAcademica]
        //,[Promedio]
        //,[IdServicioSocial]
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public ML.Carrera Carreras { get; set; }
        public string Curp { get; set; }
        public string NumeroCreditos { get; set; }
        public string VidaAcademica { get; set; }
        public decimal Promedio { get; set; }
        public ML.ServicioSocial ServicioSocial {get; set;}

    }
}
