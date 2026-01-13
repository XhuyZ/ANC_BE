namespace ANC.Domain.Models.Authen
{
    public class ResponseUserModel
    {
        public Guid? Id { get; set; }
        public string? FullName { get; set; }

        public string? Email { get; set; }
        public string? Img_url { get; set; }

        public string? Status { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
        public string? BankAccount { get; set; }
        public string? BankName { get; set; }
        /// <summary>
        /// Ngày tạo tài khoản
        /// </summary>
        public DateTimeOffset CreatedTime { get; set; }

        public string? Gender { get; set; }
    }
}
