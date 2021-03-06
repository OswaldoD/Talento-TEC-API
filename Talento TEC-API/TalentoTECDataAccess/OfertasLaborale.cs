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
    
    public partial class OfertasLaborale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OfertasLaborale()
        {
            this.AplicanteXOfertas = new HashSet<AplicanteXOferta>();
            this.CarrerasProfesionales = new HashSet<CarrerasProfesionale>();
        }
    
        public int ID_OFERTA { get; set; }
        public int FK_ID_EMPRESA { get; set; }
        public string NOMBRE_PUESTO { get; set; }
        public string DESCRIPCION_PUESTO { get; set; }
        public string REQUISITOS_PUESTO { get; set; }
        public int MONTO_SALARIO { get; set; }
        public int FK_ID_TIPO_MONEDA { get; set; }
        public string FECHA_INICIO_OFERTA { get; set; }
        public string FECHA_FINAL_OFERTA { get; set; }
        public int FK_ID_TIPO_OFERTA { get; set; }
        public string NOMBRE_CONTACTO_OFERTA { get; set; }
        public string EMAIL_CONTACTO_OFERTA { get; set; }
        public string TELEFONO_CONTACTO_EMPRESA { get; set; }
        public string ESTADO_OFERTA { get; set; }
        public string ESTADO_CONFIDENCIALIDAD_OFERTA { get; set; }
        public int CANTIDAD_PLAZAS { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AplicanteXOferta> AplicanteXOfertas { get; set; }
        public virtual TipoMoneda TipoMoneda { get; set; }
        public virtual TipoOferta TipoOferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarrerasProfesionale> CarrerasProfesionales { get; set; }
    }
}
