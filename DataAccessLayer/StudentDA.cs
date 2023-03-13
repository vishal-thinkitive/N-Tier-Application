using GE=GlobalEntity;
using DataAccessLayer.Models;



namespace DataAccessLayer
{
    public class StudentDA : IStudentDA
    {
        private readonly StudentInfoContext _context;  
        public StudentDA(StudentInfoContext context)
        {
            _context = context;
        }
        public List<GE::Student> GetAllStudents()
        {
          var student=_context.Students.ToList();
            List<GE::Student> students = new List<GE::Student>();
            if (student != null && student.Count > 0)
            {
                student.ForEach(item =>
                students.Add(new GE.Student()
                {
                    Name = item.Name,
                    Phone = item.Phone,
                    MemberId = item.MemberId,
                    IdProof = item.IdProof,
                    JoiningDate = item.JoiningDate,
                   
                }));
            }
            return students;
        }

        
    }
}