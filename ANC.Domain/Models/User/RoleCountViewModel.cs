
using ANC.Domain.Models.Authen;

namespace ANC.Domain.Models.User
{
    public class RoleCountViewModel
    {
        public int TotalCount { get; set; }
        public int TravellerCount { get; set; }
        public int RepresentativeCount { get; set; }
        public ICollection<ResponseUserModel> User { get; set; } = new List<ResponseUserModel>();

    }
}
