namespace WebApplication2.Models
{
    public class Tasks
    {
        public int Id
        {
            get; set;
        }
        public int staff_id { get; set; }
        public int status_id { get; set; }
        public string prep_name {  get; set; }
        public decimal cost { get; set; }
        public DateTime shelfLife_end { get; set; }
        public DateTime date_time_task { get; set; }
    } 
}
