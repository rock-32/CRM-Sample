namespace CRM_Sample.Model
{
    public class Branch
    {
        public int Id {  get; set; }
        public string BranchName { get; set; }
        public int Client_Id { get; set; }
        public Clients clients {  get; set; } 
        //public List<Department> departments { get; set; }
        //public List<Leads> leads { get; set; }
        //public List<Staffs> users { get; set; }
    }
}
