using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiproject.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Place { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
