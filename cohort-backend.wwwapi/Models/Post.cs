using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cohort_backend.wwwapi.Models
{
    [Table("posts")]
    public class Post
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [ForeignKey("contacts")]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
