namespace CRM_Sample.Model
{
    public class LeadsHistory
    {
        public int Id {  get; set; }
        public DateTime Date { get; set; }
        public int Lead_Id { get; set; }
        //public Leads lead { get; set; }
        public string Description { get; set; }

    }
}
