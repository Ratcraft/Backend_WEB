using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Values
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}