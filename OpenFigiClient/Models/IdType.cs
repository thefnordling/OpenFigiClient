using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract(Namespace ="")]
    public enum IdType
    {
        [EnumMember]
        Unknown,
        [EnumMember]
        ID_ISIN,
        [EnumMember]
        ID_BB_UNIQUE,
        [EnumMember]
        ID_SEDOL,
        [EnumMember]
        ID_COMMON,
        [EnumMember]
        ID_WERTPAPIER,
        [EnumMember]
        ID_CUSIP,
        [EnumMember]
        ID_CINS,
        [EnumMember]
        ID_BB,
        [EnumMember]
        ID_ITALY,
        [EnumMember]
        ID_EXCH_SYMBOL,
        [EnumMember]
        ID_FULL_EXCHANGE_SYMBOL,
        [EnumMember]
        COMPOSITE_ID_BB_GLOBAL,
        [EnumMember]
        ID_BB_GLOBAL_SHARE_CLASS_LEVEL,
        [EnumMember]
        ID_BB_GLOBAL,
        [EnumMember]
        ID_BB_SEC_NUM_DES,
        [EnumMember]
        TICKER,
        [EnumMember]
        BASE_TICKER,
        [EnumMember]
        ID_CUSIP_8_CHR,
        [EnumMember]
        OCC_SYMBOL,
        [EnumMember]
        UNIQUE_ID_FUT_OPT,
        [EnumMember]
        OPRA_SYMBOL,
        [EnumMember]
        TRADING_SYSTEM_IDENTIFIER,
        [EnumMember]
        ID_SHORT_CODE,
    }
}
