//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ex2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Universitati
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Universitati()
        {
            this.Facultatis = new HashSet<Facultati>();
        }
    
        public int Id { get; set; }
        public string NameUniv { get; set; }
        public string City { get; set; }
        public int Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facultati> Facultatis { get; set; }
    }
}
