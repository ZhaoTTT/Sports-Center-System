﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportFacilityBookingSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NewSportsEntities : DbContext
    {
        public NewSportsEntities()
            : base("name=NewSportsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AddFacility> AddFacilities { get; set; }
        public virtual DbSet<BookingInfo> BookingInfoes { get; set; }
        public virtual DbSet<CancelInfo> CancelInfoes { get; set; }
        public virtual DbSet<FacilityDetail> FacilityDetails { get; set; }
        public virtual DbSet<MemberCategory> MemberCategories { get; set; }
        public virtual DbSet<MemberInformation> MemberInformations { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
    }
}
