namespace ANC.Domain.Models.Authen
{
    public class RegisterRequestModel
    {
        public string Username { get; set; }

        public string FullName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? BankAccount { get; set; }
        public string? BankName { get; set; }
        public string Role { get; set; }
    }
}
