using Microsoft.AspNetCore.Identity;

namespace Todo_List_App.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
