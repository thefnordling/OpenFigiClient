using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace = "")]
    public enum SecurityTypeOne
    {
        [EnumMember]
        Unknown,
        [EnumMember(Value = "ABS Auto")]
        ABS_AUTO,
        [EnumMember(Value = "ABS Card")]
        ABS_CARD,
        [EnumMember(Value = "ABS Home")]
        ABS_HOME,
        [EnumMember(Value = "ABS Other")]
        ABS_OTHER,
        [EnumMember(Value = "ACCEPT BANCARIA")]
        ACCEPT_BANCARIA,
        [EnumMember(Value = "ADJ CONV. TO FIXED")]
        ADJ_CONV_TO_FIXED,
        [EnumMember(Value = "ADJ CONV. TO FIXED, OID")]
        ADJ_CONV_TO_FIXED_OID,
        [EnumMember(Value = "ADJUSTABLE")]
        ADJUSTABLE,
        [EnumMember(Value = "ADJUSTABLE, OID")]
        ADJUSTABLE_OID,
        [EnumMember(Value = "ADR")]
        ADR,
        [EnumMember(Value = "Agncy ABS Home")]
        AGNCY_ABS_HOME,
        [EnumMember(Value = "Agncy ABS Other")]
        AGNCY_ABS_OTHER,
        [EnumMember(Value = "Agncy CMBS")]
        AGNCY_CMBS,
        [EnumMember(Value = "Agncy CMO FLT")]
        AGNCY_CMO_FLT,
        [EnumMember(Value = "Agncy CMO INV")]
        AGNCY_CMO_INV,
        [EnumMember(Value = "Agncy CMO IO")]
        AGNCY_CMO_IO,
        [EnumMember(Value = "Agncy CMO Other")]
        AGNCY_CMO_OTHER,
        [EnumMember(Value = "Agncy CMO PO")]
        AGNCY_CMO_PO,
        [EnumMember(Value = "Agncy CMO Z")]
        AGNCY_CMO_Z,
        [EnumMember(Value = "Asset-Based")]
        ASSET_BASED_1,
        [EnumMember(Value = "ASSET-BASED")]
        ASSET_BASED_2,
        [EnumMember(Value = "ASSET-BASED BRIDGE")]
        ASSET_BASED_BRIDGE,
        [EnumMember(Value = "ASSET-BASED BRIDGE REV")]
        ASSET_BASED_BRIDGE_REV,
        [EnumMember(Value = "ASSET-BASED BRIDGE TERM")]
        ASSET_BASED_BRIDGE_TERM,
        [EnumMember(Value = "ASSET-BASED DELAY-DRAW TERM")]
        ASSET_BASED_DELAY_DRAW_TERM,
        [EnumMember(Value = "ASSET-BASED DIP")]
        ASSET_BASED_DIP,
        [EnumMember(Value = "ASSET-BASED DIP REV")]
        ASSET_BASED_DIP_REV,
        [EnumMember(Value = "ASSET-BASED DIP TERM")]
        ASSET_BASED_DIP_TERM,
        [EnumMember(Value = "ASSET-BASED LOC")]
        ASSET_BASED_LOC,
        [EnumMember(Value = "ASSET-BASED REV")]
        ASSET_BASED_REV,
        [EnumMember(Value = "Asset-Based Revolver")]
        ASSET_BASED_REVOLVER,
        [EnumMember(Value = "ASSET-BASED TERM")]
        ASSET_BASED_TERM_1,
        [EnumMember(Value = "Asset-Based Term")]
        ASSET_BASED_TERM_2,
        [EnumMember(Value = "AUSTRALIAN")]
        AUSTRALIAN,
        [EnumMember(Value = "AUSTRALIAN CD")]
        AUSTRALIAN_CD,
        [EnumMember(Value = "AUSTRALIAN CP")]
        AUSTRALIAN_CP,
        [EnumMember(Value = "Austrian Crt")]
        AUSTRIAN_CRT,
        [EnumMember(Value = "BANK ACCEPT BILL")]
        BANK_ACCEPT_BILL,
        [EnumMember(Value = "BANK BILL")]
        BANK_BILL,
        [EnumMember(Value = "BANK NOTE")]
        BANK_NOTE,
        [EnumMember(Value = "BANKERS ACCEPT")]
        BANKERS_ACCEPT,
        [EnumMember(Value = "BANKERS ACCEPTANCE")]
        BANKERS_ACCEPTANCE,
        [EnumMember(Value = "BASIS SWAP")]
        BASIS_SWAP,
        [EnumMember(Value = "Basket WRT")]
        BASKET_WRT,
        [EnumMember(Value = "BDR")]
        BDR,
        [EnumMember(Value = "BEARER DEP NOTE")]
        BEARER_DEP_NOTE,
        [EnumMember(Value = "Belgium Cert")]
        BELGIUM_CERT,
        [EnumMember(Value = "BELGIUM CP")]
        BELGIUM_CP,
        [EnumMember(Value = "BILL OF EXCHANGE")]
        BILL_OF_EXCHANGE,
        [EnumMember(Value = "BILLET A ORDRE")]
        BILLET_A_ORDRE,
        [EnumMember(Value = "Bond")]
        BOND,
        [EnumMember(Value = "Bond OTC Option")]
        BOND_OTC_OPTION,
        [EnumMember(Value = "BORROW")]
        BORROW,
        [EnumMember(Value = "BRAZIL GENERIC")]
        BRAZIL_GENERIC,
        [EnumMember(Value = "BRAZILIAN CDI")]
        BRAZILIAN_CDI,
        [EnumMember(Value = "Bridge")]
        BRIDGE_1,
        [EnumMember(Value = "BRIDGE")]
        BRIDGE_2,
        [EnumMember(Value = "BRIDGE DELAY-DRAW")]
        BRIDGE_DELAY_DRAW,
        [EnumMember(Value = "BRIDGE DELAY-DRAW TERM")]
        BRIDGE_DELAY_DRAW_TERM,
        [EnumMember(Value = "BRIDGE DIP TERM")]
        BRIDGE_DIP_TERM,
        [EnumMember(Value = "BRIDGE GUARANTEE FAC")]
        BRIDGE_GUARANTEE_FAC,
        [EnumMember(Value = "BRIDGE ISLAMIC")]
        BRIDGE_ISLAMIC,
        [EnumMember(Value = "BRIDGE ISLAMIC TERM")]
        BRIDGE_ISLAMIC_TERM,
        [EnumMember(Value = "BRIDGE PIK")]
        BRIDGE_PIK,
        [EnumMember(Value = "BRIDGE PIK REV")]
        BRIDGE_PIK_REV,
        [EnumMember(Value = "BRIDGE PIK TERM")]
        BRIDGE_PIK_TERM,
        [EnumMember(Value = "BRIDGE REV")]
        BRIDGE_REV,
        [EnumMember(Value = "BRIDGE REV GUARANTEE FAC")]
        BRIDGE_REV_GUARANTEE_FAC,
        [EnumMember(Value = "Bridge Revolver")]
        BRIDGE_REVOLVER,
        [EnumMember(Value = "BRIDGE STANDBY TERM")]
        BRIDGE_STANDBY_TERM,
        [EnumMember(Value = "BRIDGE TERM")]
        BRIDGE_TERM_1,
        [EnumMember(Value = "Bridge Term")]
        BRIDGE_TERM_2,
        [EnumMember(Value = "BRIDGE VAT-TRNCH")]
        BRIDGE_VAT_TRNCH,
        [EnumMember(Value = "BULLDOG")]
        BULLDOG,
        [EnumMember(Value = "BUTTERFLY SWAP")]
        BUTTERFLY_SWAP,
        [EnumMember(Value = "BUY-SELL")]
        BUY_SELL,
        [EnumMember(Value = "BUY-SELL MGN")]
        BUY_SELL_MGN,
        [EnumMember(Value = "CAD INT BEAR CP")]
        CAD_INT_BEAR_CP,
        [EnumMember(Value = "Calendar Spread Option")]
        CALENDAR_SPREAD_OPTION,
        [EnumMember(Value = "CALL LOANS")]
        CALL_LOANS,
        [EnumMember(Value = "CALLABLE CP")]
        CALLABLE_CP,
        [EnumMember(Value = "CANADIAN")]
        CANADIAN_1,
        [EnumMember(Value = "Canadian")]
        CANADIAN_2,
        [EnumMember(Value = "CANADIAN CD")]
        CANADIAN_CD,
        [EnumMember(Value = "CANADIAN CP")]
        CANADIAN_CP,
        [EnumMember(Value = "CAPS & FLOORS")]
        CAPS_FLOORS,
        [EnumMember(Value = "Car Forward")]
        CAR_FORWARD,
        [EnumMember(Value = "CASH")]
        CASH,
        [EnumMember(Value = "CASH RATE")]
        CASH_RATE,
        [EnumMember(Value = "CBLO")]
        CBLO,
        [EnumMember(Value = "CD")]
        CD,
        [EnumMember(Value = "CDI")]
        CDI,
        [EnumMember(Value = "CDR")]
        CDR,
        [EnumMember(Value = "CEDEAR")]
        CEDEAR,
        [EnumMember(Value = "CF")]
        CF,
        [EnumMember(Value = "CHILEAN CD")]
        CHILEAN_CD,
        [EnumMember(Value = "CHILEAN DN")]
        CHILEAN_DN,
        [EnumMember(Value = "Closed-End Fund")]
        CLOSED_END_FUND,
        [EnumMember(Value = "CMBS")]
        CMBS,
        [EnumMember(Value = "Cmdt Fut WRT")]
        CMDT_FUT_WRT,
        [EnumMember(Value = "Cmdt Idx WRT")]
        CMDT_IDX_WRT,
        [EnumMember(Value = "COLLAT CALL NOTE")]
        COLLAT_CALL_NOTE,
        [EnumMember(Value = "COLOMBIAN CD")]
        COLOMBIAN_CD,
        [EnumMember(Value = "COMMERCIAL NOTE")]
        COMMERCIAL_NOTE,
        [EnumMember(Value = "COMMERCIAL PAPER")]
        COMMERCIAL_PAPER,
        [EnumMember(Value = "Commodity Index")]
        COMMODITY_INDEX,
        [EnumMember(Value = "Common Stock")]
        COMMON_STOCK,
        [EnumMember(Value = "CONTRACT FOR DIFFERENCE")]
        CONTRACT_FOR_DIFFERENCE,
        [EnumMember(Value = "CONTRACT FRA")]
        CONTRACT_FRA,
        [EnumMember(Value = "Conv Bond")]
        CONV_BOND,
        [EnumMember(Value = "Conv Prfd")]
        CONV_PRFD,
        [EnumMember(Value = "Corp Bnd WRT")]
        CORP_BND_WRT,
        [EnumMember(Value = "Corporate OTC option")]
        CORPORATE_OTC_OPTION,
        [EnumMember(Value = "CP-LIKE EXT NOTE")]
        CP_LIKE_EXT_NOTE,
        [EnumMember(Value = "CPI LINKED")]
        CPI_LINKED,
        [EnumMember(Value = "CREDIT DEFAULT SWAP")]
        CREDIT_DEFAULT_SWAP,
        [EnumMember(Value = "Credit Linked Deposit")]
        CREDIT_LINKED_DEPOSIT,
        [EnumMember(Value = "CROSS")]
        CROSS,
        [EnumMember(Value = "Currency future.")]
        CURRENCY_FUTURE,
        [EnumMember(Value = "Currency option.")]
        CURRENCY_OPTION,
        [EnumMember(Value = "Currency spot.")]
        CURRENCY_SPOT,
        [EnumMember(Value = "Currency WRT")]
        CURRENCY_WRT,
        [EnumMember(Value = "Custom Ticker")]
        CUSTOM_TICKER,
        [EnumMember(Value = "DELAY-DRAW")]
        DELAY_DRAW,
        [EnumMember(Value = "DELAY-DRAW ISLAMIC")]
        DELAY_DRAW_ISLAMIC,
        [EnumMember(Value = "DELAY-DRAW ISLAMIC LOC")]
        DELAY_DRAW_ISLAMIC_LOC,
        [EnumMember(Value = "DELAY-DRAW ISLAMIC TERM")]
        DELAY_DRAW_ISLAMIC_TERM,
        [EnumMember(Value = "DELAY-DRAW LOC")]
        DELAY_DRAW_LOC,
        [EnumMember(Value = "DELAY-DRAW PIK TERM")]
        DELAY_DRAW_PIK_TERM,
        [EnumMember(Value = "DELAY-DRAW REV")]
        DELAY_DRAW_REV,
        [EnumMember(Value = "DELAY-DRAW STANDBY TERM")]
        DELAY_DRAW_STANDBY_TERM,
        [EnumMember(Value = "DELAY-DRAW TERM")]
        DELAY_DRAW_TERM,
        [EnumMember(Value = "DELAY-DRAW TERM GUARANTEE F")]
        DELAY_DRAW_TERM_GUARANTEE_F,
        [EnumMember(Value = "DELAY-DRAW TERM VAT-TRNCH")]
        DELAY_DRAW_TERM_VAT_TRNCH,
        [EnumMember(Value = "Delayed Draw")]
        DELAYED_DRAW,
        [EnumMember(Value = "Delayed Draw Pik Term")]
        DELAYED_DRAW_PIK_TERM,
        [EnumMember(Value = "Delayed Draw Term")]
        DELAYED_DRAW_TERM,
        [EnumMember(Value = "Delayed Draw Term Incremental")]
        DELAYED_DRAW_TERM_INCREMENTAL,
        [EnumMember(Value = "Delayed Draw Term Multi-Draw")]
        DELAYED_DRAW_TERM_MULTI_DRAW,
        [EnumMember(Value = "Delayed Draw Term Revolver")]
        DELAYED_DRAW_TERM_REVOLVER,
        [EnumMember(Value = "DEPO")]
        DEPO,
        [EnumMember(Value = "DEPOSIT")]
        DEPOSIT,
        [EnumMember(Value = "DEPOSIT NOTE")]
        DEPOSIT_NOTE,
        [EnumMember(Value = "DIM SUM BRIDGE TERM")]
        DIM_SUM_BRIDGE_TERM,
        [EnumMember(Value = "DIM SUM DELAY-DRAW TERM")]
        DIM_SUM_DELAY_DRAW_TERM,
        [EnumMember(Value = "DIM SUM REV")]
        DIM_SUM_REV,
        [EnumMember(Value = "DIM SUM TERM")]
        DIM_SUM_TERM,
        [EnumMember(Value = "DIP")]
        DIP,
        [EnumMember(Value = "DIP DELAY-DRAW ISLAMIC TERM")]
        DIP_DELAY_DRAW_ISLAMIC_TERM,
        [EnumMember(Value = "DIP DELAY-DRAW PIK TERM")]
        DIP_DELAY_DRAW_PIK_TERM,
        [EnumMember(Value = "DIP DELAY-DRAW REV")]
        DIP_DELAY_DRAW_REV,
        [EnumMember(Value = "DIP DELAY-DRAW TERM")]
        DIP_DELAY_DRAW_TERM,
        [EnumMember(Value = "DIP LOC")]
        DIP_LOC,
        [EnumMember(Value = "Dip Pik Revolver")]
        DIP_PIK_REVOLVER,
        [EnumMember(Value = "DIP PIK TERM")]
        DIP_PIK_TERM,
        [EnumMember(Value = "DIP REV")]
        DIP_REV,
        [EnumMember(Value = "Dip Revolver")]
        DIP_REVOLVER,
        [EnumMember(Value = "DIP STANDBY LOC")]
        DIP_STANDBY_LOC,
        [EnumMember(Value = "DIP SYNTH LOC")]
        DIP_SYNTH_LOC,
        [EnumMember(Value = "DIP TERM")]
        DIP_TERM_1,
        [EnumMember(Value = "Dip Term")]
        DIP_TERM_2,
        [EnumMember(Value = "DISCOUNT FIXBIS")]
        DISCOUNT_FIXBIS,
        [EnumMember(Value = "DISCOUNT NOTES")]
        DISCOUNT_NOTES,
        [EnumMember(Value = "DIVIDEND NEUTRAL STOCK FUTURE")]
        DIVIDEND_NEUTRAL_STOCK_FUTURE,
        [EnumMember(Value = "Dividend swaps")]
        DIVIDEND_SWAPS,
        [EnumMember(Value = "DOMESTC TIME DEP")]
        DOMESTC_TIME_DEP,
        [EnumMember(Value = "DOMESTIC")]
        DOMESTIC,
        [EnumMember(Value = "DOMESTIC MTN")]
        DOMESTIC_MTN,
        [EnumMember(Value = "Dutch Cert")]
        DUTCH_CERT,
        [EnumMember(Value = "DUTCH CP")]
        DUTCH_CP,
        [EnumMember(Value = "EDR")]
        EDR,
        [EnumMember(Value = "Equity Index")]
        EQUITY_INDEX,
        [EnumMember(Value = "Equity Linked Notes")]
        EQUITY_LINKED_NOTES,
        [EnumMember(Value = "Equity Option")]
        EQUITY_OPTION,
        [EnumMember(Value = "Equity OTC Option")]
        EQUITY_OTC_OPTION,
        [EnumMember(Value = "Equity WRT")]
        EQUITY_WRT,
        [EnumMember(Value = "ETP")]
        ETP,
        [EnumMember(Value = "EURO CD")]
        EURO_CD,
        [EnumMember(Value = "EURO CP")]
        EURO_CP,
        [EnumMember(Value = "EURO MTN")]
        EURO_MTN,
        [EnumMember(Value = "EURO NON-DOLLAR")]
        EURO_NON_DOLLAR,
        [EnumMember(Value = "EURO STRUCTRD LN")]
        EURO_STRUCTRD_LN,
        [EnumMember(Value = "EURO TIME DEPST")]
        EURO_TIME_DEPST,
        [EnumMember(Value = "EURO-DOLLAR")]
        EURO_DOLLAR,
        [EnumMember(Value = "EURO-ZONE")]
        EURO_ZONE,
        [EnumMember(Value = "EXTEND COMM NOTE")]
        EXTEND_COMM_NOTE,
        [EnumMember(Value = "EXTEND. NOTE MTN")]
        EXTEND_NOTE_MTN,
        [EnumMember(Value = "FCP")]
        FCP,
        [EnumMember(Value = "FDIC")]
        FDIC,
        [EnumMember(Value = "FED FUNDS")]
        FED_FUNDS,
        [EnumMember(Value = "FIDC")]
        FIDC,
        [EnumMember(Value = "Financial commodity future.")]
        FINANCIAL_COMMODITY_FUTURE,
        [EnumMember(Value = "Financial commodity generic.")]
        FINANCIAL_COMMODITY_GENERIC,
        [EnumMember(Value = "Financial commodity option.")]
        FINANCIAL_COMMODITY_OPTION,
        [EnumMember(Value = "Financial commodity OTC option")]
        FINANCIAL_COMMODITY_OTC_OPTION,
        [EnumMember(Value = "Financial commodity spot.")]
        FINANCIAL_COMMODITY_SPOT,
        [EnumMember(Value = "Financial index future.")]
        FINANCIAL_INDEX_FUTURE,
        [EnumMember(Value = "Financial index generic.")]
        FINANCIAL_INDEX_GENERIC,
        [EnumMember(Value = "Financial index option.")]
        FINANCIAL_INDEX_OPTION,
        [EnumMember(Value = "FINNISH CD")]
        FINNISH_CD,
        [EnumMember(Value = "FINNISH CP")]
        FINNISH_CP,
        [EnumMember(Value = "FIXED")]
        FIXED,
        [EnumMember(Value = "Fixed Income Index")]
        FIXED_INCOME_INDEX,
        [EnumMember(Value = "FIXED, OID")]
        FIXED_OID,
        [EnumMember(Value = "FIXING RATE")]
        FIXING_RATE,
        [EnumMember(Value = "FLOATING")]
        FLOATING,
        [EnumMember(Value = "FLOATING CP")]
        FLOATING_CP,
        [EnumMember(Value = "FLOATING, OID")]
        FLOATING_OID,
        [EnumMember(Value = "Foreign Sh.")]
        FOREIGN_SH,
        [EnumMember(Value = "FORWARD")]
        FORWARD,
        [EnumMember(Value = "FORWARD CROSS")]
        FORWARD_CROSS,
        [EnumMember(Value = "FORWARD CURVE")]
        FORWARD_CURVE,
        [EnumMember(Value = "FRA")]
        FRA,
        [EnumMember(Value = "FRENCH CD")]
        FRENCH_CD,
        [EnumMember(Value = "French Cert")]
        FRENCH_CERT,
        [EnumMember(Value = "FRENCH CP")]
        FRENCH_CP,
        [EnumMember(Value = "Fund of Funds")]
        FUND_OF_FUNDS,
        [EnumMember(Value = "Futures Monthly Ticker")]
        FUTURES_MONTHLY_TICKER,
        [EnumMember(Value = "FWD SWAP")]
        FWD_SWAP,
        [EnumMember(Value = "FX Curve")]
        FX_CURVE,
        [EnumMember(Value = "FX DISCOUNT NOTE")]
        FX_DISCOUNT_NOTE,
        [EnumMember(Value = "GC Basket")]
        GC_BASKET,
        [EnumMember(Value = "GDR")]
        GDR,
        [EnumMember(Value = "Generic currency future.")]
        GENERIC_CURRENCY_FUTURE,
        [EnumMember(Value = "Generic index future.")]
        GENERIC_INDEX_FUTURE,
        [EnumMember(Value = "Generic Repo")]
        GENERIC_REPO,
        [EnumMember(Value = "GENSAKI BUY")]
        GENSAKI_BUY,
        [EnumMember(Value = "GENSAKI CP SELL")]
        GENSAKI_CP_SELL,
        [EnumMember(Value = "GENSAKI SELL")]
        GENSAKI_SELL,
        [EnumMember(Value = "Gentan Borrow")]
        GENTAN_BORROW_1,
        [EnumMember(Value = "GENTAN BORROW")]
        GENTAN_BORROW_2,
        [EnumMember(Value = "GENTAN LEND")]
        GENTAN_LEND,
        [EnumMember(Value = "German Cert")]
        GERMAN_CERT,
        [EnumMember(Value = "GERMAN CP")]
        GERMAN_CP,
        [EnumMember(Value = "GLOBAL")]
        GLOBAL,
        [EnumMember(Value = "GUARANTEE FAC")]
        GUARANTEE_FAC,
        [EnumMember(Value = "Guarantee Facility")]
        GUARANTEE_FACILITY,
        [EnumMember(Value = "HB")]
        HB,
        [EnumMember(Value = "HDR")]
        HDR,
        [EnumMember(Value = "Hedge Fund")]
        HEDGE_FUND,
        [EnumMember(Value = "HONG KONG CD")]
        HONG_KONG_CD,
        [EnumMember(Value = "I.R. Fut WRT")]
        I_R_FUT_WRT,
        [EnumMember(Value = "I.R. Swp WRT")]
        I_R_SWP_WRT,
        [EnumMember(Value = "IDR")]
        IDR,
        [EnumMember(Value = "IMM FORWARD")]
        IMM_FORWARD,
        [EnumMember(Value = "IMM SWAP")]
        IMM_SWAP,
        [EnumMember(Value = "Implied Correlation")]
        IMPLIED_CORRELATION,
        [EnumMember(Value = "Implied Forward")]
        IMPLIED_FORWARD,
        [EnumMember(Value = "Implied Volatility")]
        IMPLIED_VOLATILITY,
        [EnumMember(Value = "Index")]
        INDEX,
        [EnumMember(Value = "Index Option")]
        INDEX_OPTION,
        [EnumMember(Value = "Index OTC Option")]
        INDEX_OTC_OPTION,
        [EnumMember(Value = "Index WRT")]
        INDEX_WRT,
        [EnumMember(Value = "INDIAN CD")]
        INDIAN_CD,
        [EnumMember(Value = "INDIAN CP")]
        INDIAN_CP,
        [EnumMember(Value = "INDONESIAN CP")]
        INDONESIAN_CP,
        [EnumMember(Value = "Indx Fut WRT")]
        INDX_FUT_WRT,
        [EnumMember(Value = "INFLATION SWAP")]
        INFLATION_SWAP,
        [EnumMember(Value = "INT BEAR FIXBIS")]
        INT_BEAR_FIXBIS,
        [EnumMember(Value = "Int. Rt. WRT")]
        INT_RT_WRT,
        [EnumMember(Value = "INTER. APPRECIATION")]
        INTER_APPRECIATION,
        [EnumMember(Value = "INTER. APPRECIATION, OID")]
        INTER_APPRECIATION_OID,
        [EnumMember(Value = "Islamic")]
        ISLAMIC_1,
        [EnumMember(Value = "ISLAMIC")]
        ISLAMIC_2,
        [EnumMember(Value = "ISLAMIC BA")]
        ISLAMIC_BA,
        [EnumMember(Value = "ISLAMIC CP")]
        ISLAMIC_CP,
        [EnumMember(Value = "ISLAMIC GUARANTEE FAC")]
        ISLAMIC_GUARANTEE_FAC,
        [EnumMember(Value = "ISLAMIC LOC")]
        ISLAMIC_LOC,
        [EnumMember(Value = "ISLAMIC REV")]
        ISLAMIC_REV,
        [EnumMember(Value = "ISLAMIC STANDBY")]
        ISLAMIC_STANDBY,
        [EnumMember(Value = "ISLAMIC STANDBY REV")]
        ISLAMIC_STANDBY_REV,
        [EnumMember(Value = "ISLAMIC STANDBY TERM")]
        ISLAMIC_STANDBY_TERM,
        [EnumMember(Value = "Islamic Term")]
        ISLAMIC_TERM_1,
        [EnumMember(Value = "ISLAMIC TERM")]
        ISLAMIC_TERM_2,
        [EnumMember(Value = "JUMBO CD")]
        JUMBO_CD,
        [EnumMember(Value = "KOREAN CD")]
        KOREAN_CD,
        [EnumMember(Value = "KOREAN CP")]
        KOREAN_CP,
        [EnumMember(Value = "Last-In-First-Out")]
        LAST_IN_FIRST_OUT,
        [EnumMember(Value = "LEBANESE CP")]
        LEBANESE_CP,
        [EnumMember(Value = "LEND")]
        LEND,
        [EnumMember(Value = "LIQUIDITY NOTE")]
        LIQUIDITY_NOTE,
        [EnumMember(Value = "LOC")]
        LOC,
        [EnumMember(Value = "LOC GUARANTEE FAC")]
        LOC_GUARANTEE_FAC,
        [EnumMember(Value = "LOC TERM")]
        LOC_TERM,
        [EnumMember(Value = "Ltd Part")]
        LTD_PART,
        [EnumMember(Value = "Ltr Of Credit")]
        LTR_OF_CREDIT,
        [EnumMember(Value = "MALAYSIAN CP")]
        MALAYSIAN_CP,
        [EnumMember(Value = "Managed Account")]
        MANAGED_ACCOUNT,
        [EnumMember(Value = "MARGIN TERM DEP")]
        MARGIN_TERM_DEP,
        [EnumMember(Value = "MASTER NOTES")]
        MASTER_NOTES,
        [EnumMember(Value = "MBS")]
        MBS,
        [EnumMember(Value = "MBS 10yr")]
        MBS_10YR,
        [EnumMember(Value = "MBS 15yr")]
        MBS_15YR,
        [EnumMember(Value = "MBS 20yr")]
        MBS_20YR,
        [EnumMember(Value = "MBS 30yr")]
        MBS_30YR,
        [EnumMember(Value = "MBS ARM")]
        MBS_ARM,
        [EnumMember(Value = "MBS balloon")]
        MBS_BALLOON,
        [EnumMember(Value = "MBS Other")]
        MBS_OTHER,
        [EnumMember(Value = "MED TERM NOTE")]
        MED_TERM_NOTE,
        [EnumMember(Value = "MEDIUM TERM CD")]
        MEDIUM_TERM_CD,
        [EnumMember(Value = "MEDIUM TERM ECD")]
        MEDIUM_TERM_ECD,
        [EnumMember(Value = "MEXICAN CP")]
        MEXICAN_CP,
        [EnumMember(Value = "MEXICAN PAGARE")]
        MEXICAN_PAGARE,
        [EnumMember(Value = "Misc.")]
        MISC,
        [EnumMember(Value = "MLP")]
        MLP,
        [EnumMember(Value = "MONETARY BILLS")]
        MONETARY_BILLS,
        [EnumMember(Value = "MONEY MARKET CALL")]
        MONEY_MARKET_CALL,
        [EnumMember(Value = "MUNI CP")]
        MUNI_CP,
        [EnumMember(Value = "MUNI INT BEAR CP")]
        MUNI_INT_BEAR_CP,
        [EnumMember(Value = "MUNI SWAP")]
        MUNI_SWAP,
        [EnumMember(Value = "MURABAHA")]
        MURABAHA,
        [EnumMember(Value = "Mutual Fund")]
        MUTUAL_FUND,
        [EnumMember(Value = "MV")]
        MV,
        [EnumMember(Value = "MX CERT BURSATIL")]
        MX_CERT_BURSATIL,
        [EnumMember(Value = "NDF SWAP")]
        NDF_SWAP,
        [EnumMember(Value = "NEG EURO CP")]
        NEG_EURO_CP,
        [EnumMember(Value = "NEG INST DEPOSIT")]
        NEG_INST_DEPOSIT,
        [EnumMember(Value = "NEGOTIABLE CD")]
        NEGOTIABLE_CD,
        [EnumMember(Value = "NEW ZEALAND CD")]
        NEW_ZEALAND_CD,
        [EnumMember(Value = "NEW ZEALAND CP")]
        NEW_ZEALAND_CP,
        [EnumMember(Value = "NON-DELIVERABLE FORWARD")]
        NON_DELIVERABLE_FORWARD,
        [EnumMember(Value = "NON-DELIVERABLE IRS SWAP")]
        NON_DELIVERABLE_IRS_SWAP,
        [EnumMember(Value = "NON-DELIVERABLE OIS SWAP")]
        NON_DELIVERABLE_OIS_SWAP,
        [EnumMember(Value = "NVDR")]
        NVDR,
        [EnumMember(Value = "NY Reg Shrs")]
        NY_REG_SHRS,
        [EnumMember(Value = "OID")]
        OID,
        [EnumMember(Value = "ONSHORE FORWARD")]
        ONSHORE_FORWARD,
        [EnumMember(Value = "ONSHORE SWAP")]
        ONSHORE_SWAP,
        [EnumMember(Value = "Open-End Fund")]
        OPEN_END_FUND,
        [EnumMember(Value = "Option on Equity Future")]
        OPTION_ON_EQUITY_FUTURE,
        [EnumMember(Value = "OPTION VOLATILITY")]
        OPTION_VOLATILITY,
        [EnumMember(Value = "OTHER")]
        OTHER,
        [EnumMember(Value = "OVER/NIGHT")]
        OVERNIGHT,
        [EnumMember(Value = "OVERDRAFT")]
        OVERDRAFT,
        [EnumMember(Value = "Overdraft Facility")]
        OVERDRAFT_FACILITY,
        [EnumMember(Value = "OVERNIGHT INDEXED SWAP")]
        OVERNIGHT_INDEXED_SWAP,
        [EnumMember(Value = "Participate Cert")]
        PARTICIPATE_CERT,
        [EnumMember(Value = "Pay Fix/Rec Flt")]
        PAY_FIX_REC_FLT,
        [EnumMember(Value = "PENSION REPO")]
        PENSION_REPO,
        [EnumMember(Value = "PHILIPPINE CP")]
        PHILIPPINE_CP,
        [EnumMember(Value = "Physical commodity forward.")]
        PHYSICAL_COMMODITY_FORWARD,
        [EnumMember(Value = "Physical commodity future.")]
        PHYSICAL_COMMODITY_FUTURE,
        [EnumMember(Value = "Physical commodity generic.")]
        PHYSICAL_COMMODITY_GENERIC,
        [EnumMember(Value = "Physical commodity option.")]
        PHYSICAL_COMMODITY_OPTION,
        [EnumMember(Value = "Physical commodity spot.")]
        PHYSICAL_COMMODITY_SPOT,
        [EnumMember(Value = "Physical index future.")]
        PHYSICAL_INDEX_FUTURE,
        [EnumMember(Value = "Physical index option.")]
        PHYSICAL_INDEX_OPTION,
        [EnumMember(Value = "PIK")]
        PIK_1,
        [EnumMember(Value = "Pik")]
        PIK_2,
        [EnumMember(Value = "PIK LOC")]
        PIK_LOC,
        [EnumMember(Value = "PIK REV")]
        PIK_REV,
        [EnumMember(Value = "Pik Revolver")]
        PIK_REVOLVER,
        [EnumMember(Value = "PIK SYNTH LOC")]
        PIK_SYNTH_LOC,
        [EnumMember(Value = "PIK TERM")]
        PIK_TERM_1,
        [EnumMember(Value = "Pik Term")]
        PIK_TERM_2,
        [EnumMember(Value = "PLAZOS FIJOS")]
        PLAZOS_FIJOS,
        [EnumMember(Value = "PORTUGUESE CP")]
        PORTUGUESE_CP,
        [EnumMember(Value = "Preference")]
        PREFERENCE,
        [EnumMember(Value = "Preferred")]
        PREFERRED,
        [EnumMember(Value = "PRES")]
        PRES,
        [EnumMember(Value = "Prfd WRT")]
        PRFD_WRT,
        [EnumMember(Value = "PRIV PLACEMENT")]
        PRIV_PLACEMENT,
        [EnumMember(Value = "PRIVATE")]
        PRIVATE,
        [EnumMember(Value = "Private Comp")]
        PRIVATE_COMP,
        [EnumMember(Value = "Private Eqty")]
        PRIVATE_EQTY,
        [EnumMember(Value = "PROMISSORY NOTE")]
        PROMISSORY_NOTE,
        [EnumMember(Value = "PROPERTY SWAP")]
        PROPERTY_SWAP,
        [EnumMember(Value = "PROV T-BILL")]
        PROV_T_BILL,
        [EnumMember(Value = "Prvt CMO FLT")]
        PRVT_CMO_FLT,
        [EnumMember(Value = "Prvt CMO INV")]
        PRVT_CMO_INV,
        [EnumMember(Value = "Prvt CMO IO")]
        PRVT_CMO_IO,
        [EnumMember(Value = "Prvt CMO Other")]
        PRVT_CMO_OTHER,
        [EnumMember(Value = "Prvt CMO PO")]
        PRVT_CMO_PO,
        [EnumMember(Value = "Prvt CMO Z")]
        PRVT_CMO_Z,
        [EnumMember(Value = "PUBLIC")]
        PUBLIC,
        [EnumMember(Value = "Pvt Eqty Fund")]
        PVT_EQTY_FUND,
        [EnumMember(Value = "QUARTERLY SWAP")]
        QUARTERLY_SWAP,
        [EnumMember(Value = "RDC")]
        RDC,
        [EnumMember(Value = "Realized Correlation")]
        REALIZED_CORRELATION,
        [EnumMember(Value = "Rec Fix/Pay Flt")]
        REC_FIX_PAY_FLT,
        [EnumMember(Value = "Receipt")]
        RECEIPT,
        [EnumMember(Value = "REIT")]
        REIT,
        [EnumMember(Value = "REPO")]
        REPO,
        [EnumMember(Value = "RESERVE-BASED")]
        RESERVE_BASED,
        [EnumMember(Value = "RESERVE-BASED REV")]
        RESERVE_BASED_REV,
        [EnumMember(Value = "RESTRUCTURD DEBT")]
        RESTRUCTURD_DEBT,
        [EnumMember(Value = "RETAIL CD")]
        RETAIL_CD,
        [EnumMember(Value = "RETURN IDX")]
        RETURN_IDX,
        [EnumMember(Value = "REV")]
        REV,
        [EnumMember(Value = "REV GUARANTEE FAC")]
        REV_GUARANTEE_FAC,
        [EnumMember(Value = "REV VAT-TRNCH")]
        REV_VAT_TRNCH,
        [EnumMember(Value = "REV-REPO")]
        REV_REPO,
        [EnumMember(Value = "Revolver")]
        REVOLVER,
        [EnumMember(Value = "Right")]
        RIGHT,
        [EnumMember(Value = "Royalty Trst")]
        ROYALTY_TRST,
        [EnumMember(Value = "S.TERM LOAN NOTE")]
        S_TERM_LOAN_NOTE,
        [EnumMember(Value = "SAMURAI")]
        SAMURAI,
        [EnumMember(Value = "Savings Plan")]
        SAVINGS_PLAN,
        [EnumMember(Value = "Savings Share")]
        SAVINGS_SHARE,
        [EnumMember(Value = "SBA Pool")]
        SBA_POOL,
        [EnumMember(Value = "SDR")]
        SDR,
        [EnumMember(Value = "Sec Lending")]
        SEC_LENDING,
        [EnumMember(Value = "SELL-BUY")]
        SELL_BUY,
        [EnumMember(Value = "SHOGUN")]
        SHOGUN,
        [EnumMember(Value = "SHORT TERM BN")]
        SHORT_TERM_BN,
        [EnumMember(Value = "SHORT TERM DN")]
        SHORT_TERM_DN,
        [EnumMember(Value = "SICAV")]
        SICAV,
        [EnumMember(Value = "SINGAPORE CP")]
        SINGAPORE_CP,
        [EnumMember(Value = "SINGLE STOCK DIVIDEND FUTURE")]
        SINGLE_STOCK_DIVIDEND_FUTURE,
        [EnumMember(Value = "SINGLE STOCK FORWARD")]
        SINGLE_STOCK_FORWARD,
        [EnumMember(Value = "SINGLE STOCK FUTURE")]
        SINGLE_STOCK_FUTURE,
        [EnumMember(Value = "SINGLE STOCK FUTURE SPREAD")]
        SINGLE_STOCK_FUTURE_SPREAD,
        [EnumMember(Value = "SN")]
        SN,
        [EnumMember(Value = "SPECIAL LMMK PGM")]
        SPECIAL_LMMK_PGM,
        [EnumMember(Value = "SPOT")]
        SPOT,
        [EnumMember(Value = "Spot fixing")]
        SPOT_FIXING,
        [EnumMember(Value = "Spot index.")]
        SPOT_INDEX,
        [EnumMember(Value = "Standby")]
        STANDBY_1,
        [EnumMember(Value = "STANDBY")]
        STANDBY_2,
        [EnumMember(Value = "STANDBY LOC")]
        STANDBY_LOC,
        [EnumMember(Value = "STANDBY REV")]
        STANDBY_REV,
        [EnumMember(Value = "Standby Revolver")]
        STANDBY_REVOLVER,
        [EnumMember(Value = "STANDBY TERM")]
        STANDBY_TERM,
        [EnumMember(Value = "Stapled Security")]
        STAPLED_SECURITY,
        [EnumMember(Value = "STERLING CD")]
        STERLING_CD,
        [EnumMember(Value = "STERLING CP")]
        STERLING_CP,
        [EnumMember(Value = "Strategy Trade.")]
        STRATEGY_TRADE,
        [EnumMember(Value = "SWAP")]
        SWAP,
        [EnumMember(Value = "SWAP SPREAD")]
        SWAP_SPREAD,
        [EnumMember(Value = "SWAPTION VOLATILITY")]
        SWAPTION_VOLATILITY,
        [EnumMember(Value = "SWEDISH CP")]
        SWEDISH_CP,
        [EnumMember(Value = "SWINGLINE")]
        SWINGLINE,
        [EnumMember(Value = "Swiss Cert")]
        SWISS_CERT,
        [EnumMember(Value = "SYNTH LOC")]
        SYNTH_LOC,
        [EnumMember(Value = "SYNTH REV")]
        SYNTH_REV,
        [EnumMember(Value = "SYNTH TERM")]
        SYNTH_TERM,
        [EnumMember(Value = "Synthetic")]
        SYNTHETIC,
        [EnumMember(Value = "Synthetic Ltr Of Credit")]
        SYNTHETIC_LTR_OF_CREDIT,
        [EnumMember(Value = "Synthetic Revolver")]
        SYNTHETIC_REVOLVER,
        [EnumMember(Value = "Synthetic Term")]
        SYNTHETIC_TERM,
        [EnumMember(Value = "Synthetic Term Revolver")]
        SYNTHETIC_TERM_REVOLVER,
        [EnumMember(Value = "TAIWAN CP")]
        TAIWAN_CP,
        [EnumMember(Value = "TAIWAN CP GUAR")]
        TAIWAN_CP_GUAR,
        [EnumMember(Value = "TAIWAN NEGO CD")]
        TAIWAN_NEGO_CD,
        [EnumMember(Value = "TAIWAN REV-REPO")]
        TAIWAN_REV_REPO,
        [EnumMember(Value = "TAIWAN TIME DEPO")]
        TAIWAN_TIME_DEPO,
        [EnumMember(Value = "TAX CREDIT")]
        TAX_CREDIT,
        [EnumMember(Value = "TAX CREDIT, OID")]
        TAX_CREDIT_OID,
        [EnumMember(Value = "Tax Spared Loan")]
        TAX_SPARED_LOAN,
        [EnumMember(Value = "Tax Spared Loan Incremental")]
        TAX_SPARED_LOAN_INCREMENTAL,
        [EnumMember(Value = "TDR")]
        TDR,
        [EnumMember(Value = "Term")]
        TERM_1,
        [EnumMember(Value = "TERM")]
        TERM_2,
        [EnumMember(Value = "TERM DEPOSITS")]
        TERM_DEPOSITS,
        [EnumMember(Value = "TERM GUARANTEE FAC")]
        TERM_GUARANTEE_FAC,
        [EnumMember(Value = "Term Incremental")]
        TERM_INCREMENTAL,
        [EnumMember(Value = "Term Multi-Draw")]
        TERM_MULTI_DRAW,
        [EnumMember(Value = "TERM REV")]
        TERM_REV,
        [EnumMember(Value = "Term Revolver")]
        TERM_REVOLVER,
        [EnumMember(Value = "TERM VAT-TRNCH")]
        TERM_VAT_TRNCH,
        [EnumMember(Value = "TEST")]
        TEST,
        [EnumMember(Value = "THAILAND CP")]
        THAILAND_CP,
        [EnumMember(Value = "Tracking Stk")]
        TRACKING_STK,
        [EnumMember(Value = "TREASURY BILL")]
        TREASURY_BILL,
        [EnumMember(Value = "U.S. CD")]
        U_S_CD,
        [EnumMember(Value = "U.S. CP")]
        U_S_CP,
        [EnumMember(Value = "U.S. INT BEAR CP")]
        U_S_INT_BEAR_CP,
        [EnumMember(Value = "UIT")]
        UIT,
        [EnumMember(Value = "UK GILT STOCK")]
        UK_GILT_STOCK,
        [EnumMember(Value = "UMBS MBS Other")]
        UMBS_MBS_OTHER,
        [EnumMember(Value = "Unit")]
        UNIT,
        [EnumMember(Value = "Unit Inv Tst")]
        UNIT_INV_TST,
        [EnumMember(Value = "US DOMESTIC")]
        US_DOMESTIC,
        [EnumMember(Value = "US GOVERNMENT")]
        US_GOVERNMENT,
        [EnumMember(Value = "US NON-DOLLAR")]
        US_NON_DOLLAR,
        [EnumMember(Value = "VAR RATE DEM OBL")]
        VAR_RATE_DEM_OBL,
        [EnumMember(Value = "Variance Swap")]
        VARIANCE_SWAP,
        [EnumMember(Value = "VAT-TRNCH")]
        VAT_TRNCH,
        [EnumMember(Value = "VENEZUELAN CP")]
        VENEZUELAN_CP,
        [EnumMember(Value = "VOLATILITY DERIVATIVE")]
        VOLATILITY_DERIVATIVE,
        [EnumMember(Value = "Volatility Swap")]
        VOLATILITY_SWAP,
        [EnumMember(Value = "Volatility Swap Uncapped")]
        VOLATILITY_SWAP_UNCAPPED,
        [EnumMember(Value = "WARRANT")]
        WARRANT_1,
        [EnumMember(Value = "Warrant")]
        WARRANT_2,
        [EnumMember(Value = "YANKEE")]
        YANKEE,
        [EnumMember(Value = "YANKEE CD")]
        YANKEE_CD,
        [EnumMember(Value = "YEN CD")]
        YEN_CD,
        [EnumMember(Value = "YEN CP")]
        YEN_CP,
        [EnumMember(Value = "Yield Curve")]
        YIELD_CURVE,
        [EnumMember(Value = "ZERO COUPON")]
        ZERO_COUPON,
        [EnumMember(Value = "ZERO COUPON, OID")]
        ZERO_COUPON_OID
    }
}
