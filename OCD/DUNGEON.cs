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
    
    public partial class DUNGEON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DUNGEON()
        {
            this.ADVENTURERs = new HashSet<ADVENTURER>();
        }
    
        public decimal DUNGEONID { get; set; }
        public int ROOMSDONE { get; set; }
        public int ROOMSDONEHIGHEST { get; set; }
        public Nullable<decimal> MONSTERID { get; set; }
        public bool REFRESHSHOP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADVENTURER> ADVENTURERs { get; set; }
        public virtual MONSTER MONSTER { get; set; }
    }
}
