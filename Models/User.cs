using System.Text.Json.Serialization;
using ProiectTest.Models.Base;

namespace ProiectTest.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        [JsonIgnore] // this is used to prevent the password from being sent to the client
        public string PasswordHash { get; set; }
    }
}