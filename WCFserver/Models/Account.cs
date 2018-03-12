using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFserver
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int Carma { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        public virtual ICollection<Blogs> Blog { get; set; }
    }
}