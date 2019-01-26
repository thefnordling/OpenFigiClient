using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace = "")]
    public class FigiRecord
    {
        [DataMember(Name = "figi", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(Name = "securityType", EmitDefaultValue = false, IsRequired = false)]
        public string SecurityTypeOne { get; set; }
        [DataMember(Name = "marketSector", EmitDefaultValue = false, IsRequired = false)]
        public string MarketSectorDescription { get; set; }
        [DataMember(Name = "exchCode", EmitDefaultValue = false, IsRequired = false)]
        public string ExchangeCode { get; set; }
        [DataMember(Name = "securityType2", EmitDefaultValue = false, IsRequired = false)]
        public string SecurityTypeTwo { get; set; }
        [DataMember(Name ="ticker", EmitDefaultValue = false, IsRequired = false)]
        public string Ticker { get; set; }
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }
        [DataMember(Name = "uniqueID", EmitDefaultValue = false, IsRequired = false)]
        public string UniqueId { get; set; }
        [DataMember(Name = "shareClassFIGI", EmitDefaultValue = false, IsRequired = false)]
        public string ShareClass { get; set; }
        [DataMember(Name = "compositeFIGI", EmitDefaultValue = false, IsRequired = false)]
        public string Composite { get; set; }
        [DataMember(Name = "securityDescription", EmitDefaultValue = false, IsRequired = false)]
        public string Description { get; set; }
        [DataMember(Name = "uniqueIDFutOpt", EmitDefaultValue = false, IsRequired = false)]
        public string UniqueFutureOrOptionId { get; set; }
        [DataMember(Name = "metadata", EmitDefaultValue = false, IsRequired = false)]
        public string Metadata { get; set; }
    }
}
