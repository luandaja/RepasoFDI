//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Matricula
    {
        public int MatriculaID { get; set; }
        public int FK_AlumnoID { get; set; }
        public int FK_CursoID { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
