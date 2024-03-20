namespace CRM_Sample.Model
{
    public class Staffs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role_Id { get; set; }
        //public Roles roles {  get; set; } 
        public int Branch_Id { get; set; }
        //public Branch branch { get; set; }

       /* public List<Leads> leads { get; set; }
        public List<UserTask> tasks { get; set; }*/

    }
}
