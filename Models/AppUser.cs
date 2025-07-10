using Microsoft.AspNetCore.Identity;

namespace ExpenseTrackerApi.Models
{
    public class AppUser : IdentityUser
    {
        public ICollection<Expense> Expenses { get; set; }
    }
}
