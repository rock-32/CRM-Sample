namespace CRM_Sample.Model
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignTitle { get; set; }
        public DateTime Date { get; set;}
        public string Description { get; set; }
        public int Client_Id { get; set; }
        //public Clients clients { get; set; }
        //public List<Leads> leads { get; set; }
    }
}
