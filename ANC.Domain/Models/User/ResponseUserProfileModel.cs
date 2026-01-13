namespace GT.AuthService.Domain.Models.TripExtraModel
{
    public class ResponseUserProfileModel
    {
        public string? UserProfileId { get; set; }
        public string? UserId { get; set; }
        public string? bio { get; set; }

        public string? image_url { get; set; }

        public DateTime? created_time { get; set; }
    }
}
