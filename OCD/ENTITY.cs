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
    
    public partial class ENTITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENTITY()
        {
            this.ADVENTURERs = new HashSet<ADVENTURER>();
            this.MONSTERs = new HashSet<MONSTER>();
        }
    
        public decimal ENTITYID { get; set; }
        public long ROOMS { get; set; }
        public decimal INVENTORYID { get; set; }
        public decimal EQUIPMENTID { get; set; }
        public decimal MONEY { get; set; }
        public int HEALTH { get; set; }
        public int MAXHEALTH { get; set; }
        public string STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADVENTURER> ADVENTURERs { get; set; }
        public virtual INVENTORY INVENTORY { get; set; }
        public virtual INVENTORY INVENTORY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MONSTER> MONSTERs { get; set; }
    }
}
