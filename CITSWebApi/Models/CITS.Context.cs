﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CITSWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CompanyInformationTrackingSystemEntities : DbContext
    {
        public CompanyInformationTrackingSystemEntities()
            : base("name=CompanyInformationTrackingSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_EmpAdvance> tb_EmpAdvance { get; set; }
        public virtual DbSet<tb_EmpAppraisal> tb_EmpAppraisal { get; set; }
        public virtual DbSet<tb_EmpAttendance> tb_EmpAttendance { get; set; }
        public virtual DbSet<tb_Employee> tb_Employee { get; set; }
        public virtual DbSet<tb_Employement> tb_Employement { get; set; }
        public virtual DbSet<tb_EmpPromotion> tb_EmpPromotion { get; set; }
        public virtual DbSet<tb_EmpSalary> tb_EmpSalary { get; set; }
    }
}
