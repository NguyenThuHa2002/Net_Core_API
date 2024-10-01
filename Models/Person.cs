using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_API.Models{
    [Table("Person")]
    public class Person{
        [Key]
        public string CanCuocCongDan {get; set; }
        public string HoTen {get; set; }
        public string QueQuan {get; set; }
    }
}