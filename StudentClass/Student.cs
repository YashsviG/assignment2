using System;
using System.ComponentModel.DataAnnotations;

namespace StudentClass
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BCIT_ID { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string City { get; set; }
        public string Option { get; set; }
        public string Set { get; set; }
    }
}
