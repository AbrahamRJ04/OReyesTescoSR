using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class EmpresaResidencias
    {
        public int IdEmpresaResidencias { get; set; }
        public string NombreDeEmpresa { get; set; }
        public ML.TipoEmpresa TipoEmpresa { get; set; }
        public ML.GiroEmpresa Giro { get; set; }
        public ML.Sector Sector { get; set; }
        public string NombreTitular { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Extencion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Calle { get; set; }
        public string NoExt { get; set; }
        public string NoInt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string PaginaWeb { get; set; }
        public string RedSocial { get; set; }
    }
}
