using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Library.Model
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public string FristName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public DateTime? ModeifiedDate { get; set; }
        [DataMember]
        public virtual ICollection<StudentBookDetails> StudentBookDetails { get; set; }
    }
}
