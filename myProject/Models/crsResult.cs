using System.ComponentModel.DataAnnotations.Schema;

namespace myProject.Models
{
    public class crsResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }


        [ForeignKey("crs")]
        int crs_Id;
        Course crs;


        [ForeignKey("tr")]
        int tr_Id;
        Trainee tr;
    }
}
