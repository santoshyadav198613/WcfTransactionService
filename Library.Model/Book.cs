using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Library.Model
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public DateTime PublishDate { get; set; }
        [DataMember]
        public string Section { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public DateTime? ModeifiedDate { get; set; }
        [DataMember]
        public virtual ICollection<StudentBookDetails> StudentBookDetails { get; set; }
    }
}
