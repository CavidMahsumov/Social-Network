using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        public string ImageUrl { get; set; }
    }
}
