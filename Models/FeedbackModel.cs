using System.ComponentModel.DataAnnotations;

namespace Practical_7.Models
{
    public class FeedbackModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your full name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a course/module.")]
        public string CourseName { get; set; } = string.Empty;

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5 stars.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please provide your comments.")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Comments must be between 10 and 500 characters.")]
        public string Comments { get; set; } = string.Empty;
    }
}
