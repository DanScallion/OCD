﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADVENTURER> ADVENTURERs { get; set; }
        public virtual DbSet<DUNGEON> DUNGEONs { get; set; }
        public virtual DbSet<ENTITY> ENTITies { get; set; }
        public virtual DbSet<INVENTORY> INVENTORies { get; set; }
        public virtual DbSet<ITEM> ITEMs { get; set; }
        public virtual DbSet<ITEMTYPE> ITEMTYPEs { get; set; }
        public virtual DbSet<LORD> LORDs { get; set; }
        public virtual DbSet<MONSTER> MONSTERs { get; set; }
        public virtual DbSet<MONSTERNAME> MONSTERNAMEs { get; set; }
        public virtual DbSet<SLOT> SLOTs { get; set; }
    
        public virtual int ATTACK()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ATTACK");
        }
    
        public virtual int BUYITEM(Nullable<decimal> p_ADVENTURERID, Nullable<decimal> p_ITEMID)
        {
            var p_ADVENTURERIDParameter = p_ADVENTURERID.HasValue ?
                new ObjectParameter("P_ADVENTURERID", p_ADVENTURERID) :
                new ObjectParameter("P_ADVENTURERID", typeof(decimal));
    
            var p_ITEMIDParameter = p_ITEMID.HasValue ?
                new ObjectParameter("P_ITEMID", p_ITEMID) :
                new ObjectParameter("P_ITEMID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BUYITEM", p_ADVENTURERIDParameter, p_ITEMIDParameter);
        }
    
        public virtual int CHANGESTATUS(Nullable<decimal> p_ENTITYID, string p_STATUS)
        {
            var p_ENTITYIDParameter = p_ENTITYID.HasValue ?
                new ObjectParameter("P_ENTITYID", p_ENTITYID) :
                new ObjectParameter("P_ENTITYID", typeof(decimal));
    
            var p_STATUSParameter = p_STATUS != null ?
                new ObjectParameter("P_STATUS", p_STATUS) :
                new ObjectParameter("P_STATUS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CHANGESTATUS", p_ENTITYIDParameter, p_STATUSParameter);
        }
    
        public virtual int CREATELORD(string p_LOGIN, string p_PASS1, string p_PASS2)
        {
            var p_LOGINParameter = p_LOGIN != null ?
                new ObjectParameter("P_LOGIN", p_LOGIN) :
                new ObjectParameter("P_LOGIN", typeof(string));
    
            var p_PASS1Parameter = p_PASS1 != null ?
                new ObjectParameter("P_PASS1", p_PASS1) :
                new ObjectParameter("P_PASS1", typeof(string));
    
            var p_PASS2Parameter = p_PASS2 != null ?
                new ObjectParameter("P_PASS2", p_PASS2) :
                new ObjectParameter("P_PASS2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CREATELORD", p_LOGINParameter, p_PASS1Parameter, p_PASS2Parameter);
        }
    
        public virtual int FLEE(Nullable<decimal> p_ADVENTURERID)
        {
            var p_ADVENTURERIDParameter = p_ADVENTURERID.HasValue ?
                new ObjectParameter("P_ADVENTURERID", p_ADVENTURERID) :
                new ObjectParameter("P_ADVENTURERID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FLEE", p_ADVENTURERIDParameter);
        }
    
        public virtual int MOVEITEM(Nullable<decimal> p_INVENTORYIDFROM, Nullable<decimal> p_INVENTORYIDTO, Nullable<decimal> p_ITEMID)
        {
            var p_INVENTORYIDFROMParameter = p_INVENTORYIDFROM.HasValue ?
                new ObjectParameter("P_INVENTORYIDFROM", p_INVENTORYIDFROM) :
                new ObjectParameter("P_INVENTORYIDFROM", typeof(decimal));
    
            var p_INVENTORYIDTOParameter = p_INVENTORYIDTO.HasValue ?
                new ObjectParameter("P_INVENTORYIDTO", p_INVENTORYIDTO) :
                new ObjectParameter("P_INVENTORYIDTO", typeof(decimal));
    
            var p_ITEMIDParameter = p_ITEMID.HasValue ?
                new ObjectParameter("P_ITEMID", p_ITEMID) :
                new ObjectParameter("P_ITEMID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MOVEITEM", p_INVENTORYIDFROMParameter, p_INVENTORYIDTOParameter, p_ITEMIDParameter);
        }
    
        public virtual int NEXTFIGHT(Nullable<decimal> p_ADVENTURERID)
        {
            var p_ADVENTURERIDParameter = p_ADVENTURERID.HasValue ?
                new ObjectParameter("P_ADVENTURERID", p_ADVENTURERID) :
                new ObjectParameter("P_ADVENTURERID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NEXTFIGHT", p_ADVENTURERIDParameter);
        }
    
        public virtual int SELLITEM(Nullable<decimal> p_ADVENTURERID, Nullable<decimal> p_ITEMID)
        {
            var p_ADVENTURERIDParameter = p_ADVENTURERID.HasValue ?
                new ObjectParameter("P_ADVENTURERID", p_ADVENTURERID) :
                new ObjectParameter("P_ADVENTURERID", typeof(decimal));
    
            var p_ITEMIDParameter = p_ITEMID.HasValue ?
                new ObjectParameter("P_ITEMID", p_ITEMID) :
                new ObjectParameter("P_ITEMID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SELLITEM", p_ADVENTURERIDParameter, p_ITEMIDParameter);
        }
    
        public virtual int SWITCHADVENTURER(Nullable<decimal> p_LORDID, Nullable<decimal> p_ADVENTURERID)
        {
            var p_LORDIDParameter = p_LORDID.HasValue ?
                new ObjectParameter("P_LORDID", p_LORDID) :
                new ObjectParameter("P_LORDID", typeof(decimal));
    
            var p_ADVENTURERIDParameter = p_ADVENTURERID.HasValue ?
                new ObjectParameter("P_ADVENTURERID", p_ADVENTURERID) :
                new ObjectParameter("P_ADVENTURERID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SWITCHADVENTURER", p_LORDIDParameter, p_ADVENTURERIDParameter);
        }
    }
}
