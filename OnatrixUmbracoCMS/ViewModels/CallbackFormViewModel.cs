using System.ComponentModel.DataAnnotations;

namespace CmsWin._24.ViewModels;

public class CallbackFormViewModel
{
    [Required(ErrorMessage = "Name is required")]
    [Display(Name = "Name")]
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "Email is required")]
    [Display(Name = "Email address")]
    [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;
    [Required(ErrorMessage = "Phone number is required")]
    [Display(Name = "Phone")]
    public string Phone {  get; set; } = null!;
    [Required(ErrorMessage = "Please select an option")]
    public string SelectedOption { get; set; } = null!;
}