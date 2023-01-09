using System;
using System.Collections.Generic;

namespace DL;

public partial class EmpresaResidencia
{
    public int IdEmpresaResidencias { get; set; }

    public string? NombreDeEmpresa { get; set; }

    public int? IdTipoEmpresa { get; set; }

    public int? IdGiro { get; set; }

    public int? IdSector { get; set; }

    public string? NombreTitular { get; set; }

    public string? Cargo { get; set; }

    public string? Telefono { get; set; }

    public string? Extencion { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Calle { get; set; }

    public string? NoExt { get; set; }

    public string? NoInt { get; set; }

    public string? Colonia { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public string? CodigoPostal { get; set; }

    public string? PaginaWeb { get; set; }

    public string? RedSocial { get; set; }

    public virtual GiroEmpresa? IdGiroNavigation { get; set; }

    public virtual Sector? IdSectorNavigation { get; set; }

    public virtual TipoEmpresa? IdTipoEmpresaNavigation { get; set; }

    public virtual ICollection<Proyecto> Proyectos { get; } = new List<Proyecto>();
}
