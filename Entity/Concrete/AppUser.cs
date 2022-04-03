using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string NameSurName { get; set; }
        public string ImageUrl { get; set; }
    }
}
