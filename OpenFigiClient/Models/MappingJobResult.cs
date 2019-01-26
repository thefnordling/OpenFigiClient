using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpenFigiClient
{
    [DataContract(Namespace = "")]
    public class MappingJobResult
    {
        [DataMember(Name = "error")]
        public string Error { get; set; }
        [DataMember(Name = "data")]
        public List<FigiRecord> Records { get; set; }
    }
}
