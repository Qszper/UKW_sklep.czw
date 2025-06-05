using System.ComponentModel.DataAnnotations;

namespace UKW_sklep.czw.Models.Users
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić nazwę urzytkownika")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        public string Password { get; set; }
    }
}

