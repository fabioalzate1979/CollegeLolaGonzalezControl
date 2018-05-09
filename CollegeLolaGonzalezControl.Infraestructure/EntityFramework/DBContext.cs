
using CollegeLolaGonzalezControl.DomainEntities.QualificationManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCode.SociaBPO.CommercialCRM.Infrastructure.Data.EntityFramework
{
    /// <summary>
    /// Contexto de entity framework
    /// </summary>
    public class DBContext : DbContext, IDisposable
    {
        public DBContext()
            : base("DBContext")
        {
        }

        public DBContext(DbConnection connection)
           : base(connection, true)
        {
        }

        /// <summary>
        /// Sobreescribe el mapeo de entidades
        /// </summary>
        /// <param name="modelBuilder">Model builder base</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            #region [Mappings]
            //Mapeo de entidad Qualification sin autoincremental
            modelBuilder.Entity<Qualification>();
            modelBuilder.Entity<QualificationStatus>();

            modelBuilder.Entity<User>();


            //modelBuilder.Entity<Qualification>().Property(t => t.CompanyId)
                      // .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<AuditReport>();
            //modelBuilder.Entity<AuditReport>()
            //            .Property(t => t.CompanyId)
            //            .HasColumnAnnotation(
            //                "Index",
            //                new IndexAnnotation(new IndexAttribute("IX_UniqueAuditReport") { IsUnique = true, Order = 1 }));
            //modelBuilder.Entity<AuditReport>()
            //            .Property(t => t.Consecutive)
            //            .HasColumnAnnotation(
            //                "Index",
            //                new IndexAnnotation(new IndexAttribute("IX_UniqueAuditReport") { IsUnique = true, Order = 2 }));
            //modelBuilder.Entity<AuditReport>()
            //            .Property(t => t.Year)
            //            .HasColumnAnnotation(
            //                "Index",
            //                new IndexAnnotation(new IndexAttribute("IX_UniqueAuditReport") { IsUnique = true, Order = 3 }));

            //modelBuilder.Entity<AuditReportUser>();

            //modelBuilder.Entity<AuditReportSequence>().Property(t => t.Year)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<AuditReportStatus>().Property(t => t.AuditReportStatusId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Company>().Property(t => t.CompanyId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Discovery>();            
          
            //modelBuilder.Entity<Flag>().Property(t => t.FlagId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Macroprocess>().Property(t => t.MacroprocessId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<MainProcess>().Property(t => t.MainProcessId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Subprocess>().Property(t => t.SubprocessId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Risk>().Property(t => t.RiskId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<RiskCategory>().Property(t => t.RiskCategoryId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<RiskSegment>().Property(t => t.RiskSegmentId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Plan>();

            //modelBuilder.Entity<PlanStatus>().Property(t => t.PlanStatusId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<PlanTracking>();

            //modelBuilder.Entity<PlanTrackingByDelegate>();

            //modelBuilder.Entity<PlanTrackingStatus>().Property(t => t.PlanTrackingStatusId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<DiscoveryClassification>().Property(t => t.DiscoveryClassificationId)
            //           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<AuditReportDocument>();

            #endregion


        }
    }
}
