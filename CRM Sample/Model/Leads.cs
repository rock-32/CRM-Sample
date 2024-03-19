namespace CRM_Sample.Model
{
    public class Leads
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime NextFollowUp { get; set; }
        public string FollowUpNote {  get; set; }
        public int Source_Id {  get; set; }
        public Source source { get; set; }
        public int Status_Id { get; set; }
        public Status status { get; set; }
        //public int Department_Id { get; set; }
        //public Department department { get; set; }
        //public int Branch_Id { get; set; }
        //public Branch branch { get; set; }
        public int User_Id { get; set;}
        public Users users { get; set; }
        public List<LeadsHistory> leadshistory { get; set; }
    }
}
