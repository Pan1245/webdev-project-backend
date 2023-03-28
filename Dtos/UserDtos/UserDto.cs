using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Dtos.UserDtos
{
    public class UserDto
    {
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
    }
}