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
    
    public partial class Vetítés
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vetítés()
        {
            this.Jegy = new HashSet<Jegy>();
        }
    
        public int VETITES_PK { get; set; }
        public int FILM_FK { get; set; }
        public int MOZI_FK { get; set; }
        public int TEREM_FK { get; set; }
        public int NAP_FK { get; set; }
        public int IDOPONTOK_FK { get; set; }
    
        public virtual Film Film { get; set; }
        public virtual Időpont Időpont { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jegy> Jegy { get; set; }
        public virtual Mozi Mozi { get; set; }
        public virtual Nap Nap { get; set; }
        public virtual Terem Terem { get; set; }
    }
}
