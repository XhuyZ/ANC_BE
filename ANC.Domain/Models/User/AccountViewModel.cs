using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GT.AuthService.Domain.Models.User
{
    public class AccountViewModel
    {
        public string UserId    { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Img { get; set; }
    }
}
