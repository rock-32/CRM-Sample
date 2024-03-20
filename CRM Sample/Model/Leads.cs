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
        //public LeadSource sources { get; set; }
        public int Status_Id { get; set; }
        //public LeadStatus status { get; set; }
        public int Department_Id { get; set; }
        //public Department departments { get; set; }
        public int Branch_Id { get; set; }
        //public Branch branches { get; set; }
        public int Staff_Id { get; set;}
        //public Staffs Staff { get; set; }
        public int Campaign_Id { get; set; }
        //public Campaign campaigns { get; set; }

        //public List<LeadsHistory> leadshistory { get; set; }
    }
}
