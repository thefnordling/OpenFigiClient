using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace="")]
    public class MappingRequest : List<MappingJob>
    {
        public MappingRequest() : base()
        {
        
        }
    }
}
