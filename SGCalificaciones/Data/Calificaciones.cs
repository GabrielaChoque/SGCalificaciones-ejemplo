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
    
    public partial class Calificaciones
    {
        public int id_calificacion { get; set; }
        public Nullable<int> calificacion { get; set; }
        public Nullable<int> nro_carnet { get; set; }
        public Nullable<int> id_criterio { get; set; }
        public Nullable<int> id_materia { get; set; }
    
        public virtual Criterio Criterio { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual Materia Materia { get; set; }
    }
}
