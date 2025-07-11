using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerApi.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public string Category { get; set; }

        // Foreign key & nav property
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
