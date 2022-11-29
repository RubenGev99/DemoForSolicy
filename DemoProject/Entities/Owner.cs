using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProject.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Account Account { get; set; }

    }
}
