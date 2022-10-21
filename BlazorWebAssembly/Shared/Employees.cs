using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Shared
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }= string.Empty;
        public string LastName { get; set; }= string.Empty;
        public int TelephoneNo { get; set; }

        public Manager? Manager { get; set; }

        public int ManagerId { get; set; }
    }
}
