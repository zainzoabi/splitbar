﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace splitbar
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GMS_DAYAGEntities : DbContext
    {
        public GMS_DAYAGEntities()
            : base("name=GMS_DAYAGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountItemsTBL> AccountItemsTBL { get; set; }
        public virtual DbSet<AccountTBL> AccountTBL { get; set; }
        public virtual DbSet<AgentTBL> AgentTBL { get; set; }
        public virtual DbSet<BarcodePartsTBL> BarcodePartsTBL { get; set; }
        public virtual DbSet<carTBL> carTBL { get; set; }
        public virtual DbSet<CatalogVetrinarTBL> CatalogVetrinarTBL { get; set; }
        public virtual DbSet<CatArkavaTBL> CatArkavaTBL { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryVetrinarTBL> CategoryVetrinarTBL { get; set; }
        public virtual DbSet<catTBL> catTBL { get; set; }
        public virtual DbSet<DistLineTBL> DistLineTBL { get; set; }
        public virtual DbSet<GMS_MLAY> GMS_MLAY { get; set; }
        public virtual DbSet<GMS_MLAY_History> GMS_MLAY_History { get; set; }
        public virtual DbSet<GMS_MLAY_SFIRA> GMS_MLAY_SFIRA { get; set; }
        public virtual DbSet<GMS_MLAY_SFIRA_Test> GMS_MLAY_SFIRA_Test { get; set; }
        public virtual DbSet<GMS_MLAY_Test> GMS_MLAY_Test { get; set; }
        public virtual DbSet<InMlayItemsTBL> InMlayItemsTBL { get; set; }
        public virtual DbSet<InMlayTBL> InMlayTBL { get; set; }
        public virtual DbSet<InMlayTBL_Test> InMlayTBL_Test { get; set; }
        public virtual DbSet<ItemsPerAccountTBL> ItemsPerAccountTBL { get; set; }
        public virtual DbSet<ItemsToChargeTBL> ItemsToChargeTBL { get; set; }
        public virtual DbSet<LocationsTBL> LocationsTBL { get; set; }
        public virtual DbSet<MlayInProcessTBL> MlayInProcessTBL { get; set; }
        public virtual DbSet<OrderCategoryTBL> OrderCategoryTBL { get; set; }
        public virtual DbSet<OrderHedHistoryTBL> OrderHedHistoryTBL { get; set; }
        public virtual DbSet<OrderHedTBL> OrderHedTBL { get; set; }
        public virtual DbSet<OrderRowHistoryTBL> OrderRowHistoryTBL { get; set; }
        public virtual DbSet<OrderRowTBL> OrderRowTBL { get; set; }
        public virtual DbSet<ParamTBL> ParamTBL { get; set; }
        public virtual DbSet<PirukTBL> PirukTBL { get; set; }
        public virtual DbSet<PlastonTBL> PlastonTBL { get; set; }
        public virtual DbSet<RelocateHed> RelocateHed { get; set; }
        public virtual DbSet<RelocateRow> RelocateRow { get; set; }
        public virtual DbSet<SettingsTBL> SettingsTBL { get; set; }
        public virtual DbSet<StatusTBL> StatusTBL { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<SupplierMlayTBL> SupplierMlayTBL { get; set; }
        public virtual DbSet<SuppliersTBL> SuppliersTBL { get; set; }
        public virtual DbSet<TaraTBL> TaraTBL { get; set; }
        public virtual DbSet<TypeCartTBL> TypeCartTBL { get; set; }
        public virtual DbSet<TypeItemsTBL> TypeItemsTBL { get; set; }
        public virtual DbSet<WarehousesTBL> WarehousesTBL { get; set; }
        public virtual DbSet<WorkerTBL> WorkerTBL { get; set; }
        public virtual DbSet<GMS_MLAY_tmp> GMS_MLAY_tmp { get; set; }
        public virtual DbSet<mexicani_chain> mexicani_chain { get; set; }
        public virtual DbSet<TempCodeTBL> TempCodeTBL { get; set; }
    }
}