using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace = "")]
    public class MappingResponse
    {
        [DataMember(Name = "error")]
        public string Error { get; set; }
        [DataMember(Name = "data")]
        public List<FigiRecord> Records { get; set; }
    }
}
