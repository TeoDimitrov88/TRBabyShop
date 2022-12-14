
using System.ComponentModel.DataAnnotations;
using TRBabyShop.Infrastructure.Data.Common;

namespace TRBabyShop.Core.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        [StringLength(Constants.MaxUsernameLength, MinimumLength = Constants.MinUsernameLength,ErrorMessage = "{0} length must be between {2} and {1} characters long!")]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(Constants.MaxPasswordLength, MinimumLength = Constants.MinPasswordLength, ErrorMessage = "{0} length must be between {2} and {1} characters long!")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
