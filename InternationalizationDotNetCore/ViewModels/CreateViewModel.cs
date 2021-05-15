using System.ComponentModel.DataAnnotations;

namespace InternationalizationDotNetCore.ViewModels
{
    public class CreateViewModel
    {
        [Display(Name ="Name")]
        public string Name { get; set; }
    }
}
