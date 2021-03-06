using System.ComponentModel.DataAnnotations;

namespace TheGodfatherGM.Web.Models.GameViewModel
{
    public class RegisterViewModel
    {
        //[Display(Name = "Email")]
        [Required]
        //[EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required]
        [MinLength(4)]
        public string Password { get; set; }

        [Display(Name = "Repeat your password")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }


        [Required]
        public string SocialClub { get; set; }

        [Required]
        public string Token { get; set; }
    }
}
