using System.Runtime.Serialization;

namespace Library.Model
{
    [DataContract]
    public class StudentBookDetails
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public int BookId { get; set; }
        [DataMember]
        public virtual Book Book { get; set; }
        [DataMember]
        public virtual Student Student { get; set; }
    }
}
