using Core.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Core.Security.Dtos
{
    public class UserForUpdateDto 
    {
        public User User { get; set; }
        public string Password { get; set; }
    }
}
