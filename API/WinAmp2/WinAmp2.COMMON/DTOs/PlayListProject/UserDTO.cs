using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAmp2.COMMON.DTOs.PlayListProject
{
    public class UserDTO
    {
        public int? IdUser { get; set; }
        public int IdRole { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }        
    }
}
