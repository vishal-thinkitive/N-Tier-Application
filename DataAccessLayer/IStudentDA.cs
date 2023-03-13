using GlobalEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GE = GlobalEntity;

namespace DataAccessLayer
{
    public interface IStudentDA
    {
        public List<GE::Student> GetAllStudents();
    }
}
