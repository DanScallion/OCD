//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OCD
{
    using System;
    using System.Collections.Generic;
    
    public partial class MONSTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONSTER()
        {
            this.DUNGEONs = new HashSet<DUNGEON>();
        }
    
        public decimal MONSTERID { get; set; }
        public decimal NAMEID { get; set; }
        public decimal ENTITYID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DUNGEON> DUNGEONs { get; set; }
        public virtual ENTITY ENTITY { get; set; }
        public virtual MONSTERNAME MONSTERNAME { get; set; }
    }
}