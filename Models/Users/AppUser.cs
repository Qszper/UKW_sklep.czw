﻿using Microsoft.AspNetCore.Identity;

namespace UKW_sklep.czw.Models.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
