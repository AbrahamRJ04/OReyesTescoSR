using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class ServicioSocial
    {
        public int IdServicioSocial { get; set; }
        public string NombreDependencia { get; set; }
        public ML.TipoDependencia Dependencia { get; set; }
        public string NombreDepartamento { get; set; }
        public string Domicilio { get; set; }
        public string Municipio { get; set; }
        public string Telefono { get; set; }
        public string ResponsableNombre { get; set; }
        public string CargoResponsable { get; set; }
        public ML.Programa Programa { get; set; }
        public string Actividades { get; set; }
        public int HorasAlDia { get; set; }
        public  string Turno { get; set; }
        public string FechaInicio { get; set; }
        public string FechaTermino { get; set; }
        public ML.TipoServicio TipoServicio { get; set; }

    }
}
