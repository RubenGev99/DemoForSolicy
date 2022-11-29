namespace DemoProject.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual Owner Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
