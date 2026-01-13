namespace ANC.Domain.Models.Authen
{
    public class UpdateUserModel
    {
        public Guid? UserId { get; set; }

        public string? FullName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? BankAccount { get; set; }

        public string? BankName { get; set; }
    }
}
