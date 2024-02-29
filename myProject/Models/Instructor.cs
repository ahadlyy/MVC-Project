using System.ComponentModel.DataAnnotations.Schema;

namespace myProject.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }
        public string Image { get; set; }

        [ForeignKey("dept")]
        int dept_Id;
        Department dept;



        [ForeignKey("crs")]
        int crs_Id;
        Course crs;
    }
}
