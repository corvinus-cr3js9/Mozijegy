//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alkalmazas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jegy
    {
        public int JEGY_PK { get; set; }
        public int VETITES_FK { get; set; }
        public string VENDEG_NEV { get; set; }
        public int KATEGORIA_FK { get; set; }
    
        public virtual Vetítés Vetítés { get; set; }
        public virtual Kategória Kategória { get; set; }
    }
}
