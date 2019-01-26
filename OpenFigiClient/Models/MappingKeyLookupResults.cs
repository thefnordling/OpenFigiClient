using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpenFigiClient
{
    [DataContract(Namespace="")]
    public class MappingKeyLookupResults
    {
        [DataMember(EmitDefaultValue =false, IsRequired = false)]
        public MappingKey Key { get; set; }

        [DataMember(Name="values", EmitDefaultValue = false, IsRequired=false)]
        public List<string> Values { get; set; }
    }
}
