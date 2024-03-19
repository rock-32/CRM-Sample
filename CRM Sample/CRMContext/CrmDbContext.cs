using CRM_Sample.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CRM_Sample.CRMContext
{
    public class CrmDbContext:DbContext
    {
        public CrmDbContext(DbContextOptions<CrmDbContext> option):base(option)
        {

        }

        //public DbSet<Leads> leads { get; set; }
        public DbSet<Branch> braches { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Campaign> campaigns { get; set; }
        public DbSet<CRMAdmin> CRMAdmins { get; set; }
        public DbSet<Tasks> tasks { get; set; }
        public DbSet<TaskItem> taskItems { get; set; }
        public DbSet<Users> users { get; set; }


        public DbSet<Status> status { get; set; }
        public DbSet<Source> sources { get; set; }
        public DbSet<LeadsHistory> leadsHistories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>()
                .HasOne(b => b.clients)
                .WithMany(c => c.branches)
                .HasForeignKey(b => b.Client_Id);
            modelBuilder.Entity<Department>()
                .HasOne(d => d.branch)
                .WithMany(b => b.departments)
                .HasForeignKey(d => d.Branch_Id);
            modelBuilder.Entity<Leads>()
                .HasOne(l=>l.status)
                .WithMany(s=>s.leads)
                .HasForeignKey(l=>l.Status_Id);
            modelBuilder.Entity<Leads>()
                .HasOne(l => l.source)
                .WithMany(s => s.leads)
                .HasForeignKey(l => l.Source_Id);
            //modelBuilder.Entity<Leads>()
            //   .HasOne(l => l.department)
            //   .WithMany(s => s.leads)
            //   .HasForeignKey(l => l.Department_Id)
            //   .OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Leads>()
            //   .HasOne(l => l.branch)
            //   .WithMany(s => s.leads)
            //   .HasForeignKey(l => l.Branch_Id);
            modelBuilder.Entity<Leads>()
               .HasOne(l => l.users)
               .WithMany(s => s.leads)
               .HasForeignKey(l => l.User_Id);
            modelBuilder.Entity<Users>()
               .HasOne(l => l.roles)
               .WithMany(s => s.users)
               .HasForeignKey(l => l.Role_Id);
            modelBuilder.Entity<Users>()
               .HasOne(l => l.branch)
               .WithMany(s => s.users)
               .HasForeignKey(l => l.Branch_Id);
            modelBuilder.Entity<Tasks>()
               .HasOne(l => l.users)
               .WithMany(s => s.tasks)
               .HasForeignKey(l => l.User_Id);
            modelBuilder.Entity<Tasks>()
               .HasOne(l => l.taskItem)
               .WithMany(s => s.tasks)
               .HasForeignKey(l => l.Taskitem_Id);
            modelBuilder.Entity<LeadsHistory>()
               .HasOne(l => l.lead)
               .WithMany(s => s.leadshistory)
               .HasForeignKey(l => l.Lead_Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
