using CRUD_NET_PROJEKT_WSB.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_NET_PROJEKT_WSB.Shared.Models
{
    public class PersonList
    {
        public string SearchTerm { get; set; }
        public List<Person>? Persons { get; set; }
        public int TotalPages { get; set; }
        public int PageNumber { get; set; }
    }
}
