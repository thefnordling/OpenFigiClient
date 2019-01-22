using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract(Namespace = "")]
    public enum Mic
    {
        [EnumMember]
        Unknown,
        [EnumMember(Value = "A2XX")]
        A2XX,
        [EnumMember(Value = "ACEX")]
        ACEX,
        [EnumMember(Value = "AFET")]
        AFET,
        [EnumMember(Value = "AIXE")]
        AIXE,
        [EnumMember(Value = "AMTS")]
        AMTS,
        [EnumMember(Value = "AMXO")]
        AMXO,
        [EnumMember(Value = "APEX")]
        APEX,
        [EnumMember(Value = "APXL")]
        APXL,
        [EnumMember(Value = "AQXE")]
        AQXE,
        [EnumMember(Value = "ARCO")]
        ARCO,
        [EnumMember(Value = "ARCX")]
        ARCX,
        [EnumMember(Value = "ASXP")]
        ASXP,
        [EnumMember(Value = "BATE")]
        BATE,
        [EnumMember(Value = "BATO")]
        BATO,
        [EnumMember(Value = "BATS")]
        BATS,
        [EnumMember(Value = "BATY")]
        BATY,
        [EnumMember(Value = "BCSE")]
        BCSE,
        [EnumMember(Value = "BFEX")]
        BFEX,
        [EnumMember(Value = "BIVA")]
        BIVA,
        [EnumMember(Value = "BLOX")]
        BLOX,
        [EnumMember(Value = "BMEX")]
        BMEX,
        [EnumMember(Value = "BMFM")]
        BMFM,
        [EnumMember(Value = "BMFX")]
        BMFX,
        [EnumMember(Value = "BMTF")]
        BMTF,
        [EnumMember(Value = "BMTS")]
        BMTS,
        [EnumMember(Value = "BOAT")]
        BOAT,
        [EnumMember(Value = "BOTC")]
        BOTC,
        [EnumMember(Value = "BSEX")]
        BSEX,
        [EnumMember(Value = "BURM")]
        BURM,
        [EnumMember(Value = "BVCA")]
        BVCA,
        [EnumMember(Value = "BVMF")]
        BVMF,
        [EnumMember(Value = "C2OX")]
        C2OX,
        [EnumMember(Value = "CBSX")]
        CBSX,
        [EnumMember(Value = "CCFX")]
        CCFX,
        [EnumMember(Value = "CHIA")]
        CHIA,
        [EnumMember(Value = "CHIC")]
        CHIC,
        [EnumMember(Value = "CHIJ")]
        CHIJ,
        [EnumMember(Value = "CHIX")]
        CHIX,
        [EnumMember(Value = "CMED")]
        CMED,
        [EnumMember(Value = "DGCX")]
        DGCX,
        [EnumMember(Value = "DIFX")]
        DIFX,
        [EnumMember(Value = "DKTC")]
        DKTC,
        [EnumMember(Value = "DSMD")]
        DSMD,
        [EnumMember(Value = "DUMX")]
        DUMX,
        [EnumMember(Value = "EDGA")]
        EDGA,
        [EnumMember(Value = "EDGO")]
        EDGO,
        [EnumMember(Value = "EDGX")]
        EDGX,
        [EnumMember(Value = "EMTF")]
        EMTF,
        [EnumMember(Value = "EMTS")]
        EMTS,
        [EnumMember(Value = "ENAX")]
        ENAX,
        [EnumMember(Value = "ERIS")]
        ERIS,
        [EnumMember(Value = "ETLX")]
        ETLX,
        [EnumMember(Value = "EUCH")]
        EUCH,
        [EnumMember(Value = "EUWX")]
        EUWX,
        [EnumMember(Value = "FISH")]
        FISH,
        [EnumMember(Value = "FMTS")]
        FMTS,
        [EnumMember(Value = "FNDK")]
        FNDK,
        [EnumMember(Value = "FNFI")]
        FNFI,
        [EnumMember(Value = "FNIS")]
        FNIS,
        [EnumMember(Value = "FNSE")]
        FNSE,
        [EnumMember(Value = "FRAB")]
        FRAB,
        [EnumMember(Value = "GBOT")]
        GBOT,
        [EnumMember(Value = "GEMX")]
        GEMX,
        [EnumMember(Value = "GMEG")]
        GMEG,
        [EnumMember(Value = "GMNI")]
        GMNI,
        [EnumMember(Value = "GXGR")]
        GXGR,
        [EnumMember(Value = "HKME")]
        HKME,
        [EnumMember(Value = "HMTF")]
        HMTF,
        [EnumMember(Value = "HOTC")]
        HOTC,
        [EnumMember(Value = "HSTC")]
        HSTC,
        [EnumMember(Value = "ICDX")]
        ICDX,
        [EnumMember(Value = "ICEL")]
        ICEL,
        [EnumMember(Value = "ICXL")]
        ICXL,
        [EnumMember(Value = "IEPA")]
        IEPA,
        [EnumMember(Value = "IEXG")]
        IEXG,
        [EnumMember(Value = "IFCA")]
        IFCA,
        [EnumMember(Value = "IFED")]
        IFED,
        [EnumMember(Value = "IFEU")]
        IFEU,
        [EnumMember(Value = "IFLL")]
        IFLL,
        [EnumMember(Value = "IFLO")]
        IFLO,
        [EnumMember(Value = "IFLX")]
        IFLX,
        [EnumMember(Value = "IFSG")]
        IFSG,
        [EnumMember(Value = "IFUS")]
        IFUS,
        [EnumMember(Value = "IINX")]
        IINX,
        [EnumMember(Value = "IMTS")]
        IMTS,
        [EnumMember(Value = "INSE")]
        INSE,
        [EnumMember(Value = "ISDX")]
        ISDX,
        [EnumMember(Value = "LICA")]
        LICA,
        [EnumMember(Value = "LIQU")]
        LIQU,
        [EnumMember(Value = "LYNX")]
        LYNX,
        [EnumMember(Value = "MALX")]
        MALX,
        [EnumMember(Value = "MARF")]
        MARF,
        [EnumMember(Value = "MATN")]
        MATN,
        [EnumMember(Value = "MCRY")]
        MCRY,
        [EnumMember(Value = "MCXX")]
        MCXX,
        [EnumMember(Value = "MFOX")]
        MFOX,
        [EnumMember(Value = "MISX")]
        MISX,
        [EnumMember(Value = "MOTX")]
        MOTX,
        [EnumMember(Value = "MPRL")]
        MPRL,
        [EnumMember(Value = "MTAA")]
        MTAA,
        [EnumMember(Value = "MTAH")]
        MTAH,
        [EnumMember(Value = "MTCH")]
        MTCH,
        [EnumMember(Value = "MTSC")]
        MTSC,
        [EnumMember(Value = "MTSG")]
        MTSG,
        [EnumMember(Value = "MUND")]
        MUND,
        [EnumMember(Value = "N2EX")]
        N2EX,
        [EnumMember(Value = "NASX")]
        NASX,
        [EnumMember(Value = "NCEL")]
        NCEL,
        [EnumMember(Value = "NDEX")]
        NDEX,
        [EnumMember(Value = "NEOE")]
        NEOE,
        [EnumMember(Value = "NEXX")]
        NEXX,
        [EnumMember(Value = "NILX")]
        NILX,
        [EnumMember(Value = "NORX")]
        NORX,
        [EnumMember(Value = "NOTC")]
        NOTC,
        [EnumMember(Value = "NZFX")]
        NZFX,
        [EnumMember(Value = "OMGA")]
        OMGA,
        [EnumMember(Value = "OMIP")]
        OMIP,
        [EnumMember(Value = "OOTC")]
        OOTC,
        [EnumMember(Value = "OPEX")]
        OPEX,
        [EnumMember(Value = "OTCM")]
        OTCM,
        [EnumMember(Value = "OTXB")]
        OTXB,
        [EnumMember(Value = "PDEX")]
        PDEX,
        [EnumMember(Value = "PFTQ")]
        PFTQ,
        [EnumMember(Value = "PFTS")]
        PFTS,
        [EnumMember(Value = "PLPD")]
        PLPD,
        [EnumMember(Value = "PLUS")]
        PLUS,
        [EnumMember(Value = "PORT")]
        PORT,
        [EnumMember(Value = "PURE")]
        PURE,
        [EnumMember(Value = "ROCO")]
        ROCO,
        [EnumMember(Value = "ROFX")]
        ROFX,
        [EnumMember(Value = "ROTC")]
        ROTC,
        [EnumMember(Value = "RTSX")]
        RTSX,
        [EnumMember(Value = "RUSX")]
        RUSX,
        [EnumMember(Value = "S2F")]
        S2F,
        [EnumMember(Value = "SBIJ")]
        SBIJ,
        [EnumMember(Value = "SBIU")]
        SBIU,
        [EnumMember(Value = "SBMF")]
        SBMF,
        [EnumMember(Value = "SEDX")]
        SEDX,
        [EnumMember(Value = "SEND")]
        SEND,
        [EnumMember(Value = "SGMX")]
        SGMX,
        [EnumMember(Value = "SHAR")]
        SHAR,
        [EnumMember(Value = "SHSC")]
        SHSC,
        [EnumMember(Value = "SIMV")]
        SIMV,
        [EnumMember(Value = "SMEX")]
        SMEX,
        [EnumMember(Value = "SPIM")]
        SPIM,
        [EnumMember(Value = "SZSC")]
        SZSC,
        [EnumMember(Value = "TBSP")]
        TBSP,
        [EnumMember(Value = "TFEX")]
        TFEX,
        [EnumMember(Value = "TMXS")]
        TMXS,
        [EnumMember(Value = "TOMX")]
        TOMX,
        [EnumMember(Value = "TREA")]
        TREA,
        [EnumMember(Value = "TREU")]
        TREU,
        [EnumMember(Value = "TRPX")]
        TRPX,
        [EnumMember(Value = "TRQX")]
        TRQX,
        [EnumMember(Value = "UKEX")]
        UKEX,
        [EnumMember(Value = "WDER")]
        WDER,
        [EnumMember(Value = "XADE")]
        XADE,
        [EnumMember(Value = "XADF")]
        XADF,
        [EnumMember(Value = "XADS")]
        XADS,
        [EnumMember(Value = "XAIM")]
        XAIM,
        [EnumMember(Value = "XALG")]
        XALG,
        [EnumMember(Value = "XAMM")]
        XAMM,
        [EnumMember(Value = "XAMS")]
        XAMS,
        [EnumMember(Value = "XARM")]
        XARM,
        [EnumMember(Value = "XASE")]
        XASE,
        [EnumMember(Value = "XASX")]
        XASX,
        [EnumMember(Value = "XATH")]
        XATH,
        [EnumMember(Value = "XATS")]
        XATS,
        [EnumMember(Value = "XBAA")]
        XBAA,
        [EnumMember(Value = "XBAB")]
        XBAB,
        [EnumMember(Value = "XBAH")]
        XBAH,
        [EnumMember(Value = "XBAN")]
        XBAN,
        [EnumMember(Value = "XBAR")]
        XBAR,
        [EnumMember(Value = "XBBJ")]
        XBBJ,
        [EnumMember(Value = "XBCL")]
        XBCL,
        [EnumMember(Value = "XBCM")]
        XBCM,
        [EnumMember(Value = "XBCV")]
        XBCV,
        [EnumMember(Value = "XBDA")]
        XBDA,
        [EnumMember(Value = "XBDV")]
        XBDV,
        [EnumMember(Value = "XBEL")]
        XBEL,
        [EnumMember(Value = "XBER")]
        XBER,
        [EnumMember(Value = "XBES")]
        XBES,
        [EnumMember(Value = "XBEY")]
        XBEY,
        [EnumMember(Value = "XBIL")]
        XBIL,
        [EnumMember(Value = "XBKK")]
        XBKK,
        [EnumMember(Value = "XBLB")]
        XBLB,
        [EnumMember(Value = "XBLN")]
        XBLN,
        [EnumMember(Value = "XBNV")]
        XBNV,
        [EnumMember(Value = "XBOG")]
        XBOG,
        [EnumMember(Value = "XBOL")]
        XBOL,
        [EnumMember(Value = "XBOM")]
        XBOM,
        [EnumMember(Value = "XBOS")]
        XBOS,
        [EnumMember(Value = "XBOT")]
        XBOT,
        [EnumMember(Value = "XBOX")]
        XBOX,
        [EnumMember(Value = "XBRA")]
        XBRA,
        [EnumMember(Value = "XBRD")]
        XBRD,
        [EnumMember(Value = "XBRN")]
        XBRN,
        [EnumMember(Value = "XBRU")]
        XBRU,
        [EnumMember(Value = "XBRV")]
        XBRV,
        [EnumMember(Value = "XBSD")]
        XBSD,
        [EnumMember(Value = "XBSE")]
        XBSE,
        [EnumMember(Value = "XBTR")]
        XBTR,
        [EnumMember(Value = "XBUD")]
        XBUD,
        [EnumMember(Value = "XBUE")]
        XBUE,
        [EnumMember(Value = "XBUL")]
        XBUL,
        [EnumMember(Value = "XBVC")]
        XBVC,
        [EnumMember(Value = "XBVM")]
        XBVM,
        [EnumMember(Value = "XBVR")]
        XBVR,
        [EnumMember(Value = "XBXO")]
        XBXO,
        [EnumMember(Value = "XCAI")]
        XCAI,
        [EnumMember(Value = "XCAS")]
        XCAS,
        [EnumMember(Value = "XCAY")]
        XCAY,
        [EnumMember(Value = "XCBF")]
        XCBF,
        [EnumMember(Value = "XCBO")]
        XCBO,
        [EnumMember(Value = "XCBT")]
        XCBT,
        [EnumMember(Value = "XCCX")]
        XCCX,
        [EnumMember(Value = "XCEC")]
        XCEC,
        [EnumMember(Value = "XCEG")]
        XCEG,
        [EnumMember(Value = "XCFE")]
        XCFE,
        [EnumMember(Value = "XCHG")]
        XCHG,
        [EnumMember(Value = "XCHI")]
        XCHI,
        [EnumMember(Value = "XCIE")]
        XCIE,
        [EnumMember(Value = "XCIS")]
        XCIS,
        [EnumMember(Value = "XCME")]
        XCME,
        [EnumMember(Value = "XCNQ")]
        XCNQ,
        [EnumMember(Value = "XCOL")]
        XCOL,
        [EnumMember(Value = "XCSE")]
        XCSE,
        [EnumMember(Value = "XCSX")]
        XCSX,
        [EnumMember(Value = "XCX2")]
        XCX2,
        [EnumMember(Value = "XCXD")]
        XCXD,
        [EnumMember(Value = "XCYS")]
        XCYS,
        [EnumMember(Value = "XDAR")]
        XDAR,
        [EnumMember(Value = "XDCE")]
        XDCE,
        [EnumMember(Value = "XDES")]
        XDES,
        [EnumMember(Value = "XDFM")]
        XDFM,
        [EnumMember(Value = "XDHA")]
        XDHA,
        [EnumMember(Value = "XDMI")]
        XDMI,
        [EnumMember(Value = "XDPA")]
        XDPA,
        [EnumMember(Value = "XDRF")]
        XDRF,
        [EnumMember(Value = "XDSE")]
        XDSE,
        [EnumMember(Value = "XDSX")]
        XDSX,
        [EnumMember(Value = "XDUB")]
        XDUB,
        [EnumMember(Value = "XDUS")]
        XDUS,
        [EnumMember(Value = "XECM")]
        XECM,
        [EnumMember(Value = "XECS")]
        XECS,
        [EnumMember(Value = "XEEE")]
        XEEE,
        [EnumMember(Value = "XELX")]
        XELX,
        [EnumMember(Value = "XEMD")]
        XEMD,
        [EnumMember(Value = "XEQT")]
        XEQT,
        [EnumMember(Value = "XETR")]
        XETR,
        [EnumMember(Value = "XEUE")]
        XEUE,
        [EnumMember(Value = "XEUR")]
        XEUR,
        [EnumMember(Value = "XFKA")]
        XFKA,
        [EnumMember(Value = "XFRA")]
        XFRA,
        [EnumMember(Value = "XGAT")]
        XGAT,
        [EnumMember(Value = "XGHA")]
        XGHA,
        [EnumMember(Value = "XGME")]
        XGME,
        [EnumMember(Value = "XGSE")]
        XGSE,
        [EnumMember(Value = "XGTG")]
        XGTG,
        [EnumMember(Value = "XGUA")]
        XGUA,
        [EnumMember(Value = "XHAM")]
        XHAM,
        [EnumMember(Value = "XHAN")]
        XHAN,
        [EnumMember(Value = "XHEL")]
        XHEL,
        [EnumMember(Value = "XHFT")]
        XHFT,
        [EnumMember(Value = "XHKF")]
        XHKF,
        [EnumMember(Value = "XHKG")]
        XHKG,
        [EnumMember(Value = "XHNF")]
        XHNF,
        [EnumMember(Value = "XHNX")]
        XHNX,
        [EnumMember(Value = "XICE")]
        XICE,
        [EnumMember(Value = "XICX")]
        XICX,
        [EnumMember(Value = "XIDX")]
        XIDX,
        [EnumMember(Value = "XIMC")]
        XIMC,
        [EnumMember(Value = "XINE")]
        XINE,
        [EnumMember(Value = "XIQS")]
        XIQS,
        [EnumMember(Value = "XISA")]
        XISA,
        [EnumMember(Value = "XIST")]
        XIST,
        [EnumMember(Value = "XISX")]
        XISX,
        [EnumMember(Value = "XJAM")]
        XJAM,
        [EnumMember(Value = "XJAS")]
        XJAS,
        [EnumMember(Value = "XJSE")]
        XJSE,
        [EnumMember(Value = "XKAC")]
        XKAC,
        [EnumMember(Value = "XKAR")]
        XKAR,
        [EnumMember(Value = "XKAZ")]
        XKAZ,
        [EnumMember(Value = "XKBT")]
        XKBT,
        [EnumMember(Value = "XKEM")]
        XKEM,
        [EnumMember(Value = "XKFB")]
        XKFB,
        [EnumMember(Value = "XKFE")]
        XKFE,
        [EnumMember(Value = "XKHA")]
        XKHA,
        [EnumMember(Value = "XKIS")]
        XKIS,
        [EnumMember(Value = "XKLS")]
        XKLS,
        [EnumMember(Value = "XKON")]
        XKON,
        [EnumMember(Value = "XKOS")]
        XKOS,
        [EnumMember(Value = "XKRX")]
        XKRX,
        [EnumMember(Value = "XKSE")]
        XKSE,
        [EnumMember(Value = "XKUW")]
        XKUW,
        [EnumMember(Value = "XLAO")]
        XLAO,
        [EnumMember(Value = "XLDN")]
        XLDN,
        [EnumMember(Value = "XLFX")]
        XLFX,
        [EnumMember(Value = "XLIM")]
        XLIM,
        [EnumMember(Value = "XLIS")]
        XLIS,
        [EnumMember(Value = "XLIT")]
        XLIT,
        [EnumMember(Value = "XLJU")]
        XLJU,
        [EnumMember(Value = "XLME")]
        XLME,
        [EnumMember(Value = "XLOD")]
        XLOD,
        [EnumMember(Value = "XLON")]
        XLON,
        [EnumMember(Value = "XLUS")]
        XLUS,
        [EnumMember(Value = "XLUX")]
        XLUX,
        [EnumMember(Value = "XMAB")]
        XMAB,
        [EnumMember(Value = "XMAD")]
        XMAD,
        [EnumMember(Value = "XMAE")]
        XMAE,
        [EnumMember(Value = "XMAL")]
        XMAL,
        [EnumMember(Value = "XMAN")]
        XMAN,
        [EnumMember(Value = "XMAT")]
        XMAT,
        [EnumMember(Value = "XMAU")]
        XMAU,
        [EnumMember(Value = "XMCE")]
        XMCE,
        [EnumMember(Value = "XMEV")]
        XMEV,
        [EnumMember(Value = "XMEX")]
        XMEX,
        [EnumMember(Value = "XMGE")]
        XMGE,
        [EnumMember(Value = "XMIO")]
        XMIO,
        [EnumMember(Value = "XMNT")]
        XMNT,
        [EnumMember(Value = "XMNX")]
        XMNX,
        [EnumMember(Value = "XMOC")]
        XMOC,
        [EnumMember(Value = "XMOD")]
        XMOD,
        [EnumMember(Value = "XMOL")]
        XMOL,
        [EnumMember(Value = "XMON")]
        XMON,
        [EnumMember(Value = "XMOS")]
        XMOS,
        [EnumMember(Value = "XMOT")]
        XMOT,
        [EnumMember(Value = "XMPW")]
        XMPW,
        [EnumMember(Value = "XMRV")]
        XMRV,
        [EnumMember(Value = "XMSW")]
        XMSW,
        [EnumMember(Value = "XMTB")]
        XMTB,
        [EnumMember(Value = "XMUN")]
        XMUN,
        [EnumMember(Value = "XMUS")]
        XMUS,
        [EnumMember(Value = "XNAI")]
        XNAI,
        [EnumMember(Value = "XNAM")]
        XNAM,
        [EnumMember(Value = "XNAS")]
        XNAS,
        [EnumMember(Value = "XNCD")]
        XNCD,
        [EnumMember(Value = "XNCM")]
        XNCM,
        [EnumMember(Value = "XNDQ")]
        XNDQ,
        [EnumMember(Value = "XNDX")]
        XNDX,
        [EnumMember(Value = "XNEC")]
        XNEC,
        [EnumMember(Value = "XNEP")]
        XNEP,
        [EnumMember(Value = "XNGM")]
        XNGM,
        [EnumMember(Value = "XNGO")]
        XNGO,
        [EnumMember(Value = "XNGS")]
        XNGS,
        [EnumMember(Value = "XNIM")]
        XNIM,
        [EnumMember(Value = "XNKS")]
        XNKS,
        [EnumMember(Value = "XNLX")]
        XNLX,
        [EnumMember(Value = "XNMS")]
        XNMS,
        [EnumMember(Value = "XNSA")]
        XNSA,
        [EnumMember(Value = "XNSE")]
        XNSE,
        [EnumMember(Value = "XNYM")]
        XNYM,
        [EnumMember(Value = "XNYS")]
        XNYS,
        [EnumMember(Value = "XNZE")]
        XNZE,
        [EnumMember(Value = "XOAM")]
        XOAM,
        [EnumMember(Value = "XOCH")]
        XOCH,
        [EnumMember(Value = "XOPV")]
        XOPV,
        [EnumMember(Value = "XOSE")]
        XOSE,
        [EnumMember(Value = "XOSL")]
        XOSL,
        [EnumMember(Value = "XOTC")]
        XOTC,
        [EnumMember(Value = "XPAE")]
        XPAE,
        [EnumMember(Value = "XPAR")]
        XPAR,
        [EnumMember(Value = "XPBT")]
        XPBT,
        [EnumMember(Value = "XPHL")]
        XPHL,
        [EnumMember(Value = "XPHS")]
        XPHS,
        [EnumMember(Value = "XPIC")]
        XPIC,
        [EnumMember(Value = "XPOM")]
        XPOM,
        [EnumMember(Value = "XPOR")]
        XPOR,
        [EnumMember(Value = "XPOS")]
        XPOS,
        [EnumMember(Value = "XPOW")]
        XPOW,
        [EnumMember(Value = "XPRA")]
        XPRA,
        [EnumMember(Value = "XPSX")]
        XPSX,
        [EnumMember(Value = "XPTY")]
        XPTY,
        [EnumMember(Value = "XPXE")]
        XPXE,
        [EnumMember(Value = "XQMH")]
        XQMH,
        [EnumMember(Value = "XQTX")]
        XQTX,
        [EnumMember(Value = "XQUI")]
        XQUI,
        [EnumMember(Value = "XRAS")]
        XRAS,
        [EnumMember(Value = "XRBM")]
        XRBM,
        [EnumMember(Value = "XRIS")]
        XRIS,
        [EnumMember(Value = "XRMZ")]
        XRMZ,
        [EnumMember(Value = "XROS")]
        XROS,
        [EnumMember(Value = "XSAF")]
        XSAF,
        [EnumMember(Value = "XSAM")]
        XSAM,
        [EnumMember(Value = "XSAP")]
        XSAP,
        [EnumMember(Value = "XSAT")]
        XSAT,
        [EnumMember(Value = "XSAU")]
        XSAU,
        [EnumMember(Value = "XSBI")]
        XSBI,
        [EnumMember(Value = "XSCE")]
        XSCE,
        [EnumMember(Value = "XSEC")]
        XSEC,
        [EnumMember(Value = "XSES")]
        XSES,
        [EnumMember(Value = "XSFE")]
        XSFE,
        [EnumMember(Value = "XSGE")]
        XSGE,
        [EnumMember(Value = "XSGO")]
        XSGO,
        [EnumMember(Value = "XSHE")]
        XSHE,
        [EnumMember(Value = "XSHG")]
        XSHG,
        [EnumMember(Value = "XSIM")]
        XSIM,
        [EnumMember(Value = "XSMP")]
        XSMP,
        [EnumMember(Value = "XSPS")]
        XSPS,
        [EnumMember(Value = "XSRM")]
        XSRM,
        [EnumMember(Value = "XSSC")]
        XSSC,
        [EnumMember(Value = "XSSE")]
        XSSE,
        [EnumMember(Value = "XSTC")]
        XSTC,
        [EnumMember(Value = "XSTE")]
        XSTE,
        [EnumMember(Value = "XSTO")]
        XSTO,
        [EnumMember(Value = "XSTU")]
        XSTU,
        [EnumMember(Value = "XSVA")]
        XSVA,
        [EnumMember(Value = "XSWA")]
        XSWA,
        [EnumMember(Value = "XSWX")]
        XSWX,
        [EnumMember(Value = "XTAE")]
        XTAE,
        [EnumMember(Value = "XTAF")]
        XTAF,
        [EnumMember(Value = "XTAI")]
        XTAI,
        [EnumMember(Value = "XTAL")]
        XTAL,
        [EnumMember(Value = "XTAM")]
        XTAM,
        [EnumMember(Value = "XTEH")]
        XTEH,
        [EnumMember(Value = "XTFF")]
        XTFF,
        [EnumMember(Value = "XTKO")]
        XTKO,
        [EnumMember(Value = "XTKS")]
        XTKS,
        [EnumMember(Value = "XTKT")]
        XTKT,
        [EnumMember(Value = "XTNX")]
        XTNX,
        [EnumMember(Value = "XTRN")]
        XTRN,
        [EnumMember(Value = "XTSE")]
        XTSE,
        [EnumMember(Value = "XTSX")]
        XTSX,
        [EnumMember(Value = "XTUN")]
        XTUN,
        [EnumMember(Value = "XUBS")]
        XUBS,
        [EnumMember(Value = "XUGA")]
        XUGA,
        [EnumMember(Value = "XULA")]
        XULA,
        [EnumMember(Value = "XUSE")]
        XUSE,
        [EnumMember(Value = "XVAL")]
        XVAL,
        [EnumMember(Value = "XVPA")]
        XVPA,
        [EnumMember(Value = "XVTX")]
        XVTX,
        [EnumMember(Value = "XWAR")]
        XWAR,
        [EnumMember(Value = "XWBO")]
        XWBO,
        [EnumMember(Value = "XZAG")]
        XZAG,
        [EnumMember(Value = "XZCE")]
        XZCE,
        [EnumMember(Value = "XZIM")]
        XZIM,
        [EnumMember(Value = "YLDX")]
        YLDX,
        [EnumMember(Value = "YYYY")]
        YYYY,
    }
}
