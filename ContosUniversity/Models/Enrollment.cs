using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    //enrollment one enrollment to one student and one enrollment per course
    public class Enrollment
    {
        public int EnrollmentID { get; set; }//pk
        public int CourseID { get; set; }//fk
        public int StudentID { get; set; }//fk

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }//enum can be NUll 
        public Course Course { get; set; }
        public Student Student { get; set; }

    }
}
