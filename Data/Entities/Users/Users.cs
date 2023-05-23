using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Users
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? FullName { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
