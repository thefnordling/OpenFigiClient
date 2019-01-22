using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace="")]
    public enum SecurityTypeTwo
    {
        [EnumMember]
        Unknown,
        [EnumMember(Value = "2ND LIEN")]
        _2ND_LIEN,
        [EnumMember(Value = "5.1Y Pay 10.7% 6M vs 0% 7Y For")]
        _5_1Y_PAY_10_7PCT_6M_VS_0PCT_7Y_FOR,
        [EnumMember(Value = "ABS")]
        ABS,
        [EnumMember(Value = "ABS Other")]
        ABS_OTHER,
        [EnumMember(Value = "ABS/HG")]
        ABS_HG,
        [EnumMember(Value = "ABS/MEZZ")]
        ABS_MEZZ,
        [EnumMember(Value = "BA")]
        BA,
        [EnumMember(Value = "Bagged Briquettes")]
        BAGGED_BRIQUETTES,
        [EnumMember(Value = "Bagged Pellets")]
        BAGGED_PELLETS,
        [EnumMember(Value = "BANK BILL")]
        BANK_BILL,
        [EnumMember(Value = "BANKERS ACCEPTANCE")]
        BANKERS_ACCEPTANCE,
        [EnumMember(Value = "BASIS SWAP")]
        BASIS_SWAP,
        [EnumMember(Value = "BESPOKE")]
        BESPOKE,
        [EnumMember(Value = "Bill")]
        BILL,
        [EnumMember(Value = "Billet 20MN")]
        BILLET_20MN,
        [EnumMember(Value = "Billet 3803p")]
        BILLET_3803P,
        [EnumMember(Value = "Billet 3803s")]
        BILLET_3803S,
        [EnumMember(Value = "Billet 3803sp")]
        BILLET_3803SP,
        [EnumMember(Value = "Billet 3805p")]
        BILLET_3805P,
        [EnumMember(Value = "Billet 3805s")]
        BILLET_3805S,
        [EnumMember(Value = "Billet 3805sp")]
        BILLET_3805SP,
        [EnumMember(Value = "Billet A61560")]
        BILLET_A61560,
        [EnumMember(Value = "Billet BS4449")]
        BILLET_BS4449,
        [EnumMember(Value = "Billet LME Grade 1")]
        BILLET_LME_GRADE_1,
        [EnumMember(Value = "Billet LME Grade 2")]
        BILLET_LME_GRADE_2,
        [EnumMember(Value = "Billet LME Grade 3")]
        BILLET_LME_GRADE_3,
        [EnumMember(Value = "Billet LME Grade 4")]
        BILLET_LME_GRADE_4,
        [EnumMember(Value = "Billet LME Grade 5")]
        BILLET_LME_GRADE_5,
        [EnumMember(Value = "Billet LME Grade 6")]
        BILLET_LME_GRADE_6,
        [EnumMember(Value = "Billet LME Grade 7")]
        BILLET_LME_GRADE_7,
        [EnumMember(Value = "Billet LME Grade 8")]
        BILLET_LME_GRADE_8,
        [EnumMember(Value = "Billet LME Grade 9")]
        BILLET_LME_GRADE_9,
        [EnumMember(Value = "Billet Q235")]
        BILLET_Q235,
        [EnumMember(Value = "BN")]
        BN,
        [EnumMember(Value = "Bond")]
        BOND,
        [EnumMember(Value = "Bond/Note")]
        BOND_NOTE,
        [EnumMember(Value = "Briquettes")]
        BRIQUETTES,
        [EnumMember(Value = "BUTTERFLY SWAP")]
        BUTTERFLY_SWAP,
        [EnumMember(Value = "CAPS & FLOORS")]
        CAPS_FLOORS,
        [EnumMember(Value = "CASH RATE")]
        CASH_RATE,
        [EnumMember(Value = "Cathodes")]
        CATHODES,
        [EnumMember(Value = "Cathodes 100x100mm")]
        CATHODES_100X100MM,
        [EnumMember(Value = "Cathodes 25x25mm")]
        CATHODES_25X25MM,
        [EnumMember(Value = "Cathodes 50x50mm")]
        CATHODES_50X50MM,
        [EnumMember(Value = "CD")]
        CD,
        [EnumMember(Value = "CDO2")]
        CDO2,
        [EnumMember(Value = "CDS")]
        CDS,
        [EnumMember(Value = "CDS INDEX")]
        CDS_INDEX,
        [EnumMember(Value = "CDS(ABS)")]
        CDS_ABS,
        [EnumMember(Value = "CDS(CRP)")]
        CDS_CRP,
        [EnumMember(Value = "Certificate")]
        CERTIFICATE,
        [EnumMember(Value = "CMBS")]
        CMBS,
        [EnumMember(Value = "CMO")]
        CMO,
        [EnumMember(Value = "Coarse Grain Powder")]
        COARSE_GRAIN_POWDER,
        [EnumMember(Value = "Comdty")]
        COMDTY,
        [EnumMember(Value = "COMMERCIAL PAPER")]
        COMMERCIAL_PAPER,
        [EnumMember(Value = "Common Stock")]
        COMMON_STOCK,
        [EnumMember(Value = "CONTRACT FRA")]
        CONTRACT_FRA,
        [EnumMember(Value = "Corp")]
        CORP,
        [EnumMember(Value = "CP")]
        CP,
        [EnumMember(Value = "CRE")]
        CRE,
        [EnumMember(Value = "CROSS")]
        CROSS,
        [EnumMember(Value = "Daily Future")]
        DAILY_FUTURE,
        [EnumMember(Value = "DATA - Basket")]
        DATA_BASKET,
        [EnumMember(Value = "DATA - Forecasts")]
        DATA_FORECASTS,
        [EnumMember(Value = "DATA - Index")]
        DATA_INDEX,
        [EnumMember(Value = "DATA - Trading Strategy")]
        DATA_TRADING_STRATEGY,
        [EnumMember(Value = "Delta")]
        DELTA,
        [EnumMember(Value = "DEPOSIT")]
        DEPOSIT,
        [EnumMember(Value = "Depositary Receipt")]
        DEPOSITARY_RECEIPT,
        [EnumMember(Value = "DERIVATIVE - Forward")]
        DERIVATIVE_FORWARD,
        [EnumMember(Value = "DERIVATIVE - FRA")]
        DERIVATIVE_FRA,
        [EnumMember(Value = "DERIVATIVE - Option")]
        DERIVATIVE_OPTION,
        [EnumMember(Value = "DERIVATIVE - Structured Produc")]
        DERIVATIVE_STRUCTURED_PRODUC,
        [EnumMember(Value = "DERIVATIVE - Swap")]
        DERIVATIVE_SWAP,
        [EnumMember(Value = "Derived")]
        DERIVED,
        [EnumMember(Value = "DN")]
        DN,
        [EnumMember(Value = "EM")]
        EM,
        [EnumMember(Value = "FDIC")]
        FDIC,
        [EnumMember(Value = "FIXING RATE")]
        FIXING_RATE,
        [EnumMember(Value = "FORWARD")]
        FORWARD,
        [EnumMember(Value = "FORWARD CROSS")]
        FORWARD_CROSS,
        [EnumMember(Value = "FORWARD CURVE")]
        FORWARD_CURVE,
        [EnumMember(Value = "FRA")]
        FRA,
        [EnumMember(Value = "Full Plate Cathodes")]
        FULL_PLATE_CATHODES,
        [EnumMember(Value = "Future")]
        FUTURE,
        [EnumMember(Value = "FWD SWAP")]
        FWD_SWAP,
        [EnumMember(Value = "FX Curve")]
        FX_CURVE,
        [EnumMember(Value = "Generic")]
        GENERIC,
        [EnumMember(Value = "Granules")]
        GRANULES,
        [EnumMember(Value = "Hedged")]
        HEDGED,
        [EnumMember(Value = "HF")]
        HF,
        [EnumMember(Value = "HY")]
        HY,
        [EnumMember(Value = "IG")]
        IG,
        [EnumMember(Value = "IMM FORWARD")]
        IMM_FORWARD,
        [EnumMember(Value = "IMM SWAP")]
        IMM_SWAP,
        [EnumMember(Value = "Index")]
        INDEX,
        [EnumMember(Value = "INFLATION SWAP")]
        INFLATION_SWAP,
        [EnumMember(Value = "Ingots")]
        INGOTS,
        [EnumMember(Value = "Ingots 226/DIN")]
        INGOTS_226_DIN,
        [EnumMember(Value = "Ingots A380.1")]
        INGOTS_A380_1,
        [EnumMember(Value = "Ingots AD12.1")]
        INGOTS_AD12_1,
        [EnumMember(Value = "Ingots D12S/J1S")]
        INGOTS_D12S_J1S,
        [EnumMember(Value = "Large Sows")]
        LARGE_SOWS,
        [EnumMember(Value = "Large sows 226")]
        LARGE_SOWS_226,
        [EnumMember(Value = "Large sows A380.1")]
        LARGE_SOWS_A380_1,
        [EnumMember(Value = "Large sows AD12.1")]
        LARGE_SOWS_AD12_1,
        [EnumMember(Value = "Large sows D12S")]
        LARGE_SOWS_D12S,
        [EnumMember(Value = "LL")]
        LL,
        [EnumMember(Value = "LL08")]
        LL08,
        [EnumMember(Value = "Loan")]
        LOAN,
        [EnumMember(Value = "MAC SWAP")]
        MAC_SWAP,
        [EnumMember(Value = "MEZZ")]
        MEZZ,
        [EnumMember(Value = "MH product type")]
        MH_PRODUCT_TYPE,
        [EnumMember(Value = "MML")]
        MML,
        [EnumMember(Value = "Molybdenum Cntd n RMC(Roasted")]
        MOLYBDENUM_CNTD_N_RMC_ROASTED,
        [EnumMember(Value = "MONEY MARKET CALL")]
        MONEY_MARKET_CALL,
        [EnumMember(Value = "MTN")]
        MTN,
        [EnumMember(Value = "Muni")]
        MUNI,
        [EnumMember(Value = "MUNI SWAP")]
        MUNI_SWAP,
        [EnumMember(Value = "Mutual Fund")]
        MUTUAL_FUND,
        [EnumMember(Value = "NDF SWAP")]
        NDF_SWAP,
        [EnumMember(Value = "NON-DELIVERABLE FORWARD")]
        NON_DELIVERABLE_FORWARD,
        [EnumMember(Value = "NON-DELIVERABLE IRS SWAP")]
        NON_DELIVERABLE_IRS_SWAP,
        [EnumMember(Value = "NON-DELIVERABLE OIS SWAP")]
        NON_DELIVERABLE_OIS_SWAP,
        [EnumMember(Value = "Note")]
        NOTE,
        [EnumMember(Value = "ONSHORE FORWARD")]
        ONSHORE_FORWARD,
        [EnumMember(Value = "ONSHORE SWAP")]
        ONSHORE_SWAP,
        [EnumMember(Value = "Option")]
        OPTION,
        [EnumMember(Value = "OPTION VOLATILITY")]
        OPTION_VOLATILITY,
        [EnumMember(Value = "OTHER")]
        OTHER,
        [EnumMember(Value = "OVERNIGHT INDEXED SWAP")]
        OVERNIGHT_INDEXED_SWAP,
        [EnumMember(Value = "Partnership Shares")]
        PARTNERSHIP_SHARES,
        [EnumMember(Value = "Pellets")]
        PELLETS,
        [EnumMember(Value = "Pool")]
        POOL,
        [EnumMember(Value = "PP12")]
        PP12,
        [EnumMember(Value = "PP20")]
        PP20,
        [EnumMember(Value = "PP25")]
        PP25,
        [EnumMember(Value = "PP3.5")]
        PP3_5,
        [EnumMember(Value = "Preference")]
        PREFERENCE,
        [EnumMember(Value = "Preferred Stock")]
        PREFERRED_STOCK,
        [EnumMember(Value = "PRODUCT - Money Market Instrum")]
        PRODUCT_MONEY_MARKET_INSTRUM,
        [EnumMember(Value = "PROMISSORY NOTE")]
        PROMISSORY_NOTE,
        [EnumMember(Value = "Prompt Forward")]
        PROMPT_FORWARD,
        [EnumMember(Value = "PROPERTY SWAP")]
        PROPERTY_SWAP,
        [EnumMember(Value = "QUARTERLY SWAP")]
        QUARTERLY_SWAP,
        [EnumMember(Value = "REIT")]
        REIT,
        [EnumMember(Value = "REPO")]
        REPO,
        [EnumMember(Value = "RETURN IDX")]
        RETURN_IDX,
        [EnumMember(Value = "Right")]
        RIGHT,
        [EnumMember(Value = "RMBS")]
        RMBS,
        [EnumMember(Value = "Rounds")]
        ROUNDS,
        [EnumMember(Value = "Small Sows")]
        SMALL_SOWS,
        [EnumMember(Value = "Small sows 226")]
        SMALL_SOWS_226,
        [EnumMember(Value = "Small sows A380.1")]
        SMALL_SOWS_A380_1,
        [EnumMember(Value = "Small sows AD12.1")]
        SMALL_SOWS_AD12_1,
        [EnumMember(Value = "Small sows D12S")]
        SMALL_SOWS_D12S,
        [EnumMember(Value = "SME")]
        SME,
        [EnumMember(Value = "SME/MEZZ")]
        SME_MEZZ,
        [EnumMember(Value = "Socioeconomic")]
        SOCIOECONOMIC,
        [EnumMember(Value = "Sows")]
        SOWS,
        [EnumMember(Value = "SPOT")]
        SPOT,
        [EnumMember(Value = "SWAP")]
        SWAP,
        [EnumMember(Value = "SWAP SPREAD")]
        SWAP_SPREAD,
        [EnumMember(Value = "SWAPTION VOLATILITY")]
        SWAPTION_VOLATILITY,
        [EnumMember(Value = "T-Bar")]
        T_BAR,
        [EnumMember(Value = "T-Bars 226")]
        T_BARS_226,
        [EnumMember(Value = "T-Bars A380.1")]
        T_BARS_A380_1,
        [EnumMember(Value = "T-Bars AD12.1")]
        T_BARS_AD12_1,
        [EnumMember(Value = "T-Bars D12S")]
        T_BARS_D12S,
        [EnumMember(Value = "TBA")]
        TBA,
        [EnumMember(Value = "TD")]
        TD,
        [EnumMember(Value = "TREASURY BILL")]
        TREASURY_BILL,
        [EnumMember(Value = "TRP")]
        TRP,
        [EnumMember(Value = "TRP/BK")]
        TRP_BK,
        [EnumMember(Value = "TRP/REIT")]
        TRP_REIT,
        [EnumMember(Value = "Unit")]
        UNIT,
        [EnumMember(Value = "Unit Investment Trust")]
        UNIT_INVESTMENT_TRUST,
        [EnumMember(Value = "VOL")]
        VOL,
        [EnumMember(Value = "VOLATILITY DERIVATIVE")]
        VOLATILITY_DERIVATIVE,
        [EnumMember(Value = "Warrant")]
        WARRANT,
        [EnumMember(Value = "Whole Loan")]
        WHOLE_LOAN,
        [EnumMember(Value = "Yield Curve")]
        YIELD_CURVE
    }
}
