using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTracking_Api
{
    public class User
    {
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Email { get; set; }
     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Roleid { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public string Name { get; set; }
    }
}
