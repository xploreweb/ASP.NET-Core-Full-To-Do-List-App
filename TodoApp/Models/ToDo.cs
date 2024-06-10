using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Palun sisesta tegevus!")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Palun sisesta tähtaeg!")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Palun sisesta tegevuse liik!")]
        public string CategoryID { get; set; } = string.Empty;

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Palun vali tegevuse staatus!")]
        public string StatusID { get; set; } = string.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue => StatusID == "teha" && DueDate < DateTime.Today;
    }
}
