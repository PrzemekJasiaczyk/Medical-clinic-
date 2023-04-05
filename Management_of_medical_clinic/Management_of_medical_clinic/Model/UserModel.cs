using System.ComponentModel.DataAnnotations;

namespace Console_Management_of_medical_clinic.Model
{
    public class UserModel
    {
        [Key] public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

        public UserModel() { }

        public UserModel(string username, string firstName, string lastName, string password, string role, bool isActive)
        {
            Username = username;
            Password = password;
            Role = role;
            IsActive = isActive;
        }
    }

}
