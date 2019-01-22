using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace = "")]
    public enum Currency
    {
        [EnumMember]
        Unknown,
        [EnumMember(Value = "***")]
        ASTERISKS,
        [EnumMember(Value = "-96")]
        NEG96,
        [EnumMember(Value = "ADP")]
        ADP,
        [EnumMember(Value = "AED")]
        AED,
        [EnumMember(Value = "AFN")]
        AFN,
        [EnumMember(Value = "ALL")]
        ALL,
        [EnumMember(Value = "AMD")]
        AMD,
        [EnumMember(Value = "ANG")]
        ANG,
        [EnumMember(Value = "AOA")]
        AOA,
        [EnumMember(Value = "ARS")]
        ARS,
        [EnumMember(Value = "ATS")]
        ATS,
        [EnumMember(Value = "AUd")]
        AUd,
        [EnumMember(Value = "AUD")]
        AUD,
        [EnumMember(Value = "AWG")]
        AWG,
        [EnumMember(Value = "AZM")]
        AZM,
        [EnumMember(Value = "AZN")]
        AZN,
        [EnumMember(Value = "BAM")]
        BAM,
        [EnumMember(Value = "BBD")]
        BBD,
        [EnumMember(Value = "BDT")]
        BDT,
        [EnumMember(Value = "BEF")]
        BEF,
        [EnumMember(Value = "BGN")]
        BGN,
        [EnumMember(Value = "BHD")]
        BHD,
        [EnumMember(Value = "BIF")]
        BIF,
        [EnumMember(Value = "BMD")]
        BMD,
        [EnumMember(Value = "BND")]
        BND,
        [EnumMember(Value = "BOB")]
        BOB,
        [EnumMember(Value = "BRl")]
        BRl,
        [EnumMember(Value = "BRL")]
        BRL,
        [EnumMember(Value = "BSD")]
        BSD,
        [EnumMember(Value = "BTN")]
        BTN,
        [EnumMember(Value = "BWP")]
        BWP,
        [EnumMember(Value = "BWp")]
        BWp,
        [EnumMember(Value = "BYN")]
        BYN,
        [EnumMember(Value = "BYR")]
        BYR,
        [EnumMember(Value = "BZD")]
        BZD,
        [EnumMember(Value = "CAd")]
        CAd,
        [EnumMember(Value = "CAD")]
        CAD,
        [EnumMember(Value = "CDF")]
        CDF,
        [EnumMember(Value = "CER")]
        CER,
        [EnumMember(Value = "CHF")]
        CHF,
        [EnumMember(Value = "CHf")]
        CHf,
        [EnumMember(Value = "CLF")]
        CLF,
        [EnumMember(Value = "CLP")]
        CLP,
        [EnumMember(Value = "CNH")]
        CNH,
        [EnumMember(Value = "CNT")]
        CNT,
        [EnumMember(Value = "CNY")]
        CNY,
        [EnumMember(Value = "COP")]
        COP,
        [EnumMember(Value = "CRC")]
        CRC,
        [EnumMember(Value = "CUP")]
        CUP,
        [EnumMember(Value = "CVE")]
        CVE,
        [EnumMember(Value = "CYP")]
        CYP,
        [EnumMember(Value = "CZK")]
        CZK,
        [EnumMember(Value = "DEM")]
        DEM,
        [EnumMember(Value = "DJF")]
        DJF,
        [EnumMember(Value = "DKK")]
        DKK,
        [EnumMember(Value = "DOP")]
        DOP,
        [EnumMember(Value = "DZD")]
        DZD,
        [EnumMember(Value = "ECS")]
        ECS,
        [EnumMember(Value = "EEK")]
        EEK,
        [EnumMember(Value = "EGP")]
        EGP,
        [EnumMember(Value = "ERN")]
        ERN,
        [EnumMember(Value = "ESP")]
        ESP,
        [EnumMember(Value = "ETB")]
        ETB,
        [EnumMember(Value = "EUA")]
        EUA,
        [EnumMember(Value = "EUR")]
        EUR,
        [EnumMember(Value = "EUr")]
        EUr,
        [EnumMember(Value = "FIM")]
        FIM,
        [EnumMember(Value = "FJ")]
        FJ,
        [EnumMember(Value = "FJD")]
        FJD,
        [EnumMember(Value = "FRF")]
        FRF,
        [EnumMember(Value = "GBP")]
        GBP,
        [EnumMember(Value = "GBp")]
        GBp,
        [EnumMember(Value = "GEL")]
        GEL,
        [EnumMember(Value = "GGP")]
        GGP,
        [EnumMember(Value = "GHC")]
        GHC,
        [EnumMember(Value = "GHS")]
        GHS,
        [EnumMember(Value = "GIP")]
        GIP,
        [EnumMember(Value = "GMD")]
        GMD,
        [EnumMember(Value = "GNF")]
        GNF,
        [EnumMember(Value = "GRD")]
        GRD,
        [EnumMember(Value = "GTQ")]
        GTQ,
        [EnumMember(Value = "GYD")]
        GYD,
        [EnumMember(Value = "HKD")]
        HKD,
        [EnumMember(Value = "HNL")]
        HNL,
        [EnumMember(Value = "HRK")]
        HRK,
        [EnumMember(Value = "HTG")]
        HTG,
        [EnumMember(Value = "HUF")]
        HUF,
        [EnumMember(Value = "IDR")]
        IDR,
        [EnumMember(Value = "IEP")]
        IEP,
        [EnumMember(Value = "ILs")]
        ILs,
        [EnumMember(Value = "ILS")]
        ILS,
        [EnumMember(Value = "INR")]
        INR,
        [EnumMember(Value = "IQD")]
        IQD,
        [EnumMember(Value = "IRR")]
        IRR,
        [EnumMember(Value = "ISK")]
        ISK,
        [EnumMember(Value = "ITL")]
        ITL,
        [EnumMember(Value = "JEP")]
        JEP,
        [EnumMember(Value = "JMD")]
        JMD,
        [EnumMember(Value = "JOD")]
        JOD,
        [EnumMember(Value = "JPY")]
        JPY,
        [EnumMember(Value = "KES")]
        KES,
        [EnumMember(Value = "KGS")]
        KGS,
        [EnumMember(Value = "KHR")]
        KHR,
        [EnumMember(Value = "KMF")]
        KMF,
        [EnumMember(Value = "KPW")]
        KPW,
        [EnumMember(Value = "KRW")]
        KRW,
        [EnumMember(Value = "KWD")]
        KWD,
        [EnumMember(Value = "KWd")]
        KWd,
        [EnumMember(Value = "KYD")]
        KYD,
        [EnumMember(Value = "KZT")]
        KZT,
        [EnumMember(Value = "LAK")]
        LAK,
        [EnumMember(Value = "LBP")]
        LBP,
        [EnumMember(Value = "LKR")]
        LKR,
        [EnumMember(Value = "LRD")]
        LRD,
        [EnumMember(Value = "LSL")]
        LSL,
        [EnumMember(Value = "LTL")]
        LTL,
        [EnumMember(Value = "LUF")]
        LUF,
        [EnumMember(Value = "LVL")]
        LVL,
        [EnumMember(Value = "LYD")]
        LYD,
        [EnumMember(Value = "MAD")]
        MAD,
        [EnumMember(Value = "MDL")]
        MDL,
        [EnumMember(Value = "MGA")]
        MGA,
        [EnumMember(Value = "MGF")]
        MGF,
        [EnumMember(Value = "MKD")]
        MKD,
        [EnumMember(Value = "MMK")]
        MMK,
        [EnumMember(Value = "MNT")]
        MNT,
        [EnumMember(Value = "MOP")]
        MOP,
        [EnumMember(Value = "MRO")]
        MRO,
        [EnumMember(Value = "MRU")]
        MRU,
        [EnumMember(Value = "MTL")]
        MTL,
        [EnumMember(Value = "MULTI")]
        MULTI,
        [EnumMember(Value = "MUR")]
        MUR,
        [EnumMember(Value = "MVR")]
        MVR,
        [EnumMember(Value = "MWk")]
        MWk,
        [EnumMember(Value = "MWK")]
        MWK,
        [EnumMember(Value = "MXN")]
        MXN,
        [EnumMember(Value = "MYR")]
        MYR,
        [EnumMember(Value = "MYr")]
        MYr,
        [EnumMember(Value = "MZM")]
        MZM,
        [EnumMember(Value = "MZN")]
        MZN,
        [EnumMember(Value = "NAd")]
        NAd,
        [EnumMember(Value = "NAD")]
        NAD,
        [EnumMember(Value = "NGN")]
        NGN,
        [EnumMember(Value = "NID")]
        NID,
        [EnumMember(Value = "NIO")]
        NIO,
        [EnumMember(Value = "NLG")]
        NLG,
        [EnumMember(Value = "NOK")]
        NOK,
        [EnumMember(Value = "NPR")]
        NPR,
        [EnumMember(Value = "NZD")]
        NZD,
        [EnumMember(Value = "OMR")]
        OMR,
        [EnumMember(Value = "PAB")]
        PAB,
        [EnumMember(Value = "PEN")]
        PEN,
        [EnumMember(Value = "PGK")]
        PGK,
        [EnumMember(Value = "PHP")]
        PHP,
        [EnumMember(Value = "PKR")]
        PKR,
        [EnumMember(Value = "PLN")]
        PLN,
        [EnumMember(Value = "PTE")]
        PTE,
        [EnumMember(Value = "PYG")]
        PYG,
        [EnumMember(Value = "QAR")]
        QAR,
        [EnumMember(Value = "ROL")]
        ROL,
        [EnumMember(Value = "RON")]
        RON,
        [EnumMember(Value = "RSD")]
        RSD,
        [EnumMember(Value = "RUB")]
        RUB,
        [EnumMember(Value = "RWF")]
        RWF,
        [EnumMember(Value = "SAR")]
        SAR,
        [EnumMember(Value = "SBD")]
        SBD,
        [EnumMember(Value = "SCR")]
        SCR,
        [EnumMember(Value = "SDD")]
        SDD,
        [EnumMember(Value = "SDG")]
        SDG,
        [EnumMember(Value = "SDP")]
        SDP,
        [EnumMember(Value = "SEK")]
        SEK,
        [EnumMember(Value = "SGd")]
        SGd,
        [EnumMember(Value = "SGD")]
        SGD,
        [EnumMember(Value = "SHP")]
        SHP,
        [EnumMember(Value = "SIT")]
        SIT,
        [EnumMember(Value = "SKK")]
        SKK,
        [EnumMember(Value = "SLL")]
        SLL,
        [EnumMember(Value = "SOS")]
        SOS,
        [EnumMember(Value = "SPL")]
        SPL,
        [EnumMember(Value = "SRD")]
        SRD,
        [EnumMember(Value = "SRG")]
        SRG,
        [EnumMember(Value = "SSP")]
        SSP,
        [EnumMember(Value = "STD")]
        STD,
        [EnumMember(Value = "STN")]
        STN,
        [EnumMember(Value = "SVC")]
        SVC,
        [EnumMember(Value = "SYP")]
        SYP,
        [EnumMember(Value = "SZl")]
        SZl,
        [EnumMember(Value = "SZL")]
        SZL,
        [EnumMember(Value = "THB")]
        THB,
        [EnumMember(Value = "THO")]
        THO,
        [EnumMember(Value = "TJS")]
        TJS,
        [EnumMember(Value = "TMM")]
        TMM,
        [EnumMember(Value = "TMT")]
        TMT,
        [EnumMember(Value = "TND")]
        TND,
        [EnumMember(Value = "TOP")]
        TOP,
        [EnumMember(Value = "TRL")]
        TRL,
        [EnumMember(Value = "TRY")]
        TRY,
        [EnumMember(Value = "TTD")]
        TTD,
        [EnumMember(Value = "TVD")]
        TVD,
        [EnumMember(Value = "TWD")]
        TWD,
        [EnumMember(Value = "TZS")]
        TZS,
        [EnumMember(Value = "UAH")]
        UAH,
        [EnumMember(Value = "UDI")]
        UDI,
        [EnumMember(Value = "UGX")]
        UGX,
        [EnumMember(Value = "unk")]
        unk,
        [EnumMember(Value = "US")]
        US,
        [EnumMember(Value = "USD")]
        USD,
        [EnumMember(Value = "USd")]
        USd,
        [EnumMember(Value = "UVR")]
        UVR,
        [EnumMember(Value = "UYI")]
        UYI,
        [EnumMember(Value = "UYU")]
        UYU,
        [EnumMember(Value = "UYW")]
        UYW,
        [EnumMember(Value = "UZS")]
        UZS,
        [EnumMember(Value = "VEB")]
        VEB,
        [EnumMember(Value = "VEE")]
        VEE,
        [EnumMember(Value = "VEF")]
        VEF,
        [EnumMember(Value = "VES")]
        VES,
        [EnumMember(Value = "VND")]
        VND,
        [EnumMember(Value = "VUV")]
        VUV,
        [EnumMember(Value = "WST")]
        WST,
        [EnumMember(Value = "X0S")]
        X0S,
        [EnumMember(Value = "X1S")]
        X1S,
        [EnumMember(Value = "X2S")]
        X2S,
        [EnumMember(Value = "X3S")]
        X3S,
        [EnumMember(Value = "X4S")]
        X4S,
        [EnumMember(Value = "X5S")]
        X5S,
        [EnumMember(Value = "X6S")]
        X6S,
        [EnumMember(Value = "X7S")]
        X7S,
        [EnumMember(Value = "X8S")]
        X8S,
        [EnumMember(Value = "X9S")]
        X9S,
        [EnumMember(Value = "XAF")]
        XAF,
        [EnumMember(Value = "XAG")]
        XAG,
        [EnumMember(Value = "XAL")]
        XAL,
        [EnumMember(Value = "XAS")]
        XAS,
        [EnumMember(Value = "XAU")]
        XAU,
        [EnumMember(Value = "XBN")]
        XBN,
        [EnumMember(Value = "XBS")]
        XBS,
        [EnumMember(Value = "XBT")]
        XBT,
        [EnumMember(Value = "XCD")]
        XCD,
        [EnumMember(Value = "XCS")]
        XCS,
        [EnumMember(Value = "XCU")]
        XCU,
        [EnumMember(Value = "XDH")]
        XDH,
        [EnumMember(Value = "XDR")]
        XDR,
        [EnumMember(Value = "XEO")]
        XEO,
        [EnumMember(Value = "XET")]
        XET,
        [EnumMember(Value = "XEU")]
        XEU,
        [EnumMember(Value = "XLC")]
        XLC,
        [EnumMember(Value = "XMR")]
        XMR,
        [EnumMember(Value = "XNI")]
        XNI,
        [EnumMember(Value = "XOF")]
        XOF,
        [EnumMember(Value = "XPB")]
        XPB,
        [EnumMember(Value = "XPD")]
        XPD,
        [EnumMember(Value = "XPF")]
        XPF,
        [EnumMember(Value = "XPT")]
        XPT,
        [EnumMember(Value = "XRA")]
        XRA,
        [EnumMember(Value = "XRH")]
        XRH,
        [EnumMember(Value = "XRI")]
        XRI,
        [EnumMember(Value = "XRP")]
        XRP,
        [EnumMember(Value = "XRU")]
        XRU,
        [EnumMember(Value = "XSN")]
        XSN,
        [EnumMember(Value = "XSU")]
        XSU,
        [EnumMember(Value = "XTH")]
        XTH,
        [EnumMember(Value = "XYJ")]
        XYJ,
        [EnumMember(Value = "XYK")]
        XYK,
        [EnumMember(Value = "XYL")]
        XYL,
        [EnumMember(Value = "XYM")]
        XYM,
        [EnumMember(Value = "XYN")]
        XYN,
        [EnumMember(Value = "XYO")]
        XYO,
        [EnumMember(Value = "XYP")]
        XYP,
        [EnumMember(Value = "XYQ")]
        XYQ,
        [EnumMember(Value = "XYR")]
        XYR,
        [EnumMember(Value = "XYS")]
        XYS,
        [EnumMember(Value = "XYT")]
        XYT,
        [EnumMember(Value = "XYU")]
        XYU,
        [EnumMember(Value = "XYV")]
        XYV,
        [EnumMember(Value = "XYW")]
        XYW,
        [EnumMember(Value = "XYX")]
        XYX,
        [EnumMember(Value = "XYY")]
        XYY,
        [EnumMember(Value = "XYZ")]
        XYZ,
        [EnumMember(Value = "XZC")]
        XZC,
        [EnumMember(Value = "XZI")]
        XZI,
        [EnumMember(Value = "YER")]
        YER,
        [EnumMember(Value = "ZAR")]
        ZAR,
        [EnumMember(Value = "ZAr")]
        ZAr,
        [EnumMember(Value = "ZMK")]
        ZMK,
        [EnumMember(Value = "ZMW")]
        ZMW,
        [EnumMember(Value = "ZWD")]
        ZWD,
        [EnumMember(Value = "ZWd")]
        ZWd,
        [EnumMember(Value = "ZWF")]
        ZWF,
        [EnumMember(Value = "ZWL")]
        ZWL,
        [EnumMember(Value = "ZWN")]
        ZWN,
        [EnumMember(Value = "ZWR")]
        ZWR,
        [EnumMember(Value = "€AS")]
        EURO_AS,
        [EnumMember(Value = "€DM")]
        EURO_DM,
        [EnumMember(Value = "€EC")]
        EURO_EC,
        [EnumMember(Value = "€IL")]
        EURO_IL,
    }
}
