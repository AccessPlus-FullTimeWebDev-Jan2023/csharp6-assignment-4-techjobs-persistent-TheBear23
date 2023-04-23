using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Display(Name = "Employer")]
        public int EmployerId { get; set; }

        public IEnumerable<SelectListItem> Employers { get; set; }

    }
}
