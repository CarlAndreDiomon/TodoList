using System.ComponentModel.DataAnnotations;

namespace Todo_List_App.ViewModels
{
    public class VerifyEmailViewModel
    {

        [Required(ErrorMessage = " Email is Required ")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
