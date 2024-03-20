namespace CRM_Sample.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int Branch_Id { get; set; }
      /*  public Branch branch { get; set; }
        public List<Leads> leads { get; set; }*/
    }
}