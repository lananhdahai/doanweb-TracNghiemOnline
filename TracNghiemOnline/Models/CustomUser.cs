using Microsoft.AspNetCore.Identity;

namespace TracNghiemOnline.Models
{
    public class CustomUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
