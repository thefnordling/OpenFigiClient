﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpenFigiClient
{
    [DataContract(Name = "")]
    public class MappingJob
    {
        [DataMember(Name = "idType", EmitDefaultValue = false, IsRequired = false)]
        public IdType IdType { get; set; }
        [DataMember(Name = "idValue", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }
        [DataMember(Name = "exchCode", EmitDefaultValue = false, IsRequired = false)]
        public string ExchangeCode { get; set; }
        [DataMember(Name = "micCode", EmitDefaultValue = false, IsRequired = false)]
        public string Mic { get; set; }
        [DataMember(Name = "currency", EmitDefaultValue = false, IsRequired = false)]
        public string Currency { get; set; }
        [DataMember(Name = "marketSecDes", EmitDefaultValue = false, IsRequired = false)]
        public string MarketSectorDescription { get; set; }
        [DataMember(Name = "securityType", EmitDefaultValue = false, IsRequired = false)]
        public string SecurityTypeOne { get; set; }
        [DataMember(Name = "securityType2", EmitDefaultValue = false, IsRequired = false)]
        public string SecurityTypeTwo { get; set; }
        [DataMember(Name = "includeUnlistedEquities", EmitDefaultValue = false, IsRequired = false)]
        public bool IncludeUnlistedEquities { get; set; }
        [DataMember(Name = "optionType", EmitDefaultValue = false, IsRequired = false)]
        public OptionType OptionType { get; set; }
        [DataMember(Name = "strike", EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(RangeConverter<decimal?>))]
        public Range<decimal?> Strike { get; set; }
        [DataMember(Name = "contractSize", EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(RangeConverter<decimal?>))]
        public Range<decimal?> ContractSize { get; set; }
        [DataMember(Name = "coupon", EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(RangeConverter<decimal?>))]
        public Range<decimal?> Coupon { get; set; }
        [DataMember(Name = "expiration", EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(RangeConverter<DateTime?>))]
        public Range<DateTime?> Expiration { get; set; }
        [DataMember(Name = "maturity", EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(RangeConverter<DateTime?>))]
        public Range<DateTime?> Maturity { get; set; }
    }
}
