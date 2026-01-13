

namespace GT.AuthService.Domain.Models.RoleClaim
{
    public class CreateRoleClaimModel
    {
        public Guid? RoleId { get; set; }
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }
    }
}
