using System.Net;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


namespace myProject.Models
{
    public class getDataFromModels
    {
        adlyDB context = new adlyDB();
        public getDataFromModels() { } 

        public List<Instructor> GetAll()
        {
            List<Instructor> instructors = context.instructors.ToList();
            return instructors;
        }

        public Instructor GetInsById(int id)
        {
            return context.instructors.FirstOrDefault (ins => ins.Id == id);
        }
    }
}
