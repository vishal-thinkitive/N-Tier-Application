using DataAccessLayer;
using GlobalEntity;
using Microsoft.IdentityModel.Tokens;

namespace BusinessLayer
{
    public class StudentBC : IStudentBC
    {
        private readonly StudentDA _studentDA;
        public StudentBC(StudentDA studentDA)
        {
            _studentDA = studentDA;
        }
        public List<Student> GetStudents()
        {
            return _studentDA.GetAllStudents();

        }
    }
}