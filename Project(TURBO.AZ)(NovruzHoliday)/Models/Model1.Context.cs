﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TurboAzEntities : DbContext
    {
        public TurboAzEntities()
            : base("name=TurboAzEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminPanel> AdminPanels { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Car_Year> Car_Year { get; set; }
        public virtual DbSet<EnginerPower> EnginerPowers { get; set; }
        public virtual DbSet<Fuel> Fuels { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<SelledCar> SelledCars { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<UserPanel> UserPanels { get; set; }
    }
}