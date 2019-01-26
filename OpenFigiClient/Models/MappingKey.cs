using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace OpenFigiClient
{
    [DataContract(Namespace = "")]
    public enum MappingKey
    {
        [EnumMember(Value = "Unknown")]
        UNKNOWN,
        [EnumMember(Value = "idType")]
        ID_TYPE,
        [EnumMember(Value = "exchCode")]
        EXCH_CODE,
        [EnumMember(Value = "micCode")]
        MIC_CODE,
        [EnumMember(Value = "currency")]
        CURRENCY,
        [EnumMember(Value = "marketSecDes")]
        MARKET_SECTOR,
        [EnumMember(Value = "securityType")]
        SECURITY_TYPE_ONE,
        [EnumMember(Value = "securityType2")]
        SECURITY_TYPE_TWO
    }
}
