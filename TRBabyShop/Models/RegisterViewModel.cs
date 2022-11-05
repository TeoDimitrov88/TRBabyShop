using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TRBabyShop.Infrastructure.Data.Common;

namespace TRBabyShop.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(Constants.MaxUsernameLength, MinimumLength = Constants.MinUsernameLength)]
        [DisplayName("User Name")]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(Constants.MaxEmailLength, MinimumLength = Constants.MinEmailLength)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(Constants.MaxPasswordLength, MinimumLength = Constants.MinPasswordLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
