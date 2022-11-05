
using System.ComponentModel.DataAnnotations;
using TRBabyShop.Infrastructure.Data.Common;

namespace TRBabyShop.Models
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(Constants.MaxUsernameLength, MinimumLength = Constants.MinUsernameLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(Constants.MaxPasswordLength, MinimumLength = Constants.MinPasswordLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
