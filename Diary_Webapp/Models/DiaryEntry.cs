

using System.ComponentModel.DataAnnotations;

namespace Diary_Webapp.Models
{

    public class DiaryEntry
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a Title!")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public required string Title { get; set; }

        [Required(ErrorMessage ="Enter your Content")]
        public required string Content { get; set; }

        [Required(ErrorMessage ="Enter Date to store record")]
        public DateTime CreatedAt { get; set; }
    }

}

