using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_API.Models{


    public class Employee : Person{
       

        public int EmployeeID {get; set;}
        public int Salary {get; set;}
    }
}