using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TRBabyShop.Infrastructure.Data.Common;

namespace TRBabyShop.Core.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(Constants.MaxUsernameLength, MinimumLength = Constants.MinUsernameLength, ErrorMessage = "User Name length must be between {2} and {1} characters long!")]
        [DisplayName("User Name")]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(Constants.MaxEmailLength, MinimumLength = Constants.MinEmailLength, ErrorMessage = "{0} length must be between {2} and {1} characters long!")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(Constants.MaxPasswordLength, MinimumLength = Constants.MinPasswordLength, ErrorMessage = "{0} length must be between {2} and {1} characters long ,and must contain Uppercase!")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
