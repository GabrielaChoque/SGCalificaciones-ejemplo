//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGCalificaciones.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Criterio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Criterio()
        {
            this.Calificaciones = new HashSet<Calificaciones>();
        }
    
        public int id_criterio { get; set; }
        public string desc_criterio { get; set; }
        public Nullable<int> id_bimestre { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> nro_carnet { get; set; }
    
        public virtual Bimestre Bimestre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calificaciones> Calificaciones { get; set; }
        public virtual Plantel_Educativo Plantel_Educativo { get; set; }
    }
}
