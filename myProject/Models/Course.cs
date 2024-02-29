using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace myProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int passDegree { get; set; }

        [ForeignKey("dept")]
        int dept_Id; 
        Department dept ;
    }
}
