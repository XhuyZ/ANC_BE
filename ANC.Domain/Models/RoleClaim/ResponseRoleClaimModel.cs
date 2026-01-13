using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT.AuthService.Domain.Models.RoleClaim
{
    public class ResponseRoleClaimModel
    {
        public int? RoleClaimId { get; set; }

        public Guid? RoleId { get; set; }
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }
    }
}
