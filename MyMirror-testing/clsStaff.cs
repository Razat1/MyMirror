using System;

namespace MyMirror_testing
{
    class clsStaff
    {
        public bool isAdmin { get; internal set; }
        public DateTime Startdate { get; internal set; }
        public int EmployeeId { get; internal set; }
        public int Age { get; internal set; }
        public string Name { get; internal set; }
    }
}