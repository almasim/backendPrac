using System.ComponentModel.DataAnnotations;

namespace _03._22.Models
{
    public partial class Employee
    {
        [Key]
        public int employeeNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string extension { get; set; }
        public string email { get; set; }   
        public string officeCode { get; set; }
        public string reportsTo { get; set; }
        public string jobTitle { get; set; }

    }
}
