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
    
    public partial class INVENTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVENTORY()
        {
            this.ADVENTURERs = new HashSet<ADVENTURER>();
            this.ENTITies = new HashSet<ENTITY>();
            this.ENTITies1 = new HashSet<ENTITY>();
            this.SLOTs = new HashSet<SLOT>();
        }
    
        public decimal INVENTORYID { get; set; }
        public byte SLOTQUANTITY { get; set; }
        public string INSERTPOLICY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADVENTURER> ADVENTURERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTITY> ENTITies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTITY> ENTITies1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLOT> SLOTs { get; set; }
    }
}
