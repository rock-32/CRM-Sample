namespace CRM_Sample.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string TaskTitle { get; set; }
        public string Description { get; set; }
        public DateTime ScheduleDate { get; set; }
        public List<Tasks> tasks {  get; set; } 
    }
}
