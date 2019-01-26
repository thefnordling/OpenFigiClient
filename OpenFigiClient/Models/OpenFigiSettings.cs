using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace = "")]
    public class OpenFigiSettings
    {
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string ApiKey { get; set; }
    }
}
