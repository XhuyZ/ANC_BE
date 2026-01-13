

namespace GT.AuthService.Domain.Models.RoleClaim
{
    public class UpdateRoleClaimModel
    {
        public int? RoleClaimId { get; set; }

        public string? RoleId { get; set; }
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }
    }
}
