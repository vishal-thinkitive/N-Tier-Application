using System;
using System.Collections.Generic;

namespace GlobalEntity
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? MemberId { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? IdProof { get; set; }
        public DateTime? JoiningDate { get; set; }
    }
}
