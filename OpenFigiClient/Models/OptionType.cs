using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpenFigiClient
{
    [DataContract(Namespace = "")]
    public enum OptionType
    {
        [EnumMember]
        None,
        [EnumMember(Value = "Put")]
        Put,
        [EnumMember(Value = "Call")]
        Call
    }
}
