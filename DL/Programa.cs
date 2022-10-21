using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Programa
    {
        public Programa()
        {
            ServicioSocials = new HashSet<ServicioSocial>();
        }

        public int IdPrograma { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<ServicioSocial> ServicioSocials { get; set; }
    }
}
