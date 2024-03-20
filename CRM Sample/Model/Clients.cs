namespace CRM_Sample.Model
{
    public class Clients
    {
        public int Id {  get; set; }
        public string ClientId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set;}
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public List<Branch> branches { get; set; }
        //public List<Campaign> campaigns { get; set; }
        
    }
}
