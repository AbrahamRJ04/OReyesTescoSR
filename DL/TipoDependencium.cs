using System;
using System.Collections.Generic;

namespace DL
{
    public partial class TipoDependencium
    {
        public TipoDependencium()
        {
            ServicioSocials = new HashSet<ServicioSocial>();
        }

        public int IdTipoDependencia { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<ServicioSocial> ServicioSocials { get; set; }
    }
}
