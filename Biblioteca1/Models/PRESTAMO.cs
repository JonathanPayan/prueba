//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRESTAMO
    {
        public int ID { get; set; }
        public System.DateTime FECHA { get; set; }
        public System.DateTime ENTREGA { get; set; }
        public int USUARIO_ID { get; set; }
        public int LIBRO_ID { get; set; }
    
        public virtual LIBRO LIBRO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}