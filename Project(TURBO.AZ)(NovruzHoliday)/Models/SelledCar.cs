//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_TURBO.AZ__NovruzHoliday_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SelledCar
    {
        public int ID { get; set; }
        public Nullable<int> ModelIDs { get; set; }
        public Nullable<int> YearIDs { get; set; }
        public Nullable<int> EpowIDs { get; set; }
        public Nullable<int> FuelIDs { get; set; }
        public Nullable<int> StatusIDs { get; set; }
        public string By { get; set; }
    
        public virtual Car_Year Car_Year { get; set; }
        public virtual EnginerPower EnginerPower { get; set; }
        public virtual Fuel Fuel { get; set; }
        public virtual Model Model { get; set; }
        public virtual Status Status { get; set; }
    }
}
