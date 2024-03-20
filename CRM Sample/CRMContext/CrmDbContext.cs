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

        public DbSet<CRMAdmin> CRMAdminTb { get; set; }
        public DbSet<Clients> ClientsTb { get; set; }
        public DbSet<Branch> BranchTb { get; set; }
        public DbSet<Department> DepartmentTb { get; set; }
        public DbSet<Staffs> StaffsTb { get; set; }
        public DbSet<Roles> RoleTb { get; set; }
        public DbSet<LeadSource> LeadSourceTb { get; set; }
        public DbSet<Leads> LeadsTb { get; set; }
        public DbSet<LeadStatus> LeadStatusTb { get; set; }
        public DbSet<LeadsHistory> LeadsHistoryTb { get; set; }
        public DbSet<UserTask> UserTaskTb { get; set; }
        public DbSet<TaskItem> TaskItemTb { get; set; }
        public DbSet<Campaign> CampaignTb { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>()
                .HasOne(b => b.clients)
                .WithMany(c => c.branches)
                .HasForeignKey(b => b.Client_Id);


            base.OnModelCreating(modelBuilder);
        }
    }
}
