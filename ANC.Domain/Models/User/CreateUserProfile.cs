

using Microsoft.AspNetCore.Http;

namespace GT.AuthService.Domain.Models.User
{
    public class CreateUserProfile
    {
        public string? UserId { get; set; }
        public string? bio { get; set; }

        public IFormFile? image_url { get; set; }
    }
}
