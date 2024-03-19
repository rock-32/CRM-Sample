namespace CRM_Sample.Model
{
    public class Source
    {
        public int Id { get; set; }
        public string SourceName { get; set; }
        public List<Leads> leads { get; set; }
    }
}
