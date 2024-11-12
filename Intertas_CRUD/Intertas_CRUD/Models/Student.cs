using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intertas_CRUD.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Age { get; set; }
        public string Year { get; set; }
        public string Section { get; set; }
    }
}