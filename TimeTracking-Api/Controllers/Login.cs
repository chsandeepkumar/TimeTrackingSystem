using System.Collections;

namespace TimeTracking_Api.Controllers
{
    public class Login
    {
        public int LoginId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
    }
}
