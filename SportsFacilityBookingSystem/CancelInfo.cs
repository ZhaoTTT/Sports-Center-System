//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CancelInfo
    {
        public int CancelTransID { get; set; }
        public int MemberID { get; set; }
        public int FacilityCode { get; set; }
        public int SlotID { get; set; }
        public Nullable<System.DateTime> Booking_Date_and_Time { get; set; }
        public string Remark { get; set; }
    
        public virtual AddFacility AddFacility { get; set; }
        public virtual MemberInformation MemberInformation { get; set; }
        public virtual Slot Slot { get; set; }
    }
}