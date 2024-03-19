namespace CRM_Sample.Model
{
    public class Status
    {
        public int Id {  get; set; }
        public string StatusTitle { get; set; }
        public List<Leads> leads { get; set; }
    }
}
