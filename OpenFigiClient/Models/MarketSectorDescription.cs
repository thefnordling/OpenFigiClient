using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace ="")]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketSectorDescription
    {
        [EnumMember]
        Unknown,
        [EnumMember(Value = "6")]
        SIX,
        [EnumMember(Value = "Alternatives")]
        ALTERNATIVES,
        [EnumMember(Value = "CAD TBills")]
        CAD_TBILLS,
        [EnumMember(Value = "Comdty")]
        COMDTY,
        [EnumMember(Value = "Commodities")]
        COMMODITIES,
        [EnumMember(Value = "Corp")]
        CORP,
        [EnumMember(Value = "Credit")]
        CREDIT,
        [EnumMember(Value = "CROSS ASSET")]
        CROSS_ASSET_1,
        [EnumMember(Value = "Cross Asset")]
        CROSS_ASSET_2,
        [EnumMember(Value = "Curncy")]
        CURNCY,
        [EnumMember(Value = "Equity")]
        EQUITY,
        [EnumMember(Value = "Fixed Income")]
        FIXED_INCOME,
        [EnumMember(Value = "Foreign Exchange")]
        FOREIGN_EXCHANGE,
        [EnumMember(Value = "Govt")]
        GOVT,
        [EnumMember(Value = "Index")]
        INDEX,
        [EnumMember(Value = "Interest Rate")]
        INTEREST_RATE,
        [EnumMember(Value = "M-Mkt")]
        M_MKT,
        [EnumMember(Value = "Macroeconomic")]
        MACROECONOMIC,
        [EnumMember(Value = "Money Market")]
        MONEY_MARKET,
        [EnumMember(Value = "Mtge")]
        MTGE,
        [EnumMember(Value = "Multi Asset")]
        MULTI_ASSET_1,
        [EnumMember(Value = "Multi asset")]
        MULTI_ASSET_2,
        [EnumMember(Value = "Multi Assets")]
        MULTI_ASSETS_3,
        [EnumMember(Value = "Multi-Asset")]
        MULTI_ASSET_4,
        [EnumMember(Value = "Multi-asset")]
        MULTI_ASSET_5,
        [EnumMember(Value = "Muni")]
        MUNI,
        [EnumMember(Value = "Mutual Funds")]
        MUTUAL_FUNDS,
        [EnumMember(Value = "N/A")]
        NA,
        [EnumMember(Value = "Pfd")]
        PFD,
        [EnumMember(Value = "Trd Strat")]
        TRD_STRAT
    }
}
