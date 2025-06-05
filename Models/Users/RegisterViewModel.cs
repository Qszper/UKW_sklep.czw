using System.ComponentModel.DataAnnotations;
namespace UKW_sklep.czw.Models.Users
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić adres email")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić nazwę urzytkownika")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Hasła muszą być jednakowe!")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Powtórz hasło")]
        public string ConfirmPassword { get; set; }
    }
}
