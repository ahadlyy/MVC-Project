using System.ComponentModel.DataAnnotations.Schema;

namespace myProject.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }
        public string Image { get; set; }


        [ForeignKey("dept")]
        int dept_Id;
        Department dept;
    }
}
