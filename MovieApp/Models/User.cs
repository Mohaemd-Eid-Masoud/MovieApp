using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class User : IdentityUser<long>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }

    public ICollection<Review> Reviews { get; set; }
    public ICollection<WatchList> WatchLists { get; set; }
    public Profile Profile { get; set; }
}