using System.ComponentModel.DataAnnotations;

namespace FizzAPI.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
