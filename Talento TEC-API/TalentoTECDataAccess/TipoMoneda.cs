//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TalentoTECDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoMoneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoMoneda()
        {
            this.OfertasLaborales = new HashSet<OfertasLaborale>();
        }
    
        public int ID_TIPO_MONEDA { get; set; }
        public string NOMBRE_TIPO_MONEDA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfertasLaborale> OfertasLaborales { get; set; }
    }
}
