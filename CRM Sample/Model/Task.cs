namespace CRM_Sample.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public int Taskitem_Id { get; set; }
        public TaskItem taskItem { get; set; }
        public int User_Id { get; set; }
        public Users users { get; set; }
        
    }
}
