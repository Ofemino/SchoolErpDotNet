﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScherpDbContext : DbContext
    {
        public ScherpDbContext()
            : base("name=ScherpDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CommunicationDetail> CommunicationDetails { get; set; }
        public virtual DbSet<ParentDetail> ParentDetails { get; set; }
        public virtual DbSet<SchoolDetail> SchoolDetails { get; set; }
        public virtual DbSet<StaffProfile> StaffProfiles { get; set; }
        public virtual DbSet<StudentAdmission> StudentAdmissions { get; set; }
        public virtual DbSet<StudentClass> StudentClasses { get; set; }
        public virtual DbSet<StudentPreAdmission> StudentPreAdmissions { get; set; }
        public virtual DbSet<studentProfile> studentProfiles { get; set; }
        public virtual DbSet<StudyHistory> StudyHistories { get; set; }
        public virtual DbSet<AcademicSession> AcademicSessions { get; set; }
    }
}
