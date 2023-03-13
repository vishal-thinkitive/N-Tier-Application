using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GE = GlobalEntity;

namespace BusinessLayer
{
    public interface IStudentBC
    {
        public List<GE::Student> GetStudents();
    }
}
