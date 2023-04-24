using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required.")] //Defines the Name property as a required field and specifies the error message to be displayed if it is not provided.
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Display(Name = "Employer")] //""
        public int EmployerId { get; set; } //Defines the EmployerId property as an integer type with a public getter and setter.

        public List<SelectListItem> Employers { get; set; } = new List<SelectListItem>(); //Defines the Employers property as a list of SelectListItem objects, which are used to populate a dropdown list in the corresponding view.
    }
}

//public IEnumerable<SelectListItem> Employers { get; set; } ---Went with this, but it through an error. I don not remember why

   



