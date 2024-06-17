using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FikaAmazonAPI.ConstructFeed
{
    /// <summary>
    ///     Data here came from Amazon Base XSD
    ///     https://images-na.ssl-images-amazon.com/images/G/01/rainier/help/xsd/release_1_9/amzn-base._TTH_.xsd
    ///     convert by website
    ///     http://dotnetsnip.com/xsd-to-csharp-class-converter
    /// </summary>
    public class BaseXML
    {
        /// <remarks />
        public enum AgeRecommendedUnitOfMeasure
        {
            /// <remarks />
            months,

            /// <remarks />
            years
        }

        /// <remarks />
        public enum AirEfficiencyUnitOfMeasure
        {
            /// <remarks />
            cubic_feet_per_minute_per_watt
        }

        /// <remarks />
        public enum AirFlowDisplacementUnitOfMeasure
        {
            /// <remarks />
            cubic_feet_per_minute,

            /// <remarks />
            cubic_feet_per_hour
        }

        /// <remarks />
        public enum AlcoholContentUnitOfMeasure
        {
            /// <remarks />
            percent_by_volume,

            /// <remarks />
            percent_by_weight,

            /// <remarks />
            unit_of_alcohol
        }

        /// <remarks />
        public enum AllergenInformationType
        {
            /// <remarks />
            abalone,

            /// <remarks />
            abalone_free,

            /// <remarks />
            amberjack,

            /// <remarks />
            amberjack_free,

            /// <remarks />
            apple,

            /// <remarks />
            apple_free,

            /// <remarks />
            banana,

            /// <remarks />
            banana_free,

            /// <remarks />
            barley,

            /// <remarks />
            barley_free,

            /// <remarks />
            beef,

            /// <remarks />
            beef_free,

            /// <remarks />
            buckwheat,

            /// <remarks />
            buckwheat_free,

            /// <remarks />
            celery,

            /// <remarks />
            celery_free,

            /// <remarks />
            chicken_meat,

            /// <remarks />
            chicken_meat_free,

            /// <remarks />
            codfish,

            /// <remarks />
            codfish_free,

            /// <remarks />
            crab,

            /// <remarks />
            crab_free,

            /// <remarks />
            dairy,

            /// <remarks />
            dairy_free,

            /// <remarks />
            eggs,

            /// <remarks />
            egg_free,

            /// <remarks />
            fish,

            /// <remarks />
            fish_free,

            /// <remarks />
            gelatin,

            /// <remarks />
            gelatin_free,

            /// <remarks />
            gluten,

            /// <remarks />
            gluten_free,

            /// <remarks />
            kiwi,

            /// <remarks />
            kiwi_free,

            /// <remarks />
            mackerel,

            /// <remarks />
            mackerel_free,

            /// <remarks />
            melon,

            /// <remarks />
            melon_free,

            /// <remarks />
            mushroom,

            /// <remarks />
            mushroom_free,

            /// <remarks />
            octopus,

            /// <remarks />
            octopus_free,

            /// <remarks />
            orange,

            /// <remarks />
            orange_free,

            /// <remarks />
            peach,

            /// <remarks />
            peach_free,

            /// <remarks />
            peanuts,

            /// <remarks />
            peanut_free,

            /// <remarks />
            pork,

            /// <remarks />
            pork_free,

            /// <remarks />
            salmon,

            /// <remarks />
            salmon_free,

            /// <remarks />
            salmon_roe,

            /// <remarks />
            salmon_roe_free,

            /// <remarks />
            scad,

            /// <remarks />
            scad_free,

            /// <remarks />
            scallop,

            /// <remarks />
            scallop_free,

            /// <remarks />
            sesame_seeds,

            /// <remarks />
            sesame_seeds_free,

            /// <remarks />
            shellfish,

            /// <remarks />
            shellfish_free,

            /// <remarks />
            shrimp,

            /// <remarks />
            shrimp_free,

            /// <remarks />
            soy,

            /// <remarks />
            soy_free,

            /// <remarks />
            squid,

            /// <remarks />
            squid_free,

            /// <remarks />
            tree_nuts,

            /// <remarks />
            tree_nut_free,

            /// <remarks />
            tuna,

            /// <remarks />
            tuna_free,

            /// <remarks />
            walnut,

            /// <remarks />
            walnut_free,

            /// <remarks />
            yam,

            /// <remarks />
            yam_free
        }

        /// <remarks />
        public enum AmazonMaturityRatingType
        {
            /// <remarks />
            adult_content,

            /// <remarks />
            ages_13_and_older,

            /// <remarks />
            ages_17_and_older,

            /// <remarks />
            ages_9_and_older,

            /// <remarks />
            all_ages,

            /// <remarks />
            children,

            /// <remarks />
            rating_pending
        }

        /// <remarks />
        public enum AmperageUnitOfMeasure
        {
            /// <remarks />
            amps,

            /// <remarks />
            kiloamps,

            /// <remarks />
            microamps,

            /// <remarks />
            milliamps,

            /// <remarks />
            nanoamps,

            /// <remarks />
            picoamps
        }

        /// <remarks />
        public enum AntennaTypeValues
        {
            /// <remarks />
            @fixed,

            /// <remarks />
            @internal,

            /// <remarks />
            retractable
        }

        /// <remarks />
        public enum ApertureUnitOfMeasure
        {
            /// <remarks />
            f
        }

        /// <remarks />
        public enum AreaUnitOfMeasure
        {
            /// <remarks />
            [XmlEnum("square-in")] squarein,

            /// <remarks />
            [XmlEnum("square-ft")] squareft,

            /// <remarks />
            [XmlEnum("square-cm")] squarecm,

            /// <remarks />
            [XmlEnum("square-m")] squarem
        }

        /// <remarks />
        public enum AspectRatio
        {
            /// <remarks />
            [XmlEnum("2:01")] Item201,

            /// <remarks />
            [XmlEnum("4:03")] Item403,

            /// <remarks />
            [XmlEnum("11:09")] Item1109,

            /// <remarks />
            [XmlEnum("14:09")] Item1409,

            /// <remarks />
            [XmlEnum("16:09")] Item1609,

            /// <remarks />
            [XmlEnum("1.27:1")] Item1271,

            /// <remarks />
            [XmlEnum("1.29:1")] Item1291,

            /// <remarks />
            [XmlEnum("1.30:1")] Item1301,

            /// <remarks />
            [XmlEnum("1.33:1")] Item1331,

            /// <remarks />
            [XmlEnum("1.34:1")] Item1341,

            /// <remarks />
            [XmlEnum("1.35:1")] Item1351,

            /// <remarks />
            [XmlEnum("1.37:1")] Item1371,

            /// <remarks />
            [XmlEnum("1.38:1")] Item1381,

            /// <remarks />
            [XmlEnum("1.44:1")] Item1441,

            /// <remarks />
            [XmlEnum("1.45:1")] Item1451,

            /// <remarks />
            [XmlEnum("1.50:1")] Item1501,

            /// <remarks />
            [XmlEnum("1.55:1")] Item1551,

            /// <remarks />
            [XmlEnum("1.58:1")] Item1581,

            /// <remarks />
            [XmlEnum("1.59:1")] Item1591,

            /// <remarks />
            [XmlEnum("1.60:1")] Item1601,

            /// <remarks />
            [XmlEnum("1.63:1")] Item1631,

            /// <remarks />
            [XmlEnum("1.65:1")] Item1651,

            /// <remarks />
            [XmlEnum("1.66:1")] Item1661,

            /// <remarks />
            [XmlEnum("1.67:1")] Item1671,

            /// <remarks />
            [XmlEnum("1.70:1")] Item1701,

            /// <remarks />
            [XmlEnum("1.71:1")] Item1711,

            /// <remarks />
            [XmlEnum("1.74:1")] Item1741,

            /// <remarks />
            [XmlEnum("1.75:1")] Item1751,

            /// <remarks />
            [XmlEnum("1.76:1")] Item1761,

            /// <remarks />
            [XmlEnum("1.77:1")] Item1771,

            /// <remarks />
            [XmlEnum("1.78:1")] Item1781,

            /// <remarks />
            [XmlEnum("1.83:1")] Item1831,

            /// <remarks />
            [XmlEnum("1.85:1")] Item1851,

            /// <remarks />
            [XmlEnum("1.87:1")] Item1871,

            /// <remarks />
            [XmlEnum("1.88:1")] Item1881,

            /// <remarks />
            [XmlEnum("1.98:1")] Item1981,

            /// <remarks />
            [XmlEnum("2.10:1")] Item2101,

            /// <remarks />
            [XmlEnum("2.20:1")] Item2201,

            /// <remarks />
            [XmlEnum("2.21:1")] Item2211,

            /// <remarks />
            [XmlEnum("2.22:1")] Item2221,

            /// <remarks />
            [XmlEnum("2.30:1")] Item2301,

            /// <remarks />
            [XmlEnum("2.31:1")] Item2311,

            /// <remarks />
            [XmlEnum("2.33:1")] Item2331,

            /// <remarks />
            [XmlEnum("2.35:1")] Item2351,

            /// <remarks />
            [XmlEnum("2.39:1")] Item2391,

            /// <remarks />
            [XmlEnum("2.40:1")] Item2401,

            /// <remarks />
            [XmlEnum("2.55:1")] Item2551,

            /// <remarks />
            unknown_aspect_ratio
        }

        /// <remarks />
        public enum AssemblyTimeUnitOfMeasure
        {
            /// <remarks />
            minutes,

            /// <remarks />
            hours,

            /// <remarks />
            days,

            /// <remarks />
            weeks,

            /// <remarks />
            months,

            /// <remarks />
            years
        }

        /// <remarks />
        public enum AudioEncodingType
        {
            /// <remarks />
            [XmlEnum("5_1_disney_enhanced_home_theater_mix")]
            Item5_1_disney_enhanced_home_theater_mix,

            /// <remarks />
            [XmlEnum("7_1_disney_enhanced_home_theater_mix")]
            Item7_1_disney_enhanced_home_theater_mix,

            /// <remarks />
            analog,

            /// <remarks />
            digital_atrac,

            /// <remarks />
            [XmlEnum("dolby_digital_1.0")] dolby_digital_10,

            /// <remarks />
            [XmlEnum("dolby_digital_2.0")] dolby_digital_20,

            /// <remarks />
            [XmlEnum("dolby_digital_2.0_mono")] dolby_digital_20_mono,

            /// <remarks />
            [XmlEnum("dolby_digital_2.0_stereo")] dolby_digital_20_stereo,

            /// <remarks />
            [XmlEnum("dolby_digital_2.0_surround")]
            dolby_digital_20_surround,

            /// <remarks />
            [XmlEnum("dolby_digital_2.1")] dolby_digital_21,

            /// <remarks />
            [XmlEnum("dolby_digital_3.0")] dolby_digital_30,

            /// <remarks />
            [XmlEnum("dolby_digital_4.0")] dolby_digital_40,

            /// <remarks />
            [XmlEnum("dolby_digital_4.1")] dolby_digital_41,

            /// <remarks />
            [XmlEnum("dolby_digital_5.0")] dolby_digital_50,

            /// <remarks />
            [XmlEnum("dolby_digital_5.1")] dolby_digital_51,

            /// <remarks />
            [XmlEnum("dolby_digital_5.1_es")] dolby_digital_51_es,

            /// <remarks />
            [XmlEnum("dolby_digital_5.1_ex")] dolby_digital_51_ex,

            /// <remarks />
            [XmlEnum("dolby_digital_6.1_es")] dolby_digital_61_es,

            /// <remarks />
            [XmlEnum("dolby_digital_6.1_ex")] dolby_digital_61_ex,

            /// <remarks />
            dolby_digital_ex,

            /// <remarks />
            dolby_digital_live,

            /// <remarks />
            dolby_digital_plus,

            /// <remarks />
            dolby_digital_plus_2_0,

            /// <remarks />
            dolby_digital_plus_5_1,

            /// <remarks />
            dolby_stereo_analog,

            /// <remarks />
            dolby_surround,

            /// <remarks />
            dolby_truehd,

            /// <remarks />
            dolby_truehd_5_1,

            /// <remarks />
            [XmlEnum("dts_5.0")] dts_50,

            /// <remarks />
            [XmlEnum("dts_5.1")] dts_51,

            /// <remarks />
            [XmlEnum("dts_6.1")] dts_61,

            /// <remarks />
            dts_6_1_es,

            /// <remarks />
            [XmlEnum("dts_6.1_es")] dts_61_es,

            /// <remarks />
            dts_es,

            /// <remarks />
            dts_hd_high_res_audio,

            /// <remarks />
            dts_interactive,

            /// <remarks />
            hi_res_96_24_digital_surround,

            /// <remarks />
            mlp_lossless,

            /// <remarks />
            mono,

            /// <remarks />
            [XmlEnum("mpeg_1_2.0")] mpeg_1_20,

            /// <remarks />
            [XmlEnum("mpeg_2_5.1")] mpeg_2_51,

            /// <remarks />
            pcm,

            /// <remarks />
            pcm_24bit_96khz,

            /// <remarks />
            pcm_mono,

            /// <remarks />
            pcm_stereo,

            /// <remarks />
            pcm_surround,

            /// <remarks />
            quadraphonic,

            /// <remarks />
            stereo,

            /// <remarks />
            surround,

            /// <remarks />
            thx_surround_ex,

            /// <remarks />
            unknown_audio_encoding
        }

        /// <remarks />
        public enum B2bQuantityPriceTypeValues
        {
            /// <remarks />
            @fixed,

            /// <remarks />
            percent
        }

        /// <summary>
        ///     The currency code.
        /// </summary>
        /// <value>The currency code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BaseCurrencyCode
        {
            /// <summary>
            ///     Enum USD for value: USD
            /// </summary>
            [EnumMember(Value = "USD")] USD = 1,

            /// <summary>
            ///     Enum GBP for value: GBP
            /// </summary>
            [EnumMember(Value = "GBP")] GBP,

            /// <summary>
            ///     Enum EUR for value: EUR
            /// </summary>
            [EnumMember(Value = "EUR")] EUR,

            /// <summary>
            ///     Enum JPY for value: JPY
            /// </summary>
            [EnumMember(Value = "JPY")] JPY,

            /// <summary>
            ///     Enum CAD for value: CAD
            /// </summary>
            [EnumMember(Value = "CAD")] CAD,

            /// <summary>
            ///     Enum CNY for value: CNY
            /// </summary>
            [EnumMember(Value = "CNY")] CNY,

            /// <summary>
            ///     Enum INR for value: INR
            /// </summary>
            [EnumMember(Value = "INR")] INR,

            /// <summary>
            ///     Enum MXN for value: MXN
            /// </summary>
            [EnumMember(Value = "MXN")] MXN,

            /// <summary>
            ///     Enum BRL for value: BRL
            /// </summary>
            [EnumMember(Value = "BRL")] BRL,

            /// <summary>
            ///     Enum AUD for value: AUD
            /// </summary>
            [EnumMember(Value = "AUD")] AUD,

            /// <summary>
            ///     Enum TRY for value: TRY
            /// </summary>
            [EnumMember(Value = "TRY")] TRY,

            /// <summary>
            ///     Enum SGD for value: SGD
            /// </summary>
            [EnumMember(Value = "SGD")] SGD,

            /// <summary>
            ///     Enum SEK for value: SEK
            /// </summary>
            [EnumMember(Value = "SEK")] SEK,

            /// <summary>
            ///     Enum PLN for value: PLN
            /// </summary>
            [EnumMember(Value = "PLN")] PLN,

            /// <summary>
            ///     Enum AED for value: AED
            /// </summary>
            [EnumMember(Value = "AED")] AED,

            /// <summary>
            ///     Enum SAR for value: SAR
            /// </summary>
            [EnumMember(Value = "SAR")] SAR,

            /// <summary>
            ///     Enum EGP for value: EGP
            /// </summary>
            [EnumMember(Value = "EGP")] EGP,

            /// <summary>
            ///     Enum ZAR for value: ZAR
            /// </summary>
            [EnumMember(Value = "ZAR")] ZAR
        }

        /// <remarks />
        public enum BatteryAverageLifeUnitOfMeasure
        {
            /// <remarks />
            minutes,

            /// <remarks />
            hours,

            /// <remarks />
            days,

            /// <remarks />
            weeks,

            /// <remarks />
            months,

            /// <remarks />
            years
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum BatteryBatterySubgroupBatteryType
        {
            /// <remarks />
            [XmlEnum("battery_type_2/3A")] battery_type_23A,

            /// <remarks />
            [XmlEnum("battery_type_4/3A")] battery_type_43A,

            /// <remarks />
            [XmlEnum("battery_type_4/5A")] battery_type_45A,

            /// <remarks />
            battery_type_9v,

            /// <remarks />
            battery_type_12v,

            /// <remarks />
            battery_type_a,

            /// <remarks />
            battery_type_a76,

            /// <remarks />
            battery_type_aa,

            /// <remarks />
            battery_type_aaa,

            /// <remarks />
            battery_type_aaaa,

            /// <remarks />
            battery_type_c,

            /// <remarks />
            battery_type_cr123a,

            /// <remarks />
            battery_type_cr2,

            /// <remarks />
            battery_type_cr5,

            /// <remarks />
            battery_type_d,

            /// <remarks />
            battery_type_lithium_ion,

            /// <remarks />
            battery_type_lithium_metal,

            /// <remarks />
            [XmlEnum("battery_type_L-SC")] battery_type_LSC,

            /// <remarks />
            battery_type_p76,

            /// <remarks />
            battery_type_product_specific,

            /// <remarks />
            battery_type_SC,

            /// <remarks />
            nonstandard_battery,

            /// <remarks />
            lr44,

            /// <remarks />
            unknown,

            /// <remarks />
            cr2032,

            /// <remarks />
            lr41
        }

        /// <remarks />
        public enum BatteryCellTypeValues
        {
            /// <remarks />
            NiCAD,

            /// <remarks />
            NiMh,

            /// <remarks />
            alkaline,

            /// <remarks />
            aluminum_oxygen,

            /// <remarks />
            lead_acid,

            /// <remarks />
            lead_calcium,

            /// <remarks />
            lithium,

            /// <remarks />
            lithium_ion,

            /// <remarks />
            lithium_manganese_dioxide,

            /// <remarks />
            lithium_metal,

            /// <remarks />
            lithium_polymer,

            /// <remarks />
            manganese,

            /// <remarks />
            polymer,

            /// <remarks />
            silver_oxide,

            /// <remarks />
            zinc,

            /// <remarks />
            lead_acid_agm,

            /// <remarks />
            lithium_air,

            /// <remarks />
            lithium_cobalt,

            /// <remarks />
            lithium_nickel_cobalt_aluminum,

            /// <remarks />
            lithium_nickel_manganese_cobalt,

            /// <remarks />
            lithium_phosphate,

            /// <remarks />
            lithium_thionyl_chloride,

            /// <remarks />
            lithium_titanate,

            /// <remarks />
            nickel_iron,

            /// <remarks />
            nickel_zinc,

            /// <remarks />
            silver_calcium,

            /// <remarks />
            silver_zinc,

            /// <remarks />
            zinc_air
        }

        /// <remarks />
        public enum BatteryPowerUnitOfMeasure
        {
            /// <remarks />
            milliamp_hours,

            /// <remarks />
            amp_hours,

            /// <remarks />
            volt_amperes,

            /// <remarks />
            watt_hours
        }

        /// <remarks />
        public enum BluRayRegionType
        {
            /// <remarks />
            region_a,

            /// <remarks />
            region_b,

            /// <remarks />
            region_c,

            /// <remarks />
            region_free
        }

        /// <remarks />
        public enum BootSizeUnitOfMeasure
        {
            /// <remarks />
            adult_us
        }

        /// <remarks />
        public enum BurnTimeUnitOfMeasure
        {
            /// <remarks />
            minutes,

            /// <remarks />
            hours,

            /// <remarks />
            cycles
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum BuyerPriceComponentType
        {
            /// <remarks />
            Principal,

            /// <remarks />
            Shipping,

            /// <remarks />
            CODFee,

            /// <remarks />
            Tax,

            /// <remarks />
            ShippingTax,

            /// <remarks />
            RestockingFee,

            /// <remarks />
            RestockingFeeTax,

            /// <remarks />
            GiftWrap,

            /// <remarks />
            GiftWrapTax,

            /// <remarks />
            Surcharge,

            /// <remarks />
            ReturnShipping,

            /// <remarks />
            Goodwill,

            /// <remarks />
            ExportCharge,

            /// <remarks />
            COD,

            /// <remarks />
            CODTax,

            /// <remarks />
            Other,

            /// <remarks />
            FreeReplacementReturnShipping,

            /// <remarks />
            VatExclusiveItemPrice,

            /// <remarks />
            VatExclusiveShippingPrice
        }

        /// <remarks />
        public enum CapacityUnitMeasure
        {
            /// <remarks />
            cubic_centimeters,

            /// <remarks />
            cubic_feet,

            /// <remarks />
            cubic_inches,

            /// <remarks />
            cubic_meters,

            /// <remarks />
            cubic_yards,

            /// <remarks />
            cups,

            /// <remarks />
            fluid_ounces,

            /// <remarks />
            gallons,

            /// <remarks />
            imperial_gallons,

            /// <remarks />
            liters,

            /// <remarks />
            milliliters,

            /// <remarks />
            ounces,

            /// <remarks />
            pints,

            /// <remarks />
            quarts,

            /// <remarks />
            deciliters,

            /// <remarks />
            centiliters,

            /// <remarks />
            microliters,

            /// <remarks />
            nanoliters,

            /// <remarks />
            picoliters,

            /// <remarks />
            grams,

            /// <remarks />
            kilograms,

            /// <remarks />
            [XmlEnum("ounces")] ounces1,

            /// <remarks />
            pounds,

            /// <remarks />
            milligrams
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum CarrierCode
        {
            /// <remarks />
            UPS,

            /// <remarks />
            UPSMI,

            /// <remarks />
            FedEx,

            /// <remarks />
            DHL,

            /// <remarks />
            Fastway,

            /// <remarks />
            GLS,

            /// <remarks />
            [XmlEnum("GO!")] GO,

            /// <remarks />
            [XmlEnum("Hermes Logistik Gruppe")] HermesLogistikGruppe,

            /// <remarks />
            [XmlEnum("Royal Mail")] RoyalMail,

            /// <remarks />
            Parcelforce,

            /// <remarks />
            [XmlEnum("City Link")] CityLink,

            /// <remarks />
            TNT,

            /// <remarks />
            Target,

            /// <remarks />
            SagawaExpress,

            /// <remarks />
            NipponExpress,

            /// <remarks />
            YamatoTransport,

            /// <remarks />
            [XmlEnum("DHL Global Mail")] DHLGlobalMail,

            /// <remarks />
            [XmlEnum("UPS Mail Innovations")] UPSMailInnovations,

            /// <remarks />
            [XmlEnum("FedEx SmartPost")] FedExSmartPost,

            /// <remarks />
            OSM,

            /// <remarks />
            OnTrac,

            /// <remarks />
            Streamlite,

            /// <remarks />
            Newgistics,

            /// <remarks />
            [XmlEnum("Canada Post")] CanadaPost,

            /// <remarks />
            [XmlEnum("Blue Package")] BluePackage,

            /// <remarks />
            Chronopost,

            /// <remarks />
            [XmlEnum("Deutsche Post")] DeutschePost,

            /// <remarks />
            DPD,

            /// <remarks />
            [XmlEnum("La Poste")] LaPoste,

            /// <remarks />
            Parcelnet,

            /// <remarks />
            [XmlEnum("Poste Italiane")] PosteItaliane,

            /// <remarks />
            SDA,

            /// <remarks />
            Smartmail,

            /// <remarks />
            FEDEX_JP,

            /// <remarks />
            JP_EXPRESS,

            /// <remarks />
            NITTSU,

            /// <remarks />
            SAGAWA,

            /// <remarks />
            YAMATO,

            /// <remarks />
            BlueDart,

            /// <remarks />
            [XmlEnum("AFL/Fedex")] AFLFedex,

            /// <remarks />
            Aramex,

            /// <remarks />
            [XmlEnum("India Post")] IndiaPost,

            /// <remarks />
            Professional,

            /// <remarks />
            DTDC,

            /// <remarks />
            [XmlEnum("Overnite Express")] OverniteExpress,

            /// <remarks />
            [XmlEnum("First Flight")] FirstFlight,

            /// <remarks />
            Delhivery,

            /// <remarks />
            Lasership,

            /// <remarks />
            Yodel,

            /// <remarks />
            Other,

            /// <remarks />
            [XmlEnum("Amazon Shipping")] AmazonShipping,

            /// <remarks />
            Seur,

            /// <remarks />
            Correos,

            /// <remarks />
            MRW,

            /// <remarks />
            Endopack,

            /// <remarks />
            [XmlEnum("Chrono Express")] ChronoExpress,

            /// <remarks />
            Nacex,

            /// <remarks />
            Otro,

            /// <remarks />
            Correios,

            /// <remarks />
            [XmlEnum("Toll Global Express")] TollGlobalExpress,

            /// <remarks />
            [XmlEnum("China Post")] ChinaPost,

            /// <remarks />
            AUSSIE_POST,

            /// <remarks />
            EUB,

            /// <remarks />
            [XmlEnum("Australia Post")] AustraliaPost,

            /// <remarks />
            [XmlEnum("Yun Express")] YunExpress,

            /// <remarks />
            [XmlEnum("Fastway")] Fastway1,

            /// <remarks />
            [XmlEnum("4PX")] Item4PX,

            /// <remarks />
            Hermes,

            /// <remarks />
            [XmlEnum("SF Express")] SFExpress,

            /// <remarks />
            BRT,

            /// <remarks />
            [XmlEnum("Australia Post-Consignment")]
            AustraliaPostConsignment,

            /// <remarks />
            [XmlEnum("Australia Post-ArticleId")] AustraliaPostArticleId,

            /// <remarks />
            Sendle,

            /// <remarks />
            CouriersPlease,

            /// <remarks />
            [XmlEnum("A-1")] A1,

            /// <remarks />
            [XmlEnum("AAA Cooper")] AAACooper,

            /// <remarks />
            ABF,

            /// <remarks />
            ALLJOY,

            /// <remarks />
            [XmlEnum("Aras Kargo")] ArasKargo,

            /// <remarks />
            Arkas,

            /// <remarks />
            [XmlEnum("Arrow XL")] ArrowXL,

            /// <remarks />
            Asendia,

            /// <remarks />
            Asgard,

            /// <remarks />
            Assett,

            /// <remarks />
            [XmlEnum("AT POST")] ATPOST,

            /// <remarks />
            ATS,

            /// <remarks />
            Balnak,

            /// <remarks />
            [XmlEnum("Beijing Quanfeng Express")] BeijingQuanfengExpress,

            /// <remarks />
            [XmlEnum("Best Buy")] BestBuy,

            /// <remarks />
            [XmlEnum("Best Express")] BestExpress,

            /// <remarks />
            BJS,

            /// <remarks />
            Bombax,

            /// <remarks />
            Cart2India,

            /// <remarks />
            CDC,

            /// <remarks />
            CELERITAS,

            /// <remarks />
            CEVA,

            /// <remarks />
            [XmlEnum("Ceva Lojistik")] CevaLojistik,

            /// <remarks />
            Cititrans,

            /// <remarks />
            Coliposte,

            /// <remarks />
            Colissimo,

            /// <remarks />
            Conway,

            /// <remarks />
            [XmlEnum("Correos Express")] CorreosExpress,

            /// <remarks />
            [XmlEnum("Couriers Please")] CouriersPlease1,

            /// <remarks />
            CTTExpress,

            /// <remarks />
            [XmlEnum("DB Schenker")] DBSchenker,

            /// <remarks />
            [XmlEnum("DHL eCommerce")] DHLeCommerce,

            /// <remarks />
            [XmlEnum("DHL Express")] DHLExpress,

            /// <remarks />
            [XmlEnum("DHL Freight")] DHLFreight,

            /// <remarks />
            [XmlEnum("DHL Home Delivery")] DHLHomeDelivery,

            /// <remarks />
            [XmlEnum("DHL Kargo")] DHLKargo,

            /// <remarks />
            [XmlEnum("DHL-Paket")] DHLPaket,

            /// <remarks />
            DHLPL,

            /// <remarks />
            [XmlEnum("Digital Delivery")] DigitalDelivery,

            /// <remarks />
            DirectLog,

            /// <remarks />
            Dotzot,

            /// <remarks />
            DSV,

            /// <remarks />
            [XmlEnum("DX Freight")] DXFreight,

            /// <remarks />
            ECMS,

            /// <remarks />
            [XmlEnum("Ecom Express")] EcomExpress,

            /// <remarks />
            [XmlEnum("Emirates Post")] EmiratesPost,

            /// <remarks />
            Energo,

            /// <remarks />
            Envialia,

            /// <remarks />
            Estafeta,

            /// <remarks />
            Estes,

            /// <remarks />
            [XmlEnum("Fedex Freight")] FedexFreight,

            /// <remarks />
            [XmlEnum("Fillo Kargo")] FilloKargo,

            /// <remarks />
            [XmlEnum("First Flight China")] FirstFlightChina,

            /// <remarks />
            [XmlEnum("First Mile")] FirstMile,

            /// <remarks />
            Gati,

            /// <remarks />
            [XmlEnum("GEL Express")] GELExpress,

            /// <remarks />
            geodis,

            /// <remarks />
            [XmlEnum("Geodis Calberson")] GeodisCalberson,

            /// <remarks />
            [XmlEnum("Geopost Kargo")] GeopostKargo,

            /// <remarks />
            [XmlEnum("Hermes Einrichtungsservice")]
            HermesEinrichtungsservice,

            /// <remarks />
            [XmlEnum("Home Logistics")] HomeLogistics,

            /// <remarks />
            [XmlEnum("Hongkong Post")] HongkongPost,

            /// <remarks />
            [XmlEnum("Horoz Lojistik")] HorozLojistik,

            /// <remarks />
            [XmlEnum("HS code")] HScode,

            /// <remarks />
            [XmlEnum("Hunter Logistics")] HunterLogistics,

            /// <remarks />
            [XmlEnum("ICC Worldwide")] ICCWorldwide,

            /// <remarks />
            [XmlEnum("IDS Netzwerk")] IDSNetzwerk,

            /// <remarks />
            InPost,

            /// <remarks />
            iParcel,

            /// <remarks />
            [XmlEnum("Japan Post")] JapanPost,

            /// <remarks />
            JCEX,

            /// <remarks />
            Kargokar,

            /// <remarks />
            [XmlEnum("Kuehne+Nagel")] KuehneNagel,

            /// <remarks />
            Landmark,

            /// <remarks />
            [XmlEnum("Metro Kargo")] MetroKargo,

            /// <remarks />
            [XmlEnum("MNG Kargo")] MNGKargo,

            /// <remarks />
            [XmlEnum("Narpost Kargo")] NarpostKargo,

            /// <remarks />
            Nexive,

            /// <remarks />
            Ninjavan,

            /// <remarks />
            [XmlEnum("Old Dominion")] OldDominion,

            /// <remarks />
            OneWorldExpress,

            /// <remarks />
            Panther,

            /// <remarks />
            Pilot,

            /// <remarks />
            [XmlEnum("Pilot Freight")] PilotFreight,

            /// <remarks />
            [XmlEnum("Polish Post")] PolishPost,

            /// <remarks />
            [XmlEnum("Post NL")] PostNL,

            /// <remarks />
            PostNord,

            /// <remarks />
            [XmlEnum("PTT Kargo")] PTTKargo,

            /// <remarks />
            PUROLATOR,

            /// <remarks />
            QExpress,

            /// <remarks />
            Qxpress,

            /// <remarks />
            [XmlEnum("R+L")] RL,

            /// <remarks />
            [XmlEnum("Raben Group")] RabenGroup,

            /// <remarks />
            Rhenus,

            /// <remarks />
            Rieck,

            /// <remarks />
            Rivigo,

            /// <remarks />
            Roadrunner,

            /// <remarks />
            Safexpress,

            /// <remarks />
            Saia,

            /// <remarks />
            Seino,

            /// <remarks />
            [XmlEnum("SEINO TRANSPORTATION")] SEINOTRANSPORTATION,

            /// <remarks />
            [XmlEnum("Selem Kargo")] SelemKargo,

            /// <remarks />
            [XmlEnum("Self Delivery")] SelfDelivery,

            /// <remarks />
            SENDLE,

            /// <remarks />
            SFC,

            /// <remarks />
            [XmlEnum("Ship Delight")] ShipDelight,

            /// <remarks />
            [XmlEnum("Ship Global US")] ShipGlobalUS,

            /// <remarks />
            ShipEconomy,

            /// <remarks />
            ShipGlobal,

            /// <remarks />
            [XmlEnum("Shree Maruti Courier")] ShreeMarutiCourier,

            /// <remarks />
            [XmlEnum("Shree Tirupati Courier")] ShreeTirupatiCourier,

            /// <remarks />
            [XmlEnum("Shunfeng Express")] ShunfengExpress,

            /// <remarks />
            [XmlEnum("Singapore Post")] SingaporePost,

            /// <remarks />
            [XmlEnum("South Eastern Freight Lines")]
            SouthEasternFreightLines,

            /// <remarks />
            Speedex,

            /// <remarks />
            Spoton,

            /// <remarks />
            [XmlEnum("StarTrack-ArticleID")] StarTrackArticleID,

            /// <remarks />
            [XmlEnum("StarTrack-Consignment")] StarTrackConsignment,

            /// <remarks />
            [XmlEnum("STO Express")] STOExpress,

            /// <remarks />
            [XmlEnum("Tezel Lojistik")] TezelLojistik,

            /// <remarks />
            [XmlEnum("The Professional Couriers")] TheProfessionalCouriers,

            /// <remarks />
            TIPSA,

            /// <remarks />
            [XmlEnum("TNT Kargo")] TNTKargo,

            /// <remarks />
            TNTIT,

            /// <remarks />
            [XmlEnum("Total Express")] TotalExpress,

            /// <remarks />
            Trackon,

            /// <remarks />
            TransFolha,

            /// <remarks />
            Tuffnells,

            /// <remarks />
            [XmlEnum("UPS Freight")] UPSFreight,

            /// <remarks />
            [XmlEnum("Urban Express")] UrbanExpress,

            /// <remarks />
            VIR,

            /// <remarks />
            VNLIN,

            /// <remarks />
            WanbExpress,

            /// <remarks />
            [XmlEnum("Watkins and Shepard")] WatkinsandShepard,

            /// <remarks />
            Whizzard,

            /// <remarks />
            WINIT,

            /// <remarks />
            XDP,

            /// <remarks />
            [XmlEnum("XPO Freight")] XPOFreight,

            /// <remarks />
            Xpressbees,

            /// <remarks />
            YDH,

            /// <remarks />
            [XmlEnum("Yellow Freight")] YellowFreight,

            /// <remarks />
            [XmlEnum("YTO Express")] YTOExpress,

            /// <remarks />
            [XmlEnum("Yunda Express")] YundaExpress,

            /// <remarks />
            [XmlEnum("ZTO Express")] ZTOExpress,

            /// <remarks />
            Tourline,

            /// <remarks />
            Centex,

            /// <remarks />
            iMile,

            /// <remarks />
            Chukou1,

            /// <remarks />
            CNE,

            /// <remarks />
            Equick,

            /// <remarks />
            UBI,

            /// <remarks />
            Sunyou,

            /// <remarks />
            [XmlEnum("COLIS PRIVE")] COLISPRIVE,

            /// <remarks />
            [XmlEnum("Colis Prive")] ColisPrive,

            /// <remarks />
            DASCHER,

            /// <remarks />
            DACHSER,

            /// <remarks />
            [XmlEnum("France Express")] FranceExpress,

            /// <remarks />
            Heppner,

            /// <remarks />
            [XmlEnum("Kuehne Nagel")] KuehneNagel1,

            /// <remarks />
            [XmlEnum("Arco Spedizioni")] ArcoSpedizioni,

            /// <remarks />
            [XmlEnum("FAST EST")] FASTEST,

            /// <remarks />
            FERCAM,

            /// <remarks />
            Fercam,

            /// <remarks />
            Liccardi,

            /// <remarks />
            Milkman,

            /// <remarks />
            [XmlEnum("Zust Ambrosetti")] ZustAmbrosetti,

            /// <remarks />
            Yanwen,

            /// <remarks />
            ROYAL_MAIL,

            /// <remarks />
            Whistl,

            /// <remarks />
            [XmlEnum("Hermes (Corporate)")] HermesCorporate,

            /// <remarks />
            AMAUK,

            /// <remarks />
            [XmlEnum("Digital Delivery")] DigitalDelivery1,

            /// <remarks />
            [XmlEnum("The Delivery Group")] TheDeliveryGroup,

            /// <remarks />
            RMLGB,

            /// <remarks />
            UKMail,

            /// <remarks />
            APC,

            /// <remarks />
            [XmlEnum("Jersey Post")] JerseyPost,

            /// <remarks />
            Caribou,

            /// <remarks />
            [XmlEnum("Hermes UK")] HermesUK,

            /// <remarks />
            [XmlEnum("DPD Local")] DPDLocal,

            /// <remarks />
            [XmlEnum("UK MAIL")] UKMAIL,

            /// <remarks />
            [XmlEnum("APC Overnight")] APCOvernight,

            /// <remarks />
            USPS,

            /// <remarks />
            [XmlEnum("DHL")] DHL1,

            /// <remarks />
            [XmlEnum("DX Express")] DXExpress,

            /// <remarks />
            [XmlEnum("DX Secure")] DXSecure,

            /// <remarks />
            [XmlEnum("Parcel Station")] ParcelStation,

            /// <remarks />
            AMZL_UK,

            /// <remarks />
            DX,

            /// <remarks />
            [XmlEnum("APC-Overnight")] APCOvernight1,

            /// <remarks />
            [XmlEnum("B2C Europe")] B2CEurope,

            /// <remarks />
            [XmlEnum("ITD Global")] ITDGlobal,

            /// <remarks />
            Parcelhub,

            /// <remarks />
            HubEurope,

            /// <remarks />
            [XmlEnum("Huxloe Logistics")] HuxloeLogistics,

            /// <remarks />
            GFS,

            /// <remarks />
            [XmlEnum("Spring GDS")] SpringGDS,

            /// <remarks />
            [XmlEnum("Verage Shipping")] VerageShipping,

            /// <remarks />
            [XmlEnum("Post NL")] PostNL1,

            /// <remarks />
            MHI,

            /// <remarks />
            Truline,

            /// <remarks />
            [XmlEnum("Delivery Group")] DeliveryGroup,

            /// <remarks />
            [XmlEnum("PDC Logistics")] PDCLogistics,

            /// <remarks />
            [XmlEnum("Fastway")] Fastway2,

            /// <remarks />
            [XmlEnum("PARCEL2GO.COM")] PARCEL2GOCOM,

            /// <remarks />
            [XmlEnum("DEL Deliveries")] DELDeliveries,

            /// <remarks />
            [XmlEnum("Parcelink Logistics")] ParcelinkLogistics,

            /// <remarks />
            Cubyn,

            /// <remarks />
            [XmlEnum("Hotpoint Logistics")] HotpointLogistics,

            /// <remarks />
            [XmlEnum("AT Post")] ATPost,

            /// <remarks />
            GEL,

            /// <remarks />
            IDS,

            /// <remarks />
            Raben,

            /// <remarks />
            [XmlEnum("Rhenus")] Rhenus1,

            /// <remarks />
            [XmlEnum("DB Schenker")] DBSchenker1,

            /// <remarks />
            [XmlEnum("DSV")] DSV1,

            /// <remarks />
            [XmlEnum("TNT")] TNT1,

            /// <remarks />
            [XmlEnum("Kuehne Nagel")] KuehneNagel2,

            /// <remarks />
            [XmlEnum("Rieck")] Rieck1,

            /// <remarks />
            [XmlEnum("AO Deutschland")] AODeutschland,

            /// <remarks />
            [XmlEnum("Asendia")] Asendia1,

            /// <remarks />
            [XmlEnum("MZZ-Briefdienst")] MZZBriefdienst,

            /// <remarks />
            [XmlEnum("Der Kurier")] DerKurier,

            /// <remarks />
            REDUR,

            /// <remarks />
            Europaczka,

            /// <remarks />
            Emons,

            /// <remarks />
            [XmlEnum("Seven Senders")] SevenSenders,

            /// <remarks />
            Sendcloud,

            /// <remarks />
            [XmlEnum("GO!")] GO1,

            /// <remarks />
            [XmlEnum("IDS Netzwerk")] IDSNetzwerk1,

            /// <remarks />
            [XmlEnum("Mail Alliance")] MailAlliance,

            /// <remarks />
            Mainpost,

            /// <remarks />
            [XmlEnum("Parcelforce")] Parcelforce1,

            /// <remarks />
            PIN,

            /// <remarks />
            [XmlEnum("Post Modern")] PostModern,

            /// <remarks />
            [XmlEnum("Raben Group")] RabenGroup1,

            /// <remarks />
            [XmlEnum("Trans-o-Flex")] TransoFlex,

            /// <remarks />
            Exapaq,

            /// <remarks />
            Trakpak,

            /// <remarks />
            BPOST,

            /// <remarks />
            UPakWeShip,

            /// <remarks />
            [XmlEnum("City Link")] CityLink1,

            /// <remarks />
            [XmlEnum("Mondial Relay")] MondialRelay,

            /// <remarks />
            [XmlEnum("Swiss post")] Swisspost,

            /// <remarks />
            [XmlEnum("DPD")] DPD1,

            /// <remarks />
            [XmlEnum("UPS")] UPS1,

            /// <remarks />
            [XmlEnum("Consegna Mezzi Propri")] ConsegnaMezziPropri,

            /// <remarks />
            [XmlEnum("Seur")] Seur1,

            /// <remarks />
            [XmlEnum("Royal Mail")] RoyalMail1,

            /// <remarks />
            [XmlEnum("Deutsche Post")] DeutschePost1,

            /// <remarks />
            [XmlEnum("La Poste")] LaPoste1,

            /// <remarks />
            [XmlEnum("Chronopost")] Chronopost1,

            /// <remarks />
            [XmlEnum("Colis Prive")] ColisPrive1,

            /// <remarks />
            [XmlEnum("Colissimo")] Colissimo1,

            /// <remarks />
            DACSHER,

            /// <remarks />
            GEODIS,

            /// <remarks />
            XPO,

            /// <remarks />
            [XmlEnum("VIR")] VIR1,

            /// <remarks />
            [XmlEnum("Heppner")] Heppner1,

            /// <remarks />
            [XmlEnum("Correos")] Correos1,

            /// <remarks />
            [XmlEnum("Correos Express")] CorreosExpress1,

            /// <remarks />
            [XmlEnum("Landmark")] Landmark1,

            /// <remarks />
            NACEX,

            /// <remarks />
            Sprint,

            /// <remarks />
            Susa,

            /// <remarks />
            Zeleris,

            /// <remarks />
            TWS,

            /// <remarks />
            Sailpost,

            /// <remarks />
            WPX,

            /// <remarks />
            HRP,

            /// <remarks />
            Sending,

            /// <remarks />
            CBL,

            /// <remarks />
            [XmlEnum("DYNAMIC EXPRESS")] DYNAMICEXPRESS,

            /// <remarks />
            [XmlEnum("EINSA SOURCING")] EINSASOURCING,

            /// <remarks />
            [XmlEnum("GRUPO LOGISTIC")] GRUPOLOGISTIC,

            /// <remarks />
            KEAVO,

            /// <remarks />
            NTL,

            /// <remarks />
            SPRING,

            /// <remarks />
            Szendex,

            /// <remarks />
            TDN,

            /// <remarks />
            [XmlEnum("TransaragonÃ©s")] TransaragonÃs,

            /// <remarks />
            TSB,

            /// <remarks />
            TXT,

            /// <remarks />
            TyD,

            /// <remarks />
            [XmlEnum("Via Xpress")] ViaXpress,

            /// <remarks />
            [XmlEnum("CTT EXPRESS")] CTTEXPRESS,

            /// <remarks />
            [XmlEnum("Home Logistics")] HomeLogistics1,

            /// <remarks />
            [XmlEnum("DASCHER")] DASCHER1,

            /// <remarks />
            [XmlEnum("FRANCE EXPRESS")] FRANCEEXPRESS,

            /// <remarks />
            [XmlEnum("Arco Spedizioni")] ArcoSpedizioni1,

            /// <remarks />
            [XmlEnum("CEVA")] CEVA1,

            /// <remarks />
            [XmlEnum("FAST EST")] FASTEST1,

            /// <remarks />
            [XmlEnum("FERCAM")] FERCAM1,

            /// <remarks />
            [XmlEnum("Liccardi")] Liccardi1,

            /// <remarks />
            [XmlEnum("Milkman")] Milkman1,

            /// <remarks />
            [XmlEnum("Zust Ambrosetti")] ZustAmbrosetti1,

            /// <remarks />
            Bartolini,

            /// <remarks />
            AMZL,

            /// <remarks />
            Andere,

            /// <remarks />
            AO,

            /// <remarks />
            B2C,

            /// <remarks />
            CargoLine,

            /// <remarks />
            Citypost,

            /// <remarks />
            Delivengo,

            /// <remarks />
            DPB,

            /// <remarks />
            [XmlEnum("EKI Trans")] EKITrans,

            /// <remarks />
            FRACHTPOST,

            /// <remarks />
            Hellmann,

            /// <remarks />
            Hlog,

            /// <remarks />
            honesteye,

            /// <remarks />
            Huxloe,

            /// <remarks />
            Interlink,

            /// <remarks />
            Interno,

            /// <remarks />
            Intersoft,

            /// <remarks />
            [XmlEnum("JPL UPU")] JPLUPU,

            /// <remarks />
            Kybotech,

            /// <remarks />
            [XmlEnum("Landmark Global")] LandmarkGlobal,

            /// <remarks />
            MBE,

            /// <remarks />
            [XmlEnum("Mezzi propri")] Mezzipropri,

            /// <remarks />
            [XmlEnum("MZZ Briefdienst")] MZZBriefdienst1,

            /// <remarks />
            NOVEO,

            /// <remarks />
            [XmlEnum("OCS Worldwide")] OCSWorldwide,

            /// <remarks />
            ONTIME,

            /// <remarks />
            Palletline,

            /// <remarks />
            Palletways,

            /// <remarks />
            [XmlEnum("Parcel Hub")] ParcelHub,

            /// <remarks />
            [XmlEnum("Parcel Monkey")] ParcelMonkey,

            /// <remarks />
            Parcel2go,

            /// <remarks />
            ParcelDenOnline,

            /// <remarks />
            ParcelOne,

            /// <remarks />
            [XmlEnum("PostNL")] PostNL2,

            /// <remarks />
            RBNA,

            /// <remarks />
            [XmlEnum("RR Donnelley")] RRDonnelley,

            /// <remarks />
            [XmlEnum("Schweizer Post")] SchweizerPost,

            /// <remarks />
            Shipmate,

            /// <remarks />
            Sonstige,

            /// <remarks />
            [XmlEnum("Stahlmann and Sachs")] StahlmannandSachs,

            /// <remarks />
            Stampit,

            /// <remarks />
            STG,

            /// <remarks />
            Transaher,

            /// <remarks />
            [XmlEnum("TransaragonÃ©s")] TransaragonÃs1,

            /// <remarks />
            Translink,

            /// <remarks />
            Transoflex,

            /// <remarks />
            Upsilon
        }

        /// <remarks />
        public enum CarSeatWeightGroupEUType
        {
            /// <remarks />
            group_zero,

            /// <remarks />
            group_zero_plus,

            /// <remarks />
            group_one,

            /// <remarks />
            group_two,

            /// <remarks />
            group_three
        }

        /// <remarks />
        public enum ClothingSizeUnitOfMeasure
        {
            /// <remarks />
            IN,

            /// <remarks />
            CM
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum ColorMap
        {
            /// <remarks />
            beige,

            /// <remarks />
            black,

            /// <remarks />
            blue,

            /// <remarks />
            brass,

            /// <remarks />
            bronze,

            /// <remarks />
            brown,

            /// <remarks />
            burst,

            /// <remarks />
            chrome,

            /// <remarks />
            clear,

            /// <remarks />
            gold,

            /// <remarks />
            gray,

            /// <remarks />
            green,

            /// <remarks />
            metallic,

            /// <remarks />
            [XmlEnum("multi-colored")] multicolored,

            /// <remarks />
            natural,

            /// <remarks />
            [XmlEnum("off-white")] offwhite,

            /// <remarks />
            orange,

            /// <remarks />
            pink,

            /// <remarks />
            purple,

            /// <remarks />
            red,

            /// <remarks />
            silver,

            /// <remarks />
            white,

            /// <remarks />
            yellow
        }

        /// <remarks />
        public enum ComputerCpuTypeValues
        {
            /// <remarks />
            Pentium_N3510,

            /// <remarks />
            Celeron_867,

            /// <remarks />
            Core_i3_350M,

            /// <remarks />
            Athlon_II_X3_Triple_Core_450,

            /// <remarks />
            pentium_gold_g5500t,

            /// <remarks />
            Core_i5_3340s,

            /// <remarks />
            Pentium_G662,

            /// <remarks />
            Pentium_G660,

            /// <remarks />
            celeron_n3000,

            /// <remarks />
            Turion_II_ULTRA_M600,

            /// <remarks />
            C7_M_772_VIA,

            /// <remarks />
            xeon_platinum_8176f,

            /// <remarks />
            [XmlEnum("68882")] Item68882,

            /// <remarks />
            atom_z8700,

            /// <remarks />
            A4_1200_Accelerated,

            /// <remarks />
            core_i3_2357u,

            /// <remarks />
            Core_i5_3210M,

            /// <remarks />
            Athlon_II_X2_Dual_Core_235e,

            /// <remarks />
            i3_2367,

            /// <remarks />
            [XmlEnum("Core_i7_2.2_GHz")] Core_i7_22_GHz,

            /// <remarks />
            xeon_platinum_8176m,

            /// <remarks />
            Phenom_II_X2_Dual_Core_550,

            /// <remarks />
            pentium_g3450t,

            /// <remarks />
            Pentium_G650,

            /// <remarks />
            Pentium_N3530,

            /// <remarks />
            Athlon_II_X3_Triple_Core_435,

            /// <remarks />
            Core_i3_2357M,

            /// <remarks />
            Core_2_Duo_P8800,

            /// <remarks />
            a8_7600,

            /// <remarks />
            A_Series_Quad_Core_A8_5600K,

            /// <remarks />
            Sempron_3000,

            /// <remarks />
            atom_z3480,

            /// <remarks />
            xeon_bronze_3106,

            /// <remarks />
            xeon_bronze_3104,

            /// <remarks />
            pentium_e7600,

            /// <remarks />
            Intel_Core_i7_Extreme,

            /// <remarks />
            Celeron_887,

            /// <remarks />
            Core_2_Duo_T9300,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.93GHz")] Core_2_Duo_293GHz,

            /// <remarks />
            Pentium_3556U,

            /// <remarks />
            Athlon_X2_Dual_Core_5000_plus_,

            /// <remarks />
            amd_a6,

            /// <remarks />
            Xeon_W3520,

            /// <remarks />
            Athlon_II_X3_Triple_Core_440,

            /// <remarks />
            fx_8_core,

            /// <remarks />
            amd_a8,

            /// <remarks />
            core_i7_2760qm,

            /// <remarks />
            Pentium_M_715,

            /// <remarks />
            amd_a4,

            /// <remarks />
            pentium_4405y,

            /// <remarks />
            Pentium_M_710,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.8GHz")] Core_2_Duo_18GHz,

            /// <remarks />
            Celeron_877,

            /// <remarks />
            ryzen_5_4500u,

            /// <remarks />
            Phenom_II_X3_Triple_Core_8450,

            /// <remarks />
            pentium_4405u,

            /// <remarks />
            omap3630,

            /// <remarks />
            Core_i5_2450M,

            /// <remarks />
            core_i5_6500,

            /// <remarks />
            Core_i7_4550U,

            /// <remarks />
            Pentium_U5600,

            /// <remarks />
            core_m,

            /// <remarks />
            core_i3_2227u,

            /// <remarks />
            Phenom_II_X4_Quad_Core_920,

            /// <remarks />
            Phenom_II_X4_Quad_Core_P940,

            /// <remarks />
            Pentium_M_725,

            /// <remarks />
            Celeron_2957U,

            /// <remarks />
            Core_i5_3470T,

            /// <remarks />
            Phenom_II_X4_Quad_Core_925,

            /// <remarks />
            pa_8600,

            /// <remarks />
            FX_Series_Eight_Core_FX_8350,

            /// <remarks />
            cyrix_mii,

            /// <remarks />
            xscale,

            /// <remarks />
            core_i5_1035g1,

            /// <remarks />
            Core_i5_4670K,

            /// <remarks />
            core_i5_3470,

            /// <remarks />
            geode_gx1,

            /// <remarks />
            Xeon_W3503,

            /// <remarks />
            v30mx,

            /// <remarks />
            A6_5200,

            /// <remarks />
            Core_i3_2350M,

            /// <remarks />
            Pentium_3550M,

            /// <remarks />
            Pentium_M_738,

            /// <remarks />
            mobile_athlon_xp_m,

            /// <remarks />
            apple_a7,

            /// <remarks />
            Pentium_M_733,

            /// <remarks />
            core_i7_4712mq,

            /// <remarks />
            apple_a6,

            /// <remarks />
            Pentium_M_735,

            /// <remarks />
            apple_a5,

            /// <remarks />
            apple_a4,

            /// <remarks />
            Pentium_M_730,

            /// <remarks />
            apple_a8,

            /// <remarks />
            core_i5_3470s,

            /// <remarks />
            xeon_gold_6126t,

            /// <remarks />
            Athlon_64_3800,

            /// <remarks />
            e_series_dual_core_e_450,

            /// <remarks />
            arm_v7,

            /// <remarks />
            pentium_d3400,

            /// <remarks />
            celeron_n3450,

            /// <remarks />
            alpha_21164a,

            /// <remarks />
            Celeron_847,

            /// <remarks />
            pentium_g3258,

            /// <remarks />
            Snapdragon_s2,

            /// <remarks />
            Snapdragon_s1,

            /// <remarks />
            [XmlEnum("1_2GHz_Cortex_A13")] Item1_2GHz_Cortex_A13,

            /// <remarks />
            Core_i5_3340M,

            /// <remarks />
            ARM_Cortex_A5,

            /// <remarks />
            core_i7_4980HQ,

            /// <remarks />
            Phenom_II_X4_Quad_Core_P960,

            /// <remarks />
            Pentium_M_745,

            /// <remarks />
            Celeron_2955U,

            /// <remarks />
            Turion_II_X2_Dual_Core_N530,

            /// <remarks />
            Pentium_M_740,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.66GHz")] Core_2_Duo_166GHz,

            /// <remarks />
            Core_i7_2630QM,

            /// <remarks />
            Core_2_Duo,

            /// <remarks />
            winchip_c6,

            /// <remarks />
            pentium_g3250,

            /// <remarks />
            Pentium_P6200,

            /// <remarks />
            core_i5_1035g7,

            /// <remarks />
            core_i5_1035g4,

            /// <remarks />
            Phenom_II_X6_Six_Core_1055T,

            /// <remarks />
            Phenom_II_X3_Triple_Core_8400,

            /// <remarks />
            Phenom_II_X4_Quad_Core_910,

            /// <remarks />
            pentium_g3260,

            /// <remarks />
            Pentium_M_755,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9650,

            /// <remarks />
            intel_atom_230,

            /// <remarks />
            Pentium_M_753,

            /// <remarks />
            Pentium_M_750,

            /// <remarks />
            core_i5_4278u,

            /// <remarks />
            geode_gxm,

            /// <remarks />
            Turion_II_Neo_X2_Dual_Core_K625,

            /// <remarks />
            Pentium_957,

            /// <remarks />
            pentium_g630,

            /// <remarks />
            [XmlEnum("Quad_Core_Xeon_2.4GHz_")] Quad_Core_Xeon_24GHz_,

            /// <remarks />
            Phenom_II_X4_Quad_Core_965,

            /// <remarks />
            intel_turbo_n2840,

            /// <remarks />
            novathor_l9000,

            /// <remarks />
            Core_i3_390M,

            /// <remarks />
            Pentium_E8400,

            /// <remarks />
            Pentium_T2330,

            /// <remarks />
            Turion_64_X2_Dual_Core_TL_52,

            /// <remarks />
            Core_i5_2540M,

            /// <remarks />
            Pentium_M_760,

            /// <remarks />
            Turion_64_X2_Dual_Core_TL_56,

            /// <remarks />
            Snapdragon,

            /// <remarks />
            Core_i7_4800MQ,

            /// <remarks />
            Phenom_II_X2_Dual_Core_B75,

            /// <remarks />
            Athlon_64_X2_QL_64_Dual_Core,

            /// <remarks />
            core_i7_6600u,

            /// <remarks />
            core_i9_7940x,

            /// <remarks />
            Core_i5_4460,

            /// <remarks />
            Athlon_64_X2_3600_plus,

            /// <remarks />
            Core_i7_980X,

            /// <remarks />
            Pentium_M_778,

            /// <remarks />
            ryzen_3_3250u,

            /// <remarks />
            core_i7_6820hk,

            /// <remarks />
            Core_i7_4702MQ,

            /// <remarks />
            Pentium_M_773,

            /// <remarks />
            sa_1100,

            /// <remarks />
            Intel_Core_i5_4430,

            /// <remarks />
            Pentium_T4500,

            /// <remarks />
            v25,

            /// <remarks />
            [XmlEnum("5x86")] Item5x86,

            /// <remarks />
            Pentium_M_770,

            /// <remarks />
            omap5432,

            /// <remarks />
            Phenom_II_X3_Triple_Core_N850,

            /// <remarks />
            core_i7_6820hq,

            /// <remarks />
            omap5430,

            /// <remarks />
            z_series_dual_core_z_01,

            /// <remarks />
            Core_2_Duo_T8400,

            /// <remarks />
            E_Series_Processor_E_240,

            /// <remarks />
            Athlon_64_X2_4600,

            /// <remarks />
            core_i7_6950x,

            /// <remarks />
            Phenom_II_X4_Quad_Core_945,

            /// <remarks />
            Core_2_Quad_Q9500,

            /// <remarks />
            core_i7_6700hq,

            /// <remarks />
            Core_i7_4770S,

            /// <remarks />
            E1_2500_Accelerated_Processor,

            /// <remarks />
            Sempron_3400,

            /// <remarks />
            Athlon_LE_1640,

            /// <remarks />
            k6_2_plus,

            /// <remarks />
            Pentium_T2310,

            /// <remarks />
            v30,

            /// <remarks />
            amd_ryzen_5_1600x,

            /// <remarks />
            Core_i5_2457M,

            /// <remarks />
            [XmlEnum("Quad_Core_Xeon_2.8_GHz_")] Quad_Core_Xeon_28_GHz_,

            /// <remarks />
            Turion_X2_RM_75,

            /// <remarks />
            Athlon_II_X4_Quad_Core_620,

            /// <remarks />
            powerpc,

            /// <remarks />
            ryzen_threadripper_3960x,

            /// <remarks />
            extremecpu,

            /// <remarks />
            Core_i5_560UM,

            /// <remarks />
            core_i7_4860HQ,

            /// <remarks />
            amd_ryzen_1800x,

            /// <remarks />
            core_i3,

            /// <remarks />
            core_i5,

            /// <remarks />
            core_i7,

            /// <remarks />
            Phenom_II_X4_Quad_Core_955,

            /// <remarks />
            Core_i7_4200U,

            /// <remarks />
            [XmlEnum("Core_i3_3.2_GHz_")] Core_i3_32_GHz_,

            /// <remarks />
            Pentium_B820,

            /// <remarks />
            Core_i7_4770K,

            /// <remarks />
            C7_M_764,

            /// <remarks />
            xeon_platinum_8170m,

            /// <remarks />
            Athlon_II_X4_Quad_Core_630,

            /// <remarks />
            core_i9,

            /// <remarks />
            Phenom_II_X3_Triple_Core_N830,

            /// <remarks />
            Core_i5_2410M,

            /// <remarks />
            Turion_II_ULTRA_M660,

            /// <remarks />
            core_i5_4670r,

            /// <remarks />
            Xeon_X5560,

            /// <remarks />
            core_i5_4670s,

            /// <remarks />
            amd_ryzen_3_1200,

            /// <remarks />
            xscale_pxa901,

            /// <remarks />
            Athlon_II_X4_Quad_Core_635,

            /// <remarks />
            Core_i7_4558U,

            /// <remarks />
            intel_core_2_duo,

            /// <remarks />
            atom_z8350,

            /// <remarks />
            Core_i7_4510U,

            /// <remarks />
            i3_2350m,

            /// <remarks />
            Athlon_II_X4_Quad_Core_640,

            /// <remarks />
            cyrix_iii,

            /// <remarks />
            pentium_g4520,

            /// <remarks />
            [XmlEnum("Quad_Core_2.26GHz")] Quad_Core_226GHz,

            /// <remarks />
            core_i7_4930mx,

            /// <remarks />
            geoden_x,

            /// <remarks />
            Core_2_Duo_T7100,

            /// <remarks />
            Pentium_T2370,

            /// <remarks />
            Athlon_II_X3_Triple_Core_425,

            /// <remarks />
            core_i7_4770r,

            /// <remarks />
            core_i5_5300u,

            /// <remarks />
            A4_1250,

            /// <remarks />
            Athlon_II_X4_Quad_Core_645,

            /// <remarks />
            Core_i5_660,

            /// <remarks />
            Pentium_3558U,

            /// <remarks />
            Core_i3_2310M,

            /// <remarks />
            Athlon_64_X2_Dual_Core_4450,

            /// <remarks />
            Celeron_2950M,

            /// <remarks />
            Intel_Core_i3_3120M,

            /// <remarks />
            Pentium_997,

            /// <remarks />
            intel_centrino,

            /// <remarks />
            Athlon_II_Dual_Core_M320,

            /// <remarks />
            ARM_9_2818,

            /// <remarks />
            i5_4670k,

            /// <remarks />
            Sempron_210U,

            /// <remarks />
            Pentium_T3200,

            /// <remarks />
            [XmlEnum("210")] Item210,

            /// <remarks />
            sa_1110,

            /// <remarks />
            pentium_g4500,

            /// <remarks />
            Celeron_T3000,

            /// <remarks />
            Pentium_T2350,

            /// <remarks />
            Phenom_II_X6_Six_Core_1100T,

            /// <remarks />
            A31s,

            /// <remarks />
            Sempron_2100,

            /// <remarks />
            Athlon_II_X2_Dual_Core_QL_60,

            /// <remarks />
            Sempron_M_2600,

            /// <remarks />
            Athlon_II_X2_Dual_Core_QL_62,

            /// <remarks />
            Athlon_II_X2_Dual_Core_QL_64,

            /// <remarks />
            [XmlEnum("6x86mx")] Item6x86mx,

            /// <remarks />
            [XmlEnum("Core_i3_3.06_GHz_")] Core_i3_306_GHz_,

            /// <remarks />
            athlon_mp,

            /// <remarks />
            eden_esp_7000,

            /// <remarks />
            Athlon_64_X2_Dual_Core_3800_plus,

            /// <remarks />
            Core_2_Due_P8400,

            /// <remarks />
            core_i5_6500t,

            /// <remarks />
            efficion_8800,

            /// <remarks />
            mc68sz328,

            /// <remarks />
            core_i5_5250u,

            /// <remarks />
            Core_i5_750,

            /// <remarks />
            celeron_n2940,

            /// <remarks />
            Phenom_II_X6_Six_Core_1090T,

            /// <remarks />
            core_i7_4600u,

            /// <remarks />
            Core_i5_2310,

            /// <remarks />
            core_i7_4770,

            /// <remarks />
            core_i7_4771,

            /// <remarks />
            core_i3_4360t,

            /// <remarks />
            Core_2_Quad_Q9450,

            /// <remarks />
            duron,

            /// <remarks />
            Core_2_Duo_E6600,

            /// <remarks />
            Athlon_64_X2_Dual_Core_4400,

            /// <remarks />
            ryzen_7_2700,

            /// <remarks />
            celeron_3855u,

            /// <remarks />
            intel_core_i9,

            /// <remarks />
            Core_i7_3610QM,

            /// <remarks />
            core_i5_6440hq,

            /// <remarks />
            Core_i5_2537M,

            /// <remarks />
            pentium_gold_g5500,

            /// <remarks />
            Pentium_E5300,

            /// <remarks />
            Atom_Z3770,

            /// <remarks />
            Pentium_E5301,

            /// <remarks />
            intel_atom_n280,

            /// <remarks />
            Core_i7_3667U,

            /// <remarks />
            Exynos_5200,

            /// <remarks />
            core_i7_5930k,

            /// <remarks />
            Core_Duo_T2600,

            /// <remarks />
            Core_Duo_U2400,

            /// <remarks />
            Atom_N330,

            /// <remarks />
            core_i9_7800x,

            /// <remarks />
            pentium_n3520,

            /// <remarks />
            Core_i5_450M,

            /// <remarks />
            alpha_21364,

            /// <remarks />
            a_series_quad_core_a8_6500,

            /// <remarks />
            ARM_Cortex_A_9,

            /// <remarks />
            Atom_230,

            /// <remarks />
            Atom_D2550,

            /// <remarks />
            Pentium_T2390,

            /// <remarks />
            Core_i5_2405S,

            /// <remarks />
            Intel_Core_i7_4702MQ,

            /// <remarks />
            motorola_dragonball,

            /// <remarks />
            A_Series_Dual_Core_A4_3305,

            /// <remarks />
            tmpr3922au,

            /// <remarks />
            Athlon_64_X2_4000_plus,

            /// <remarks />
            Core_i5_760,

            /// <remarks />
            Athlon_64_4200_plus,

            /// <remarks />
            Pentium_4,

            /// <remarks />
            intel_bay_trail_m_n2830_dual_core,

            /// <remarks />
            SOC_PXA986_Dual_Core,

            /// <remarks />
            intel_core_2_extreme,

            /// <remarks />
            Core_i5_470UM,

            /// <remarks />
            Core_2_Quad_Q9000,

            /// <remarks />
            core_i7_4900mq,

            /// <remarks />
            Core_2_Duo_T6600,

            /// <remarks />
            Mediatek_8389_Quadcore,

            /// <remarks />
            phenom_dual_core,

            /// <remarks />
            Celeron_E3500,

            /// <remarks />
            Core_2_Duo_T5750,

            /// <remarks />
            Core_2_Duo_SP9400,

            /// <remarks />
            Pentium_M,

            /// <remarks />
            pentium_n3540,

            /// <remarks />
            Core_2_Quad_Q9400,

            /// <remarks />
            Core_i5_3427U,

            /// <remarks />
            core_i7_8650u,

            /// <remarks />
            Athlon_II_170u,

            /// <remarks />
            Core_2_Duo_SU_9600,

            /// <remarks />
            supersparc,

            /// <remarks />
            xeon_e3_1226v3,

            /// <remarks />
            core_i3_family,

            /// <remarks />
            Core_2_Duo_T7500,

            /// <remarks />
            Pentium_E4400,

            /// <remarks />
            core_i7_4770hq,

            /// <remarks />
            quad_core_a8_6410_accelerated,

            /// <remarks />
            Pentium_E2220,

            /// <remarks />
            Celeron_T3500,

            /// <remarks />
            Core_2_Duo_E2200,

            /// <remarks />
            Snapdragon_S1_MSM7225,

            /// <remarks />
            Core_2_Duo_T6670,

            /// <remarks />
            power5,

            /// <remarks />
            Turion_64_X2_Mobile,

            /// <remarks />
            ryzen_threadripper_1950x,

            /// <remarks />
            r4000,

            /// <remarks />
            Athlon_64_3000,

            /// <remarks />
            Intel_PDC_G2030,

            /// <remarks />
            Sempron_64_3000,

            /// <remarks />
            OMAP_3400,

            /// <remarks />
            celeron_2961y,

            /// <remarks />
            AMD_Kabini_E1_2100,

            /// <remarks />
            power3,

            /// <remarks />
            power4,

            /// <remarks />
            Xeon_3530,

            /// <remarks />
            celeron_j3355,

            /// <remarks />
            AMD_Kabini_A6_5200M_Quad_Core,

            /// <remarks />
            Sempron_3600_plus,

            /// <remarks />
            atom_z3735d,

            /// <remarks />
            atom_z3735e,

            /// <remarks />
            A_Series_Quad_Core_A6_3430MX,

            /// <remarks />
            Pentium_E6600,

            /// <remarks />
            Core_i7_4820K,

            /// <remarks />
            ryzen_3_3300x,

            /// <remarks />
            atom_z3735f,

            /// <remarks />
            intel_atom_n270,

            /// <remarks />
            atom_z3735g,

            /// <remarks />
            Core_2_Duo_T5300,

            /// <remarks />
            Pentium_G620T,

            /// <remarks />
            Core_i5_2400s,

            /// <remarks />
            Core_2_Duo_E4400,

            /// <remarks />
            Core_i7_3537U,

            /// <remarks />
            Core_i7_3632QM,

            /// <remarks />
            celeron_n2930,

            /// <remarks />
            core_i5_5257u,

            /// <remarks />
            ryzen_7_3700x,

            /// <remarks />
            atom_z3736f,

            /// <remarks />
            Core_i5_540M,

            /// <remarks />
            Pentium_M_725A,

            /// <remarks />
            amd_r_series,

            /// <remarks />
            phenom_x4,

            /// <remarks />
            core_i7_3740qm,

            /// <remarks />
            atom_x5_z8300,

            /// <remarks />
            i7_2637m,

            /// <remarks />
            Athlon_64_Single_Core_TF_20,

            /// <remarks />
            Intel_Core_i5_4200U,

            /// <remarks />
            xeon_e5_2450,

            /// <remarks />
            phenom_x2,

            /// <remarks />
            phenom_x3,

            /// <remarks />
            core_i7_6560u,

            /// <remarks />
            Athlon_64_X2_4450B,

            /// <remarks />
            intel_core_2_duo_mobile,

            /// <remarks />
            arm610,

            /// <remarks />
            Snapdragon_S3_APQ8060,

            /// <remarks />
            eden_esp_4000,

            /// <remarks />
            MT8317T,

            /// <remarks />
            [XmlEnum("80486")] Item80486,

            /// <remarks />
            Core_2_Duo_P9600,

            /// <remarks />
            athlon_x2,

            /// <remarks />
            powerpc_970,

            /// <remarks />
            pentium_ii_xeon,

            /// <remarks />
            athlon_x4,

            /// <remarks />
            FX_Series_Quad_Core_FX_4320,

            /// <remarks />
            [XmlEnum("80c31")] Item80c31,

            /// <remarks />
            Core_i7_2600K,

            /// <remarks />
            [XmlEnum("80c32")] Item80c32,

            /// <remarks />
            intel_atom_z530,

            /// <remarks />
            winchip_2,

            /// <remarks />
            amd_ryzen_7_pro_1700x,

            /// <remarks />
            Athlon_II_X2_Dual_Core_M520,

            /// <remarks />
            Core_i7_2600S,

            /// <remarks />
            Celeron_330,

            /// <remarks />
            pentium_e8500,

            /// <remarks />
            Athlon_II_X2_Dual_Core_260,

            /// <remarks />
            Pentium_E5700,

            /// <remarks />
            core_i7_10510u,

            /// <remarks />
            atom_z3770d,

            /// <remarks />
            Athlon_II_X2_Dual_Core_TK_53,

            /// <remarks />
            core_i7_10510y,

            /// <remarks />
            Athlon_II_X2_Dual_Core_TK_57,

            /// <remarks />
            core_i5_6400,

            /// <remarks />
            Core_i3_530M,

            /// <remarks />
            Core_i3_4100M,

            /// <remarks />
            xeon_gold_6126f,

            /// <remarks />
            A_Series_Dual_Core_A6_5400K,

            /// <remarks />
            Phenom_II_X4_Quad_Core_P920,

            /// <remarks />
            unknown,

            /// <remarks />
            Athlon_II_X2_Dual_Core_255,

            /// <remarks />
            Core_i7_2670QM,

            /// <remarks />
            ryzen_5_2500x,

            /// <remarks />
            Athlon_II_X2_Dual_Core_250,

            /// <remarks />
            Core_2_Duo_E8400,

            /// <remarks />
            athlon_xp,

            /// <remarks />
            Atom_z3635G,

            /// <remarks />
            Pentium_E2200,

            /// <remarks />
            ryzen_5_2500u,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9600,

            /// <remarks />
            intel_atom_z550,

            /// <remarks />
            xeon_e5_2407,

            /// <remarks />
            core_i7_3517um,

            /// <remarks />
            Athlon_2650e,

            /// <remarks />
            a_series_quad_core_a6_3600m,

            /// <remarks />
            Athlon_II_X2_Dual_Core_245,

            /// <remarks />
            mobile_athlon_4,

            /// <remarks />
            Core_i3_4100U,

            /// <remarks />
            Athlon_II_X2_Dual_Core_240,

            /// <remarks />
            core_i9_8950hk,

            /// <remarks />
            a10_7850k,

            /// <remarks />
            [XmlEnum("80c88")] Item80c88,

            /// <remarks />
            atom_z3580,

            /// <remarks />
            Athlon_64_X2_5400_plus,

            /// <remarks />
            i7_3960x,

            /// <remarks />
            itanium_2,

            /// <remarks />
            core_i3_6100h,

            /// <remarks />
            Atom_Z3740,

            /// <remarks />
            Core_i3_4012Y,

            /// <remarks />
            xeon_e5_2400,

            /// <remarks />
            Intel_Celeron_G1610T,

            /// <remarks />
            Core_i7_820QM,

            /// <remarks />
            Atom_Z670,

            /// <remarks />
            core_i3_8100,

            /// <remarks />
            a6_8500p,

            /// <remarks />
            core_i3_6100t,

            /// <remarks />
            core_i3_6100u,

            /// <remarks />
            Core_2_Duo_U7700,

            /// <remarks />
            Celeron_SU2300,

            /// <remarks />
            Athlon_II_X2_Dual_Core_220,

            /// <remarks />
            rockchip_rk3288,

            /// <remarks />
            Athlon_64_3400,

            /// <remarks />
            Athlon_II_Neo_X2_Dual_Core_K325,

            /// <remarks />
            Core_2_Duo_P7450,

            /// <remarks />
            Core_2_Duo_E7500,

            /// <remarks />
            atom_z3560,

            /// <remarks />
            Exynos_5250,

            /// <remarks />
            intel_atom_z520,

            /// <remarks />
            Sempron_M_3000,

            /// <remarks />
            mobile_pentium_4,

            /// <remarks />
            Snapdragon_MSM8260A,

            /// <remarks />
            mobile_pentium_2,

            /// <remarks />
            mobile_pentium_3,

            /// <remarks />
            Athlon_64_X2_6000_plus,

            /// <remarks />
            atom_z3775d,

            /// <remarks />
            Core_i3_4010U,

            /// <remarks />
            E_Series_Dual_Core_E3_3200,

            /// <remarks />
            FX_Series_Six_Core_FX_6200,

            /// <remarks />
            pentium_p7570,

            /// <remarks />
            Core_i3_4010Y,

            /// <remarks />
            Core_2_Duo_E4000,

            /// <remarks />
            Athlon_II_X2_Dual_Core_215,

            /// <remarks />
            Quad_Core_Q9000,

            /// <remarks />
            Core_i7_620LM,

            /// <remarks />
            intel_atom_z510,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.86GHz")] Core_2_Duo_186GHz,

            /// <remarks />
            Core_i5_2300,

            /// <remarks />
            core_i7_8700,

            /// <remarks />
            pentium_pro,

            /// <remarks />
            i7_2677m,

            /// <remarks />
            Turion_64_X2_TK_55,

            /// <remarks />
            Turion_64_X2_TK_57,

            /// <remarks />
            Turion_64_X2_TK_58,

            /// <remarks />
            [XmlEnum("80486dx2")] Item80486dx2,

            /// <remarks />
            Turion_64_X2_TK_53,

            /// <remarks />
            Athlon_II_Dual_Core_260,

            /// <remarks />
            r3900,

            /// <remarks />
            ARM_710a,

            /// <remarks />
            Sempron_3100,

            /// <remarks />
            a6_7000,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.0GHz")] Core_2_Duo_20GHz,

            /// <remarks />
            Core_i5_4200Y,

            /// <remarks />
            ryzen_5_4600u,

            /// <remarks />
            core_i7_extreme,

            /// <remarks />
            Pentium_G540,

            /// <remarks />
            Core_i3_2100_,

            /// <remarks />
            Phenom_II_X6_Six_Core_1045T,

            /// <remarks />
            ryzen_5_4600h,

            /// <remarks />
            core_i5_6600k,

            /// <remarks />
            pentium_g3220t,

            /// <remarks />
            r3912,

            /// <remarks />
            pentium_t7500,

            /// <remarks />
            r3910,

            /// <remarks />
            geode_gxlv,

            /// <remarks />
            a10_8700p,

            /// <remarks />
            i7_2670qm,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9550,

            /// <remarks />
            Athlon_II_Dual_Core_245,

            /// <remarks />
            xeon_phi,

            /// <remarks />
            core_i3_8300,

            /// <remarks />
            Pentium_G531,

            /// <remarks />
            pa_7200,

            /// <remarks />
            mobile_athon_64,

            /// <remarks />
            Celeron_D_360,

            /// <remarks />
            Intel_Core_i7_4500U,

            /// <remarks />
            core_i5_3570s,

            /// <remarks />
            Core_i5_4202Y,

            /// <remarks />
            xeon_gold_6150,

            /// <remarks />
            Athlon_II_X3_Triple_Core_400E,

            /// <remarks />
            xeon_gold_6152,

            /// <remarks />
            core_i5_6600t,

            /// <remarks />
            sparc,

            /// <remarks />
            Pentium_G560,

            /// <remarks />
            xeon_gold_6154,

            /// <remarks />
            amd_ryzen_1600,

            /// <remarks />
            ARM_710t,

            /// <remarks />
            intel_pentium_g4400,

            /// <remarks />
            Tegra,

            /// <remarks />
            xeon_gold_6146,

            /// <remarks />
            Athlon_X2_Dual_Core_M300,

            /// <remarks />
            ryzen_5_3400g,

            /// <remarks />
            xeon_gold_6148,

            /// <remarks />
            core_i7_4720hq,

            /// <remarks />
            amd_ryzen_3_pro_1200,

            /// <remarks />
            xeon_gold_6140,

            /// <remarks />
            pentium_t6670,

            /// <remarks />
            Turion_64_X2_TL_64_Gold,

            /// <remarks />
            xeon_gold_6142,

            /// <remarks />
            celeron_n3150,

            /// <remarks />
            Pentium_G550,

            /// <remarks />
            intel_xeon_mp,

            /// <remarks />
            xeon_gold_6144,

            /// <remarks />
            athlon_x4_540,

            /// <remarks />
            pentium_J2900,

            /// <remarks />
            Core_i3_540,

            /// <remarks />
            nec_mips,

            /// <remarks />
            Core_2_Duo_P8700,

            /// <remarks />
            Snapdragon_S2_MSM8225,

            /// <remarks />
            Turion_II_X2_Dual_Core_M300,

            /// <remarks />
            Celeron_D_340,

            /// <remarks />
            pentium_t6600,

            /// <remarks />
            Celeron_D_346,

            /// <remarks />
            Celeron_D_345,

            /// <remarks />
            Athlon_II_Dual_Core_260u,

            /// <remarks />
            pentium_t5750,

            /// <remarks />
            pentium_3561y,

            /// <remarks />
            Celeron_G1820,

            /// <remarks />
            omap4430,

            /// <remarks />
            Core_2_Duo_E8300,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9500,

            /// <remarks />
            Pentium_3560Y,

            /// <remarks />
            Core_i3_550,

            /// <remarks />
            Core_i7_640LM,

            /// <remarks />
            core_i7_4810MQ,

            /// <remarks />
            Core_i5_3350P,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.86GHz_")] Core_2_Duo_186GHz_,

            /// <remarks />
            Celeron_D_335,

            /// <remarks />
            a_series_quad_core_a6_3400m,

            /// <remarks />
            Celeron_D_336,

            /// <remarks />
            xeon_gold_6138t,

            /// <remarks />
            Core_i7_2620QM,

            /// <remarks />
            core_i5_8250u,

            /// <remarks />
            a8_6410,

            /// <remarks />
            Phenom_II_X3_Triple_Core_8550,

            /// <remarks />
            Core_Duo_T2050,

            /// <remarks />
            core_i5_4690,

            /// <remarks />
            Pentium_G570,

            /// <remarks />
            athlon_x4_560,

            /// <remarks />
            pentium_3560m,

            /// <remarks />
            core_i3_4370,

            /// <remarks />
            intel_core_2_solo,

            /// <remarks />
            ultrasparc_iii,

            /// <remarks />
            ultrasparc_iis,

            /// <remarks />
            Core_i5_3570K,

            /// <remarks />
            Core_i3_2365M,

            /// <remarks />
            E1_6010,

            /// <remarks />
            Celeron_D_326,

            /// <remarks />
            alpha,

            /// <remarks />
            Celeron_D_325,

            /// <remarks />
            A_Series_Quad_Core_A8_3850,

            /// <remarks />
            ARM_7100,

            /// <remarks />
            Xeon_Dual_Core,

            /// <remarks />
            ultrasparc_iie,

            /// <remarks />
            pa_8500,

            /// <remarks />
            a10_7800,

            /// <remarks />
            intel_pentium_4_ht,

            /// <remarks />
            Athlon_X2_Dual_Core_5000_plus,

            /// <remarks />
            Core_i5_4200M,

            /// <remarks />
            powerpc_440gx,

            /// <remarks />
            core_i3_4360,

            /// <remarks />
            Core_i5_4200H,

            /// <remarks />
            Opteron_Quad_1354,

            /// <remarks />
            Core_i5_3570T,

            /// <remarks />
            core_i5_4460t,

            /// <remarks />
            core_i5_4460s,

            /// <remarks />
            core_i5_3340,

            /// <remarks />
            intel_atom,

            /// <remarks />
            Core_2_Duo_T5250,

            /// <remarks />
            Celeron_900,

            /// <remarks />
            core_i3_4350,

            /// <remarks />
            V_Series_Single_Core_V140,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9150,

            /// <remarks />
            amd_ryzen_1700x,

            /// <remarks />
            mobile_sempron,

            /// <remarks />
            Turion_X2_Ultra_Dual_Core_ZM_85,

            /// <remarks />
            Core_i5_4570,

            /// <remarks />
            omap4470,

            /// <remarks />
            Core_i5_2467M,

            /// <remarks />
            ryzen_threadripper_3970x,

            /// <remarks />
            apple_ci5,

            /// <remarks />
            apple_ci3,

            /// <remarks />
            Core_2_Duo_T9600,

            /// <remarks />
            mc88110,

            /// <remarks />
            apple_ci7,

            /// <remarks />
            Pentium_P6100,

            /// <remarks />
            pentium_g3260t,

            /// <remarks />
            elansc400,

            /// <remarks />
            pentium_987,

            /// <remarks />
            celeron_3205u,

            /// <remarks />
            xeon_platinum_8180m,

            /// <remarks />
            amd_c_series,

            /// <remarks />
            core_i7_5960x,

            /// <remarks />
            omap4460,

            /// <remarks />
            V_Series_Single_Core_V120,

            /// <remarks />
            celeron_t1400,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.33GHz")] Core_2_Duo_233GHz,

            /// <remarks />
            Pentium_E7200,

            /// <remarks />
            a8_8650,

            /// <remarks />
            powerpc_740_g3,

            /// <remarks />
            via_cyrix_c3,

            /// <remarks />
            Core_i3_380M,

            /// <remarks />
            efficeon_tm8600,

            /// <remarks />
            Celeron_925,

            /// <remarks />
            core_i7_2670m,

            /// <remarks />
            core_i5_5575r,

            /// <remarks />
            Athlon_64_L110,

            /// <remarks />
            Athon_II_X2_Dual_Core_P360,

            /// <remarks />
            core_i3_4330,

            /// <remarks />
            athlon_xp_m,

            /// <remarks />
            Core_2_Duo_T7400,

            /// <remarks />
            Core_2_Duo_T6570,

            /// <remarks />
            Core_i3_2328M,

            /// <remarks />
            i5_2450m,

            /// <remarks />
            Athlon_II_X2_Dual_Core_260u,

            /// <remarks />
            Core_i3_530,

            /// <remarks />
            Core_2_Quad_Q8300,

            /// <remarks />
            Core_i5_3317U,

            /// <remarks />
            Athlon_64,

            /// <remarks />
            core_i7_8500y,

            /// <remarks />
            Turion_64_MT_37,

            /// <remarks />
            ryzen_3_2200ge,

            /// <remarks />
            core_i5_2550k,

            /// <remarks />
            V_Series_Single_Core_V105,

            /// <remarks />
            Xeon_E5520,

            /// <remarks />
            powerpc_rs64,

            /// <remarks />
            xeon_gold_5119t,

            /// <remarks />
            core_i7_9700k,

            /// <remarks />
            core_m3_8100y,

            /// <remarks />
            core_i7_6500u,

            /// <remarks />
            Phenom_II_X4_Quad_Core_645,

            /// <remarks />
            Quad_Core_Xeon,

            /// <remarks />
            Pentium_E6300,

            /// <remarks />
            core_i5_family,

            /// <remarks />
            Celeron_T3100,

            /// <remarks />
            [XmlEnum("6x86")] Item6x86,

            /// <remarks />
            Intel_Core_i3_3240,

            /// <remarks />
            Core_Duo_T2450,

            /// <remarks />
            Core_Solo_U1300,

            /// <remarks />
            Phenom_II_X4_Quad_Core_910_,

            /// <remarks />
            Sempron_2200,

            /// <remarks />
            E1_2500,

            /// <remarks />
            mtk_8121,

            /// <remarks />
            Tablet_Processor,

            /// <remarks />
            core_i3_2125,

            /// <remarks />
            Athlon_64_X2_5200_plus,

            /// <remarks />
            tegra_4,

            /// <remarks />
            Geode_GX,

            /// <remarks />
            Core_i7_640UM,

            /// <remarks />
            Xeon_E5530,

            /// <remarks />
            Core_2_Duo_T5270,

            /// <remarks />
            Core_i7_2820QM,

            /// <remarks />
            Athlon_II_X2_Dual_Core_170u,

            /// <remarks />
            Xeon_E5504,

            /// <remarks />
            Xeon_E5506,

            /// <remarks />
            Sempron_3500_plus,

            /// <remarks />
            Xeon_E5507,

            /// <remarks />
            Core_Duo_LV_L2400,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.13GHz")] Core_2_Duo_213GHz,

            /// <remarks />
            core_i7_6850k,

            /// <remarks />
            pentium_967,

            /// <remarks />
            Celeron_N2830_Dual_Core,

            /// <remarks />
            Core_i3_3217U,

            /// <remarks />
            pa_8900,

            /// <remarks />
            pentium_iii_e,

            /// <remarks />
            celeron_b815,

            /// <remarks />
            core_i5_2410,

            /// <remarks />
            pentium_iii_s,

            /// <remarks />
            amd_ryzen_5_1400,

            /// <remarks />
            Athlon_X2_Dual_Core_7750,

            /// <remarks />
            Pentium_T4400,

            /// <remarks />
            Intel_Clover_Trail,

            /// <remarks />
            E_Series_Dual_Core_E2_3000,

            /// <remarks />
            opteron,

            /// <remarks />
            amd_ryzen_7_1700,

            /// <remarks />
            Intel_Core_i3_3130M,

            /// <remarks />
            Core_2_Duo_T8300,

            /// <remarks />
            Athlon_64_LE_1660,

            /// <remarks />
            Celeron_B800,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.53GHz")] Core_2_Duo_253GHz,

            /// <remarks />
            Atom_Z520,

            /// <remarks />
            celeron_j3455,

            /// <remarks />
            pentium_3825u,

            /// <remarks />
            ARM_11_Telechips_8902,

            /// <remarks />
            Core_2_Quad_9600,

            /// <remarks />
            r4310,

            /// <remarks />
            Core_i5_460M,

            /// <remarks />
            ryzen_7_3800x,

            /// <remarks />
            pa_7300lc,

            /// <remarks />
            Atom_D525,

            /// <remarks />
            Core_i5_2500K,

            /// <remarks />
            amd_ryzen_7_1700x,

            /// <remarks />
            Athlon_II_X2_Dual_Core_3250e,

            /// <remarks />
            Core_i3_4020Y,

            /// <remarks />
            Core_i5_2500T,

            /// <remarks />
            Core_i5_2500S,

            /// <remarks />
            celeron_g1850,

            /// <remarks />
            Core_2_Duo_E4300,

            /// <remarks />
            Core_2_Quad_Q8400S,

            /// <remarks />
            fx_series_eight_core_fx_8100,

            /// <remarks />
            core_i7_8550u,

            /// <remarks />
            core_m_5y31,

            /// <remarks />
            Atom_Z515,

            /// <remarks />
            [XmlEnum("Core_i5_2.3_GHz")] Core_i5_23_GHz,

            /// <remarks />
            Core_2_Duo_P7370,

            /// <remarks />
            Sempron_M120,

            /// <remarks />
            Core_i7_2410M,

            /// <remarks />
            Pentium_G3250T,

            /// <remarks />
            Intel_Celeron_G470,

            /// <remarks />
            Core_2_Duo_T6500,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9100E,

            /// <remarks />
            Core_i7_680UM,

            /// <remarks />
            core_i7_6900k,

            /// <remarks />
            Celeron_T4500,

            /// <remarks />
            Athlon_64_LE_1640,

            /// <remarks />
            Core_i7_3520M,

            /// <remarks />
            Atom_Z540,

            /// <remarks />
            Core_i5_650,

            /// <remarks />
            core_i7_2630m,

            /// <remarks />
            a4_7210,

            /// <remarks />
            core_i7_2630q,

            /// <remarks />
            core_i5_5350h,

            /// <remarks />
            Core_i5__760,

            /// <remarks />
            Core_i7_3720QM,

            /// <remarks />
            powerpc_604e,

            /// <remarks />
            Athlon_II_X4_Quad_Core_610e_,

            /// <remarks />
            ultrasparc_t1,

            /// <remarks />
            Atom_Z530,

            /// <remarks />
            core_i7_920xm,

            /// <remarks />
            Core_2_Duo_U7600,

            /// <remarks />
            core_m_5y10,

            /// <remarks />
            [XmlEnum("68lc040")] Item68lc040,

            /// <remarks />
            celeron_3865u,

            /// <remarks />
            A_Series_Dual_Core_A4_3420,

            /// <remarks />
            r4300,

            /// <remarks />
            fx_series_eight_core_fx_8120,

            /// <remarks />
            core_i5_10310y,

            /// <remarks />
            crusoe_tm5600,

            /// <remarks />
            Core_i7_620M,

            /// <remarks />
            Core_Duo_T2500,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.4GHz")] Core_2_Duo_24GHz,

            /// <remarks />
            A8_5557M,

            /// <remarks />
            ultrasparc_iv_plus,

            /// <remarks />
            core_i7_4765t,

            /// <remarks />
            Turion_64_MT_32,

            /// <remarks />
            Core_i5_3439Y,

            /// <remarks />
            Turion_64_MT_30,

            /// <remarks />
            core_i3_4025u,

            /// <remarks />
            Celeron_M_340,

            /// <remarks />
            T40_S_TEGRA_4_A15_Quad_Core,

            /// <remarks />
            Pentium_E6700,

            /// <remarks />
            Turion_64_MT_28,

            /// <remarks />
            Pentium_G630T,

            /// <remarks />
            Core_i3_520M,

            /// <remarks />
            Core_i7_3920XM,

            /// <remarks />
            Pentium_D_840,

            /// <remarks />
            Core_2_Duo_T5200,

            /// <remarks />
            core_i3_5005u,

            /// <remarks />
            core_i5_4590s,

            /// <remarks />
            core_i3_2370M,

            /// <remarks />
            r14000,

            /// <remarks />
            core_i5_4590t,

            /// <remarks />
            Core_2_Quad_Q8200,

            /// <remarks />
            core_i9_7920x,

            /// <remarks />
            Core_i5_3330,

            /// <remarks />
            core_m_5y71,

            /// <remarks />
            core_i3_4110m,

            /// <remarks />
            core_m_5y70,

            /// <remarks />
            Celeron_M_330,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.16GHz")] Core_2_Duo_216GHz,

            /// <remarks />
            eden_esp_5000,

            /// <remarks />
            Core_i3_4150T,

            /// <remarks />
            quad_core_a8_6410,

            /// <remarks />
            atom_c3200_rk,

            /// <remarks />
            Pentium_E3200,

            /// <remarks />
            core_i9_7980xe,

            /// <remarks />
            pr31700,

            /// <remarks />
            vr4300,

            /// <remarks />
            ryzen_3_2200g,

            /// <remarks />
            Atom_D510,

            /// <remarks />
            athlon_220ge,

            /// <remarks />
            pentium_p8700,

            /// <remarks />
            core_i3_4330t,

            /// <remarks />
            Celeron_M_320,

            /// <remarks />
            Core_i7_4700HQ,

            /// <remarks />
            Core_i5_4670,

            /// <remarks />
            Core_2_Quad_Q9550,

            /// <remarks />
            pentium_j2900,

            /// <remarks />
            a_series_quad_core_a8_3520m,

            /// <remarks />
            core_i5_6200u,

            /// <remarks />
            Exynos_4200,

            /// <remarks />
            Core_i7_3840QM,

            /// <remarks />
            core_m_5y51,

            /// <remarks />
            A10_5757M,

            /// <remarks />
            Phenom_II_X2_B55,

            /// <remarks />
            pentium_gold_g5400,

            /// <remarks />
            Pentium_E5400,

            /// <remarks />
            ryzen_3_2200u,

            /// <remarks />
            Core_2_Duo_T8700,

            /// <remarks />
            Core_2_Duo_T5670,

            /// <remarks />
            Exynos_4210,

            /// <remarks />
            ryzen_5_2600h,

            /// <remarks />
            pa_7100lc,

            /// <remarks />
            ryzen_5_2600e,

            /// <remarks />
            Celeron_D_420,

            /// <remarks />
            amd_fx,

            /// <remarks />
            Core_2_Duo_SU9600,

            /// <remarks />
            Atom_N270,

            /// <remarks />
            pa_8000,

            /// <remarks />
            [XmlEnum("Core_i7_2.0_GHz")] Core_i7_20_GHz,

            /// <remarks />
            core_i3_350um,

            /// <remarks />
            Pentium_D_805,

            /// <remarks />
            Pentium_G3240,

            /// <remarks />
            Core_i5_4288U,

            /// <remarks />
            amd_a6_6400k,

            /// <remarks />
            atom_zZ8300,

            /// <remarks />
            Core_i3_2130,

            /// <remarks />
            r10000,

            /// <remarks />
            core_i7_7y75,

            /// <remarks />
            Atom_N280,

            /// <remarks />
            pentium,

            /// <remarks />
            Celeron_450,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9950,

            /// <remarks />
            Phenom_II_X4_Quad_Core_B95,

            /// <remarks />
            xeon_gold_6134m,

            /// <remarks />
            ryzen_5_3600,

            /// <remarks />
            ryzen_5_2600x,

            /// <remarks />
            [XmlEnum("68000")] Item68000,

            /// <remarks />
            Core_2_Duo_SL9300,

            /// <remarks />
            powerpc_403_gcx,

            /// <remarks />
            arm710,

            /// <remarks />
            turion_64,

            /// <remarks />
            xeon_gold_6138f,

            /// <remarks />
            C7_M_770_VIA,

            /// <remarks />
            pentium_xeon,

            /// <remarks />
            core_i7_4712hq,

            /// <remarks />
            Core_2_Duo_P9500,

            /// <remarks />
            Celeron_485,

            /// <remarks />
            A_Series_Dual_Core_A6_4455M,

            /// <remarks />
            Pentium_D_820,

            /// <remarks />
            powerpc_601,

            /// <remarks />
            powerpc_603,

            /// <remarks />
            powerpc_604,

            /// <remarks />
            ryzen_threadripper_2970wx,

            /// <remarks />
            tegra_2_0,

            /// <remarks />
            ultrasparc_iv,

            /// <remarks />
            ryzen_threadripper_1920x,

            /// <remarks />
            r5230,

            /// <remarks />
            celeron_g1840t,

            /// <remarks />
            Celeron_M_T1400,

            /// <remarks />
            core_i5_4590,

            /// <remarks />
            Pentium_D_830,

            /// <remarks />
            A_Series_Quad_Core_A10_5700,

            /// <remarks />
            handheld_engine_cxd2230ga_temp,

            /// <remarks />
            Core_2_Duo_SL7100,

            /// <remarks />
            core_i3_1005g1,

            /// <remarks />
            Celeron_E3200,

            /// <remarks />
            atom_n2600,

            /// <remarks />
            ultrasparc_ii,

            /// <remarks />
            Celeron_B840,

            /// <remarks />
            Core_i3_2105,

            /// <remarks />
            ARM_11_iMAPX210,

            /// <remarks />
            a8_8600p,

            /// <remarks />
            Atom_N230,

            /// <remarks />
            pentium_e7500,

            /// <remarks />
            Core_2_Duo_SL9300_,

            /// <remarks />
            [XmlEnum("68030")] Item68030,

            /// <remarks />
            Pentium_G620,

            /// <remarks />
            Core_2_Duo_T5600,

            /// <remarks />
            omap3620,

            /// <remarks />
            xeon_gold_6130t,

            /// <remarks />
            core_2_solo,

            /// <remarks />
            cortex,

            /// <remarks />
            Athlon_II_X2_Dual_Core_B22,

            /// <remarks />
            Atom_Z550,

            /// <remarks />
            c167cr,

            /// <remarks />
            Phenom_II_X2_Dual_Core_511,

            /// <remarks />
            Core_i5_2400,

            /// <remarks />
            ultrasparc_iii_cu,

            /// <remarks />
            Athlon_II_X2_Dual_Core_B26,

            /// <remarks />
            Athlon_II_X2_Dual_Core_B24,

            /// <remarks />
            celeron_g1620t,

            /// <remarks />
            Core_i3_4158U,

            /// <remarks />
            xeon_gold_6130f,

            /// <remarks />
            Atom_Z2760,

            /// <remarks />
            Snapdragon_S4_APQ8064,

            /// <remarks />
            [XmlEnum("68040")] Item68040,

            /// <remarks />
            a6_7400k,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.6GHz")] Core_2_Duo_16GHz,

            /// <remarks />
            k6_iii_plus,

            /// <remarks />
            powerpc_603e,

            /// <remarks />
            core_i5_6287u,

            /// <remarks />
            core_i5_9400f,

            /// <remarks />
            celeron_n3050,

            /// <remarks />
            Celeron_B820,

            /// <remarks />
            Core_i3_2120,

            /// <remarks />
            Athlon_64_4800_plus,

            /// <remarks />
            core_i3_6157u,

            /// <remarks />
            core_i3_4370t,

            /// <remarks />
            Pentium_G645,

            /// <remarks />
            Pentium_G3220,

            /// <remarks />
            Pentium_G641,

            /// <remarks />
            a10_7300,

            /// <remarks />
            Pentium_G640,

            /// <remarks />
            fx_series_eight_core_fx_8150,

            /// <remarks />
            Athlon_64_LE_1600,

            /// <remarks />
            Athlon_II_Single_Core_160u,

            /// <remarks />
            celeron_n3060,

            /// <remarks />
            Celeron_B830,

            /// <remarks />
            V_SERIES_V160,

            /// <remarks />
            alpha_ev7,

            /// <remarks />
            Xeon_3000,

            /// <remarks />
            Sempron_M100,

            /// <remarks />
            Pentium_D_T2060,

            /// <remarks />
            pentium_gold_g5400t,

            /// <remarks />
            Athlon_64_2650,

            /// <remarks />
            Pentium_E5800,

            /// <remarks />
            Atom_z3735G,

            /// <remarks />
            Pentium_G631,

            /// <remarks />
            Pentium_G630,

            /// <remarks />
            core_i5_8200y,

            /// <remarks />
            Core_2_Duo_P7350,

            /// <remarks />
            celeron_g1840,

            /// <remarks />
            Core_2_Duo_E7400,

            /// <remarks />
            Athlon_64_3500,

            /// <remarks />
            Athlon_Neo_Single_Core_MV_40,

            /// <remarks />
            core_i7_4790K,

            /// <remarks />
            Core_i5_3450S,

            /// <remarks />
            core_solo,

            /// <remarks />
            sparc_ii,

            /// <remarks />
            Athlon_X2_Dual_Core_5000,

            /// <remarks />
            Phenom_II_X3_Triple_Core_P860,

            /// <remarks />
            Core_i5_4430S,

            /// <remarks />
            Core_i3_3227U,

            /// <remarks />
            Core_I3_2330E,

            /// <remarks />
            Athlon_X2_Dual_Core_TK_53,

            /// <remarks />
            Core_2_Duo_U1400,

            /// <remarks />
            core_i7_4790t,

            /// <remarks />
            core_i7_4790s,

            /// <remarks />
            exynos_5_octa_5800,

            /// <remarks />
            mxs,

            /// <remarks />
            supersparc_ii,

            /// <remarks />
            A_Series_Dual_Core_A4_4355M,

            /// <remarks />
            Core_i3_2330M,

            /// <remarks />
            Athlon_II_X4_Quad_Core_610e,

            /// <remarks />
            Core_i7_920,

            /// <remarks />
            C_Series_Dual_Core_C_50,

            /// <remarks />
            Athlon_X2_Dual_Core_TK_57,

            /// <remarks />
            r12000a,

            /// <remarks />
            Core_i7_2617M,

            /// <remarks />
            Core_2_Duo_T9550,

            /// <remarks />
            xeon_e3_1271,

            /// <remarks />
            Pentium_U3600,

            /// <remarks />
            core_i7_36517u,

            /// <remarks />
            bay_trail_t_z3735g,

            /// <remarks />
            Snapdragon_S2_MSM7230,

            /// <remarks />
            Core_i5_3320M,

            /// <remarks />
            Athlon_X2_Dual_Core_L335,

            /// <remarks />
            A_Series_Dual_Core_A6_3620,

            /// <remarks />
            sparc64v,

            /// <remarks />
            Phenom_II_X3_Triple_Core_P840,

            /// <remarks />
            Phenom_II_X6_Six_Core_1035T,

            /// <remarks />
            Turion_64_ML_37,

            /// <remarks />
            Turion_64_ML_34,

            /// <remarks />
            A6_6310,

            /// <remarks />
            Turion_64_ML_32,

            /// <remarks />
            Turion_64_ML_30,

            /// <remarks />
            Snapdragon_S3_MSM8260,

            /// <remarks />
            FX_Series_Eigth_Core_FX_8320,

            /// <remarks />
            Turion_II_X2_Dual_Core_P520,

            /// <remarks />
            core_i7_5550u,

            /// <remarks />
            core_i7_4720HQ,

            /// <remarks />
            Core_Solo_T1200,

            /// <remarks />
            a_series_quad_core_a6_3410m,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9450,

            /// <remarks />
            omap850,

            /// <remarks />
            tegra_ap_2600,

            /// <remarks />
            core_i5_4210m,

            /// <remarks />
            a8_7200p,

            /// <remarks />
            Core_i3_370M,

            /// <remarks />
            core_i5_4210h,

            /// <remarks />
            Intel_Pentium_2127U_ULV,

            /// <remarks />
            athlon_64_for_dtr,

            /// <remarks />
            athlon,

            /// <remarks />
            tm_44,

            /// <remarks />
            Core_2_Duo_L7200,

            /// <remarks />
            atom_c3130,

            /// <remarks />
            Phenom_II_X3_Triple_Core_P820,

            /// <remarks />
            Core_i5_470UM_,

            /// <remarks />
            atom_z8500,

            /// <remarks />
            intel_xscale_pxa263,

            /// <remarks />
            nova_a9000,

            /// <remarks />
            Athlon_64_X2_5000_plus,

            /// <remarks />
            crusoe_5800,

            /// <remarks />
            Athlon_64_X2_Pro_L310,

            /// <remarks />
            Core_i5_3230M,

            /// <remarks />
            intel_core_2_quad,

            /// <remarks />
            intel_core_solo,

            /// <remarks />
            a6_7310,

            /// <remarks />
            Xeon_5000,

            /// <remarks />
            A_Series_Quad_Core_A10_4655M,

            /// <remarks />
            core_i3_10110u,

            /// <remarks />
            amd_ryzen_3_pro_1300,

            /// <remarks />
            core_i3_10110y,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.26GHz")] Core_2_Duo_226GHz,

            /// <remarks />
            intel_xscale_pxa255,

            /// <remarks />
            xeon_silver_4109t,

            /// <remarks />
            [XmlEnum("80c186")] Item80c186,

            /// <remarks />
            Core_2_Duo_P8600,

            /// <remarks />
            intel_xscale_pxa250,

            /// <remarks />
            Celeron_D_440,

            /// <remarks />
            celeron_j1850,

            /// <remarks />
            Athlon_64_X2_6400_plus,

            /// <remarks />
            i5_2467m,

            /// <remarks />
            Pentium_4_360,

            /// <remarks />
            pentium_e6950,

            /// <remarks />
            Athlon_II_X4_Quad_Core_615e,

            /// <remarks />
            Core_i5_4210Y,

            /// <remarks />
            A_Series_Quad_Core_A8_4555M,

            /// <remarks />
            e_series,

            /// <remarks />
            powerpc_rs64_iv,

            /// <remarks />
            Core_i5_4210U,

            /// <remarks />
            Core_i5_4258U,

            /// <remarks />
            powerpc_rs64_ii,

            /// <remarks />
            Core_2_Quad_Q6600,

            /// <remarks />
            Clover_Trail_Plus_Z2560,

            /// <remarks />
            arm7500fe,

            /// <remarks />
            Celeron_P4500,

            /// <remarks />
            Athlon_64_X2_4200_plus,

            /// <remarks />
            Phenom_II_X3_Triple_Core_8650,

            /// <remarks />
            Athlon_II_Neo_X2_Dual_Core_K625,

            /// <remarks />
            sh_4,

            /// <remarks />
            pentium_n2930,

            /// <remarks />
            Athlon_X2_Dual_Core_3250e,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.8GHz")] Core_2_Duo_28GHz,

            /// <remarks />
            Pentium_U5400,

            /// <remarks />
            Core_Duo_T2300,

            /// <remarks />
            core_i5_4690s,

            /// <remarks />
            Athlon_II_X2_Dual_Core_250U,

            /// <remarks />
            core_i5_4690t,

            /// <remarks />
            AMD_Richland_A8_5550M,

            /// <remarks />
            xeon_e5_1630v3,

            /// <remarks />
            celeron_1037u,

            /// <remarks />
            core_m_6y75,

            /// <remarks />
            core_i5_6300hq,

            /// <remarks />
            core_i7_4870hq,

            /// <remarks />
            i3_2370m,

            /// <remarks />
            Core_2_Duo_E4700,

            /// <remarks />
            Celeron_M_380,

            /// <remarks />
            ARM_11_2818,

            /// <remarks />
            celeron,

            /// <remarks />
            pa_8800,

            /// <remarks />
            Core_2_Duo_T7300,

            /// <remarks />
            pentium_g3470,

            /// <remarks />
            mobile_k6_2_plus,

            /// <remarks />
            a8_7410,

            /// <remarks />
            E_Series_Dual_Core_E1_1500,

            /// <remarks />
            arm710t,

            /// <remarks />
            A_Series_Dual_Core_A4_5300,

            /// <remarks />
            Core_2_Quad_Q8400,

            /// <remarks />
            fx_8800p,

            /// <remarks />
            intel_core_duo,

            /// <remarks />
            Celeron_M_370,

            /// <remarks />
            geode_gx,

            /// <remarks />
            arm710a,

            /// <remarks />
            Turion_Neo_X2_Dual_Core_L625,

            /// <remarks />
            Celeron_E1500,

            /// <remarks />
            Core_2_Duo_P3750,

            /// <remarks />
            core_m_6y57,

            /// <remarks />
            core_m_6y54,

            /// <remarks />
            Intel_Core_i7_4770,

            /// <remarks />
            Snapdragon_S3_MSM8660,

            /// <remarks />
            pentium_j4205,

            /// <remarks />
            Celeron_M_360,

            /// <remarks />
            Pentium_T3400,

            /// <remarks />
            core_i7_5557u,

            /// <remarks />
            core_i7_5775r,

            /// <remarks />
            pentium_g2120,

            /// <remarks />
            pentium_g3450,

            /// <remarks />
            Core_i7_3630QM,

            /// <remarks />
            Pentium_P6000,

            /// <remarks />
            core_i3_3220t,

            /// <remarks />
            i7_2675qm,

            /// <remarks />
            mobile_pentium_4_ht,

            /// <remarks />
            celeron_3215u,

            /// <remarks />
            r4700,

            /// <remarks />
            Core_Solo_U1400,

            /// <remarks />
            ultrasparc_iii_plus,

            /// <remarks />
            core_i3_2375m,

            /// <remarks />
            Athlon_II_X4_Quad_Core,

            /// <remarks />
            core_duo,

            /// <remarks />
            Celeron_M_353,

            /// <remarks />
            core_i7_1065g7,

            /// <remarks />
            Celeron_M_350,

            /// <remarks />
            intel_xeon,

            /// <remarks />
            pentium_g2130,

            /// <remarks />
            pentium_g3460,

            /// <remarks />
            Turion_64_ML_28,

            /// <remarks />
            Core_2_Duo_T7350,

            /// <remarks />
            intel_core_i7_5950hq,

            /// <remarks />
            Xeon,

            /// <remarks />
            amd_ryzen_5_pro_1500,

            /// <remarks />
            texas_instruments_omap1510,

            /// <remarks />
            Core_i7_4790,

            /// <remarks />
            xeon_silver_4108,

            /// <remarks />
            xeon_silver_4110,

            /// <remarks />
            xeon_silver_4114,

            /// <remarks />
            ultrasparc_s400,

            /// <remarks />
            xeon_silver_4112,

            /// <remarks />
            Core_i3_330UM,

            /// <remarks />
            Core_i5_540UM,

            /// <remarks />
            Pentium_2117U,

            /// <remarks />
            Pentium_T2130,

            /// <remarks />
            core_i5_5675c,

            /// <remarks />
            celeron_j1800,

            /// <remarks />
            core_i3_2377m,

            /// <remarks />
            Celeron_D_Processor_420,

            /// <remarks />
            A_Series_Quad_Core_A8_5500,

            /// <remarks />
            Athlon_Neo_X2_Dual_Core_L335,

            /// <remarks />
            core_i9_7960x,

            /// <remarks />
            core_m_5y10c,

            /// <remarks />
            core_i7_5775c,

            /// <remarks />
            core_m_5y10a,

            /// <remarks />
            xeon_silver_4116,

            /// <remarks />
            amd_ryzen_1600x,

            /// <remarks />
            core_i5_5675r,

            /// <remarks />
            Intel_Pentium_G2020T,

            /// <remarks />
            Athlon_II_X3_415E,

            /// <remarks />
            Turion_II_X2_Dual_Core_P540,

            /// <remarks />
            pa_8700_plus,

            /// <remarks />
            Pentium_T4300,

            /// <remarks />
            Core_i7_4700MQ,

            /// <remarks />
            phenom_triple_core,

            /// <remarks />
            amd_ryzen_1700,

            /// <remarks />
            Athlon_Neo_X2_Dual_Core_L325,

            /// <remarks />
            Core_i7_3770K,

            /// <remarks />
            Sempron_3200,

            /// <remarks />
            Athlon_64_X2_Dual_Core_TK_42_,

            /// <remarks />
            athlon_x4_840,

            /// <remarks />
            Turion_64_X2_RM_70,

            /// <remarks />
            Turion_64_X2_RM_72,

            /// <remarks />
            core_i5_4300u,

            /// <remarks />
            atom_455,

            /// <remarks />
            Athlon_64_Mobile_3000,

            /// <remarks />
            elansc310,

            /// <remarks />
            Core_i3_3229Y,

            /// <remarks />
            Turion_64_X2_RM_74,

            /// <remarks />
            Core_2_Duo_T9500,

            /// <remarks />
            Celeron_D_Processor_440,

            /// <remarks />
            Athlon_64_X2_4800,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9100E_,

            /// <remarks />
            E_Series_Single_Core_E_240,

            /// <remarks />
            Exynos_5000_Series,

            /// <remarks />
            core_i9_7740x,

            /// <remarks />
            Athlon_X2_Dual_Core_5400_plus,

            /// <remarks />
            E2_Series_Dual_Core_E2_2000,

            /// <remarks />
            Celeron_M_390,

            /// <remarks />
            r16000,

            /// <remarks />
            athlon_x4_830,

            /// <remarks />
            A_Series_Dual_Core_A6_3650,

            /// <remarks />
            tegra_k1,

            /// <remarks />
            Turion_II_X2_Dual_Core_P560,

            /// <remarks />
            Core_i7_3770T,

            /// <remarks />
            phenom_ii_x2,

            /// <remarks />
            Core_i5_2430M,

            /// <remarks />
            phenom_ii_x4,

            /// <remarks />
            Core_i7_3770S,

            /// <remarks />
            phenom_ii_x3,

            /// <remarks />
            phenom_ii_x6,

            /// <remarks />
            elansc300,

            /// <remarks />
            Core_Duo_T2350,

            /// <remarks />
            A4_5000,

            /// <remarks />
            phenom_ii_x4_quad_core_n970,

            /// <remarks />
            Atom_N550,

            /// <remarks />
            Atom_D410,

            /// <remarks />
            ryzen_threadripper_2950x,

            /// <remarks />
            eden_esp,

            /// <remarks />
            Celeron_M_420,

            /// <remarks />
            mc68ez328,

            /// <remarks />
            Core_2_Duo_T7700,

            /// <remarks />
            Athlon_64_X2,

            /// <remarks />
            ryzen_7_2700e,

            /// <remarks />
            A10,

            /// <remarks />
            A13,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.5GHz")] Core_2_Duo_25GHz,

            /// <remarks />
            Core_2_Duo_U7500,

            /// <remarks />
            core_i5_8300h,

            /// <remarks />
            k6_3,

            /// <remarks />
            core_i7_6700,

            /// <remarks />
            k6_2,

            /// <remarks />
            OMAP_3600,

            /// <remarks />
            A110,

            /// <remarks />
            Intel_Pentium_Dual_Core_2020M,

            /// <remarks />
            Core_2_Duo_T4200,

            /// <remarks />
            Celeron_M_410,

            /// <remarks />
            pentium_2,

            /// <remarks />
            crusoe_tm5500,

            /// <remarks />
            pentium_4,

            /// <remarks />
            mediatek_mt8127,

            /// <remarks />
            A20,

            /// <remarks />
            pentium_3,

            /// <remarks />
            core_i5_2410qm,

            /// <remarks />
            intel_core_i7_4810mq,

            /// <remarks />
            core_i5_5750hq,

            /// <remarks />
            phenom_quad_core,

            /// <remarks />
            amd_ryzen_7_1800x,

            /// <remarks />
            Core_2_Duo__T6500,

            /// <remarks />
            eden_esp_6000,

            /// <remarks />
            Atom_N570,

            /// <remarks />
            core_i3_4120u,

            /// <remarks />
            Core_i3_4030U,

            /// <remarks />
            Atom_D425,

            /// <remarks />
            ARM_11_iMAP210,

            /// <remarks />
            Core_2_Duo_T5500,

            /// <remarks />
            intel_core_i5_6600,

            /// <remarks />
            Atom_Silverthorne,

            /// <remarks />
            core_i3_5015u,

            /// <remarks />
            Celeron_D_Processor_360,

            /// <remarks />
            A31,

            /// <remarks />
            ryzen_7_2700x,

            /// <remarks />
            Athlon_Dual_Core,

            /// <remarks />
            core_i7_10710u,

            /// <remarks />
            mobile_duron,

            /// <remarks />
            athlon_x4_860k,

            /// <remarks />
            ryzen_3_4300u,

            /// <remarks />
            intel_celeron_d,

            /// <remarks />
            ryzen_7_2700u,

            /// <remarks />
            pentium_d,

            /// <remarks />
            Core_i5_560M,

            /// <remarks />
            Athlon_II_X2_Dual_Core_M340,

            /// <remarks />
            pentium_m,

            /// <remarks />
            Pentium_Dual_Core_2127U,

            /// <remarks />
            i3_2367m,

            /// <remarks />
            Phenom_II_X2_Dual_Core_P650,

            /// <remarks />
            xeon_gold_6140m,

            /// <remarks />
            Core_i7_3689Y,

            /// <remarks />
            Core_Duo_T2300E,

            /// <remarks />
            Athlon_64_X2_5600_plus,

            /// <remarks />
            core_m_6y30,

            /// <remarks />
            pentium_p8600,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.66GHz")] Core_2_Duo_266GHz,

            /// <remarks />
            core_i7_6800k,

            /// <remarks />
            core_i7_5600u,

            /// <remarks />
            atom_z3745,

            /// <remarks />
            Athlon_II_X2_Dual_Core_235e_,

            /// <remarks />
            core_i7_3687u,

            /// <remarks />
            FX_Series_Quad_Core_FX_4120,

            /// <remarks />
            Pentium_T6570,

            /// <remarks />
            amd_athlon_quad_core_5150,

            /// <remarks />
            omap1710,

            /// <remarks />
            novathor_l8000,

            /// <remarks />
            core_i7_5820k,

            /// <remarks />
            Core_i7_2620M,

            /// <remarks />
            Athlon_II_X2_Dual_Core_M320,

            /// <remarks />
            Core_i7_875K,

            /// <remarks />
            Core_i5_3450,

            /// <remarks />
            core_2_extreme,

            /// <remarks />
            Pentium_E5500,

            /// <remarks />
            Core_i7_4930K,

            /// <remarks />
            Turion_II_Ultra_X2_Dual_Core_M600,

            /// <remarks />
            Core_i5_2557M,

            /// <remarks />
            atom_z3735,

            /// <remarks />
            celeron_d,

            /// <remarks />
            Exynos_5400,

            /// <remarks />
            i7_2700k,

            /// <remarks />
            Athlon_II,

            /// <remarks />
            pentium_sl9300,

            /// <remarks />
            itanium,

            /// <remarks />
            Core_Duo_T2400,

            /// <remarks />
            Turion_II_Ultra_X2_Dual_Core_M620,

            /// <remarks />
            core_i9_7820x,

            /// <remarks />
            intel_core_i3_6100,

            /// <remarks />
            Xeon_W5580,

            /// <remarks />
            Celeron_M_440,

            /// <remarks />
            alpha_21164,

            /// <remarks />
            core_i7_4970k,

            /// <remarks />
            Core_i5_430M,

            /// <remarks />
            core_i5_10210u,

            /// <remarks />
            A_Series_Tri_Core_A6_3500,

            /// <remarks />
            [XmlEnum("Core_i7_2.7_GHz")] Core_i7_27_GHz,

            /// <remarks />
            rm5231,

            /// <remarks />
            ARM_710,

            /// <remarks />
            Core_2_Duo_T9900,

            /// <remarks />
            microsparc_ii,

            /// <remarks />
            core_i5_10210y,

            /// <remarks />
            core_i5_4690K,

            /// <remarks />
            Intel_Core_i5_3330S,

            /// <remarks />
            [XmlEnum("80486slc")] Item80486slc,

            /// <remarks />
            core_i3_6300t,

            /// <remarks />
            Athlon_II_X2_Dual_Core_M300,

            /// <remarks />
            pentium_3_xeon,

            /// <remarks />
            Celeron_M_430,

            /// <remarks />
            securcore,

            /// <remarks />
            Core_2_Solo_SU3500,

            /// <remarks />
            Intel_Mobile_CPU,

            /// <remarks />
            Core_i3_4160T,

            /// <remarks />
            Core_2_Duo_T6400,

            /// <remarks />
            Core_2_Duo_T5550,

            /// <remarks />
            Core_2_Duo_E5500,

            /// <remarks />
            A_Series_Dual_Core_A6_4400M,

            /// <remarks />
            core_i5_4690k,

            /// <remarks />
            ryzen_7_4700u,

            /// <remarks />
            a_series_dual_core_a4_3400m,

            /// <remarks />
            E_Series_Dual_Core_E_350,

            /// <remarks />
            Athlon_II_X2_Dual_Core_240e_,

            /// <remarks />
            atom_z3785,

            /// <remarks />
            Turion_II_X2_Dual_Core_M500,

            /// <remarks />
            xscale_pxa261,

            /// <remarks />
            xscale_pxa260,

            /// <remarks />
            core_i3_6167u,

            /// <remarks />
            xeon_gold_6148f,

            /// <remarks />
            athlon_x2_450,

            /// <remarks />
            xscale_pxa262,

            /// <remarks />
            pentium_b987,

            /// <remarks />
            tx3922,

            /// <remarks />
            intel_atom_n450,

            /// <remarks />
            Core_i7_720QM,

            /// <remarks />
            Pentium_D_925,

            /// <remarks />
            core_i3_539,

            /// <remarks />
            xscale_pxa270,

            /// <remarks />
            athlon_ii_x4,

            /// <remarks />
            athlon_ii_x2,

            /// <remarks />
            athlon_ii_x3,

            /// <remarks />
            Celeron_585,

            /// <remarks />
            Pentium_D_920,

            /// <remarks />
            athlon_64,

            /// <remarks />
            core_2_quad,

            /// <remarks />
            exynos_5_octa_5420,

            /// <remarks />
            intel_atom_n455,

            /// <remarks />
            atom_z3775,

            /// <remarks />
            xscale_pxa272,

            /// <remarks />
            tegra_3_0,

            /// <remarks />
            Sempron,

            /// <remarks />
            Athlon_64_3200,

            /// <remarks />
            Core_2_Duo_SU7300,

            /// <remarks />
            amd_a_series,

            /// <remarks />
            C_Series_Single_Core_C_30,

            /// <remarks />
            Core_2_Duo_E7300,

            /// <remarks />
            core_i3_7100u,

            /// <remarks />
            Pentium_D_930,

            /// <remarks />
            core_i5_7y54,

            /// <remarks />
            tegra_ap_2500,

            /// <remarks />
            celeron_m,

            /// <remarks />
            celeron_n,

            /// <remarks />
            Turion_II_X2_Dual_Core_M520,

            /// <remarks />
            core_i7_4810HQ,

            /// <remarks />
            cortex_a8,

            /// <remarks />
            cortex_a7,

            /// <remarks />
            fx_series_six_core_fx_6120,

            /// <remarks />
            Core_2_Duo_U2200,

            /// <remarks />
            ryzen_3_2300u,

            /// <remarks />
            Core_2_Duo_T5900,

            /// <remarks />
            pentium_g4500t,

            /// <remarks />
            Pentium_D_945,

            /// <remarks />
            celeron_807,

            /// <remarks />
            Pentium_D_940,

            /// <remarks />
            Core_i7_3517U,

            /// <remarks />
            pentium_g3900,

            /// <remarks />
            Athlon_XP_3000,

            /// <remarks />
            alpha_21064a,

            /// <remarks />
            arm_dual_core_cortex_a9_omap_4,

            /// <remarks />
            Core_i5_2380P,

            /// <remarks />
            Athlon_64_TF_36,

            /// <remarks />
            pentium_n4200,

            /// <remarks />
            Core_i5_2500,

            /// <remarks />
            xeon_gold_5120t,

            /// <remarks />
            Core_i5_3360M,

            /// <remarks />
            hypersparc,

            /// <remarks />
            Core_i7_980,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9850,

            /// <remarks />
            fx_series_six_core_fx_6100,

            /// <remarks />
            OMAP_5400,

            /// <remarks />
            xeon_e5_2650,

            /// <remarks />
            Pentium_D_950,

            /// <remarks />
            Snapdragon_S1_QSD8650,

            /// <remarks />
            intel_pentium_d,

            /// <remarks />
            Core_i3_330M,

            /// <remarks />
            celeron_n4000,

            /// <remarks />
            Core_2_Duo_SL9400,

            /// <remarks />
            a_series_quad_core_a10_6700,

            /// <remarks />
            Celeron_J1800,

            /// <remarks />
            xeon_gold_6134,

            /// <remarks />
            pentium_other,

            /// <remarks />
            Pentium_M_A110,

            /// <remarks />
            Core_i7_950,

            /// <remarks />
            xeon_gold_6136,

            /// <remarks />
            core_i7_3635qm,

            /// <remarks />
            Pentium_SU2700,

            /// <remarks />
            xeon_gold_6138,

            /// <remarks />
            Athlon_II_Neo_Single_Core_K125,

            /// <remarks />
            ARM_7500fe,

            /// <remarks />
            core_i5_8400,

            /// <remarks />
            pentium_ii,

            /// <remarks />
            Celeron_540,

            /// <remarks />
            xeon_gold_6130,

            /// <remarks />
            xeon_gold_6132,

            /// <remarks />
            Core_2_Duo_T2450,

            /// <remarks />
            Core_2_Duo_E6400,

            /// <remarks />
            xeon_e3_1241,

            /// <remarks />
            Core_2_Duo_T6600_,

            /// <remarks />
            Athlon_X2_Dual_Core,

            /// <remarks />
            Phenom_II_X4_Quad_Core_N930,

            /// <remarks />
            apple_a5x,

            /// <remarks />
            a_series_dual_core_a4_3310m,

            /// <remarks />
            Core_i7_960,

            /// <remarks />
            xeon_gold_6142f,

            /// <remarks />
            xeon_gold_6126,

            /// <remarks />
            pentium_j2850,

            /// <remarks />
            xeon_gold_6128,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.1GHz")] Core_2_Duo_21GHz,

            /// <remarks />
            xeon_gold_6142m,

            /// <remarks />
            xeon_silver_4116t,

            /// <remarks />
            Core_i7_3612QM,

            /// <remarks />
            ARM_11_8902,

            /// <remarks />
            xeon_e3_1231,

            /// <remarks />
            Athlon_X2_Dual_Core_QL_60,

            /// <remarks />
            Celeron_M_ULV,

            /// <remarks />
            Athlon_X2_Dual_Core_QL_62,

            /// <remarks />
            mediagx,

            /// <remarks />
            pentium_b960,

            /// <remarks />
            Athlon_X2_Dual_Core_QL_64,

            /// <remarks />
            Athlon_X2_Dual_Core_QL_66,

            /// <remarks />
            a_series,

            /// <remarks />
            Pentium_G524,

            /// <remarks />
            e2_6110,

            /// <remarks />
            Core_i5_4250U,

            /// <remarks />
            Core_i7_930,

            /// <remarks />
            xeon_e5_2620,

            /// <remarks />
            a10_8750,

            /// <remarks />
            Core_2_Duo_E6420,

            /// <remarks />
            Pentium_G520,

            /// <remarks />
            A_Series_Quad_Core_A10_4600M,

            /// <remarks />
            Turion_64_X2_Dual_Core_RM_70,

            /// <remarks />
            Celeron_T1500,

            /// <remarks />
            Intel_Core_i7_4700MQ,

            /// <remarks />
            Turion_64_X2_Dual_Core_RM_72,

            /// <remarks />
            xeon_e3_1225,

            /// <remarks />
            xeon_e3_1220,

            /// <remarks />
            Mobile_Pentium_4_532,

            /// <remarks />
            xeon_e5_2600,

            /// <remarks />
            atom_z3795,

            /// <remarks />
            a33_arm_cortex_a7_quad_core,

            /// <remarks />
            ryzen_5_3500u,

            /// <remarks />
            Phenom_II_X4_Quad_Core_N950,

            /// <remarks />
            ARM_11_ROCK_2818,

            /// <remarks />
            Mobile_Pentium_4_538,

            /// <remarks />
            Pentium_G519,

            /// <remarks />
            Pentium_G517,

            /// <remarks />
            A_Series_Eight_Core_A10_5700,

            /// <remarks />
            Pentium_G516,

            /// <remarks />
            Core_i7_2600,

            /// <remarks />
            Pentium_D_915,

            /// <remarks />
            Pentium_G515,

            /// <remarks />
            Athlon_II_X4_Quad_Core_620_,

            /// <remarks />
            Core_i7_940,

            /// <remarks />
            core_i3_5010u,

            /// <remarks />
            core_i3_4030y,

            /// <remarks />
            Celeron_E3300,

            /// <remarks />
            amd_ryzen_3_1300x,

            /// <remarks />
            xeon_silver_4114t,

            /// <remarks />
            celeron_n3350,

            /// <remarks />
            Core_2_Duo_T7270,

            /// <remarks />
            Core_2_Duo_SL9600,

            /// <remarks />
            core_i9_7640x,

            /// <remarks />
            ultrasparc_iiii,

            /// <remarks />
            Core_i5_3330M,

            /// <remarks />
            core_i7_7500u,

            /// <remarks />
            Athlon_II_X4_Dual_Core_240e,

            /// <remarks />
            Celeron_743,

            /// <remarks />
            core_i5_4310u,

            /// <remarks />
            Turion_II_Neo_X2_Dual_Core_L625,

            /// <remarks />
            core_i7_8700k,

            /// <remarks />
            Athlon_64_X2_TK_55,

            /// <remarks />
            Athlon_X2_Dual_Core_4200_plus,

            /// <remarks />
            core_i7_8700t,

            /// <remarks />
            core_i5_4310m,

            /// <remarks />
            atom_n2930,

            /// <remarks />
            alpha_21264a,

            /// <remarks />
            ryzen_threadripper_2990wx,

            /// <remarks />
            alpha_21264b,

            /// <remarks />
            alpha_21264c,

            /// <remarks />
            alpha_21264d,

            /// <remarks />
            core_i7_6567u,

            /// <remarks />
            Athlon_II_X4Quad_Core_600e,

            /// <remarks />
            Core_Solo_T1300,

            /// <remarks />
            pentium_g645t,

            /// <remarks />
            power4_plus,

            /// <remarks />
            Celeron_N2830,

            /// <remarks />
            A_Series_Quad_Core_A8_3520M,

            /// <remarks />
            a_series_quad_core_a6_3420m,

            /// <remarks />
            powerpc_603ev,

            /// <remarks />
            xeon_e5_1620,

            /// <remarks />
            A_Series_Quad_Core_A8_4500M,

            /// <remarks />
            Phenom_II_X4_Quad_Core_840T_,

            /// <remarks />
            core_i7_4710MQ,

            /// <remarks />
            Athlon_X2_4050E,

            /// <remarks />
            Core_Duo_T2250,

            /// <remarks />
            core_i3_8130u,

            /// <remarks />
            Core_2_Duo_T8100,

            /// <remarks />
            a8_7650k,

            /// <remarks />
            Core_2_Duo_T7250,

            /// <remarks />
            core_i3_4170,

            /// <remarks />
            Turion_64_X2_Ultra_ZM_82,

            /// <remarks />
            amd_ryzen_5_pro_1600,

            /// <remarks />
            Turion_64_X2_Ultra_ZM_87,

            /// <remarks />
            amd_ryzen_1500x,

            /// <remarks />
            Core_2_Duo_SU9300,

            /// <remarks />
            Turion_64_X2_Ultra_ZM_85,

            /// <remarks />
            xeon_e5_1607,

            /// <remarks />
            Pentium_2127U,

            /// <remarks />
            Athlon_II_X4_Quad_Core_600E,

            /// <remarks />
            C_SERIES_C_60,

            /// <remarks />
            Celeron_763,

            /// <remarks />
            E_Series_Dual_Core_E1_1200,

            /// <remarks />
            core_i3_4160,

            /// <remarks />
            Pentium_M_ULV,

            /// <remarks />
            arm_7100,

            /// <remarks />
            Mediatek_8317_Dual_Core,

            /// <remarks />
            Core_i5_3550S,

            /// <remarks />
            Athlon_X2_Dual_Core_7550,

            /// <remarks />
            Athlon_64_3700,

            /// <remarks />
            Turion_II_X2_Dual_Core_M520_,

            /// <remarks />
            k6_mmx,

            /// <remarks />
            e_series_dual_core_e_350,

            /// <remarks />
            apple_c2d,

            /// <remarks />
            core_i7_4470s,

            /// <remarks />
            ultrasparc_i,

            /// <remarks />
            intel_centrino_2,

            /// <remarks />
            pentium_d840,

            /// <remarks />
            amd_ryzen_5_1500x,

            /// <remarks />
            ryzen_5_2400ge,

            /// <remarks />
            mc68vz328,

            /// <remarks />
            Pentium_T2410,

            /// <remarks />
            Core_i3_2120T,

            /// <remarks />
            Phenom_II_X4_Quad_Core_840T,

            /// <remarks />
            ryzen_5_2600,

            /// <remarks />
            Phenom_II_X3_Triple_Core_B75,

            /// <remarks />
            ryzen_threadripper_3990x,

            /// <remarks />
            a10_7700k,

            /// <remarks />
            [XmlEnum("68328")] Item68328,

            /// <remarks />
            Pentium_P6300,

            /// <remarks />
            Snapdragon_S4,

            /// <remarks />
            Snapdragon_S3,

            /// <remarks />
            Core_i7_740QM,

            /// <remarks />
            Athlon_2850e,

            /// <remarks />
            g3,

            /// <remarks />
            Snapdragon_S5,

            /// <remarks />
            Phenom_II_X4_Quad_Core_810,

            /// <remarks />
            Core_2_Quad_Q6700,

            /// <remarks />
            g4,

            /// <remarks />
            g5,

            /// <remarks />
            Intel_Celeron_1007U,

            /// <remarks />
            fx_4_core,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9750,

            /// <remarks />
            intel_atom_330,

            /// <remarks />
            pentium_4_extreme_edition,

            /// <remarks />
            core_i5_4220y,

            /// <remarks />
            omap311,

            /// <remarks />
            core_i3_6320,

            /// <remarks />
            omap310,

            /// <remarks />
            core_i5_6600,

            /// <remarks />
            Sempron_SI_42,

            /// <remarks />
            fx_series_quad_core_fx_4100,

            /// <remarks />
            a6_8550,

            /// <remarks />
            A6_5350M,

            /// <remarks />
            Core_Solo_T1350,

            /// <remarks />
            Celeron_N2840,

            /// <remarks />
            core_i5_3570,

            /// <remarks />
            efficeon_tm8000,

            /// <remarks />
            i5_2430m,

            /// <remarks />
            powerpc_403,

            /// <remarks />
            Athlon_II_Dual_Core_P320,

            /// <remarks />
            amd_ryzen_1400,

            /// <remarks />
            brazos_e450,

            /// <remarks />
            Core_i7_4750HQ,

            /// <remarks />
            Athlon_II_X2_Dual_Core_P360,

            /// <remarks />
            Core_i7_3770,

            /// <remarks />
            Athlon_II_X4_Quad_Core_605e,

            /// <remarks />
            bulverde,

            /// <remarks />
            Core_i5_430M_,

            /// <remarks />
            Athlon_II_X2_Dual_Core_240e,

            /// <remarks />
            Athlon_64_X2_Dual_Core_L310,

            /// <remarks />
            core_i7_4722hq,

            /// <remarks />
            Turion_X2_Ultra_ZM_82,

            /// <remarks />
            pentium_g4400t,

            /// <remarks />
            Turion_X2_Ultra_ZM_87,

            /// <remarks />
            Turion_X2_Ultra_ZM_85,

            /// <remarks />
            core_i3_6300,

            /// <remarks />
            Core_i5_4440s,

            /// <remarks />
            Turion_X2_Ultra_ZM_84,

            /// <remarks />
            Phenom_II_X2_Dual_Core_250,

            /// <remarks />
            Pentium_Dual_Core_2030M,

            /// <remarks />
            atom_z7345,

            /// <remarks />
            Core_i7_640M,

            /// <remarks />
            AMD_Richland_A10_5750M,

            /// <remarks />
            Celeron_G530,

            /// <remarks />
            ryzen_9_3900x,

            /// <remarks />
            core_i7_4785t,

            /// <remarks />
            Phenom_II_X4_Quad_Core_840,

            /// <remarks />
            celeron_g465,

            /// <remarks />
            Phenom_II_X2_Dual_Core_N640,

            /// <remarks />
            e_series_dual_core_e_300,

            /// <remarks />
            celeron_1000m,

            /// <remarks />
            core_i5_4570r,

            /// <remarks />
            Athlon_II_X2_Dual_Core_P340,

            /// <remarks />
            k5,

            /// <remarks />
            Core_i7_4650U,

            /// <remarks />
            Celeron_G540,

            /// <remarks />
            Core_Solo_U1500,

            /// <remarks />
            amd_ryzen_7,

            /// <remarks />
            fx_series_quad_core_fx_b4150,

            /// <remarks />
            Phenom_II_X2_Dual_Core_N650,

            /// <remarks />
            Sempron_140,

            /// <remarks />
            core_i7_5500u,

            /// <remarks />
            Core_2_Duo_T5470,

            /// <remarks />
            pentium_g530,

            /// <remarks />
            core_i5_5200u,

            /// <remarks />
            vr4181,

            /// <remarks />
            Phenom_II_X4_Quad_Core_820,

            /// <remarks />
            intel_core_i7_5700hq,

            /// <remarks />
            intel_core_m,

            /// <remarks />
            Core_i5_3339Y,

            /// <remarks />
            Core_2_Duo_E4600,

            /// <remarks />
            tegra_650,

            /// <remarks />
            pentium_g3900t,

            /// <remarks />
            Phenom_II_X2_Dual_Core_N620,

            /// <remarks />
            Core_i7_2720QM,

            /// <remarks />
            Pentium_B950,

            /// <remarks />
            pa_8700,

            /// <remarks />
            Exynos_4400,

            /// <remarks />
            Phenom_II_X2_Dual_Core_511_,

            /// <remarks />
            sa_110,

            /// <remarks />
            Pentium_847,

            /// <remarks />
            power3_ii,

            /// <remarks />
            c_series_dual_core_c_60,

            /// <remarks />
            amd_ryzen_5_1600,

            /// <remarks />
            Sempron_LE_1250,

            /// <remarks />
            e1_7010,

            /// <remarks />
            Athlon_II_X2_Dual_Core_P320,

            /// <remarks />
            core_m_7y30,

            /// <remarks />
            Phenom_II_X4_Quad_Core_830,

            /// <remarks />
            Pentium_B940,

            /// <remarks />
            Core_i7_4710HQ,

            /// <remarks />
            Core_i5_520M,

            /// <remarks />
            mediatek_mt8183,

            /// <remarks />
            Athlon_II_X2_B24,

            /// <remarks />
            mediagxm,

            /// <remarks />
            Exynos_4412,

            /// <remarks />
            i7_4770K,

            /// <remarks />
            mediagxi,

            /// <remarks />
            turion_64_x2,

            /// <remarks />
            c_series_dual_core_c_50,

            /// <remarks />
            Core_i7_660UM,

            /// <remarks />
            pentium_n3700,

            /// <remarks />
            Turion_64_X2_ZM_80,

            /// <remarks />
            a8_7100,

            /// <remarks />
            vr4121,

            /// <remarks />
            i5_2320,

            /// <remarks />
            Turion_64_X2_ZM_82,

            /// <remarks />
            vr4122,

            /// <remarks />
            celeron_1005m,

            /// <remarks />
            athlon_240ge,

            /// <remarks />
            GEODE_LX_LX_800,

            /// <remarks />
            Sempron_3300,

            /// <remarks />
            Snapdragon_S4_MSM8270,

            /// <remarks />
            xeon_platinum_8160t,

            /// <remarks />
            core_i3_2340m,

            /// <remarks />
            A_Series_Dual_Core_A4,

            /// <remarks />
            i7_3820,

            /// <remarks />
            Pentium_2129Y,

            /// <remarks />
            athlon_64_x2,

            /// <remarks />
            Pentium_B970,

            /// <remarks />
            Pentium_E2180,

            /// <remarks />
            Intel_Pentium_G2020,

            /// <remarks />
            Core_2_Duo_T9400,

            /// <remarks />
            turbosparc,

            /// <remarks />
            core_i5_6400t,

            /// <remarks />
            core_i5_6402p,

            /// <remarks />
            Atom_N450_,

            /// <remarks />
            Turion_64_X2_ZM_72,

            /// <remarks />
            h8s,

            /// <remarks />
            vr4111,

            /// <remarks />
            pentium_g3240t,

            /// <remarks />
            Turion_64_X2_ZM_74,

            /// <remarks />
            hitachi_sh3,

            /// <remarks />
            eden,

            /// <remarks />
            sis550,

            /// <remarks />
            Pentium_B967,

            /// <remarks />
            Pentium_SU4100,

            /// <remarks />
            r4640,

            /// <remarks />
            Pentium_E7400,

            /// <remarks />
            core_i5_3200u,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9350,

            /// <remarks />
            Core_i5_655K,

            /// <remarks />
            xeon_platinum_8160m,

            /// <remarks />
            Pentium_B960,

            /// <remarks />
            tegra_600,

            /// <remarks />
            xeon_platinum_8160f,

            /// <remarks />
            Turion_64_MK_38,

            /// <remarks />
            Turion_64_MK_36,

            /// <remarks />
            fx_6_core,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.4GHz_")] Core_2_Duo_14GHz_,

            /// <remarks />
            Core_i5_430UM,

            /// <remarks />
            Athlon_64_X2_QL_65,

            /// <remarks />
            powerpc_750_g3,

            /// <remarks />
            microsparc_iiep,

            /// <remarks />
            microsoft_sq1,

            /// <remarks />
            Intel_Core_i3_3240T,

            /// <remarks />
            fx_4300,

            /// <remarks />
            Phenom_II_X2_Dual_Core_N660,

            /// <remarks />
            Athlon_64_X2_Dual_Core_TK_42,

            /// <remarks />
            Core_2_Duo_T7200,

            /// <remarks />
            celeron_j1900,

            /// <remarks />
            Core_i3_2348M,

            /// <remarks />
            handheld_engine_cxd2230ga,

            /// <remarks />
            ARMv7_Dual_Core,

            /// <remarks />
            mc68328,

            /// <remarks />
            fx_series_quad_core_fx_4170,

            /// <remarks />
            vr4131,

            /// <remarks />
            Core_i5_3337U,

            /// <remarks />
            C_SERIES_C_30,

            /// <remarks />
            Pentium_B980,

            /// <remarks />
            core_i7_5675r,

            /// <remarks />
            pentium_g3460t,

            /// <remarks />
            A4_6210,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.83GHz")] Core_2_Duo_183GHz,

            /// <remarks />
            amd_v_series,

            /// <remarks />
            ARMv7,

            /// <remarks />
            celeron_n2820,

            /// <remarks />
            Atom_N435,

            /// <remarks />
            athlon_200ge,

            /// <remarks />
            Vision_A10_Quad_Core_APU,

            /// <remarks />
            Pentium_E2140,

            /// <remarks />
            Celeron_M_540,

            /// <remarks />
            Pentium_E6500,

            /// <remarks />
            core_i3_2330,

            /// <remarks />
            Atom_330,

            /// <remarks />
            Core_i3_4160,

            /// <remarks />
            FX_Series_Six_Core_FX_6300,

            /// <remarks />
            TEGRA_250,

            /// <remarks />
            Core_2_Duo_T6670_,

            /// <remarks />
            core_i9_7900x,

            /// <remarks />
            Core_2_Duo_T2390,

            /// <remarks />
            powerpc_750cx,

            /// <remarks />
            core_i5_5287u,

            /// <remarks />
            athlon_silver_3050U,

            /// <remarks />
            Atom_Z2560,

            /// <remarks />
            Celeron_M_530,

            /// <remarks />
            crusoe_tm3200,

            /// <remarks />
            Core_i3_4130T,

            /// <remarks />
            intel_core_i7_5850hq,

            /// <remarks />
            Core_i3_4150,

            /// <remarks />
            Celeron_E3400,

            /// <remarks />
            core_i5_6267u,

            /// <remarks />
            core_i3_5157u,

            /// <remarks />
            Celeron_E1200,

            /// <remarks />
            celeron_n2840,

            /// <remarks />
            Core_i7_4960X,

            /// <remarks />
            ryzen_3_3200g,

            /// <remarks />
            Atom_N455,

            /// <remarks />
            Core_i7_4702HQ,

            /// <remarks />
            Pentium_E2160,

            /// <remarks />
            Atom_N450,

            /// <remarks />
            core_i7_3632qn,

            /// <remarks />
            a_series_quad_core_a8_3500m,

            /// <remarks />
            C_Series_C_50,

            /// <remarks />
            Celeron_M_520,

            /// <remarks />
            pentium_N5000,

            /// <remarks />
            Pentium_G2030T,

            /// <remarks />
            athlon_64_fx,

            /// <remarks />
            Core_i5_3550,

            /// <remarks />
            core_i5_7200u,

            /// <remarks />
            r12000,

            /// <remarks />
            OMAP_3500,

            /// <remarks />
            pentium_gold_g5600,

            /// <remarks />
            Pentium_E5200,

            /// <remarks />
            Pentium_T4200,

            /// <remarks />
            ryzen_3_3200x,

            /// <remarks />
            ryzen_7_pro_2700u,

            /// <remarks />
            e2_7110,

            /// <remarks />
            Snapdragon_S4_MSM8230,

            /// <remarks />
            ryzen_3_3200u,

            /// <remarks />
            e_series_single_core_e_240,

            /// <remarks />
            Core_2_Duo_E7600,

            /// <remarks />
            Core_2_Duo_T5870,

            /// <remarks />
            tegra_2_t20,

            /// <remarks />
            [XmlEnum("68ez328")] Item68ez328,

            /// <remarks />
            athlon_4,

            /// <remarks />
            alpha_21264,

            /// <remarks />
            Core_2_Duo_SU4100,

            /// <remarks />
            atom_z3745d,

            /// <remarks />
            A_Series_Quad_Core_A6,

            /// <remarks />
            Core_2_Duo_E4500,

            /// <remarks />
            Core_2_Quad_Q9400S,

            /// <remarks />
            Celeron_M_585,

            /// <remarks />
            Core_i5_2435M,

            /// <remarks />
            xeon_platinum_8176,

            /// <remarks />
            ARM_610,

            /// <remarks />
            Core_2_Duo_T9800,

            /// <remarks />
            Core_i5_2520M,

            /// <remarks />
            intel_core_i5_6500,

            /// <remarks />
            xeon_platinum_8170,

            /// <remarks />
            tegra_2_t25,

            /// <remarks />
            A_Series_Quad_Core_A8,

            /// <remarks />
            Celeron_1017U,

            /// <remarks />
            atom_z2520,

            /// <remarks />
            powerpc_403ga,

            /// <remarks />
            Sempron_LE_1300,

            /// <remarks />
            Pentium_T2080,

            /// <remarks />
            Celeron_M_575,

            /// <remarks />
            core_i5_8400t,

            /// <remarks />
            Core_2_Duo_T5450,

            /// <remarks />
            xeon_platinum_8180,

            /// <remarks />
            ryzen_threadripper_2920x,

            /// <remarks />
            core_i7_3630m,

            /// <remarks />
            core_m_family,

            /// <remarks />
            ryzen_9_3950x,

            /// <remarks />
            core_i7_6700t,

            /// <remarks />
            Core_2_Quad_Q9300,

            /// <remarks />
            Athlon_64_X2_5050,

            /// <remarks />
            celeron_n2807,

            /// <remarks />
            Celeron_M_560,

            /// <remarks />
            ryzen_7_4800h,

            /// <remarks />
            celeron_n2808,

            /// <remarks />
            r14000a,

            /// <remarks />
            celeron_n2805,

            /// <remarks />
            Core_2_Duo_E6700,

            /// <remarks />
            xeon_platinum_8158,

            /// <remarks />
            celeron_n2806,

            /// <remarks />
            xeon_platinum_8156,

            /// <remarks />
            OMAP_4400,

            /// <remarks />
            xeon_platinum_8153,

            /// <remarks />
            core_i7_8750h,

            /// <remarks />
            Core_2_Duo_T7600,

            /// <remarks />
            Exynos_3110,

            /// <remarks />
            Core_2_Quad_Q8200S,

            /// <remarks />
            core_i5_4308u,

            /// <remarks />
            Rockchip_RK2928,

            /// <remarks />
            Turion_X2_ZM_80,

            /// <remarks />
            core_i5_32320m,

            /// <remarks />
            celeron_n2810,

            /// <remarks />
            Turion_X2_ZM_82,

            /// <remarks />
            celeron_n2815,

            /// <remarks />
            ryzen_7_4800u,

            /// <remarks />
            core_i7_6700k,

            /// <remarks />
            Celeron_M_550,

            /// <remarks />
            Core_i5_4440,

            /// <remarks />
            xeon_platinum_8168,

            /// <remarks />
            xeon_platinum_8164,

            /// <remarks />
            Athlon_II_X2_Dual_Core_245e_,

            /// <remarks />
            Pentium_T2060,

            /// <remarks />
            Core_i3_4130,

            /// <remarks />
            xeon_platinum_8160,

            /// <remarks />
            s3c2442,

            /// <remarks />
            Atom_Z2580,

            /// <remarks />
            s3c2440,

            /// <remarks />
            ryzen_3_pro_2300u,

            /// <remarks />
            Athlon_II_Dual_Core_240e,

            /// <remarks />
            Core_i3_540M,

            /// <remarks />
            Turion_II_X2_Dual_Core_M620,

            /// <remarks />
            none,

            /// <remarks />
            Core_i3_4005U,

            /// <remarks />
            xeon_gold_5122,

            /// <remarks />
            Turion_64_X2_TL_50,

            /// <remarks />
            Core_i7_870,

            /// <remarks />
            r5000,

            /// <remarks />
            Celeron_220,

            /// <remarks />
            Core_2_Duo_T5800,

            /// <remarks />
            Atom_N2800,

            /// <remarks />
            Core_2_Duo_E6320,

            /// <remarks />
            Core_i3_3110M,

            /// <remarks />
            Turion_64_X2_TL_56,

            /// <remarks />
            Turion_64_X2_TL_57,

            /// <remarks />
            Turion_64_X2_TL_58,

            /// <remarks />
            core_i3_4170t,

            /// <remarks />
            Turion_64_X2_TL_52,

            /// <remarks />
            xeon_gold_5120,

            /// <remarks />
            Core_2_Duo_E8500,

            /// <remarks />
            i7_3930k,

            /// <remarks />
            Core_i3_3220,

            /// <remarks />
            Turion_X2_Dual_Core_RM_75,

            /// <remarks />
            Phenom_II_X4_N960,

            /// <remarks />
            pentium_dual_core,

            /// <remarks />
            [XmlEnum("80486sx")] Item80486sx,

            /// <remarks />
            Core_i5_2390T,

            /// <remarks />
            E_Series_Dual_Core_E2_1800,

            /// <remarks />
            xeon_gold_5115,

            /// <remarks />
            MediaTek_MT8125,

            /// <remarks />
            amd_e_series,

            /// <remarks />
            xeon_gold_5118,

            /// <remarks />
            Core_i7_3820QM,

            /// <remarks />
            a_series_dual_core_a4_3305m,

            /// <remarks />
            Core_i7_2657M,

            /// <remarks />
            [XmlEnum("8803_CORTEX_A8")] Item8803_CORTEX_A8,

            /// <remarks />
            pentium_iii,

            /// <remarks />
            Snapdragon_QSD8250,

            /// <remarks />
            Celeron_J1900,

            /// <remarks />
            [XmlEnum("8031")] Item8031,

            /// <remarks />
            intel_strongarm,

            /// <remarks />
            [XmlEnum("8032")] Item8032,

            /// <remarks />
            A_Series_Dual_Core_A4_4300M,

            /// <remarks />
            Core_2_Duo_L7500,

            /// <remarks />
            [XmlEnum("80386")] Item80386,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.2GHz")] Core_2_Duo_22GHz,

            /// <remarks />
            core_i5_6260u,

            /// <remarks />
            Pentium_G840,

            /// <remarks />
            s3c2410,

            /// <remarks />
            Athlon_II_Dual_Core_P360,

            /// <remarks />
            sh7709a,

            /// <remarks />
            core_i5_6350hq,

            /// <remarks />
            Turion_64_X2_TL_60,

            /// <remarks />
            pentium_2030m,

            /// <remarks />
            Core_i7_860,

            /// <remarks />
            Turion_64_X2_TL_62,

            /// <remarks />
            efficeon,

            /// <remarks />
            [XmlEnum("Core_i5_2.8GHz")] Core_i5_28GHz,

            /// <remarks />
            Core_i5_4570T,

            /// <remarks />
            Core_i7_3615QM,

            /// <remarks />
            Core_2_Duo_P8400,

            /// <remarks />
            Core_2_Duo_E7200,

            /// <remarks />
            Core_i5_4570S,

            /// <remarks />
            Turion_64_X2_TL_68,

            /// <remarks />
            Turion_64_X2_TL_64,

            /// <remarks />
            Core_2_Duo_P7550,

            /// <remarks />
            Turion_64_X2_TL_66,

            /// <remarks />
            Celeron_T1600,

            /// <remarks />
            A_Series_Eight_Core_A10_5800K,

            /// <remarks />
            mediagxlv,

            /// <remarks />
            atom_e3815,

            /// <remarks />
            ryzen_5_3600x,

            /// <remarks />
            Sempron_M_3100,

            /// <remarks />
            Core_i5_480M,

            /// <remarks />
            Atom_N475,

            /// <remarks />
            Core_2_Duo_SU9400,

            /// <remarks />
            atom_z3460,

            /// <remarks />
            pentium_3805u,

            /// <remarks />
            Core_i3_2390T,

            /// <remarks />
            core_i7_family,

            /// <remarks />
            Athlon_II_X3_445AIIX3,

            /// <remarks />
            Atom_N470,

            /// <remarks />
            Athlon_Dual_Core_QL62A,

            /// <remarks />
            Pentium_G6950,

            /// <remarks />
            Core_2_Duo_T2330,

            /// <remarks />
            Pentium_G860,

            /// <remarks />
            Core_Duo_T2400__,

            /// <remarks />
            pa_8200,

            /// <remarks />
            Xeon_5400,

            /// <remarks />
            ryzen_3_3100,

            /// <remarks />
            core_i5_4260u,

            /// <remarks />
            Core_i3_4570T,

            /// <remarks />
            core_i3_5020u,

            /// <remarks />
            Core_2_Duo_T5850,

            /// <remarks />
            Pentium_G850,

            /// <remarks />
            ryzen_5_2400g,

            /// <remarks />
            pentium_mmx,

            /// <remarks />
            sempron,

            /// <remarks />
            atom_d2701,

            /// <remarks />
            Phenom_II_X4_Quad_Core_N820,

            /// <remarks />
            GP33003,

            /// <remarks />
            atom_d2700,

            /// <remarks />
            i7_2640m,

            /// <remarks />
            [XmlEnum("Core_2_Duo_3.06GHz")] Core_2_Duo_306GHz,

            /// <remarks />
            a10_7400p,

            /// <remarks />
            Core_2_Duo_T2310,

            /// <remarks />
            xeon_e5_1650,

            /// <remarks />
            amd_ryzen_7_pro_1700,

            /// <remarks />
            Core_2_Duo_E6300,

            /// <remarks />
            core_i7_6770hq,

            /// <remarks />
            atom_n2830,

            /// <remarks />
            Atom_Z330,

            /// <remarks />
            atom_c3230_rk,

            /// <remarks />
            mobile_celeron,

            /// <remarks />
            powerpc_rs64_iii,

            /// <remarks />
            Core_i3_380UM,

            /// <remarks />
            [XmlEnum("1_2GHz_Cortex_A8")] Item1_2GHz_Cortex_A8,

            /// <remarks />
            [XmlEnum("1_2GHz_Cortex_A9")] Item1_2GHz_Cortex_A9,

            /// <remarks />
            Core_i3_4000M,

            /// <remarks />
            a_series_dual_core_a4_3300m,

            /// <remarks />
            A_Series_Eight_Core_A10_4600M,

            /// <remarks />
            ryzen_threadripper_1900x,

            /// <remarks />
            atom_z650,

            /// <remarks />
            atom_z3740d,

            /// <remarks />
            k6_2e,

            /// <remarks />
            r16000b,

            /// <remarks />
            FX_8300,

            /// <remarks />
            [XmlEnum("Core_Duo_1.83GHz")] Core_Duo_183GHz,

            /// <remarks />
            r16000a,

            /// <remarks />
            Pentium_G870,

            /// <remarks />
            Rockchip_3188,

            /// <remarks />
            Pentium_G6960
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum ComputerPlatformType
        {
            /// <remarks />
            windows,

            /// <remarks />
            mac,

            /// <remarks />
            linux
        }

        /// <remarks />
        public enum ComputerPlatformValues
        {
            /// <remarks />
            game_boy_advance,

            /// <remarks />
            gameboy,

            /// <remarks />
            gameboy_color,

            /// <remarks />
            gamecube,

            /// <remarks />
            gizmondo,

            /// <remarks />
            linux,

            /// <remarks />
            macintosh,

            /// <remarks />
            n_gage,

            /// <remarks />
            nintendo_ds,

            /// <remarks />
            nintendo_NES,

            /// <remarks />
            nintendo_super_NES,

            /// <remarks />
            nintendo_wii,

            /// <remarks />
            nintendo64,

            /// <remarks />
            palm,

            /// <remarks />
            playstation,

            /// <remarks />
            playstation_2,

            /// <remarks />
            playstation_vita,

            /// <remarks />
            pocket_pc,

            /// <remarks />
            powermac,

            /// <remarks />
            sega_saturn,

            /// <remarks />
            sony_psp,

            /// <remarks />
            super_nintendo,

            /// <remarks />
            unix,

            /// <remarks />
            windows,

            /// <remarks />
            xbox
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum ConditionType
        {
            /// <remarks />
            New,

            /// <remarks />
            UsedLikeNew,

            /// <remarks />
            UsedVeryGood,

            /// <remarks />
            UsedGood,

            /// <remarks />
            UsedAcceptable,

            /// <remarks />
            CollectibleLikeNew,

            /// <remarks />
            CollectibleVeryGood,

            /// <remarks />
            CollectibleGood,

            /// <remarks />
            CollectibleAcceptable,

            /// <remarks />
            Club,

            /// <remarks />
            NewOpenBox,

            /// <remarks />
            NewOem,

            /// <remarks />
            Refurbished
        }

        /// <remarks />
        public enum ContinuousShootingUnitOfMeasure
        {
            /// <remarks />
            frames
        }

        /// <remarks />
        public enum CountryAsLabeledValues
        {
            /// <remarks />
            PR,

            /// <remarks />
            PS,

            /// <remarks />
            PT,

            /// <remarks />
            PW,

            /// <remarks />
            PY,

            /// <remarks />
            QA,

            /// <remarks />
            AC,

            /// <remarks />
            AD,

            /// <remarks />
            AE,

            /// <remarks />
            AF,

            /// <remarks />
            AG,

            /// <remarks />
            AI,

            /// <remarks />
            AL,

            /// <remarks />
            AM,

            /// <remarks />
            AN,

            /// <remarks />
            AO,

            /// <remarks />
            AQ,

            /// <remarks />
            AR,

            /// <remarks />
            AS,

            /// <remarks />
            AT,

            /// <remarks />
            RE,

            /// <remarks />
            AU,

            /// <remarks />
            AW,

            /// <remarks />
            AX,

            /// <remarks />
            AZ,

            /// <remarks />
            RO,

            /// <remarks />
            BA,

            /// <remarks />
            BB,

            /// <remarks />
            RS,

            /// <remarks />
            BD,

            /// <remarks />
            BE,

            /// <remarks />
            RU,

            /// <remarks />
            BF,

            /// <remarks />
            BG,

            /// <remarks />
            RW,

            /// <remarks />
            BH,

            /// <remarks />
            BI,

            /// <remarks />
            BJ,

            /// <remarks />
            BL,

            /// <remarks />
            BM,

            /// <remarks />
            BN,

            /// <remarks />
            BO,

            /// <remarks />
            SA,

            /// <remarks />
            SB,

            /// <remarks />
            BQ,

            /// <remarks />
            BR,

            /// <remarks />
            SC,

            /// <remarks />
            BS,

            /// <remarks />
            SD,

            /// <remarks />
            BT,

            /// <remarks />
            SE,

            /// <remarks />
            BV,

            /// <remarks />
            SG,

            /// <remarks />
            BW,

            /// <remarks />
            SH,

            /// <remarks />
            SI,

            /// <remarks />
            BY,

            /// <remarks />
            SJ,

            /// <remarks />
            BZ,

            /// <remarks />
            SK,

            /// <remarks />
            SL,

            /// <remarks />
            SM,

            /// <remarks />
            SN,

            /// <remarks />
            SO,

            /// <remarks />
            CA,

            /// <remarks />
            SR,

            /// <remarks />
            CC,

            /// <remarks />
            SS,

            /// <remarks />
            CD,

            /// <remarks />
            ST,

            /// <remarks />
            CF,

            /// <remarks />
            SV,

            /// <remarks />
            CG,

            /// <remarks />
            CH,

            /// <remarks />
            SX,

            /// <remarks />
            CI,

            /// <remarks />
            SY,

            /// <remarks />
            SZ,

            /// <remarks />
            CK,

            /// <remarks />
            CL,

            /// <remarks />
            CM,

            /// <remarks />
            CN,

            /// <remarks />
            CO,

            /// <remarks />
            TA,

            /// <remarks />
            CR,

            /// <remarks />
            TC,

            /// <remarks />
            TD,

            /// <remarks />
            CS,

            /// <remarks />
            CU,

            /// <remarks />
            TF,

            /// <remarks />
            CV,

            /// <remarks />
            TG,

            /// <remarks />
            TH,

            /// <remarks />
            CW,

            /// <remarks />
            CX,

            /// <remarks />
            CY,

            /// <remarks />
            TJ,

            /// <remarks />
            CZ,

            /// <remarks />
            TK,

            /// <remarks />
            TL,

            /// <remarks />
            TM,

            /// <remarks />
            TN,

            /// <remarks />
            TO,

            /// <remarks />
            TP,

            /// <remarks />
            TR,

            /// <remarks />
            TT,

            /// <remarks />
            DE,

            /// <remarks />
            TV,

            /// <remarks />
            TW,

            /// <remarks />
            DJ,

            /// <remarks />
            TZ,

            /// <remarks />
            DK,

            /// <remarks />
            DM,

            /// <remarks />
            DO,

            /// <remarks />
            UA,

            /// <remarks />
            UG,

            /// <remarks />
            DZ,

            /// <remarks />
            UK,

            /// <remarks />
            UM,

            /// <remarks />
            EC,

            /// <remarks />
            US,

            /// <remarks />
            EE,

            /// <remarks />
            EG,

            /// <remarks />
            EH,

            /// <remarks />
            UY,

            /// <remarks />
            UZ,

            /// <remarks />
            VA,

            /// <remarks />
            ER,

            /// <remarks />
            VC,

            /// <remarks />
            ES,

            /// <remarks />
            ET,

            /// <remarks />
            VE,

            /// <remarks />
            VG,

            /// <remarks />
            VI,

            /// <remarks />
            VN,

            /// <remarks />
            VU,

            /// <remarks />
            FI,

            /// <remarks />
            FJ,

            /// <remarks />
            FK,

            /// <remarks />
            FM,

            /// <remarks />
            FO,

            /// <remarks />
            FR,

            /// <remarks />
            WD,

            /// <remarks />
            WF,

            /// <remarks />
            GA,

            /// <remarks />
            GB,

            /// <remarks />
            WS,

            /// <remarks />
            GD,

            /// <remarks />
            GE,

            /// <remarks />
            GF,

            /// <remarks />
            GG,

            /// <remarks />
            GH,

            /// <remarks />
            GI,

            /// <remarks />
            WZ,

            /// <remarks />
            GL,

            /// <remarks />
            GM,

            /// <remarks />
            GN,

            /// <remarks />
            GP,

            /// <remarks />
            GQ,

            /// <remarks />
            XB,

            /// <remarks />
            GR,

            /// <remarks />
            XC,

            /// <remarks />
            GS,

            /// <remarks />
            GT,

            /// <remarks />
            XE,

            /// <remarks />
            GU,

            /// <remarks />
            GW,

            /// <remarks />
            GY,

            /// <remarks />
            XK,

            /// <remarks />
            XM,

            /// <remarks />
            XN,

            /// <remarks />
            XY,

            /// <remarks />
            HK,

            /// <remarks />
            HM,

            /// <remarks />
            HN,

            /// <remarks />
            HR,

            /// <remarks />
            HT,

            /// <remarks />
            YE,

            /// <remarks />
            HU,

            /// <remarks />
            IC,

            /// <remarks />
            ID,

            /// <remarks />
            YT,

            /// <remarks />
            IE,

            /// <remarks />
            YU,

            /// <remarks />
            IL,

            /// <remarks />
            IM,

            /// <remarks />
            IN,

            /// <remarks />
            IO,

            /// <remarks />
            ZA,

            /// <remarks />
            IQ,

            /// <remarks />
            IR,

            /// <remarks />
            IS,

            /// <remarks />
            IT,

            /// <remarks />
            ZM,

            /// <remarks />
            ZR,

            /// <remarks />
            JE,

            /// <remarks />
            ZW,

            /// <remarks />
            JM,

            /// <remarks />
            JO,

            /// <remarks />
            JP,

            /// <remarks />
            unknown,

            /// <remarks />
            KE,

            /// <remarks />
            KG,

            /// <remarks />
            KH,

            /// <remarks />
            KI,

            /// <remarks />
            KM,

            /// <remarks />
            KN,

            /// <remarks />
            KP,

            /// <remarks />
            KR,

            /// <remarks />
            KW,

            /// <remarks />
            KY,

            /// <remarks />
            KZ,

            /// <remarks />
            LA,

            /// <remarks />
            LB,

            /// <remarks />
            LC,

            /// <remarks />
            LI,

            /// <remarks />
            LK,

            /// <remarks />
            LR,

            /// <remarks />
            LS,

            /// <remarks />
            LT,

            /// <remarks />
            LU,

            /// <remarks />
            LV,

            /// <remarks />
            LY,

            /// <remarks />
            MA,

            /// <remarks />
            MC,

            /// <remarks />
            MD,

            /// <remarks />
            ME,

            /// <remarks />
            MF,

            /// <remarks />
            MG,

            /// <remarks />
            MH,

            /// <remarks />
            MK,

            /// <remarks />
            ML,

            /// <remarks />
            MM,

            /// <remarks />
            MN,

            /// <remarks />
            MO,

            /// <remarks />
            MP,

            /// <remarks />
            MQ,

            /// <remarks />
            MR,

            /// <remarks />
            MS,

            /// <remarks />
            MT,

            /// <remarks />
            MU,

            /// <remarks />
            MV,

            /// <remarks />
            MW,

            /// <remarks />
            MX,

            /// <remarks />
            MY,

            /// <remarks />
            MZ,

            /// <remarks />
            NA,

            /// <remarks />
            NC,

            /// <remarks />
            NE,

            /// <remarks />
            NF,

            /// <remarks />
            NG,

            /// <remarks />
            NI,

            /// <remarks />
            NL,

            /// <remarks />
            NO,

            /// <remarks />
            NP,

            /// <remarks />
            NR,

            /// <remarks />
            NU,

            /// <remarks />
            NZ,

            /// <remarks />
            OM,

            /// <remarks />
            PA,

            /// <remarks />
            PE,

            /// <remarks />
            PF,

            /// <remarks />
            PG,

            /// <remarks />
            PH,

            /// <remarks />
            PK,

            /// <remarks />
            PL,

            /// <remarks />
            PM,

            /// <remarks />
            PN
        }

        /// <remarks />
        public enum CountUnit
        {
            /// <remarks />
            count,

            /// <remarks />
            roll,

            /// <remarks />
            can,

            /// <remarks />
            piece,

            /// <remarks />
            pair,

            /// <remarks />
            bag,

            /// <remarks />
            box,

            /// <remarks />
            sheet,

            /// <remarks />
            bottle
        }

        /// <remarks />
        public enum CurrentUnitOfMeasure
        {
            /// <remarks />
            mA,

            /// <remarks />
            A,

            /// <remarks />
            amps,

            /// <remarks />
            picoamps,

            /// <remarks />
            microamps,

            /// <remarks />
            milliamps,

            /// <remarks />
            kiloamps,

            /// <remarks />
            nanoamps
        }

        /// <remarks />
        public enum CustomerReturnPolicyType
        {
            /// <remarks />
            collectible,

            /// <remarks />
            restocking_fee,

            /// <remarks />
            standard,

            /// <remarks />
            non_returnable,

            /// <remarks />
            seasonal,

            /// <remarks />
            unknown
        }

        /// <remarks />
        public enum CycleLengthUnitOfMeasure
        {
            /// <remarks />
            CM,

            /// <remarks />
            IN
        }

        /// <remarks />
        public enum DataTransferUnitOfMeasure
        {
            /// <remarks />
            KHz,

            /// <remarks />
            MHz,

            /// <remarks />
            GHz,

            /// <remarks />
            Mbps,

            /// <remarks />
            Gbps
        }

        /// <remarks />
        public enum DateUnitOfMeasure
        {
            /// <remarks />
            days,

            /// <remarks />
            weeks,

            /// <remarks />
            months,

            /// <remarks />
            years
        }

        /// <remarks />
        public enum DegreeUnitOfMeasure
        {
            /// <remarks />
            degrees,

            /// <remarks />
            microradian,

            /// <remarks />
            arc_minute,

            /// <remarks />
            arc_sec,

            /// <remarks />
            milliradian,

            /// <remarks />
            radians,

            /// <remarks />
            turns,

            /// <remarks />
            revolutions
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum DeliveryChannel
        {
            /// <remarks />
            in_store,

            /// <remarks />
            direct_ship
        }

        /// <remarks />
        public enum DensityUnitOfMeasure
        {
            /// <remarks />
            grams_per_square_meter
        }

        /// <remarks />
        public enum DistributionDesignationValues
        {
            /// <remarks />
            jp_parallel_import
        }

        /// <remarks />
        public enum DockingStationExternalInterfaceTypeValues
        {
            /// <remarks />
            firewire_1600,

            /// <remarks />
            firewire_3200,

            /// <remarks />
            firewire_400,

            /// <remarks />
            firewire_800,

            /// <remarks />
            firewire_esata,

            /// <remarks />
            [XmlEnum("usb1.0")] usb10,

            /// <remarks />
            [XmlEnum("usb1.1")] usb11,

            /// <remarks />
            [XmlEnum("usb2.0")] usb20,

            /// <remarks />
            [XmlEnum("usb3.0")] usb30
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum EmailAddressTypePreferredFormat
        {
            /// <remarks />
            TextOnly,

            /// <remarks />
            HTML
        }

        /// <remarks />
        public enum EnergyConsumptionUnitOfMeasure
        {
            /// <remarks />
            kilowatt_hours,

            /// <remarks />
            btu,

            /// <remarks />
            kilowatts,

            /// <remarks />
            watt_hours,

            /// <remarks />
            btus,

            /// <remarks />
            cubic_meters,

            /// <remarks />
            cubic_feet,

            /// <remarks />
            joules,

            /// <remarks />
            milliamp_hours,

            /// <remarks />
            milliampere_hour,

            /// <remarks />
            milliampere_second
        }

        /// <remarks />
        public enum EnergyLabelEfficiencyClass
        {
            /// <remarks />
            a,

            /// <remarks />
            b,

            /// <remarks />
            c,

            /// <remarks />
            d,

            /// <remarks />
            e,

            /// <remarks />
            f,

            /// <remarks />
            g,

            /// <remarks />
            a_plus,

            /// <remarks />
            a_plus_plus,

            /// <remarks />
            a_plus_plus_plus
        }

        /// <remarks />
        public enum EnergyUnitOfMeasure
        {
            /// <remarks />
            BTU,

            /// <remarks />
            watts,

            /// <remarks />
            joules,

            /// <remarks />
            kilojoules
        }

        /// <remarks />
        public enum EuAcousticNoiseValue
        {
            /// <remarks />
            [XmlEnum("1")] Item1,

            /// <remarks />
            [XmlEnum("2")] Item2,

            /// <remarks />
            [XmlEnum("3")] Item3
        }

        /// <remarks />
        public enum FocalLengthDimension
        {
            /// <remarks />
            MM,

            /// <remarks />
            CM,

            /// <remarks />
            M,

            /// <remarks />
            meters,

            /// <remarks />
            centimeters,

            /// <remarks />
            millimeters,

            /// <remarks />
            angstrom
        }

        /// <remarks />
        public enum ForceUnitOfMeasure
        {
            /// <remarks />
            newtons,

            /// <remarks />
            Newton,

            /// <remarks />
            pounds,

            /// <remarks />
            kilograms,

            /// <remarks />
            PSI
        }

        /// <remarks />
        public enum FrequencyUnitOfMeasure
        {
            /// <remarks />
            pages_per_minute,

            /// <remarks />
            hertz,

            /// <remarks />
            millihertz,

            /// <remarks />
            microhertz,

            /// <remarks />
            terahertz,

            /// <remarks />
            Hz,

            /// <remarks />
            KHz,

            /// <remarks />
            MHz,

            /// <remarks />
            GHz
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum FulfillmentMethod
        {
            /// <remarks />
            Ship,

            /// <remarks />
            InStorePickup,

            /// <remarks />
            MerchantDelivery
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum FulfillmentServiceLevel
        {
            /// <remarks />
            Standard,

            /// <remarks />
            Expedited,

            /// <remarks />
            Scheduled,

            /// <remarks />
            NextDay,

            /// <remarks />
            SecondDay,

            /// <remarks />
            Next,

            /// <remarks />
            Second,

            /// <remarks />
            Priority
        }

        /// <remarks />
        public enum FulfillReadiness
        {
            /// <remarks />
            drop_ship_ready,

            /// <remarks />
            not_ready,

            /// <remarks />
            receive_ready,

            /// <remarks />
            exception_receive_ready,

            /// <remarks />
            po_ready,

            /// <remarks />
            unknown
        }

        /// <remarks />
        public enum GdprRiskType
        {
            /// <remarks />
            manufacturer_website_registration,

            /// <remarks />
            no_electronic_information_stored,

            /// <remarks />
            user_setting_information_storage,

            /// <remarks />
            pin_or_biometric_recognition_lock,

            /// <remarks />
            cloud_account_connectivity,

            /// <remarks />
            physical_or_cloud_data_storage
        }

        /// <remarks />
        public enum GenericUnit
        {
            /// <remarks />
            kilograms,

            /// <remarks />
            grams,

            /// <remarks />
            milligrams,

            /// <remarks />
            ounces,

            /// <remarks />
            pounds,

            /// <remarks />
            inches,

            /// <remarks />
            feet,

            /// <remarks />
            meters,

            /// <remarks />
            centimeters,

            /// <remarks />
            millimeters,

            /// <remarks />
            square_meters,

            /// <remarks />
            square_centimeters,

            /// <remarks />
            square_feet,

            /// <remarks />
            square_inches,

            /// <remarks />
            gallons,

            /// <remarks />
            pints,

            /// <remarks />
            quarts,

            /// <remarks />
            fluid_ounces,

            /// <remarks />
            liters,

            /// <remarks />
            cubic_meters,

            /// <remarks />
            cubic_feet,

            /// <remarks />
            cubic_inches,

            /// <remarks />
            cubic_centimeters
        }

        /// <remarks />
        public enum GiftCardsFormatType
        {
            /// <remarks />
            email_gift_cards,

            /// <remarks />
            plastic_gift_cards,

            /// <remarks />
            print_at_home,

            /// <remarks />
            multi_pack,

            /// <remarks />
            facebook,

            /// <remarks />
            gift_box
        }

        /// <remarks />
        public enum GlobalCurrencyCode
        {
            /// <remarks />
            AED,

            /// <remarks />
            ALL,

            /// <remarks />
            ARS,

            /// <remarks />
            ATS,

            /// <remarks />
            AUD,

            /// <remarks />
            BAM,

            /// <remarks />
            BEF,

            /// <remarks />
            BGN,

            /// <remarks />
            BHD,

            /// <remarks />
            BOB,

            /// <remarks />
            BRL,

            /// <remarks />
            BYR,

            /// <remarks />
            CAD,

            /// <remarks />
            CHF,

            /// <remarks />
            CLP,

            /// <remarks />
            CNY,

            /// <remarks />
            COP,

            /// <remarks />
            CRC,

            /// <remarks />
            CSD,

            /// <remarks />
            CZK,

            /// <remarks />
            DEM,

            /// <remarks />
            DKK,

            /// <remarks />
            DOP,

            /// <remarks />
            DZD,

            /// <remarks />
            EEK,

            /// <remarks />
            EGP,

            /// <remarks />
            ESP,

            /// <remarks />
            EUR,

            /// <remarks />
            FIM,

            /// <remarks />
            FRF,

            /// <remarks />
            GBP,

            /// <remarks />
            GRD,

            /// <remarks />
            GTQ,

            /// <remarks />
            HKD,

            /// <remarks />
            HNL,

            /// <remarks />
            HRK,

            /// <remarks />
            HUF,

            /// <remarks />
            IDR,

            /// <remarks />
            ILS,

            /// <remarks />
            INR,

            /// <remarks />
            IQD,

            /// <remarks />
            ISK,

            /// <remarks />
            ITL,

            /// <remarks />
            JOD,

            /// <remarks />
            JPY,

            /// <remarks />
            KRW,

            /// <remarks />
            KWD,

            /// <remarks />
            LBP,

            /// <remarks />
            LTL,

            /// <remarks />
            LUF,

            /// <remarks />
            LVL,

            /// <remarks />
            LYD,

            /// <remarks />
            MAD,

            /// <remarks />
            MKD,

            /// <remarks />
            MXN,

            /// <remarks />
            MYR,

            /// <remarks />
            NIO,

            /// <remarks />
            NOK,

            /// <remarks />
            NZD,

            /// <remarks />
            OMR,

            /// <remarks />
            PAB,

            /// <remarks />
            PEN,

            /// <remarks />
            PHP,

            /// <remarks />
            PLN,

            /// <remarks />
            PTE,

            /// <remarks />
            PYG,

            /// <remarks />
            QAR,

            /// <remarks />
            RON,

            /// <remarks />
            RSD,

            /// <remarks />
            RUB,

            /// <remarks />
            SAR,

            /// <remarks />
            SDG,

            /// <remarks />
            SEK,

            /// <remarks />
            SGD,

            /// <remarks />
            SKK,

            /// <remarks />
            SVC,

            /// <remarks />
            SYP,

            /// <remarks />
            THB,

            /// <remarks />
            TND,

            /// <remarks />
            TRY,

            /// <remarks />
            TWD,

            /// <remarks />
            UAH,

            /// <remarks />
            USD,

            /// <remarks />
            UYU,

            /// <remarks />
            VEF,

            /// <remarks />
            VND,

            /// <remarks />
            YER,

            /// <remarks />
            ZAR
        }

        /// <remarks />
        public enum GraphicsRAMTypeValues
        {
            /// <remarks />
            [XmlEnum("72_pin_edo_simm")] Item72_pin_edo_simm,

            /// <remarks />
            ddr2_sdram,

            /// <remarks />
            ddr3_sdram,

            /// <remarks />
            ddr4_sdram,

            /// <remarks />
            ddr5_sdram,

            /// <remarks />
            ddr_dram,

            /// <remarks />
            ddr_sdram,

            /// <remarks />
            dimm,

            /// <remarks />
            dram,

            /// <remarks />
            edo_dram,

            /// <remarks />
            eeprom,

            /// <remarks />
            eprom,

            /// <remarks />
            fpm_dram,

            /// <remarks />
            fpm_ram,

            /// <remarks />
            gddr3,

            /// <remarks />
            gddr4,

            /// <remarks />
            gddr5,

            /// <remarks />
            l2_cache,

            /// <remarks />
            micro_dimm,

            /// <remarks />
            pc2_4200,

            /// <remarks />
            pc2_4300,

            /// <remarks />
            pc2_5300,

            /// <remarks />
            pc2_5400,

            /// <remarks />
            pc2_6000,

            /// <remarks />
            pc_100_sdram,

            /// <remarks />
            pc_1066,

            /// <remarks />
            pc_133_sdram,

            /// <remarks />
            pc_1600,

            /// <remarks />
            pc_2100_ddr,

            /// <remarks />
            pc_2700_ddr,

            /// <remarks />
            pc_3000,

            /// <remarks />
            pc_3200_ddr,

            /// <remarks />
            pc_3500_ddr,

            /// <remarks />
            pc_3700,

            /// <remarks />
            pc_4000_ddr,

            /// <remarks />
            pc_4200,

            /// <remarks />
            pc_4300,

            /// <remarks />
            pc_4400,

            /// <remarks />
            pc_66_sdram,

            /// <remarks />
            pc_800,

            /// <remarks />
            rambus,

            /// <remarks />
            rdram,

            /// <remarks />
            rimm,

            /// <remarks />
            sdram,

            /// <remarks />
            sgram,

            /// <remarks />
            shared,

            /// <remarks />
            simm,

            /// <remarks />
            sipp,

            /// <remarks />
            sldram,

            /// <remarks />
            sodimm,

            /// <remarks />
            sorimm,

            /// <remarks />
            sram,

            /// <remarks />
            unknown,

            /// <remarks />
            vram,

            /// <remarks />
            wram
        }

        /// <remarks />
        public enum HardDriveInterfaceTypeValues
        {
            /// <remarks />
            ata,

            /// <remarks />
            ata100,

            /// <remarks />
            ata133,

            /// <remarks />
            ata_2,

            /// <remarks />
            ata_3,

            /// <remarks />
            ata_4,

            /// <remarks />
            ata_5,

            /// <remarks />
            atapi,

            /// <remarks />
            dma,

            /// <remarks />
            eide,

            /// <remarks />
            eio,

            /// <remarks />
            esata,

            /// <remarks />
            esdi,

            /// <remarks />
            ethernet,

            /// <remarks />
            ethernet_100base_t,

            /// <remarks />
            ethernet_100base_tx,

            /// <remarks />
            ethernet_10_100_1000,

            /// <remarks />
            ethernet_10base_t,

            /// <remarks />
            fast_scsi,

            /// <remarks />
            fast_wide_scsi,

            /// <remarks />
            fata,

            /// <remarks />
            fc_al,

            /// <remarks />
            fc_al_2,

            /// <remarks />
            fdd,

            /// <remarks />
            fibre_channel,

            /// <remarks />
            firewire,

            /// <remarks />
            ide,

            /// <remarks />
            ieee_1284,

            /// <remarks />
            ieee_1394b,

            /// <remarks />
            iscsi,

            /// <remarks />
            lvds,

            /// <remarks />
            pc_card,

            /// <remarks />
            pci_express_x16,

            /// <remarks />
            pci_express_x4,

            /// <remarks />
            pci_express_x8,

            /// <remarks />
            raid,

            /// <remarks />
            scsi,

            /// <remarks />
            serial_ata,

            /// <remarks />
            serial_ata150,

            /// <remarks />
            serial_ata300,

            /// <remarks />
            serial_ata600,

            /// <remarks />
            serial_scsi,

            /// <remarks />
            solid_state,

            /// <remarks />
            ssa,

            /// <remarks />
            st412,

            /// <remarks />
            ultra2_scsi,

            /// <remarks />
            ultra2_wide_scsi,

            /// <remarks />
            ultra3_scsi,

            /// <remarks />
            ultra_160_scsi,

            /// <remarks />
            ultra_320_scsi,

            /// <remarks />
            ultra_ata,

            /// <remarks />
            ultra_scsi,

            /// <remarks />
            ultra_wide_scsi,

            /// <remarks />
            unknown,

            /// <remarks />
            usb,

            /// <remarks />
            [XmlEnum("usb_1.1")] usb_11,

            /// <remarks />
            [XmlEnum("usb_2.0")] usb_20,

            /// <remarks />
            [XmlEnum("usb_2.0_3.0")] usb_20_30,

            /// <remarks />
            [XmlEnum("usb_3.0")] usb_30
        }

        /// <remarks />
        public enum HardnessUnitOfMeasure
        {
            /// <remarks />
            brinnell,

            /// <remarks />
            vickers,

            /// <remarks />
            rockwell_a,

            /// <remarks />
            rockwell_b,

            /// <remarks />
            rockwell_c,

            /// <remarks />
            rockwell_d,

            /// <remarks />
            shore_a,

            /// <remarks />
            shore_b,

            /// <remarks />
            shore_c,

            /// <remarks />
            shore_d,

            /// <remarks />
            shore_do,

            /// <remarks />
            shore_e,

            /// <remarks />
            shore_m,

            /// <remarks />
            shore_o,

            /// <remarks />
            shore_oo,

            /// <remarks />
            shore_ooo,

            /// <remarks />
            shore_ooo_s
        }

        /// <remarks />
        public enum HardwareInterfaceValues
        {
            /// <remarks />
            [XmlEnum("1_4_inch_audio")] Item1_4_inch_audio,

            /// <remarks />
            [XmlEnum("2_5_mm_audio")] Item2_5_mm_audio,

            /// <remarks />
            [XmlEnum("3.0_v_ttl")] Item30_v_ttl,

            /// <remarks />
            [XmlEnum("3_5_floppy")] Item3_5_floppy,

            /// <remarks />
            [XmlEnum("3_5_mm_audio")] Item3_5_mm_audio,

            /// <remarks />
            ata,

            /// <remarks />
            ata_flash_card,

            /// <remarks />
            audio_video_port,

            /// <remarks />
            bluetooth,

            /// <remarks />
            built_in_flash_memory,

            /// <remarks />
            [XmlEnum("cd-r")] cdr,

            /// <remarks />
            cd_rw,

            /// <remarks />
            cdr_drive,

            /// <remarks />
            compact_disc,

            /// <remarks />
            compact_flash_card,

            /// <remarks />
            compact_flash_type_i_or_ii,

            /// <remarks />
            compactflash_type_i,

            /// <remarks />
            compactflash_type_ii,

            /// <remarks />
            component_video,

            /// <remarks />
            composite_video,

            /// <remarks />
            d_sub,

            /// <remarks />
            dmi,

            /// <remarks />
            dssi,

            /// <remarks />
            dvd_r,

            /// <remarks />
            dvd_rw,

            /// <remarks />
            dvi_x_1,

            /// <remarks />
            dvi_x_2,

            /// <remarks />
            dvi_x_4,

            /// <remarks />
            eide,

            /// <remarks />
            eisa,

            /// <remarks />
            ethernet,

            /// <remarks />
            express_card,

            /// <remarks />
            fibre_channel,

            /// <remarks />
            firewire_1600,

            /// <remarks />
            firewire_3200,

            /// <remarks />
            firewire_400,

            /// <remarks />
            firewire_800,

            /// <remarks />
            firewire_esata,

            /// <remarks />
            game_port,

            /// <remarks />
            gbic,

            /// <remarks />
            hdmi,

            /// <remarks />
            headphone,

            /// <remarks />
            hp_hsc,

            /// <remarks />
            hp_pb,

            /// <remarks />
            hs_mmc,

            /// <remarks />
            ibm_microdrive,

            /// <remarks />
            ide,

            /// <remarks />
            ieee_1284,

            /// <remarks />
            infrared,

            /// <remarks />
            internal_w_removable_media,

            /// <remarks />
            iomega_clik_disk,

            /// <remarks />
            isa,

            /// <remarks />
            isp,

            /// <remarks />
            lanc,

            /// <remarks />
            mca,

            /// <remarks />
            media_card,

            /// <remarks />
            memory_stick,

            /// <remarks />
            memory_stick_duo,

            /// <remarks />
            memory_stick_micro,

            /// <remarks />
            memory_stick_pro,

            /// <remarks />
            memory_stick_pro_duo,

            /// <remarks />
            memory_stick_pro_hg_duo,

            /// <remarks />
            memory_stick_select,

            /// <remarks />
            memory_stick_xc,

            /// <remarks />
            memory_stick_xc_hg_micro,

            /// <remarks />
            memory_stick_xc_micro,

            /// <remarks />
            micard,

            /// <remarks />
            micro_sdhc,

            /// <remarks />
            micro_sdxc,

            /// <remarks />
            microsd,

            /// <remarks />
            mini_dvd,

            /// <remarks />
            mini_hdmi,

            /// <remarks />
            mini_pci,

            /// <remarks />
            mini_sdhc,

            /// <remarks />
            mini_sdxc,

            /// <remarks />
            minisd,

            /// <remarks />
            mmc_micro,

            /// <remarks />
            multimedia_card,

            /// <remarks />
            multimedia_card_mobile,

            /// <remarks />
            multimedia_card_plus,

            /// <remarks />
            multipronged_audio,

            /// <remarks />
            nubus,

            /// <remarks />
            parallel_interface,

            /// <remarks />
            pc_card,

            /// <remarks />
            pci,

            /// <remarks />
            pci_64,

            /// <remarks />
            pci_64_hot_plug,

            /// <remarks />
            pci_64_hot_plug_33_mhz,

            /// <remarks />
            pci_64_hot_plug_66_mhz,

            /// <remarks />
            pci_express_x4,

            /// <remarks />
            pci_express_x8,

            /// <remarks />
            pci_hot_plug,

            /// <remarks />
            pci_raid,

            /// <remarks />
            pci_x,

            /// <remarks />
            pci_x_1,

            /// <remarks />
            pci_x_100_mhz,

            /// <remarks />
            pci_x_16,

            /// <remarks />
            pci_x_16_gb,

            /// <remarks />
            pci_x_4,

            /// <remarks />
            pci_x_66_mhz,

            /// <remarks />
            pci_x_8,

            /// <remarks />
            pci_x_hot_plug,

            /// <remarks />
            pci_x_hot_plug_133_mhz,

            /// <remarks />
            pcmcia,

            /// <remarks />
            pcmcia_ii,

            /// <remarks />
            pcmcia_iii,

            /// <remarks />
            pictbridge,

            /// <remarks />
            [XmlEnum("ps/2")] ps2,

            /// <remarks />
            radio_frequency,

            /// <remarks />
            rs_mmc,

            /// <remarks />
            s_video,

            /// <remarks />
            sas,

            /// <remarks />
            sata_1_5_gb,

            /// <remarks />
            sata_3_0_gb,

            /// <remarks />
            sata_6_0_gb,

            /// <remarks />
            sbus,

            /// <remarks />
            scsi,

            /// <remarks />
            sdhc,

            /// <remarks />
            sdio,

            /// <remarks />
            sdxc,

            /// <remarks />
            secure_digital,

            /// <remarks />
            secure_mmc,

            /// <remarks />
            serial_interface,

            /// <remarks />
            sim_card,

            /// <remarks />
            smartmedia_card,

            /// <remarks />
            solid_state_drive,

            /// <remarks />
            spd,

            /// <remarks />
            springboard_module,

            /// <remarks />
            ssfdc,

            /// <remarks />
            superdisk,

            /// <remarks />
            transflash,

            /// <remarks />
            unknown,

            /// <remarks />
            usb,

            /// <remarks />
            [XmlEnum("usb1.0")] usb10,

            /// <remarks />
            [XmlEnum("usb1.1")] usb11,

            /// <remarks />
            [XmlEnum("usb2.0")] usb20,

            /// <remarks />
            [XmlEnum("usb3.0")] usb30,

            /// <remarks />
            usb_docking_station,

            /// <remarks />
            usb_streaming,

            /// <remarks />
            vga,

            /// <remarks />
            xd_picture_card,

            /// <remarks />
            xd_picture_card_h,

            /// <remarks />
            xd_picture_card_m,

            /// <remarks />
            xd_picture_card_m_plus,

            /// <remarks />
            ieee_1394,

            /// <remarks />
            pci_x_133_mhz
        }

        /// <remarks />
        public enum HazmatItemType
        {
            /// <remarks />
            butane,

            /// <remarks />
            fuel_cell,

            /// <remarks />
            gasoline,

            /// <remarks />
            orm_d_class_1,

            /// <remarks />
            orm_d_class_2,

            /// <remarks />
            orm_d_class_3,

            /// <remarks />
            orm_d_class_4,

            /// <remarks />
            orm_d_class_5,

            /// <remarks />
            orm_d_class_6,

            /// <remarks />
            orm_d_class_7,

            /// <remarks />
            orm_d_class_8,

            /// <remarks />
            orm_d_class_9,

            /// <remarks />
            sealed_lead_acid_battery,

            /// <remarks />
            unknown
        }

        /// <remarks />
        public enum HumanInterfaceInputType
        {
            /// <remarks />
            buttons,

            /// <remarks />
            dial,

            /// <remarks />
            handwriting_recognition,

            /// <remarks />
            keyboard,

            /// <remarks />
            keypad,

            /// <remarks />
            keypad_stroke,

            /// <remarks />
            [XmlEnum("keypad_stroke")] keypad_stroke1,

            /// <remarks />
            microphone,

            /// <remarks />
            touch_screen,

            /// <remarks />
            touch_screen_stylus_pen,

            /// <remarks />
            trackpoint_pointing_device
        }

        /// <remarks />
        public enum HumanInterfaceOutputType
        {
            /// <remarks />
            screen,

            /// <remarks />
            speaker
        }

        /// <remarks />
        public enum IdentityPackageType
        {
            /// <remarks />
            bulk,

            /// <remarks />
            frustration_free,

            /// <remarks />
            traditional
        }

        /// <remarks />
        public enum IsSourcingOnDemandValues
        {
            /// <remarks />
            yes,

            /// <remarks />
            no
        }

        /// <remarks />
        [XmlType(IncludeInSchema = false)]
        public enum ItemChoiceType
        {
            /// <remarks />
            PreviousPrice,

            /// <remarks />
            Price
        }

        /// <remarks />
        public enum JewelryLengthUnitOfMeasure
        {
            /// <remarks />
            MM,

            /// <remarks />
            CM,

            /// <remarks />
            IN
        }

        /// <remarks />
        public enum JewelryWeightUnitOfMeasure
        {
            /// <remarks />
            GR,

            /// <remarks />
            KG,

            /// <remarks />
            OZ,

            /// <remarks />
            LB,

            /// <remarks />
            CARATS,

            /// <remarks />
            DWT
        }

        /// <remarks />
        public enum LanguageStringType
        {
            /// <remarks />
            Abkhazian,

            /// <remarks />
            Adygei,

            /// <remarks />
            Afar,

            /// <remarks />
            Afrikaans,

            /// <remarks />
            Albanian,

            /// <remarks />
            Alsatian,

            /// <remarks />
            Amharic,

            /// <remarks />
            Arabic,

            /// <remarks />
            Aramaic,

            /// <remarks />
            Armenian,

            /// <remarks />
            Assamese,

            /// <remarks />
            Aymara,

            /// <remarks />
            Azerbaijani,

            /// <remarks />
            Bambara,

            /// <remarks />
            Bashkir,

            /// <remarks />
            Basque,

            /// <remarks />
            Bengali,

            /// <remarks />
            Berber,

            /// <remarks />
            Bhutani,

            /// <remarks />
            Bihari,

            /// <remarks />
            Bislama,

            /// <remarks />
            Breton,

            /// <remarks />
            Bulgarian,

            /// <remarks />
            Burmese,

            /// <remarks />
            Buryat,

            /// <remarks />
            Byelorussian,

            /// <remarks />
            CantoneseChinese,

            /// <remarks />
            Castillian,

            /// <remarks />
            Catalan,

            /// <remarks />
            Cayuga,

            /// <remarks />
            Cheyenne,

            /// <remarks />
            Chinese,

            /// <remarks />
            ClassicalNewari,

            /// <remarks />
            Cornish,

            /// <remarks />
            Corsican,

            /// <remarks />
            Creole,

            /// <remarks />
            CrimeanTatar,

            /// <remarks />
            Croatian,

            /// <remarks />
            Czech,

            /// <remarks />
            Danish,

            /// <remarks />
            Dargwa,

            /// <remarks />
            Dutch,

            /// <remarks />
            English,

            /// <remarks />
            Esperanto,

            /// <remarks />
            Estonian,

            /// <remarks />
            Faroese,

            /// <remarks />
            Farsi,

            /// <remarks />
            Fiji,

            /// <remarks />
            Filipino,

            /// <remarks />
            Finnish,

            /// <remarks />
            Flemish,

            /// <remarks />
            French,

            /// <remarks />
            FrenchCanadian,

            /// <remarks />
            Frisian,

            /// <remarks />
            Galician,

            /// <remarks />
            Georgian,

            /// <remarks />
            German,

            /// <remarks />
            Gibberish,

            /// <remarks />
            Greek,

            /// <remarks />
            Greenlandic,

            /// <remarks />
            Guarani,

            /// <remarks />
            Gujarati,

            /// <remarks />
            Gullah,

            /// <remarks />
            Hausa,

            /// <remarks />
            Hawaiian,

            /// <remarks />
            Hebrew,

            /// <remarks />
            Hindi,

            /// <remarks />
            Hmong,

            /// <remarks />
            Hungarian,

            /// <remarks />
            Icelandic,

            /// <remarks />
            IndoEuropean,

            /// <remarks />
            Indonesian,

            /// <remarks />
            Ingush,

            /// <remarks />
            Interlingua,

            /// <remarks />
            Interlingue,

            /// <remarks />
            Inuktitun,

            /// <remarks />
            Inuktitut,

            /// <remarks />
            Inupiak,

            /// <remarks />
            Inupiaq,

            /// <remarks />
            Irish,

            /// <remarks />
            Italian,

            /// <remarks />
            Japanese,

            /// <remarks />
            Javanese,

            /// <remarks />
            Kalaallisut,

            /// <remarks />
            Kalmyk,

            /// <remarks />
            Kannada,

            /// <remarks />
            KarachayBalkar,

            /// <remarks />
            Kashmiri,

            /// <remarks />
            Kashubian,

            /// <remarks />
            Kazakh,

            /// <remarks />
            Khmer,

            /// <remarks />
            Kinyarwanda,

            /// <remarks />
            Kirghiz,

            /// <remarks />
            Kirundi,

            /// <remarks />
            Klingon,

            /// <remarks />
            Korean,

            /// <remarks />
            Kurdish,

            /// <remarks />
            Ladino,

            /// <remarks />
            Lao,

            /// <remarks />
            Lapp,

            /// <remarks />
            Latin,

            /// <remarks />
            Latvian,

            /// <remarks />
            Lingala,

            /// <remarks />
            Lithuanian,

            /// <remarks />
            Lojban,

            /// <remarks />
            LowerSorbian,

            /// <remarks />
            Macedonian,

            /// <remarks />
            Malagasy,

            /// <remarks />
            Malay,

            /// <remarks />
            Malayalam,

            /// <remarks />
            Maltese,

            /// <remarks />
            MandarinChinese,

            /// <remarks />
            Maori,

            /// <remarks />
            Marathi,

            /// <remarks />
            Mende,

            /// <remarks />
            MiddleEnglish,

            /// <remarks />
            Mirandese,

            /// <remarks />
            Moksha,

            /// <remarks />
            Moldavian,

            /// <remarks />
            Mongo,

            /// <remarks />
            Mongolian,

            /// <remarks />
            Multilingual,

            /// <remarks />
            Nauru,

            /// <remarks />
            Navaho,

            /// <remarks />
            Nepali,

            /// <remarks />
            Nogai,

            /// <remarks />
            Norwegian,

            /// <remarks />
            Occitan,

            /// <remarks />
            OldEnglish,

            /// <remarks />
            Oriya,

            /// <remarks />
            Oromo,

            /// <remarks />
            Pashto,

            /// <remarks />
            Persian,

            /// <remarks />
            PigLatin,

            /// <remarks />
            Polish,

            /// <remarks />
            Portuguese,

            /// <remarks />
            Punjabi,

            /// <remarks />
            Quechua,

            /// <remarks />
            Romance,

            /// <remarks />
            Romanian,

            /// <remarks />
            Romany,

            /// <remarks />
            Russian,

            /// <remarks />
            Samaritan,

            /// <remarks />
            Samoan,

            /// <remarks />
            Sangho,

            /// <remarks />
            Sanskrit,

            /// <remarks />
            Serbian,

            /// <remarks />
            [XmlEnum("Serbo-Croatian")] SerboCroatian,

            /// <remarks />
            Sesotho,

            /// <remarks />
            Setswana,

            /// <remarks />
            Shona,

            /// <remarks />
            SichuanYi,

            /// <remarks />
            Sicilian,

            /// <remarks />
            SignLanguage,

            /// <remarks />
            Sindhi,

            /// <remarks />
            Sinhalese,

            /// <remarks />
            Siswati,

            /// <remarks />
            Slavic,

            /// <remarks />
            Slovak,

            /// <remarks />
            Slovakian,

            /// <remarks />
            Slovene,

            /// <remarks />
            Somali,

            /// <remarks />
            Spanish,

            /// <remarks />
            Sumerian,

            /// <remarks />
            Sundanese,

            /// <remarks />
            Swahili,

            /// <remarks />
            Swedish,

            /// <remarks />
            SwissGerman,

            /// <remarks />
            Syriac,

            /// <remarks />
            Tagalog,

            /// <remarks />
            TaiwaneseChinese,

            /// <remarks />
            Tajik,

            /// <remarks />
            Tamil,

            /// <remarks />
            Tatar,

            /// <remarks />
            Telugu,

            /// <remarks />
            Thai,

            /// <remarks />
            Tibetan,

            /// <remarks />
            Tigrinya,

            /// <remarks />
            Tonga,

            /// <remarks />
            Tsonga,

            /// <remarks />
            Turkish,

            /// <remarks />
            Turkmen,

            /// <remarks />
            Twi,

            /// <remarks />
            Udmurt,

            /// <remarks />
            Uighur,

            /// <remarks />
            Ukrainian,

            /// <remarks />
            Ukranian,

            /// <remarks />
            Unknown,

            /// <remarks />
            Urdu,

            /// <remarks />
            Uzbek,

            /// <remarks />
            Vietnamese,

            /// <remarks />
            Volapuk,

            /// <remarks />
            Welsh,

            /// <remarks />
            Wolof,

            /// <remarks />
            Xhosa,

            /// <remarks />
            Yiddish,

            /// <remarks />
            Yoruba,

            /// <remarks />
            Zhuang,

            /// <remarks />
            Zulu
        }

        /// <remarks />
        public enum LanguageSWVG
        {
            /// <remarks />
            adygei,

            /// <remarks />
            afrikaans,

            /// <remarks />
            albanian,

            /// <remarks />
            alsatian,

            /// <remarks />
            amharic,

            /// <remarks />
            arabic,

            /// <remarks />
            armenian,

            /// <remarks />
            assamese,

            /// <remarks />
            bambara,

            /// <remarks />
            basque,

            /// <remarks />
            bengali,

            /// <remarks />
            berber,

            /// <remarks />
            breton,

            /// <remarks />
            bulgarian,

            /// <remarks />
            buryat,

            /// <remarks />
            cantonese_chinese,

            /// <remarks />
            castillian,

            /// <remarks />
            catalan,

            /// <remarks />
            cayuga,

            /// <remarks />
            cheyenne,

            /// <remarks />
            chinese,

            /// <remarks />
            classical_newari,

            /// <remarks />
            cornish,

            /// <remarks />
            corsican,

            /// <remarks />
            creole,

            /// <remarks />
            crimean_tatar,

            /// <remarks />
            croatian,

            /// <remarks />
            czech,

            /// <remarks />
            danish,

            /// <remarks />
            dargwa,

            /// <remarks />
            dutch,

            /// <remarks />
            english,

            /// <remarks />
            esperanto,

            /// <remarks />
            estonian,

            /// <remarks />
            farsi,

            /// <remarks />
            filipino,

            /// <remarks />
            finnish,

            /// <remarks />
            flemish,

            /// <remarks />
            french,

            /// <remarks />
            french_canadian,

            /// <remarks />
            georgian,

            /// <remarks />
            german,

            /// <remarks />
            gibberish,

            /// <remarks />
            greek,

            /// <remarks />
            gujarati,

            /// <remarks />
            gullah,

            /// <remarks />
            hausa,

            /// <remarks />
            hawaiian,

            /// <remarks />
            hebrew,

            /// <remarks />
            hindi,

            /// <remarks />
            hmong,

            /// <remarks />
            hungarian,

            /// <remarks />
            icelandic,

            /// <remarks />
            indo_european,

            /// <remarks />
            indonesian,

            /// <remarks />
            ingush,

            /// <remarks />
            inuktitun,

            /// <remarks />
            inuktitut,

            /// <remarks />
            inupiaq,

            /// <remarks />
            irish,

            /// <remarks />
            italian,

            /// <remarks />
            japanese,

            /// <remarks />
            kalaallisut,

            /// <remarks />
            kalmyk,

            /// <remarks />
            karachay_balkar,

            /// <remarks />
            kashubian,

            /// <remarks />
            kazakh,

            /// <remarks />
            khmer,

            /// <remarks />
            klingon,

            /// <remarks />
            korean,

            /// <remarks />
            kurdish,

            /// <remarks />
            ladino,

            /// <remarks />
            lao,

            /// <remarks />
            lapp,

            /// <remarks />
            latin,

            /// <remarks />
            lithuanian,

            /// <remarks />
            lojban,

            /// <remarks />
            lower_sorbian,

            /// <remarks />
            macedonian,

            /// <remarks />
            malagasy,

            /// <remarks />
            malay,

            /// <remarks />
            malayalam,

            /// <remarks />
            maltese,

            /// <remarks />
            mandarin_chinese,

            /// <remarks />
            maori,

            /// <remarks />
            mende,

            /// <remarks />
            middle_english,

            /// <remarks />
            mirandese,

            /// <remarks />
            moksha,

            /// <remarks />
            mongo,

            /// <remarks />
            mongolian,

            /// <remarks />
            multilingual,

            /// <remarks />
            navaho,

            /// <remarks />
            nogai,

            /// <remarks />
            norwegian,

            /// <remarks />
            old_english,

            /// <remarks />
            persian,

            /// <remarks />
            pig_latin,

            /// <remarks />
            polish,

            /// <remarks />
            portuguese,

            /// <remarks />
            romance,

            /// <remarks />
            romanian,

            /// <remarks />
            romany,

            /// <remarks />
            russian,

            /// <remarks />
            samaritan,

            /// <remarks />
            sanskrit,

            /// <remarks />
            serbian,

            /// <remarks />
            [XmlEnum("serbo-croatian")] serbocroatian,

            /// <remarks />
            sichuan_yi,

            /// <remarks />
            sicilian,

            /// <remarks />
            sign_language,

            /// <remarks />
            slavic,

            /// <remarks />
            slovak,

            /// <remarks />
            slovene,

            /// <remarks />
            somali,

            /// <remarks />
            spanish,

            /// <remarks />
            sumerian,

            /// <remarks />
            swahili,

            /// <remarks />
            swedish,

            /// <remarks />
            swiss_german,

            /// <remarks />
            tagalog,

            /// <remarks />
            taiwanese_chinese,

            /// <remarks />
            tamil,

            /// <remarks />
            thai,

            /// <remarks />
            tibetan,

            /// <remarks />
            turkish,

            /// <remarks />
            udmurt,

            /// <remarks />
            ukrainian,

            /// <remarks />
            unknown,

            /// <remarks />
            urdu,

            /// <remarks />
            vietnamese,

            /// <remarks />
            welsh,

            /// <remarks />
            wolof,

            /// <remarks />
            xhosa,

            /// <remarks />
            yiddish,

            /// <remarks />
            zulu
        }

        /// <remarks />
        public enum LanguageValues
        {
            /// <remarks />
            german,

            /// <remarks />
            aragonese,

            /// <remarks />
            sidamo,

            /// <remarks />
            altaic_languages,

            /// <remarks />
            luo,

            /// <remarks />
            papuan_languages,

            /// <remarks />
            khotanese,

            /// <remarks />
            kinyarwanda,

            /// <remarks />
            elamite,

            /// <remarks />
            hausa,

            /// <remarks />
            dutch,

            /// <remarks />
            old_french,

            /// <remarks />
            classical_syriac,

            /// <remarks />
            flemish,

            /// <remarks />
            kokborok,

            /// <remarks />
            songhai_languages,

            /// <remarks />
            nepali,

            /// <remarks />
            makasar,

            /// <remarks />
            ancient_greek,

            /// <remarks />
            sardinian,

            /// <remarks />
            niger_kordofanian_languages,

            /// <remarks />
            chinook_jargon,

            /// <remarks />
            cayuga,

            /// <remarks />
            castillian,

            /// <remarks />
            old_irish,

            /// <remarks />
            persian,

            /// <remarks />
            aleut,

            /// <remarks />
            jula,

            /// <remarks />
            siksika,

            /// <remarks />
            pohnpeian,

            /// <remarks />
            nzima,

            /// <remarks />
            chiricahua,

            /// <remarks />
            siswati,

            /// <remarks />
            sumerian,

            /// <remarks />
            north_american_indian_languages,

            /// <remarks />
            pidgin_english,

            /// <remarks />
            minangkabau,

            /// <remarks />
            dravidian_languages,

            /// <remarks />
            gorontalo,

            /// <remarks />
            slovak,

            /// <remarks />
            hebrew,

            /// <remarks />
            sasak,

            /// <remarks />
            northern_sami,

            /// <remarks />
            ekajuk,

            /// <remarks />
            chechen,

            /// <remarks />
            selkup,

            /// <remarks />
            kirundi,

            /// <remarks />
            braj,

            /// <remarks />
            celtic_languages,

            /// <remarks />
            bengali,

            /// <remarks />
            azerbaijani,

            /// <remarks />
            upper_sorbian,

            /// <remarks />
            sorbian_languages,

            /// <remarks />
            scots,

            /// <remarks />
            afrikaans,

            /// <remarks />
            sami,

            /// <remarks />
            umbundu,

            /// <remarks />
            australian_languages,

            /// <remarks />
            assyrian,

            /// <remarks />
            navaho,

            /// <remarks />
            khoisan_languages,

            /// <remarks />
            chamic_languages,

            /// <remarks />
            lithuanian,

            /// <remarks />
            bambara,

            /// <remarks />
            vietnamese,

            /// <remarks />
            bini,

            /// <remarks />
            maltese,

            /// <remarks />
            slave_athapascan,

            /// <remarks />
            mandar,

            /// <remarks />
            susu,

            /// <remarks />
            lule_sami,

            /// <remarks />
            apache_languages,

            /// <remarks />
            artificial_languages,

            /// <remarks />
            algonquian_languages,

            /// <remarks />
            bikol,

            /// <remarks />
            sanskrit,

            /// <remarks />
            tuvinian,

            /// <remarks />
            bihari,

            /// <remarks />
            wakashan_languages,

            /// <remarks />
            gaelic_scots,

            /// <remarks />
            tatar,

            /// <remarks />
            luba_katanga,

            /// <remarks />
            kumyk,

            /// <remarks />
            welsh,

            /// <remarks />
            chinese,

            /// <remarks />
            japanese,

            /// <remarks />
            beja,

            /// <remarks />
            norwegian_bokmal,

            /// <remarks />
            tzeltal,

            /// <remarks />
            tiv,

            /// <remarks />
            angika,

            /// <remarks />
            scots_gaelic,

            /// <remarks />
            garo,

            /// <remarks />
            otomian_languages,

            /// <remarks />
            north_ndebele,

            /// <remarks />
            dhivehi,

            /// <remarks />
            aramaic,

            /// <remarks />
            rarotongan,

            /// <remarks />
            setswana,

            /// <remarks />
            kanuri,

            /// <remarks />
            mon_khmer_languages,

            /// <remarks />
            haryanvi,

            /// <remarks />
            zaza,

            /// <remarks />
            lushai,

            /// <remarks />
            ijo_languages,

            /// <remarks />
            zande_languages,

            /// <remarks />
            indic,

            /// <remarks />
            sandawe,

            /// <remarks />
            fon,

            /// <remarks />
            ndonga,

            /// <remarks />
            xhosa,

            /// <remarks />
            judeo_persian,

            /// <remarks />
            taiwanese_chinese,

            /// <remarks />
            karen_languages,

            /// <remarks />
            bribri,

            /// <remarks />
            marathi,

            /// <remarks />
            sinhalese,

            /// <remarks />
            inuktitut,

            /// <remarks />
            tigre,

            /// <remarks />
            slovene,

            /// <remarks />
            choctaw,

            /// <remarks />
            ga,

            /// <remarks />
            northern_frisian,

            /// <remarks />
            yugoslavian,

            /// <remarks />
            mirandese,

            /// <remarks />
            nauru,

            /// <remarks />
            spanish,

            /// <remarks />
            somali,

            /// <remarks />
            dakota,

            /// <remarks />
            syriac,

            /// <remarks />
            french_canadian,

            /// <remarks />
            lower_sorbian,

            /// <remarks />
            punjabi,

            /// <remarks />
            inari_sami,

            /// <remarks />
            gwichin,

            /// <remarks />
            inuktitun,

            /// <remarks />
            erzya,

            /// <remarks />
            cushitic_languages,

            /// <remarks />
            kikuyu,

            /// <remarks />
            quechua,

            /// <remarks />
            nilo_saharan_languages,

            /// <remarks />
            sino_tibetan,

            /// <remarks />
            kalaallisut,

            /// <remarks />
            asturian,

            /// <remarks />
            romance,

            /// <remarks />
            pampanga,

            /// <remarks />
            fanti,

            /// <remarks />
            bislama,

            /// <remarks />
            bahasa,

            /// <remarks />
            aromanian,

            /// <remarks />
            madurese,

            /// <remarks />
            pedi,

            /// <remarks />
            norwegian,

            /// <remarks />
            herero,

            /// <remarks />
            yoruba,

            /// <remarks />
            ottoman_turkish,

            /// <remarks />
            latin,

            /// <remarks />
            middle_english,

            /// <remarks />
            gilbertese,

            /// <remarks />
            french,

            /// <remarks />
            georgian,

            /// <remarks />
            portuguese_brazilian,

            /// <remarks />
            old_provencal,

            /// <remarks />
            tamashek,

            /// <remarks />
            serbian,

            /// <remarks />
            marshallese,

            /// <remarks />
            kru_languages,

            /// <remarks />
            kashubian,

            /// <remarks />
            chhattisgarhi,

            /// <remarks />
            kosraean,

            /// <remarks />
            hindi,

            /// <remarks />
            esperanto,

            /// <remarks />
            kazakh,

            /// <remarks />
            gayo,

            /// <remarks />
            afghan_pashtu,

            /// <remarks />
            rapanui,

            /// <remarks />
            ewondo,

            /// <remarks />
            egyptian,

            /// <remarks />
            gibberish,

            /// <remarks />
            khmer,

            /// <remarks />
            banda_languages,

            /// <remarks />
            hungarian,

            /// <remarks />
            moksha,

            /// <remarks />
            creek,

            /// <remarks />
            luiseno,

            /// <remarks />
            karelian,

            /// <remarks />
            greenlandic,

            /// <remarks />
            samoan,

            /// <remarks />
            romansch,

            /// <remarks />
            berber,

            /// <remarks />
            cree,

            /// <remarks />
            gothic,

            /// <remarks />
            nyamwezi,

            /// <remarks />
            magahi,

            /// <remarks />
            shona,

            /// <remarks />
            lunda,

            /// <remarks />
            uzbek,

            /// <remarks />
            arawak,

            /// <remarks />
            friulian,

            /// <remarks />
            fiji,

            /// <remarks />
            turkmen,

            /// <remarks />
            old_persian,

            /// <remarks />
            shan,

            /// <remarks />
            latvian,

            /// <remarks />
            old_english,

            /// <remarks />
            tsonga,

            /// <remarks />
            faroese,

            /// <remarks />
            votic,

            /// <remarks />
            ossetian,

            /// <remarks />
            iroquoian_languages,

            /// <remarks />
            yupik_languages,

            /// <remarks />
            dargwa,

            /// <remarks />
            papiamento,

            /// <remarks />
            phoenician,

            /// <remarks />
            mandingo,

            /// <remarks />
            delaware,

            /// <remarks />
            low_german,

            /// <remarks />
            lao,

            /// <remarks />
            mongolian,

            /// <remarks />
            telugu,

            /// <remarks />
            abkhazian,

            /// <remarks />
            chagatai,

            /// <remarks />
            achinese,

            /// <remarks />
            udmurt,

            /// <remarks />
            siouan_languages,

            /// <remarks />
            malagasy,

            /// <remarks />
            pashto,

            /// <remarks />
            thai,

            /// <remarks />
            efik,

            /// <remarks />
            luxembourgish,

            /// <remarks />
            bodo,

            /// <remarks />
            gbaya,

            /// <remarks />
            kara_kalpak,

            /// <remarks />
            eastern_frisian,

            /// <remarks />
            nepal_bhasa,

            /// <remarks />
            malay,

            /// <remarks />
            germanic_languages,

            /// <remarks />
            tsimshian,

            /// <remarks />
            hokkien,

            /// <remarks />
            adangme,

            /// <remarks />
            dogri,

            /// <remarks />
            lamba,

            /// <remarks />
            sogdian,

            /// <remarks />
            scandanavian_languages,

            /// <remarks />
            middle_french,

            /// <remarks />
            afrihili,

            /// <remarks />
            estonian,

            /// <remarks />
            sichuan_yi,

            /// <remarks />
            portuguese_creole,

            /// <remarks />
            igbo,

            /// <remarks />
            awadhi,

            /// <remarks />
            ukranian,

            /// <remarks />
            interlingua,

            /// <remarks />
            gahrwali,

            /// <remarks />
            mizo,

            /// <remarks />
            interlingue,

            /// <remarks />
            cantonese_chinese,

            /// <remarks />
            albanian,

            /// <remarks />
            italian,

            /// <remarks />
            adygei,

            /// <remarks />
            korean,

            /// <remarks />
            khasi,

            /// <remarks />
            tupi_languages,

            /// <remarks />
            lojban,

            /// <remarks />
            ewe,

            /// <remarks />
            gullah,

            /// <remarks />
            simplified_chinese,

            /// <remarks />
            prakrit_languages,

            /// <remarks />
            akan,

            /// <remarks />
            kashmiri,

            /// <remarks />
            bosnian,

            /// <remarks />
            klingon,

            /// <remarks />
            tai_languages,

            /// <remarks />
            dzongkha,

            /// <remarks />
            belgian,

            /// <remarks />
            manipuri,

            /// <remarks />
            lapp,

            /// <remarks />
            guarani,

            /// <remarks />
            valencian,

            /// <remarks />
            sangho,

            /// <remarks />
            yapese,

            /// <remarks />
            zuni,

            /// <remarks />
            kuanyama,

            /// <remarks />
            bhutani,

            /// <remarks />
            english,

            /// <remarks />
            sign_language,

            /// <remarks />
            czech,

            /// <remarks />
            hawaiian,

            /// <remarks />
            south_ndebele,

            /// <remarks />
            palauan,

            /// <remarks />
            geez,

            /// <remarks />
            austronesian,

            /// <remarks />
            tahitian,

            /// <remarks />
            ladino,

            /// <remarks />
            dinka,

            /// <remarks />
            komi,

            /// <remarks />
            bhojpuri,

            /// <remarks />
            old_norse,

            /// <remarks />
            walloon,

            /// <remarks />
            central_american_indian_languages,

            /// <remarks />
            javanese,

            /// <remarks />
            belarusian,

            /// <remarks />
            tibetan,

            /// <remarks />
            zulu,

            /// <remarks />
            cherokee,

            /// <remarks />
            swahili,

            /// <remarks />
            iranian_languages,

            /// <remarks />
            himachali_languages,

            /// <remarks />
            oriya,

            /// <remarks />
            galibi_carib,

            /// <remarks />
            middle_irish,

            /// <remarks />
            icelandic,

            /// <remarks />
            classical_newari,

            /// <remarks />
            baltic_languages,

            /// <remarks />
            kamba,

            /// <remarks />
            twi,

            /// <remarks />
            afro_asiatic_languages,

            /// <remarks />
            gujarati,

            /// <remarks />
            nyankole,

            /// <remarks />
            baluchi,

            /// <remarks />
            uighur,

            /// <remarks />
            occitan,

            /// <remarks />
            pangasinan,

            /// <remarks />
            semitic_languages,

            /// <remarks />
            sundanese,

            /// <remarks />
            nko,

            /// <remarks />
            tamil,

            /// <remarks />
            gondi,

            /// <remarks />
            judeo_arabic,

            /// <remarks />
            arapaho,

            /// <remarks />
            micmac,

            /// <remarks />
            mohawk,

            /// <remarks />
            yao,

            /// <remarks />
            sranan_tongo,

            /// <remarks />
            farsi,

            /// <remarks />
            bliss,

            /// <remarks />
            gallegan,

            /// <remarks />
            buryat,

            /// <remarks />
            manx,

            /// <remarks />
            tagalog,

            /// <remarks />
            assamese,

            /// <remarks />
            kurukh,

            /// <remarks />
            swiss_german,

            /// <remarks />
            scandinavian_languages,

            /// <remarks />
            old_high_german,

            /// <remarks />
            mandarin_chinese,

            /// <remarks />
            polish,

            /// <remarks />
            kabyle,

            /// <remarks />
            galician,

            /// <remarks />
            mayan,

            /// <remarks />
            ukrainian,

            /// <remarks />
            bamileke_languages,

            /// <remarks />
            zenaga,

            /// <remarks />
            kalmyk,

            /// <remarks />
            ojibwa,

            /// <remarks />
            tereno,

            /// <remarks />
            karachay_balkar,

            /// <remarks />
            yakut,

            /// <remarks />
            filipino,

            /// <remarks />
            rajasthani,

            /// <remarks />
            aymara,

            /// <remarks />
            kawi,

            /// <remarks />
            manchu,

            /// <remarks />
            traditional_chinese,

            /// <remarks />
            romanian,

            /// <remarks />
            limburgan,

            /// <remarks />
            southern_sami,

            /// <remarks />
            burmese,

            /// <remarks />
            armenian,

            /// <remarks />
            breton,

            /// <remarks />
            hmong,

            /// <remarks />
            indo_european,

            /// <remarks />
            middle_high_german,

            /// <remarks />
            ido,

            /// <remarks />
            sindhi,

            /// <remarks />
            bulgarian,

            /// <remarks />
            neapolitan,

            /// <remarks />
            kachin,

            /// <remarks />
            dogrib,

            /// <remarks />
            moldavian,

            /// <remarks />
            mongo,

            /// <remarks />
            blin,

            /// <remarks />
            ugaritic,

            /// <remarks />
            hiri_motu,

            /// <remarks />
            soninke,

            /// <remarks />
            tok_pisin,

            /// <remarks />
            osage,

            /// <remarks />
            romany,

            /// <remarks />
            byelorussian,

            /// <remarks />
            maharati,

            /// <remarks />
            duala,

            /// <remarks />
            american_sign_language,

            /// <remarks />
            marwari,

            /// <remarks />
            sicilian,

            /// <remarks />
            akkadian,

            /// <remarks />
            timne,

            /// <remarks />
            tumbuka,

            /// <remarks />
            greek,

            /// <remarks />
            basa,

            /// <remarks />
            kabardian,

            /// <remarks />
            southern_sotho,

            /// <remarks />
            haida,

            /// <remarks />
            basque,

            /// <remarks />
            chipewyan,

            /// <remarks />
            [XmlEnum("serbo-croatian")] serbocroatian,

            /// <remarks />
            finnish,

            /// <remarks />
            venda,

            /// <remarks />
            avaric,

            /// <remarks />
            croatian,

            /// <remarks />
            hittite,

            /// <remarks />
            southern_altai,

            /// <remarks />
            salishan_languages,

            /// <remarks />
            mari,

            /// <remarks />
            mende,

            /// <remarks />
            nahuatl,

            /// <remarks />
            haitian,

            /// <remarks />
            maori,

            /// <remarks />
            sukuma,

            /// <remarks />
            corsican,

            /// <remarks />
            ingush,

            /// <remarks />
            nyoro,

            /// <remarks />
            washo,

            /// <remarks />
            none,

            /// <remarks />
            romansh,

            /// <remarks />
            inupiaq,

            /// <remarks />
            mossi,

            /// <remarks />
            buginese,

            /// <remarks />
            pali,

            /// <remarks />
            inupiak,

            /// <remarks />
            nias,

            /// <remarks />
            vai,

            /// <remarks />
            kumaoni,

            /// <remarks />
            russian,

            /// <remarks />
            chichewa,

            /// <remarks />
            lahnda,

            /// <remarks />
            nogai,

            /// <remarks />
            french_creole,

            /// <remarks />
            iban,

            /// <remarks />
            manobo_languages,

            /// <remarks />
            nubian_languages,

            /// <remarks />
            pig_latin,

            /// <remarks />
            cornish,

            /// <remarks />
            walamo,

            /// <remarks />
            afar,

            /// <remarks />
            yiddish,

            /// <remarks />
            bantu,

            /// <remarks />
            avestan,

            /// <remarks />
            grebo,

            /// <remarks />
            irish,

            /// <remarks />
            kannada,

            /// <remarks />
            niuean,

            /// <remarks />
            acoli,

            /// <remarks />
            unknown,

            /// <remarks />
            norwegian_nynorsk,

            /// <remarks />
            arabic,

            /// <remarks />
            dari,

            /// <remarks />
            multilingual,

            /// <remarks />
            indonesian,

            /// <remarks />
            danish,

            /// <remarks />
            philippine_languages,

            /// <remarks />
            chamorro,

            /// <remarks />
            tetum,

            /// <remarks />
            tonga_nyasa,

            /// <remarks />
            lingala,

            /// <remarks />
            zhuang,

            /// <remarks />
            batak,

            /// <remarks />
            zapotec,

            /// <remarks />
            caddo,

            /// <remarks />
            catalan,

            /// <remarks />
            cebuano,

            /// <remarks />
            skolt_sami,

            /// <remarks />
            kirghiz,

            /// <remarks />
            munda_languages,

            /// <remarks />
            old_slavonic,

            /// <remarks />
            ganda,

            /// <remarks />
            serer,

            /// <remarks />
            lezghian,

            /// <remarks />
            tlingit,

            /// <remarks />
            hupa,

            /// <remarks />
            unqualified,

            /// <remarks />
            provencal,

            /// <remarks />
            chuukese,

            /// <remarks />
            cambodian,

            /// <remarks />
            caucasian_languages,

            /// <remarks />
            slovakian,

            /// <remarks />
            waray,

            /// <remarks />
            fang,

            /// <remarks />
            swedish,

            /// <remarks />
            maithili,

            /// <remarks />
            alsatian,

            /// <remarks />
            kutenai,

            /// <remarks />
            wolof,

            /// <remarks />
            bashkir,

            /// <remarks />
            luba_lulua,

            /// <remarks />
            fulah,

            /// <remarks />
            kpelle,

            /// <remarks />
            slavic,

            /// <remarks />
            kurdish,

            /// <remarks />
            turkish,

            /// <remarks />
            cheyenne,

            /// <remarks />
            macedonian,

            /// <remarks />
            tokelau,

            /// <remarks />
            tigrinya,

            /// <remarks />
            santali,

            /// <remarks />
            crimean_tatar,

            /// <remarks />
            south_american_indian,

            /// <remarks />
            lozi,

            /// <remarks />
            ainu,

            /// <remarks />
            sesotho,

            /// <remarks />
            mapudungun,

            /// <remarks />
            athapascan_languages,

            /// <remarks />
            coptic,

            /// <remarks />
            pahlavi,

            /// <remarks />
            malayalam,

            /// <remarks />
            chuvash,

            /// <remarks />
            urdu,

            /// <remarks />
            land_dayak_languages,

            /// <remarks />
            portuguese,

            /// <remarks />
            latin_spanish,

            /// <remarks />
            bemba,

            /// <remarks />
            oromo,

            /// <remarks />
            frisian,

            /// <remarks />
            amharic,

            /// <remarks />
            kongo,

            /// <remarks />
            chibcha,

            /// <remarks />
            masai,

            /// <remarks />
            iloko,

            /// <remarks />
            hiligaynon,

            /// <remarks />
            finno_ugrian,

            /// <remarks />
            tuvalu,

            /// <remarks />
            tajik,

            /// <remarks />
            volapuk,

            /// <remarks />
            balinese,

            /// <remarks />
            kimbundu,

            /// <remarks />
            creole,

            /// <remarks />
            middle_dutch,

            /// <remarks />
            tonga,

            /// <remarks />
            tulu,

            /// <remarks />
            samaritan,

            /// <remarks />
            konkani
        }

        /// <remarks />
        public enum LengthUnitOfMeasure
        {
            /// <remarks />
            MM,

            /// <remarks />
            CM,

            /// <remarks />
            M,

            /// <remarks />
            IN,

            /// <remarks />
            FT,

            /// <remarks />
            inches,

            /// <remarks />
            feet,

            /// <remarks />
            meters,

            /// <remarks />
            decimeters,

            /// <remarks />
            centimeters,

            /// <remarks />
            millimeters,

            /// <remarks />
            micrometers,

            /// <remarks />
            nanometers,

            /// <remarks />
            picometers,

            /// <remarks />
            hundredths_inches,

            /// <remarks />
            yards,

            /// <remarks />
            angstrom,

            /// <remarks />
            mils,

            /// <remarks />
            miles
        }

        /// <remarks />
        public enum LithiumBatteryPackagingType
        {
            /// <remarks />
            batteries_contained_in_equipment,

            /// <remarks />
            batteries_only,

            /// <remarks />
            batteries_packed_with_equipment
        }

        /// <remarks />
        public enum LuminanceUnitOfMeasure
        {
            /// <remarks />
            lumens
        }

        /// <remarks />
        public enum LuminousIntensityUnitOfMeasure
        {
            /// <remarks />
            candela
        }

        /// <remarks />
        public enum MagnificationUnitOfMeasure
        {
            /// <remarks />
            multiplier_x,

            /// <remarks />
            diopters
        }

        /// <remarks />
        public enum MaximumPowerUnitOfMeasure
        {
            /// <remarks />
            W,

            /// <remarks />
            KW
        }

        /// <remarks />
        public enum MemorySizeUnitOfMeasure
        {
            /// <remarks />
            TB,

            /// <remarks />
            GB,

            /// <remarks />
            MB,

            /// <remarks />
            KB,

            /// <remarks />
            KO,

            /// <remarks />
            MO,

            /// <remarks />
            GO,

            /// <remarks />
            TO,

            /// <remarks />
            bytes
        }

        /// <remarks />
        public enum MillimeterUnitOfMeasure
        {
            /// <remarks />
            millimeters
        }

        /// <remarks />
        public enum ModemTypeValues
        {
            /// <remarks />
            analog_modem,

            /// <remarks />
            data_fax_voice,

            /// <remarks />
            isdn_modem,

            /// <remarks />
            cable,

            /// <remarks />
            data_modem,

            /// <remarks />
            network_modem,

            /// <remarks />
            cellular,

            /// <remarks />
            digital,

            /// <remarks />
            unknown_modem_type,

            /// <remarks />
            csu,

            /// <remarks />
            dsl,

            /// <remarks />
            voice,

            /// <remarks />
            data_fax,

            /// <remarks />
            dsu,

            /// <remarks />
            winmodem
        }

        /// <remarks />
        public enum MusicFormatType
        {
            /// <remarks />
            authorized_bootleg,

            /// <remarks />
            bsides,

            /// <remarks />
            best_of,

            /// <remarks />
            box_set,

            /// <remarks />
            original_recording,

            /// <remarks />
            reissued,

            /// <remarks />
            remastered,

            /// <remarks />
            soundtrack,

            /// <remarks />
            special_edition,

            /// <remarks />
            special_limited_edition,

            /// <remarks />
            cast_recording,

            /// <remarks />
            compilation,

            /// <remarks />
            deluxe_edition,

            /// <remarks />
            digital_sound,

            /// <remarks />
            double_lp,

            /// <remarks />
            explicit_lyrics,

            /// <remarks />
            [XmlEnum("hi-fidelity")] hifidelity,

            /// <remarks />
            import,

            /// <remarks />
            limited_collectors_edition,

            /// <remarks />
            limited_edition,

            /// <remarks />
            remixes,

            /// <remarks />
            live,

            /// <remarks />
            extra_tracks,

            /// <remarks />
            cutout,

            /// <remarks />
            cd_and_dvd,

            /// <remarks />
            dual_disc,

            /// <remarks />
            hybrid_sacd,

            /// <remarks />
            [XmlEnum("cd-single")] cdsingle,

            /// <remarks />
            maxi_single,

            /// <remarks />
            sacd,

            /// <remarks />
            minidisc,

            /// <remarks />
            uk_import,

            /// <remarks />
            us_import,

            /// <remarks />
            jp_import,

            /// <remarks />
            enhanced,

            /// <remarks />
            clean,

            /// <remarks />
            copy_protected_cd,

            /// <remarks />
            [XmlEnum("double_lp")] double_lp1,

            /// <remarks />
            [XmlEnum("soundtrack")] soundtrack1,

            /// <remarks />
            [XmlEnum("cd-single")] cdsingle1,

            /// <remarks />
            [XmlEnum("remastered")] remastered1,

            /// <remarks />
            [XmlEnum("box_set")] box_set1,

            /// <remarks />
            double_cd,

            /// <remarks />
            karaoke,

            /// <remarks />
            [XmlEnum("limited_edition")] limited_edition1,

            /// <remarks />
            [XmlEnum("maxi_single")] maxi_single1,

            /// <remarks />
            mp3_audio,

            /// <remarks />
            ringle,

            /// <remarks />
            [XmlEnum("cd_and_dvd")] cd_and_dvd1,

            /// <remarks />
            shm_cd
        }

        /// <remarks />
        public enum NeckSizeUnitOfMeasure
        {
            /// <remarks />
            CM,

            /// <remarks />
            IN,

            /// <remarks />
            MM,

            /// <remarks />
            M,

            /// <remarks />
            FT
        }

        /// <remarks />
        public enum NicotineConcentrationUnitOfMeasure
        {
            /// <remarks />
            milligrams_per_milliliter
        }

        /// <remarks />
        public enum NoiseLevelUnitOfMeasure
        {
            /// <remarks />
            dBA,

            /// <remarks />
            decibels
        }

        /// <remarks />
        public enum OpticalPowerUnitOfMeasure
        {
            /// <remarks />
            diopters
        }

        /// <remarks />
        public enum OrganizationTaxRoles
        {
            /// <remarks />
            doctor,

            /// <remarks />
            dentist,

            /// <remarks />
            hospital,

            /// <remarks />
            clinic
        }

        /// <remarks />
        public enum Originality
        {
            /// <remarks />
            Original,

            /// <remarks />
            [XmlEnum("Original Limited Edition")] OriginalLimitedEdition,

            /// <remarks />
            Reproduced,

            /// <remarks />
            [XmlEnum("Reproduced Limited Edition")]
            ReproducedLimitedEdition,

            /// <remarks />
            Replica,

            /// <remarks />
            [XmlEnum("Replica Limited Edition")] ReplicaLimitedEdition,

            /// <remarks />
            [XmlEnum("Limited Edition")] LimitedEdition,

            /// <remarks />
            Manufactured,

            /// <remarks />
            Licensed,

            /// <remarks />
            Vintage
        }

        /// <remarks />
        public enum PEGIRatingType
        {
            /// <remarks />
            ages_3_and_over,

            /// <remarks />
            ages_7_and_over,

            /// <remarks />
            ages_12_and_over,

            /// <remarks />
            ages_16_and_over,

            /// <remarks />
            ages_18_and_over,

            /// <remarks />
            unknown
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum PhoneNumberTypeType
        {
            /// <remarks />
            Voice,

            /// <remarks />
            Fax
        }

        /// <remarks />
        public enum PixelUnitOfMeasure
        {
            /// <remarks />
            pixels,

            /// <remarks />
            MP
        }

        /// <remarks />
        public enum PowerPlugType
        {
            /// <remarks />
            type_a_2pin_jp,

            /// <remarks />
            type_e_2pin_fr,

            /// <remarks />
            type_j_3pin_ch,

            /// <remarks />
            type_a_2pin_na,

            /// <remarks />
            type_ef_2pin_eu,

            /// <remarks />
            type_k_3pin_dk,

            /// <remarks />
            type_b_3pin_jp,

            /// <remarks />
            type_f_2pin_de,

            /// <remarks />
            type_l_3pin_it,

            /// <remarks />
            type_b_3pin_na,

            /// <remarks />
            type_g_3pin_uk,

            /// <remarks />
            type_m_3pin_za,

            /// <remarks />
            type_c_2pin_eu,

            /// <remarks />
            type_h_3pin_il,

            /// <remarks />
            type_n_3pin_br,

            /// <remarks />
            type_d_3pin_in,

            /// <remarks />
            type_i_3pin_au
        }

        /// <remarks />
        public enum PowerUnitOfMeasure
        {
            /// <remarks />
            watts,

            /// <remarks />
            kilowatts,

            /// <remarks />
            horsepower,

            /// <remarks />
            [XmlEnum("watts-per-sec")] wattspersec
        }

        /// <remarks />
        public enum PressureUnitOfMeasure
        {
            /// <remarks />
            bars,

            /// <remarks />
            psi,

            /// <remarks />
            pascal
        }

        /// <remarks />
        public enum PricingStrategyValues
        {
            /// <remarks />
            bulk_by_uom,

            /// <remarks />
            catch_by_uom,

            /// <remarks />
            produce_by_uom,

            /// <remarks />
            produce_by_each
        }

        /// <remarks />
        public enum ProcessorTypeValues
        {
            /// <remarks />
            [XmlEnum("5x86")] Item5x86,

            /// <remarks />
            [XmlEnum("68000")] Item68000,

            /// <remarks />
            [XmlEnum("68030")] Item68030,

            /// <remarks />
            [XmlEnum("68040")] Item68040,

            /// <remarks />
            [XmlEnum("68328")] Item68328,

            /// <remarks />
            [XmlEnum("68882")] Item68882,

            /// <remarks />
            [XmlEnum("68ez328")] Item68ez328,

            /// <remarks />
            [XmlEnum("68lc040")] Item68lc040,

            /// <remarks />
            [XmlEnum("6x86")] Item6x86,

            /// <remarks />
            [XmlEnum("6x86mx")] Item6x86mx,

            /// <remarks />
            [XmlEnum("8031")] Item8031,

            /// <remarks />
            [XmlEnum("8032")] Item8032,

            /// <remarks />
            [XmlEnum("80386")] Item80386,

            /// <remarks />
            [XmlEnum("80486")] Item80486,

            /// <remarks />
            [XmlEnum("80486dx2")] Item80486dx2,

            /// <remarks />
            [XmlEnum("80486slc")] Item80486slc,

            /// <remarks />
            [XmlEnum("80486sx")] Item80486sx,

            /// <remarks />
            [XmlEnum("80c186")] Item80c186,

            /// <remarks />
            [XmlEnum("80c31")] Item80c31,

            /// <remarks />
            [XmlEnum("80c32")] Item80c32,

            /// <remarks />
            [XmlEnum("80c88")] Item80c88,

            /// <remarks />
            alpha_21064a,

            /// <remarks />
            alpha_21164,

            /// <remarks />
            alpha_21164a,

            /// <remarks />
            alpha_21264,

            /// <remarks />
            alpha_21264a,

            /// <remarks />
            alpha_21264b,

            /// <remarks />
            alpha_21264c,

            /// <remarks />
            alpha_21264d,

            /// <remarks />
            alpha_21364,

            /// <remarks />
            alpha_ev7,

            /// <remarks />
            amd_a_series,

            /// <remarks />
            amd_c_series,

            /// <remarks />
            amd_e_series,

            /// <remarks />
            amd_v_series,

            /// <remarks />
            arm610,

            /// <remarks />
            arm710,

            /// <remarks />
            arm_7100,

            /// <remarks />
            arm710a,

            /// <remarks />
            arm710t,

            /// <remarks />
            arm7500fe,

            /// <remarks />
            athlon,

            /// <remarks />
            Athlon_2650e,

            /// <remarks />
            Athlon_2850e,

            /// <remarks />
            athlon_4,

            /// <remarks />
            athlon_64,

            /// <remarks />
            Athlon_64_2650,

            /// <remarks />
            Athlon_64_3500,

            /// <remarks />
            Athlon_64_4200_plus,

            /// <remarks />
            Athlon_64_4800_plus,

            /// <remarks />
            athlon_64_for_dtr,

            /// <remarks />
            athlon_64_fx,

            /// <remarks />
            Athlon_64_Single_Core_TF_20,

            /// <remarks />
            Athlon_64_TF_36,

            /// <remarks />
            athlon_64_x2,

            /// <remarks />
            Athlon_64_X2_3600_plus,

            /// <remarks />
            Athlon_64_X2_4000_plus,

            /// <remarks />
            Athlon_64_X2_4200_plus,

            /// <remarks />
            Athlon_64_X2_4450B,

            /// <remarks />
            Athlon_64_X2_4800,

            /// <remarks />
            Athlon_64_X2_5000_plus,

            /// <remarks />
            Athlon_64_X2_5050,

            /// <remarks />
            Athlon_64_X2_5200_plus,

            /// <remarks />
            Athlon_64_X2_5400_plus,

            /// <remarks />
            Athlon_64_X2_5600_plus,

            /// <remarks />
            Athlon_64_X2_6000_plus,

            /// <remarks />
            Athlon_64_X2_6400_plus,

            /// <remarks />
            Athlon_64_X2_Dual_Core_3800_plus,

            /// <remarks />
            Athlon_64_X2_Dual_Core_4400,

            /// <remarks />
            Athlon_64_X2_Dual_Core_4450,

            /// <remarks />
            Athlon_64_X2_Dual_Core_L310,

            /// <remarks />
            Athlon_64_X2_Dual_Core_TK_42,

            /// <remarks />
            Athlon_64_X2_QL_64_Dual_Core,

            /// <remarks />
            Athlon_Dual_Core_QL62A,

            /// <remarks />
            Athlon_II,

            /// <remarks />
            Athlon_II_170u,

            /// <remarks />
            Athlon_II_Dual_Core_240e,

            /// <remarks />
            Athlon_II_Dual_Core_245,

            /// <remarks />
            Athlon_II_Dual_Core_260,

            /// <remarks />
            Athlon_II_Dual_Core_260u,

            /// <remarks />
            Athlon_II_Dual_Core_M320,

            /// <remarks />
            Athlon_II_Dual_Core_P320,

            /// <remarks />
            Athlon_II_Dual_Core_P360,

            /// <remarks />
            Athlon_II_Neo_Single_Core_K125,

            /// <remarks />
            Athlon_II_Neo_X2_Dual_Core_K325,

            /// <remarks />
            Athlon_II_Neo_X2_Dual_Core_K625,

            /// <remarks />
            Athlon_II_Single_Core_160u,

            /// <remarks />
            Athlon_II_X2_B24,

            /// <remarks />
            Athlon_II_X2_Dual_Core_170u,

            /// <remarks />
            Athlon_II_X2_Dual_Core_215,

            /// <remarks />
            Athlon_II_X2_Dual_Core_235e,

            /// <remarks />
            Athlon_II_X2_Dual_Core_240,

            /// <remarks />
            Athlon_II_X2_Dual_Core_240e,

            /// <remarks />
            Athlon_II_X2_Dual_Core_245,

            /// <remarks />
            Athlon_II_X2_Dual_Core_250,

            /// <remarks />
            Athlon_II_X2_Dual_Core_250U,

            /// <remarks />
            Athlon_II_X2_Dual_Core_255,

            /// <remarks />
            Athlon_II_X2_Dual_Core_3250e,

            /// <remarks />
            Athlon_II_X2_Dual_Core_M300,

            /// <remarks />
            Athlon_II_X2_Dual_Core_M320,

            /// <remarks />
            Athlon_II_X2_Dual_Core_M340,

            /// <remarks />
            Athlon_II_X2_Dual_Core_M520,

            /// <remarks />
            Athlon_II_X2_Dual_Core_P320,

            /// <remarks />
            Athlon_II_X2_Dual_Core_P340,

            /// <remarks />
            Athlon_II_X2_Dual_Core_P360,

            /// <remarks />
            Athlon_II_X2_Dual_Core_QL_60,

            /// <remarks />
            Athlon_II_X2_Dual_Core_QL_62,

            /// <remarks />
            Athlon_II_X2_Dual_Core_TK_53,

            /// <remarks />
            Athlon_II_X2_Dual_Core_TK_57,

            /// <remarks />
            athlon_ii_x3,

            /// <remarks />
            Athlon_II_X3_Triple_Core_400E,

            /// <remarks />
            Athlon_II_X3_Triple_Core_425,

            /// <remarks />
            Athlon_II_X3_Triple_Core_435,

            /// <remarks />
            athlon_ii_x4,

            /// <remarks />
            Athlon_II_X4_Dual_Core_240e,

            /// <remarks />
            Athlon_II_X4_Quad_Core,

            /// <remarks />
            Athlon_II_X4_Quad_Core_600E,

            /// <remarks />
            Athlon_II_X4_Quad_Core_605e,

            /// <remarks />
            Athlon_II_X4_Quad_Core_615e,

            /// <remarks />
            Athlon_II_X4_Quad_Core_620,

            /// <remarks />
            Athlon_II_X4_Quad_Core_630,

            /// <remarks />
            Athlon_II_X4_Quad_Core_635,

            /// <remarks />
            Athlon_II_X4_Quad_Core_640,

            /// <remarks />
            Athlon_II_X4_Quad_Core_645,

            /// <remarks />
            Athlon_LE_1640,

            /// <remarks />
            athlon_mp,

            /// <remarks />
            Athlon_Neo_Single_Core_MV_40,

            /// <remarks />
            Athlon_Neo_X2_Dual_Core_L325,

            /// <remarks />
            Athlon_Neo_X2_Dual_Core_L335,

            /// <remarks />
            Athlon_X2_Dual_Core_4200_plus,

            /// <remarks />
            Athlon_X2_Dual_Core_5000,

            /// <remarks />
            Athlon_X2_Dual_Core_5000_plus,

            /// <remarks />
            Athlon_X2_Dual_Core_5400_plus,

            /// <remarks />
            Athlon_X2_Dual_Core_7550,

            /// <remarks />
            Athlon_X2_Dual_Core_7750,

            /// <remarks />
            Athlon_X2_Dual_Core_QL_66,

            /// <remarks />
            athlon_xp,

            /// <remarks />
            athlon_xp_m,

            /// <remarks />
            Atom_D410,

            /// <remarks />
            Atom_D425,

            /// <remarks />
            Atom_D510,

            /// <remarks />
            Atom_D525,

            /// <remarks />
            Atom_N230,

            /// <remarks />
            Atom_N270,

            /// <remarks />
            Atom_N280,

            /// <remarks />
            Atom_N330,

            /// <remarks />
            Atom_N470,

            /// <remarks />
            Atom_N475,

            /// <remarks />
            Atom_N550,

            /// <remarks />
            Atom_Silverthorne,

            /// <remarks />
            Atom_Z330,

            /// <remarks />
            Atom_Z515,

            /// <remarks />
            bulverde,

            /// <remarks />
            c167cr,

            /// <remarks />
            celeron,

            /// <remarks />
            Celeron_450,

            /// <remarks />
            Celeron_585,

            /// <remarks />
            Celeron_743,

            /// <remarks />
            Celeron_900,

            /// <remarks />
            Celeron_925,

            /// <remarks />
            Celeron_D_Processor_360,

            /// <remarks />
            Celeron_D_Processor_420,

            /// <remarks />
            Celeron_D_Processor_440,

            /// <remarks />
            Celeron_E1200,

            /// <remarks />
            Celeron_E1500,

            /// <remarks />
            Celeron_E3200,

            /// <remarks />
            Celeron_E3300,

            /// <remarks />
            Celeron_M_353,

            /// <remarks />
            Celeron_M_440,

            /// <remarks />
            Celeron_M_520,

            /// <remarks />
            Celeron_M_530,

            /// <remarks />
            Celeron_M_540,

            /// <remarks />
            Celeron_M_550,

            /// <remarks />
            Celeron_M_560,

            /// <remarks />
            Celeron_M_575,

            /// <remarks />
            Celeron_M_585,

            /// <remarks />
            Celeron_M_T1400,

            /// <remarks />
            Celeron_SU2300,

            /// <remarks />
            Celeron_T1500,

            /// <remarks />
            Celeron_T3000,

            /// <remarks />
            Celeron_T4500,

            /// <remarks />
            Core_2_Duo,

            /// <remarks />
            Core_2_Duo_E2200,

            /// <remarks />
            Core_2_Duo_E4000,

            /// <remarks />
            Core_2_Duo_E4300,

            /// <remarks />
            Core_2_Duo_E4400,

            /// <remarks />
            Core_2_Duo_E4500,

            /// <remarks />
            Core_2_Duo_E4600,

            /// <remarks />
            Core_2_Duo_E5500,

            /// <remarks />
            Core_2_Duo_E6300,

            /// <remarks />
            Core_2_Duo_E6400,

            /// <remarks />
            Core_2_Duo_E6420,

            /// <remarks />
            Core_2_Duo_E6600,

            /// <remarks />
            Core_2_Duo_E7200,

            /// <remarks />
            Core_2_Duo_E7300,

            /// <remarks />
            Core_2_Duo_E7400,

            /// <remarks />
            Core_2_Duo_E7500,

            /// <remarks />
            Core_2_Duo_E7600,

            /// <remarks />
            Core_2_Duo_E8400,

            /// <remarks />
            Core_2_Duo_E8500,

            /// <remarks />
            Core_2_Duo_L7500,

            /// <remarks />
            Core_2_Duo_P3750,

            /// <remarks />
            Core_2_Duo_P7350,

            /// <remarks />
            Core_2_Duo_P7370,

            /// <remarks />
            Core_2_Duo_P7450,

            /// <remarks />
            Core_2_Duo_P7550,

            /// <remarks />
            Core_2_Duo_P8400,

            /// <remarks />
            Core_2_Duo_P8600,

            /// <remarks />
            Core_2_Duo_P8700,

            /// <remarks />
            Core_2_Duo_P8800,

            /// <remarks />
            Core_2_Duo_P9500,

            /// <remarks />
            Core_2_Duo_P9600,

            /// <remarks />
            Core_2_Duo_SL7100,

            /// <remarks />
            Core_2_Duo_SL9300,

            /// <remarks />
            Core_2_Duo_SL9400,

            /// <remarks />
            Core_2_Duo_SL9600,

            /// <remarks />
            Core_2_Duo_SP9400,

            /// <remarks />
            Core_2_Duo_SU4100,

            /// <remarks />
            Core_2_Duo_SU7300,

            /// <remarks />
            Core_2_Duo_SU9300,

            /// <remarks />
            Core_2_Duo_SU9400,

            /// <remarks />
            Core_2_Duo_SU_9600,

            /// <remarks />
            Core_2_Duo_T2310,

            /// <remarks />
            Core_2_Duo_T2330,

            /// <remarks />
            Core_2_Duo_T2390,

            /// <remarks />
            Core_2_Duo_T2450,

            /// <remarks />
            Core_2_Duo_T4200,

            /// <remarks />
            Core_2_Duo_T5200,

            /// <remarks />
            Core_2_Duo_T5250,

            /// <remarks />
            Core_2_Duo_T5270,

            /// <remarks />
            Core_2_Duo_T5300,

            /// <remarks />
            Core_2_Duo_T5450,

            /// <remarks />
            Core_2_Duo_T5470,

            /// <remarks />
            Core_2_Duo_T5500,

            /// <remarks />
            Core_2_Duo_T5550,

            /// <remarks />
            Core_2_Duo_T5600,

            /// <remarks />
            Core_2_Duo_T5670,

            /// <remarks />
            Core_2_Duo_T5750,

            /// <remarks />
            Core_2_Duo_T5800,

            /// <remarks />
            Core_2_Duo_T5850,

            /// <remarks />
            Core_2_Duo_T5870,

            /// <remarks />
            Core_2_Duo_T6400,

            /// <remarks />
            Core_2_Duo__T6500,

            /// <remarks />
            Core_2_Duo_T6570,

            /// <remarks />
            Core_2_Duo_T6600,

            /// <remarks />
            Core_2_Duo_T6670,

            /// <remarks />
            Core_2_Duo_T7100,

            /// <remarks />
            Core_2_Duo_T7200,

            /// <remarks />
            Core_2_Duo_T7250,

            /// <remarks />
            Core_2_Duo_T7270,

            /// <remarks />
            Core_2_Duo_T7300,

            /// <remarks />
            Core_2_Duo_T7350,

            /// <remarks />
            Core_2_Duo_T7400,

            /// <remarks />
            Core_2_Duo_T7500,

            /// <remarks />
            Core_2_Duo_T7700,

            /// <remarks />
            Core_2_Duo_T8100,

            /// <remarks />
            Core_2_Duo_T8300,

            /// <remarks />
            Core_2_Duo_T8400,

            /// <remarks />
            Core_2_Duo_T8700,

            /// <remarks />
            Core_2_Duo_T9300,

            /// <remarks />
            Core_2_Duo_T9400,

            /// <remarks />
            Core_2_Duo_T9500,

            /// <remarks />
            Core_2_Duo_T9550,

            /// <remarks />
            Core_2_Duo_T9600,

            /// <remarks />
            Core_2_Duo_T9900,

            /// <remarks />
            Core_2_Duo_U1400,

            /// <remarks />
            Core_2_Duo_U2200,

            /// <remarks />
            Core_2_Duo_U7500,

            /// <remarks />
            Core_2_Duo_U7700,

            /// <remarks />
            Core_2_Quad_9600,

            /// <remarks />
            Core_2_Quad_Q6600,

            /// <remarks />
            Core_2_Quad_Q6700,

            /// <remarks />
            Core_2_Quad_Q8200,

            /// <remarks />
            Core_2_Quad_Q8200S,

            /// <remarks />
            Core_2_Quad_Q8300,

            /// <remarks />
            Core_2_Quad_Q8400,

            /// <remarks />
            Core_2_Quad_Q8400S,

            /// <remarks />
            Core_2_Quad_Q9000,

            /// <remarks />
            Core_2_Quad_Q9300,

            /// <remarks />
            Core_2_Quad_Q9400,

            /// <remarks />
            Core_2_Quad_Q9400S,

            /// <remarks />
            Core_2_Quad_Q9450,

            /// <remarks />
            Core_2_Quad_Q9500,

            /// <remarks />
            Core_2_Quad_Q9550,

            /// <remarks />
            Core_2_Solo_SU3500,

            /// <remarks />
            Core_Duo_1V_L2400,

            /// <remarks />
            Core_Duo_LV_L2400,

            /// <remarks />
            Core_Duo_T2250,

            /// <remarks />
            Core_Duo_T2400,

            /// <remarks />
            Core_Duo_U2400,

            /// <remarks />
            core_i3,

            /// <remarks />
            Core_i3_2330M,

            /// <remarks />
            Core_i3_330UM,

            /// <remarks />
            Core_i3_350M,

            /// <remarks />
            Core_i3_370M,

            /// <remarks />
            Core_i3_380M,

            /// <remarks />
            Core_i3_380UM,

            /// <remarks />
            Core_i3_520M,

            /// <remarks />
            Core_i3_530,

            /// <remarks />
            Core_i3_530M,

            /// <remarks />
            Core_i3_540,

            /// <remarks />
            Core_i3_540M,

            /// <remarks />
            Core_i3_550,

            /// <remarks />
            core_i5,

            /// <remarks />
            Core_i5_2300,

            /// <remarks />
            Core_i5_2520M,

            /// <remarks />
            Core_i5_2540M,

            /// <remarks />
            Core_i5_430M,

            /// <remarks />
            Core_i5_430UM,

            /// <remarks />
            Core_i5_450M,

            /// <remarks />
            Core_i5_460M,

            /// <remarks />
            Core_i5_470UM,

            /// <remarks />
            Core_i5_480M,

            /// <remarks />
            Core_i5_560M,

            /// <remarks />
            Core_i5_650,

            /// <remarks />
            Core_i5_655K,

            /// <remarks />
            Core_i5_660,

            /// <remarks />
            Core_i5_750,

            /// <remarks />
            Core_i5_760,

            /// <remarks />
            Core_i5__760,

            /// <remarks />
            core_i7,

            /// <remarks />
            Core_i7_2600,

            /// <remarks />
            Core_i7_2620QM,

            /// <remarks />
            Core_i7_2630QM,

            /// <remarks />
            Core_i7_2720QM,

            /// <remarks />
            Core_i7_2820QM,

            /// <remarks />
            Core_i7_4800MQ,

            /// <remarks />
            Core_i7_620LM,

            /// <remarks />
            Core_i7_620M,

            /// <remarks />
            Core_i7_640LM,

            /// <remarks />
            Core_i7_640M,

            /// <remarks />
            Core_i7_640UM,

            /// <remarks />
            Core_i7_680UM,

            /// <remarks />
            Core_i7_740QM,

            /// <remarks />
            Core_i7_860,

            /// <remarks />
            Core_i7_870,

            /// <remarks />
            Core_i7_875K,

            /// <remarks />
            Core_i7_920,

            /// <remarks />
            Core_i7_930,

            /// <remarks />
            Core_i7_940,

            /// <remarks />
            Core_i7_950,

            /// <remarks />
            Core_i7_960,

            /// <remarks />
            Core_i7_980,

            /// <remarks />
            Core_Solo_U1500,

            /// <remarks />
            crusoe_5800,

            /// <remarks />
            crusoe_tm3200,

            /// <remarks />
            crusoe_tm5500,

            /// <remarks />
            crusoe_tm5600,

            /// <remarks />
            C_Series_C_50,

            /// <remarks />
            cyrix_iii,

            /// <remarks />
            cyrix_mii,

            /// <remarks />
            duron,

            /// <remarks />
            eden,

            /// <remarks />
            eden_esp,

            /// <remarks />
            eden_esp_4000,

            /// <remarks />
            eden_esp_5000,

            /// <remarks />
            eden_esp_6000,

            /// <remarks />
            eden_esp_7000,

            /// <remarks />
            efficeon,

            /// <remarks />
            efficeon_tm8000,

            /// <remarks />
            efficeon_tm8600,

            /// <remarks />
            efficion_8800,

            /// <remarks />
            elansc300,

            /// <remarks />
            elansc310,

            /// <remarks />
            elansc400,

            /// <remarks />
            E_Series_Dual_Core_E_350,

            /// <remarks />
            E_Series_Processor_E_240,

            /// <remarks />
            extremecpu,

            /// <remarks />
            fx_series_eight_core_fx_8100,

            /// <remarks />
            fx_series_eight_core_fx_8120,

            /// <remarks />
            fx_series_eight_core_fx_8150,

            /// <remarks />
            fx_series_quad_core_fx_4100,

            /// <remarks />
            fx_series_quad_core_fx_4170,

            /// <remarks />
            fx_series_quad_core_fx_b4150,

            /// <remarks />
            fx_series_six_core_fx_6100,

            /// <remarks />
            fx_series_six_core_fx_6120,

            /// <remarks />
            g3,

            /// <remarks />
            g4,

            /// <remarks />
            g5,

            /// <remarks />
            geode_gx,

            /// <remarks />
            Geode_GX,

            /// <remarks />
            geode_gx1,

            /// <remarks />
            geode_gxlv,

            /// <remarks />
            geode_gxm,

            /// <remarks />
            geoden_x,

            /// <remarks />
            h8s,

            /// <remarks />
            handheld_engine_cxd2230ga,

            /// <remarks />
            handheld_engine_cxd2230ga_temp,

            /// <remarks />
            hitachi_sh3,

            /// <remarks />
            hypersparc,

            /// <remarks />
            intel_atom,

            /// <remarks />
            intel_atom_230,

            /// <remarks />
            intel_atom_330,

            /// <remarks />
            intel_atom_n270,

            /// <remarks />
            intel_atom_n280,

            /// <remarks />
            intel_atom_n450,

            /// <remarks />
            intel_atom_n455,

            /// <remarks />
            intel_atom_z520,

            /// <remarks />
            intel_atom_z530,

            /// <remarks />
            intel_celeron_d,

            /// <remarks />
            intel_centrino,

            /// <remarks />
            intel_centrino_2,

            /// <remarks />
            intel_core_2_duo,

            /// <remarks />
            intel_core_2_duo_mobile,

            /// <remarks />
            intel_core_2_extreme,

            /// <remarks />
            intel_core_2_quad,

            /// <remarks />
            intel_core_2_solo,

            /// <remarks />
            intel_core_duo,

            /// <remarks />
            intel_core_solo,

            /// <remarks />
            Intel_Mobile_CPU,

            /// <remarks />
            intel_pentium_4_ht,

            /// <remarks />
            intel_pentium_d,

            /// <remarks />
            intel_strongarm,

            /// <remarks />
            intel_xeon,

            /// <remarks />
            intel_xeon_mp,

            /// <remarks />
            intel_xscale_pxa250,

            /// <remarks />
            intel_xscale_pxa255,

            /// <remarks />
            intel_xscale_pxa263,

            /// <remarks />
            itanium,

            /// <remarks />
            itanium_2,

            /// <remarks />
            k5,

            /// <remarks />
            k6_2,

            /// <remarks />
            k6_2e,

            /// <remarks />
            k6_2_plus,

            /// <remarks />
            k6_3,

            /// <remarks />
            k6_iii_plus,

            /// <remarks />
            k6_mmx,

            /// <remarks />
            mc68328,

            /// <remarks />
            mc68ez328,

            /// <remarks />
            mc68sz328,

            /// <remarks />
            mc68vz328,

            /// <remarks />
            mc88110,

            /// <remarks />
            mediagx,

            /// <remarks />
            mediagxi,

            /// <remarks />
            mediagxlv,

            /// <remarks />
            mediagxm,

            /// <remarks />
            microsparc_ii,

            /// <remarks />
            microsparc_iiep,

            /// <remarks />
            mobile_athlon_4,

            /// <remarks />
            mobile_athlon_xp_m,

            /// <remarks />
            mobile_athon_64,

            /// <remarks />
            mobile_celeron,

            /// <remarks />
            mobile_duron,

            /// <remarks />
            mobile_k6_2_plus,

            /// <remarks />
            mobile_pentium_2,

            /// <remarks />
            mobile_pentium_3,

            /// <remarks />
            mobile_pentium_4,

            /// <remarks />
            mobile_pentium_4_ht,

            /// <remarks />
            mobile_sempron,

            /// <remarks />
            motorola_dragonball,

            /// <remarks />
            nec_mips,

            /// <remarks />
            none,

            /// <remarks />
            omap1710,

            /// <remarks />
            omap310,

            /// <remarks />
            omap311,

            /// <remarks />
            omap850,

            /// <remarks />
            opteron,

            /// <remarks />
            pa_7100lc,

            /// <remarks />
            pa_7200,

            /// <remarks />
            pa_7300lc,

            /// <remarks />
            pa_8000,

            /// <remarks />
            pa_8200,

            /// <remarks />
            pa_8500,

            /// <remarks />
            pa_8600,

            /// <remarks />
            pa_8700,

            /// <remarks />
            pa_8700_plus,

            /// <remarks />
            pa_8800,

            /// <remarks />
            pa_8900,

            /// <remarks />
            pentium,

            /// <remarks />
            pentium_2,

            /// <remarks />
            pentium_3,

            /// <remarks />
            pentium_3_xeon,

            /// <remarks />
            pentium_4,

            /// <remarks />
            pentium_4_extreme_edition,

            /// <remarks />
            Pentium_D_925,

            /// <remarks />
            Pentium_D_T2060,

            /// <remarks />
            pentium_dual_core,

            /// <remarks />
            Pentium_E2140,

            /// <remarks />
            Pentium_E2160,

            /// <remarks />
            Pentium_E2180,

            /// <remarks />
            Pentium_E2200,

            /// <remarks />
            Pentium_E2220,

            /// <remarks />
            Pentium_E3200,

            /// <remarks />
            Pentium_E4400,

            /// <remarks />
            Pentium_E5200,

            /// <remarks />
            Pentium_E5300,

            /// <remarks />
            Pentium_E5301,

            /// <remarks />
            Pentium_E5400,

            /// <remarks />
            Pentium_E5500,

            /// <remarks />
            Pentium_E5700,

            /// <remarks />
            Pentium_E5800,

            /// <remarks />
            Pentium_E6300,

            /// <remarks />
            Pentium_E6600,

            /// <remarks />
            Pentium_E6700,

            /// <remarks />
            Pentium_E7200,

            /// <remarks />
            Pentium_E7400,

            /// <remarks />
            Pentium_E8400,

            /// <remarks />
            Pentium_G6950,

            /// <remarks />
            pentium_iii_e,

            /// <remarks />
            pentium_iii_s,

            /// <remarks />
            pentium_ii_xeon,

            /// <remarks />
            pentium_m,

            /// <remarks />
            Pentium_M_738,

            /// <remarks />
            Pentium_M_778,

            /// <remarks />
            pentium_mmx,

            /// <remarks />
            Pentium_P6000,

            /// <remarks />
            Pentium_P6100,

            /// <remarks />
            Pentium_P6200,

            /// <remarks />
            pentium_pro,

            /// <remarks />
            Pentium_SU2700,

            /// <remarks />
            Pentium_SU4100,

            /// <remarks />
            Pentium_T2080,

            /// <remarks />
            Pentium_T2130,

            /// <remarks />
            Pentium_T2310,

            /// <remarks />
            Pentium_T2330,

            /// <remarks />
            Pentium_T2350,

            /// <remarks />
            Pentium_T2370,

            /// <remarks />
            Pentium_T2390,

            /// <remarks />
            Pentium_T3200,

            /// <remarks />
            Pentium_T3400,

            /// <remarks />
            Pentium_T4200,

            /// <remarks />
            Pentium_T4300,

            /// <remarks />
            Pentium_T4400,

            /// <remarks />
            Pentium_T4500,

            /// <remarks />
            Pentium_T6570,

            /// <remarks />
            Pentium_U5400,

            /// <remarks />
            Pentium_U5600,

            /// <remarks />
            pentium_xeon,

            /// <remarks />
            phenom_dual_core,

            /// <remarks />
            phenom_ii_x2,

            /// <remarks />
            Phenom_II_X2_Dual_Core_511,

            /// <remarks />
            Phenom_II_X2_Dual_Core_550,

            /// <remarks />
            Phenom_II_X2_Dual_Core_N620,

            /// <remarks />
            Phenom_II_X2_Dual_Core_N640,

            /// <remarks />
            Phenom_II_X2_Dual_Core_N650,

            /// <remarks />
            Phenom_II_X2_Dual_Core_N660,

            /// <remarks />
            phenom_ii_x3,

            /// <remarks />
            Phenom_II_X3_Triple_Core_8400,

            /// <remarks />
            Phenom_II_X3_Triple_Core_8450,

            /// <remarks />
            Phenom_II_X3_Triple_Core_8550,

            /// <remarks />
            Phenom_II_X3_Triple_Core_8650,

            /// <remarks />
            Phenom_II_X3_Triple_Core_B75,

            /// <remarks />
            Phenom_II_X3_Triple_Core_N830,

            /// <remarks />
            Phenom_II_X3_Triple_Core_N850,

            /// <remarks />
            Phenom_II_X3_Triple_Core_P820,

            /// <remarks />
            Phenom_II_X3_Triple_Core_P840,

            /// <remarks />
            Phenom_II_X3_Triple_Core_P860,

            /// <remarks />
            phenom_ii_x4,

            /// <remarks />
            Phenom_II_X4_Quad_Core_810,

            /// <remarks />
            Phenom_II_X4_Quad_Core_820,

            /// <remarks />
            Phenom_II_X4_Quad_Core_830,

            /// <remarks />
            Phenom_II_X4_Quad_Core_840T,

            /// <remarks />
            Phenom_II_X4_Quad_Core_910,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9100E,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9150,

            /// <remarks />
            Phenom_II_X4_Quad_Core_920,

            /// <remarks />
            Phenom_II_X4_Quad_Core_925,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9350,

            /// <remarks />
            Phenom_II_X4_Quad_Core_945,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9450,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9500,

            /// <remarks />
            Phenom_II_X4_Quad_Core_955,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9550,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9600,

            /// <remarks />
            Phenom_II_X4_Quad_Core_965,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9650,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9750,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9850,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9950,

            /// <remarks />
            Phenom_II_X4_Quad_Core_N820,

            /// <remarks />
            Phenom_II_X4_Quad_Core_N930,

            /// <remarks />
            Phenom_II_X4_Quad_Core_N950,

            /// <remarks />
            Phenom_II_X4_Quad_Core_P920,

            /// <remarks />
            Phenom_II_X4_Quad_Core_P940,

            /// <remarks />
            Phenom_II_X4_Quad_Core_P960,

            /// <remarks />
            phenom_ii_x6,

            /// <remarks />
            Phenom_II_X6_Six_Core_1035T,

            /// <remarks />
            Phenom_II_X6_Six_Core_1045T,

            /// <remarks />
            Phenom_II_X6_Six_Core_1055T,

            /// <remarks />
            Phenom_II_X6_Six_Core_1090T,

            /// <remarks />
            phenom_quad_core,

            /// <remarks />
            phenom_triple_core,

            /// <remarks />
            power3,

            /// <remarks />
            power3_ii,

            /// <remarks />
            power4,

            /// <remarks />
            power4_plus,

            /// <remarks />
            power5,

            /// <remarks />
            powerpc,

            /// <remarks />
            powerpc_403,

            /// <remarks />
            powerpc_403ga,

            /// <remarks />
            powerpc_403_gcx,

            /// <remarks />
            powerpc_440gx,

            /// <remarks />
            powerpc_601,

            /// <remarks />
            powerpc_603,

            /// <remarks />
            powerpc_603e,

            /// <remarks />
            powerpc_603ev,

            /// <remarks />
            powerpc_604,

            /// <remarks />
            powerpc_604e,

            /// <remarks />
            powerpc_740_g3,

            /// <remarks />
            powerpc_750cx,

            /// <remarks />
            powerpc_750_g3,

            /// <remarks />
            powerpc_970,

            /// <remarks />
            powerpc_rs64,

            /// <remarks />
            powerpc_rs64_ii,

            /// <remarks />
            powerpc_rs64_iii,

            /// <remarks />
            powerpc_rs64_iv,

            /// <remarks />
            pr31700,

            /// <remarks />
            r10000,

            /// <remarks />
            r12000,

            /// <remarks />
            r12000a,

            /// <remarks />
            r14000,

            /// <remarks />
            r14000a,

            /// <remarks />
            r16000,

            /// <remarks />
            r16000a,

            /// <remarks />
            r16000b,

            /// <remarks />
            r3900,

            /// <remarks />
            r3910,

            /// <remarks />
            r3912,

            /// <remarks />
            r4000,

            /// <remarks />
            r4300,

            /// <remarks />
            r4310,

            /// <remarks />
            r4640,

            /// <remarks />
            r4700,

            /// <remarks />
            r5000,

            /// <remarks />
            r5230,

            /// <remarks />
            rm5231,

            /// <remarks />
            s3c2410,

            /// <remarks />
            s3c2440,

            /// <remarks />
            s3c2442,

            /// <remarks />
            sa_110,

            /// <remarks />
            sa_1100,

            /// <remarks />
            sa_1110,

            /// <remarks />
            sempron,

            /// <remarks />
            Sempron_140,

            /// <remarks />
            Sempron_3500_plus,

            /// <remarks />
            Sempron_3600_plus,

            /// <remarks />
            Sempron_LE_1250,

            /// <remarks />
            Sempron_LE_1300,

            /// <remarks />
            Sempron_M100,

            /// <remarks />
            Sempron_M120,

            /// <remarks />
            sh_4,

            /// <remarks />
            sh7709a,

            /// <remarks />
            sis550,

            /// <remarks />
            snapdragon,

            /// <remarks />
            sparc,

            /// <remarks />
            sparc64v,

            /// <remarks />
            sparc_ii,

            /// <remarks />
            supersparc,

            /// <remarks />
            supersparc_ii,

            /// <remarks />
            tegra,

            /// <remarks />
            tegra_2_0,

            /// <remarks />
            tegra_250,

            /// <remarks />
            tegra_3_0,

            /// <remarks />
            texas_instruments_omap1510,

            /// <remarks />
            tm_44,

            /// <remarks />
            tmpr3922au,

            /// <remarks />
            turbosparc,

            /// <remarks />
            turion_64,

            /// <remarks />
            turion_64_x2,

            /// <remarks />
            Turion_64_X2_Dual_Core_RM_70,

            /// <remarks />
            Turion_64_X2_Dual_Core_RM_72,

            /// <remarks />
            Turion_64_X2_Dual_Core_TL_52,

            /// <remarks />
            Turion_64_X2_Dual_Core_TL_56,

            /// <remarks />
            Turion_64_X2_Mobile,

            /// <remarks />
            Turion_64_X2_RM_74,

            /// <remarks />
            Turion_64_X2_TK_53,

            /// <remarks />
            Turion_64_X2_TK_55,

            /// <remarks />
            Turion_64_X2_TK_57,

            /// <remarks />
            Turion_64_X2_TK_58,

            /// <remarks />
            Turion_64_X2_TL_50,

            /// <remarks />
            Turion_64_X2_TL_57,

            /// <remarks />
            Turion_64_X2_TL_58,

            /// <remarks />
            Turion_64_X2_TL_60,

            /// <remarks />
            Turion_64_X2_TL_62,

            /// <remarks />
            Turion_64_X2_TL_64_Gold,

            /// <remarks />
            Turion_64_X2_TL_66,

            /// <remarks />
            Turion_64_X2_Ultra_ZM_82,

            /// <remarks />
            Turion_64_X2_Ultra_ZM_85,

            /// <remarks />
            Turion_64_X2_Ultra_ZM_87,

            /// <remarks />
            Turion_64_X2_ZM_72,

            /// <remarks />
            Turion_64_X2_ZM_74,

            /// <remarks />
            Turion_64_X2_ZM_80,

            /// <remarks />
            Turion_II_Neo_X2_Dual_Core_K625,

            /// <remarks />
            Turion_II_Neo_X2_Dual_Core_L625,

            /// <remarks />
            Turion_II_Ultra_X2_Dual_Core_M600,

            /// <remarks />
            Turion_II_Ultra_X2_Dual_Core_M620,

            /// <remarks />
            Turion_II_X2_Dual_Core_M300,

            /// <remarks />
            Turion_II_X2_Dual_Core_M500,

            /// <remarks />
            Turion_II_X2_Dual_Core_M520,

            /// <remarks />
            Turion_II_X2_Dual_Core_P520,

            /// <remarks />
            Turion_II_X2_Dual_Core_P540,

            /// <remarks />
            Turion_II_X2_Dual_Core_P560,

            /// <remarks />
            Turion_X2_Dual_Core_RM_75,

            /// <remarks />
            Turion_X2_Ultra_Dual_Core_ZM_85,

            /// <remarks />
            tx3922,

            /// <remarks />
            ultrasparc_i,

            /// <remarks />
            ultrasparc_ii,

            /// <remarks />
            ultrasparc_iie,

            /// <remarks />
            ultrasparc_iii,

            /// <remarks />
            ultrasparc_iii_cu,

            /// <remarks />
            ultrasparc_iiii,

            /// <remarks />
            ultrasparc_iii_plus,

            /// <remarks />
            ultrasparc_iis,

            /// <remarks />
            ultrasparc_iv,

            /// <remarks />
            ultrasparc_iv_plus,

            /// <remarks />
            ultrasparc_s400,

            /// <remarks />
            ultrasparc_t1,

            /// <remarks />
            unknown,

            /// <remarks />
            v25,

            /// <remarks />
            v30,

            /// <remarks />
            v30mx,

            /// <remarks />
            via_cyrix_c3,

            /// <remarks />
            vr4111,

            /// <remarks />
            vr4121,

            /// <remarks />
            vr4122,

            /// <remarks />
            vr4131,

            /// <remarks />
            vr4181,

            /// <remarks />
            vr4300,

            /// <remarks />
            V_Series_Single_Core_V105,

            /// <remarks />
            V_Series_Single_Core_V120,

            /// <remarks />
            V_Series_Single_Core_V140,

            /// <remarks />
            winchip_2,

            /// <remarks />
            winchip_c6,

            /// <remarks />
            Xeon,

            /// <remarks />
            Xeon_3000,

            /// <remarks />
            Xeon_3530,

            /// <remarks />
            Xeon_5000,

            /// <remarks />
            Xeon_5400,

            /// <remarks />
            Xeon_E5504,

            /// <remarks />
            Xeon_E5506,

            /// <remarks />
            Xeon_E5520,

            /// <remarks />
            Xeon_E5530,

            /// <remarks />
            Xeon_W3503,

            /// <remarks />
            Xeon_W5580,

            /// <remarks />
            Xeon_X5560,

            /// <remarks />
            xscale,

            /// <remarks />
            xscale_pxa260,

            /// <remarks />
            xscale_pxa261,

            /// <remarks />
            xscale_pxa262,

            /// <remarks />
            xscale_pxa270,

            /// <remarks />
            xscale_pxa272,

            /// <remarks />
            xscale_pxa901,

            /// <remarks />
            celeron_3865u,

            /// <remarks />
            ryzen_5_2600h,

            /// <remarks />
            core_i7_4810HQ,

            /// <remarks />
            xeon_silver_4116t,

            /// <remarks />
            xeon_silver_4116,

            /// <remarks />
            xeon_silver_4114t,

            /// <remarks />
            xeon_silver_4114,

            /// <remarks />
            xeon_silver_4112,

            /// <remarks />
            xeon_silver_4110,

            /// <remarks />
            xeon_silver_4109t,

            /// <remarks />
            xeon_silver_4108,

            /// <remarks />
            xeon_platinum_8180m,

            /// <remarks />
            xeon_platinum_8180,

            /// <remarks />
            xeon_platinum_8176m,

            /// <remarks />
            xeon_platinum_8176f,

            /// <remarks />
            xeon_platinum_8176,

            /// <remarks />
            xeon_platinum_8170m,

            /// <remarks />
            xeon_platinum_8170,

            /// <remarks />
            xeon_platinum_8168,

            /// <remarks />
            xeon_platinum_8164,

            /// <remarks />
            xeon_platinum_8160t,

            /// <remarks />
            xeon_platinum_8160m,

            /// <remarks />
            xeon_platinum_8160f,

            /// <remarks />
            xeon_platinum_8160,

            /// <remarks />
            xeon_platinum_8158,

            /// <remarks />
            xeon_platinum_8156,

            /// <remarks />
            xeon_platinum_8153,

            /// <remarks />
            xeon_gold_6154,

            /// <remarks />
            xeon_gold_6152,

            /// <remarks />
            xeon_gold_6150,

            /// <remarks />
            xeon_gold_6148f,

            /// <remarks />
            xeon_gold_6148,

            /// <remarks />
            xeon_gold_6146,

            /// <remarks />
            xeon_gold_6144,

            /// <remarks />
            xeon_gold_6142m,

            /// <remarks />
            xeon_gold_6142f,

            /// <remarks />
            xeon_gold_6142,

            /// <remarks />
            xeon_gold_6140m,

            /// <remarks />
            xeon_gold_6140,

            /// <remarks />
            xeon_gold_6138t,

            /// <remarks />
            xeon_gold_6138f,

            /// <remarks />
            xeon_gold_6138,

            /// <remarks />
            xeon_gold_6136,

            /// <remarks />
            xeon_gold_6134m,

            /// <remarks />
            xeon_gold_6134,

            /// <remarks />
            xeon_gold_6132,

            /// <remarks />
            xeon_gold_6130t,

            /// <remarks />
            xeon_gold_6130f,

            /// <remarks />
            xeon_gold_6130,

            /// <remarks />
            xeon_gold_6128,

            /// <remarks />
            xeon_gold_6126t,

            /// <remarks />
            xeon_gold_6126f,

            /// <remarks />
            xeon_gold_6126,

            /// <remarks />
            xeon_gold_5122,

            /// <remarks />
            xeon_gold_5120t,

            /// <remarks />
            xeon_gold_5120,

            /// <remarks />
            xeon_gold_5119t,

            /// <remarks />
            xeon_gold_5118,

            /// <remarks />
            xeon_gold_5115,

            /// <remarks />
            xeon_bronze_3106,

            /// <remarks />
            xeon_bronze_3104,

            /// <remarks />
            ryzen_threadripper_1950x,

            /// <remarks />
            ryzen_threadripper_1920x,

            /// <remarks />
            ryzen_threadripper_1900x,

            /// <remarks />
            ryzen_7_pro_2700u,

            /// <remarks />
            amd_ryzen_7_pro_1700x,

            /// <remarks />
            amd_ryzen_7_pro_1700,

            /// <remarks />
            ryzen_7_2700u,

            /// <remarks />
            amd_ryzen_7_1800x,

            /// <remarks />
            amd_ryzen_7_1700x,

            /// <remarks />
            amd_ryzen_7_1700,

            /// <remarks />
            amd_ryzen_5_pro_1600,

            /// <remarks />
            amd_ryzen_5_pro_1500,

            /// <remarks />
            ryzen_5_2500u,

            /// <remarks />
            ryzen_5_2400ge,

            /// <remarks />
            amd_ryzen_5_1600x,

            /// <remarks />
            amd_ryzen_5_1600,

            /// <remarks />
            amd_ryzen_5_1500x,

            /// <remarks />
            amd_ryzen_5_1400,

            /// <remarks />
            ryzen_3_pro_2300u,

            /// <remarks />
            amd_ryzen_3_pro_1300,

            /// <remarks />
            amd_ryzen_3_pro_1200,

            /// <remarks />
            ryzen_3_2300u,

            /// <remarks />
            ryzen_3_2200u,

            /// <remarks />
            ryzen_3_2200ge,

            /// <remarks />
            amd_ryzen_3_1300x,

            /// <remarks />
            amd_ryzen_3_1200,

            /// <remarks />
            pentium_gold_g5500t,

            /// <remarks />
            pentium_gold_g5400t,

            /// <remarks />
            core_i9_8950hk,

            /// <remarks />
            core_i9_7980xe,

            /// <remarks />
            core_i9_7960x,

            /// <remarks />
            core_i9_7940x,

            /// <remarks />
            core_i9_7920x,

            /// <remarks />
            core_i9_7900x,

            /// <remarks />
            core_i9_7820x,

            /// <remarks />
            core_i9_7800x,

            /// <remarks />
            core_i9_7740x,

            /// <remarks />
            core_i9_7640x,

            /// <remarks />
            core_i7_8750h,

            /// <remarks />
            core_i7_8700t,

            /// <remarks />
            core_i7_8700k,

            /// <remarks />
            core_i7_8700,

            /// <remarks />
            core_i7_8550u,

            /// <remarks />
            core_i5_8400t,

            /// <remarks />
            core_i5_8400,

            /// <remarks />
            core_i5_8300h,

            /// <remarks />
            core_i5_8250u,

            /// <remarks />
            core_i3_8300,

            /// <remarks />
            core_i3_8130u,

            /// <remarks />
            core_i3_8100,

            /// <remarks />
            pentium_gold_g5400,

            /// <remarks />
            pentium_gold_g5500,

            /// <remarks />
            pentium_gold_g5600,

            /// <remarks />
            ryzen_3_2200g,

            /// <remarks />
            ryzen_5_2400g,

            /// <remarks />
            core_i9,

            /// <remarks />
            amd_ryzen_1800x,

            /// <remarks />
            amd_ryzen_1700x,

            /// <remarks />
            amd_ryzen_1700,

            /// <remarks />
            amd_ryzen_1600x,

            /// <remarks />
            amd_ryzen_1600,

            /// <remarks />
            amd_ryzen_1500x,

            /// <remarks />
            amd_ryzen_1400,

            /// <remarks />
            amd_ryzen_7,

            /// <remarks />
            xeon_e3_1226v3,

            /// <remarks />
            core_i5_6402p,

            /// <remarks />
            core_i7_6600u,

            /// <remarks />
            celeron_n,

            /// <remarks />
            celeron_n3060,

            /// <remarks />
            atom_z8350,

            /// <remarks />
            apple_a8,

            /// <remarks />
            celeron_j3355,

            /// <remarks />
            celeron_j3455,

            /// <remarks />
            celeron_n3350,

            /// <remarks />
            celeron_n3450,

            /// <remarks />
            pentium_j4205,

            /// <remarks />
            pentium_n4200,

            /// <remarks />
            core_m_7y30,

            /// <remarks />
            core_i3_6157u,

            /// <remarks />
            core_i3_7100u,

            /// <remarks />
            core_i5_6350hq,

            /// <remarks />
            core_i5_7200u,

            /// <remarks />
            core_i5_7y54,

            /// <remarks />
            core_i7_7y75,

            /// <remarks />
            core_i7_6770hq,

            /// <remarks />
            core_i7_7500u,

            /// <remarks />
            core_i7_6800k,

            /// <remarks />
            core_i7_6850k,

            /// <remarks />
            core_i7_6900k,

            /// <remarks />
            core_i7_6950x,

            /// <remarks />
            xeon_e5_2650,

            /// <remarks />
            xeon_e5_2620,

            /// <remarks />
            xeon_e5_2600,

            /// <remarks />
            xeon_e5_2450,

            /// <remarks />
            xeon_e5_2407,

            /// <remarks />
            xeon_e5_2400,

            /// <remarks />
            xeon_e5_1650,

            /// <remarks />
            xeon_e5_1630v3,

            /// <remarks />
            xeon_e5_1620,

            /// <remarks />
            xeon_e5_1607,

            /// <remarks />
            xeon_e3_1271,

            /// <remarks />
            xeon_e3_1241,

            /// <remarks />
            xeon_e3_1231,

            /// <remarks />
            xeon_e3_1225,

            /// <remarks />
            xeon_e3_1220,

            /// <remarks />
            pentium_t7500,

            /// <remarks />
            pentium_t6670,

            /// <remarks />
            pentium_t6600,

            /// <remarks />
            pentium_t5750,

            /// <remarks />
            pentium_sl9300,

            /// <remarks />
            pentium_p8700,

            /// <remarks />
            pentium_p8600,

            /// <remarks />
            pentium_p7570,

            /// <remarks />
            pentium_other,

            /// <remarks />
            pentium_n3520,

            /// <remarks />
            pentium_n2930,

            /// <remarks />
            pentium_j2850,

            /// <remarks />
            pentium_g645t,

            /// <remarks />
            pentium_g3258,

            /// <remarks />
            pentium_g3240t,

            /// <remarks />
            pentium_g3220t,

            /// <remarks />
            pentium_g2130,

            /// <remarks />
            pentium_g2120,

            /// <remarks />
            pentium_e8500,

            /// <remarks />
            pentium_e7600,

            /// <remarks />
            pentium_e7500,

            /// <remarks />
            pentium_e6950,

            /// <remarks />
            pentium_d840,

            /// <remarks />
            pentium_d3400,

            /// <remarks />
            pentium_b987,

            /// <remarks />
            pentium_987,

            /// <remarks />
            pentium_967,

            /// <remarks />
            core_m_family,

            /// <remarks />
            core_i7_family,

            /// <remarks />
            core_i7_920xm,

            /// <remarks />
            core_i7_6700k,

            /// <remarks />
            core_i7_5960x,

            /// <remarks />
            core_i7_5930k,

            /// <remarks />
            core_i7_5820k,

            /// <remarks />
            core_i7_5600u,

            /// <remarks />
            core_i7_4970k,

            /// <remarks />
            core_i7_4930mx,

            /// <remarks />
            core_i7_4900mq,

            /// <remarks />
            core_i7_4770,

            /// <remarks />
            core_i7_4765t,

            /// <remarks />
            core_i7_4600u,

            /// <remarks />
            core_i7_4470s,

            /// <remarks />
            core_i7_3740qm,

            /// <remarks />
            core_i7_3687u,

            /// <remarks />
            core_i7_36517u,

            /// <remarks />
            core_i7_3635qm,

            /// <remarks />
            core_i7_3632qn,

            /// <remarks />
            core_i7_3630m,

            /// <remarks />
            core_i7_2760qm,

            /// <remarks />
            core_i7_2670m,

            /// <remarks />
            core_i7_2630q,

            /// <remarks />
            core_i7_2630m,

            /// <remarks />
            core_i5_family,

            /// <remarks />
            core_i5_6600k,

            /// <remarks />
            core_i5_5300u,

            /// <remarks />
            core_i5_4670s,

            /// <remarks />
            core_i5_4310u,

            /// <remarks />
            core_i5_4310m,

            /// <remarks />
            core_i5_4300u,

            /// <remarks />
            core_i5_3570s,

            /// <remarks />
            core_i5_3570,

            /// <remarks />
            core_i5_3470s,

            /// <remarks />
            core_i5_3470,

            /// <remarks />
            core_i5_3340,

            /// <remarks />
            core_i5_32320m,

            /// <remarks />
            core_i5_3200u,

            /// <remarks />
            core_i5_2550k,

            /// <remarks />
            core_i5_2410qm,

            /// <remarks />
            core_i5_2410,

            /// <remarks />
            core_i3_family,

            /// <remarks />
            core_i3_539,

            /// <remarks />
            core_i3_4350,

            /// <remarks />
            core_i3_4330t,

            /// <remarks />
            core_i3_4330,

            /// <remarks />
            core_i3_350um,

            /// <remarks />
            core_i3_3220t,

            /// <remarks />
            core_i3_2375m,

            /// <remarks />
            core_i3_2357u,

            /// <remarks />
            core_i3_2340m,

            /// <remarks />
            core_i3_2330,

            /// <remarks />
            core_i3_2227u,

            /// <remarks />
            core_i3_2125,

            /// <remarks />
            celeron_t1400,

            /// <remarks />
            celeron_n2930,

            /// <remarks />
            celeron_n2820,

            /// <remarks />
            celeron_n2810,

            /// <remarks />
            celeron_n2807,

            /// <remarks />
            celeron_n2806,

            /// <remarks />
            celeron_n2805,

            /// <remarks />
            celeron_j1850,

            /// <remarks />
            celeron_g465,

            /// <remarks />
            celeron_g1620t,

            /// <remarks />
            celeron_807,

            /// <remarks />
            celeron_1037u,

            /// <remarks />
            celeron_1005m,

            /// <remarks />
            celeron_1000m,

            /// <remarks />
            atom_z7345,

            /// <remarks />
            atom_z650,

            /// <remarks />
            atom_z3736f,

            /// <remarks />
            atom_x5_z8300,

            /// <remarks />
            atom_n2930,

            /// <remarks />
            atom_n2830,

            /// <remarks />
            atom_e3815,

            /// <remarks />
            atom_d2701,

            /// <remarks />
            atom_455,

            /// <remarks />
            apple_ci7,

            /// <remarks />
            apple_ci5,

            /// <remarks />
            apple_ci3,

            /// <remarks />
            apple_c2d,

            /// <remarks />
            pentium_g4520,

            /// <remarks />
            pentium_g4500t,

            /// <remarks />
            pentium_g4500,

            /// <remarks />
            pentium_g4400t,

            /// <remarks />
            pentium_g3900t,

            /// <remarks />
            pentium_g3900,

            /// <remarks />
            pentium_4405y,

            /// <remarks />
            core_m_6y57,

            /// <remarks />
            core_i7_6820hq,

            /// <remarks />
            core_i7_6567u,

            /// <remarks />
            core_i7_6560u,

            /// <remarks />
            core_i7_5675r,

            /// <remarks />
            core_i5_6440hq,

            /// <remarks />
            core_i5_6287u,

            /// <remarks />
            core_i5_6267u,

            /// <remarks />
            core_i5_6260u,

            /// <remarks />
            core_i3_6320,

            /// <remarks />
            core_i3_6300t,

            /// <remarks />
            core_i3_6300,

            /// <remarks />
            core_i3_6167u,

            /// <remarks />
            core_i3_6100t,

            /// <remarks />
            celeron_3855u,

            /// <remarks />
            intel_core_i3_6100,

            /// <remarks />
            intel_pentium_g4400,

            /// <remarks />
            intel_core_i5_6600,

            /// <remarks />
            intel_core_i5_6500,

            /// <remarks />
            atom_c3200_rk,

            /// <remarks />
            pentium_4405u,

            /// <remarks />
            core_m_6y30,

            /// <remarks />
            core_m_6y54,

            /// <remarks />
            core_m_6y75,

            /// <remarks />
            core_i3_6100h,

            /// <remarks />
            core_i3_6100u,

            /// <remarks />
            core_i5_6400t,

            /// <remarks />
            core_i5_6500t,

            /// <remarks />
            core_i5_6600t,

            /// <remarks />
            core_i5_6200u,

            /// <remarks />
            core_i5_6300hq,

            /// <remarks />
            core_i5_6400,

            /// <remarks />
            core_i5_6500,

            /// <remarks />
            core_i5_5350h,

            /// <remarks />
            core_i5_5675c,

            /// <remarks />
            core_i5_5575r,

            /// <remarks />
            core_i5_5675r,

            /// <remarks />
            core_i7_5775r,

            /// <remarks />
            core_i7_5775c,

            /// <remarks />
            core_i5_5750hq,

            /// <remarks />
            core_i5_6600,

            /// <remarks />
            core_i7_6700t,

            /// <remarks />
            core_i7_6500u,

            /// <remarks />
            core_i7_6700,

            /// <remarks />
            core_i7_6700hq,

            /// <remarks />
            core_i7_6820hk,

            /// <remarks />
            rockchip_rk3288,

            /// <remarks />
            amd_fx,

            /// <remarks />
            amd_a8,

            /// <remarks />
            amd_a6,

            /// <remarks />
            amd_a4,

            /// <remarks />
            intel_core_i7_5850hq,

            /// <remarks />
            intel_core_i7_5700hq,

            /// <remarks />
            intel_core_i7_5950hq,

            /// <remarks />
            intel_turbo_n2840,

            /// <remarks />
            amd_athlon_quad_core_5150,

            /// <remarks />
            a4_7210,

            /// <remarks />
            a6_7000,

            /// <remarks />
            a6_7310,

            /// <remarks />
            a6_7400k,

            /// <remarks />
            a6_8500p,

            /// <remarks />
            a6_8550,

            /// <remarks />
            a8_6410,

            /// <remarks />
            a8_7100,

            /// <remarks />
            a8_7200p,

            /// <remarks />
            a8_7410,

            /// <remarks />
            a8_7650k,

            /// <remarks />
            a8_8600p,

            /// <remarks />
            a8_8650,

            /// <remarks />
            a10_7300,

            /// <remarks />
            a10_7400p,

            /// <remarks />
            a10_7700k,

            /// <remarks />
            a10_8700p,

            /// <remarks />
            a10_8750,

            /// <remarks />
            athlon_x2_450,

            /// <remarks />
            athlon_x4_540,

            /// <remarks />
            athlon_x4_560,

            /// <remarks />
            athlon_x4_830,

            /// <remarks />
            athlon_x4_840,

            /// <remarks />
            athlon_x4_860k,

            /// <remarks />
            atom_c3130,

            /// <remarks />
            atom_c3230_rk,

            /// <remarks />
            atom_z2520,

            /// <remarks />
            atom_zZ8300,

            /// <remarks />
            atom_z8500,

            /// <remarks />
            atom_z8700,

            /// <remarks />
            celeron_3215u,

            /// <remarks />
            celeron_n3000,

            /// <remarks />
            celeron_n3050,

            /// <remarks />
            celeron_n3150,

            /// <remarks />
            core_i3_4170,

            /// <remarks />
            core_i3_4170t,

            /// <remarks />
            core_i3_4370t,

            /// <remarks />
            core_i3_5015u,

            /// <remarks />
            core_i3_5020u,

            /// <remarks />
            core_i5_4690k,

            /// <remarks />
            core_i7_4870hq,

            /// <remarks />
            e1_7010,

            /// <remarks />
            e2_6110,

            /// <remarks />
            e2_7110,

            /// <remarks />
            fx_8800p,

            /// <remarks />
            pentium_3825u,

            /// <remarks />
            pentium_g3260,

            /// <remarks />
            pentium_g3260t,

            /// <remarks />
            pentium_g3460t,

            /// <remarks />
            pentium_g3470,

            /// <remarks />
            pentium_n3700,

            /// <remarks />
            fx_4300,

            /// <remarks />
            core_i7_4790K,

            /// <remarks />
            bay_trail_t_z3735g,

            /// <remarks />
            pentium_n3540,

            /// <remarks />
            pentium_j2900,

            /// <remarks />
            pentium_g3460,

            /// <remarks />
            pentium_g3450t,

            /// <remarks />
            pentium_g3450,

            /// <remarks />
            pentium_g3250,

            /// <remarks />
            pentium_3805u,

            /// <remarks />
            pentium_3561y,

            /// <remarks />
            pentium_3560m,

            /// <remarks />
            pentium_2030m,

            /// <remarks />
            mediatek_mt8127,

            /// <remarks />
            core_m,

            /// <remarks />
            core_m_5y71,

            /// <remarks />
            core_m_5y70,

            /// <remarks />
            core_m_5y51,

            /// <remarks />
            core_m_5y31,

            /// <remarks />
            core_m_5y10c,

            /// <remarks />
            core_m_5y10a,

            /// <remarks />
            core_m_5y10,

            /// <remarks />
            core_i7_5557u,

            /// <remarks />
            core_i7_5550u,

            /// <remarks />
            core_i7_5500u,

            /// <remarks />
            core_i7_4790t,

            /// <remarks />
            core_i7_4790s,

            /// <remarks />
            core_i7_4785t,

            /// <remarks />
            core_i7_4771,

            /// <remarks />
            core_i7_4770r,

            /// <remarks />
            core_i7_4770hq,

            /// <remarks />
            core_i7_4722hq,

            /// <remarks />
            core_i7_4720hq,

            /// <remarks />
            core_i7_4712mq,

            /// <remarks />
            core_i7_4712hq,

            /// <remarks />
            core_i5_5287u,

            /// <remarks />
            core_i5_5257u,

            /// <remarks />
            core_i5_5250u,

            /// <remarks />
            core_i5_5200u,

            /// <remarks />
            core_i5_4690t,

            /// <remarks />
            core_i5_4690s,

            /// <remarks />
            core_i5_4690,

            /// <remarks />
            core_i5_4670r,

            /// <remarks />
            core_i5_4590t,

            /// <remarks />
            core_i5_4590s,

            /// <remarks />
            core_i5_4590,

            /// <remarks />
            core_i5_4570r,

            /// <remarks />
            core_i5_4460t,

            /// <remarks />
            core_i5_4460s,

            /// <remarks />
            core_i5_4308u,

            /// <remarks />
            core_i5_4278u,

            /// <remarks />
            core_i5_4260u,

            /// <remarks />
            core_i5_4220y,

            /// <remarks />
            core_i5_4210m,

            /// <remarks />
            core_i5_4210h,

            /// <remarks />
            core_i3_5157u,

            /// <remarks />
            core_i3_5010u,

            /// <remarks />
            core_i3_5005u,

            /// <remarks />
            core_i3_4370,

            /// <remarks />
            core_i3_4360t,

            /// <remarks />
            core_i3_4360,

            /// <remarks />
            core_i3_4160,

            /// <remarks />
            core_i3_4120u,

            /// <remarks />
            core_i3_4110m,

            /// <remarks />
            core_i3_4030y,

            /// <remarks />
            core_i3_4025u,

            /// <remarks />
            celeron_n2940,

            /// <remarks />
            celeron_n2840,

            /// <remarks />
            celeron_n2815,

            /// <remarks />
            celeron_n2808,

            /// <remarks />
            celeron_j1900,

            /// <remarks />
            celeron_j1800,

            /// <remarks />
            celeron_g1850,

            /// <remarks />
            celeron_g1840t,

            /// <remarks />
            celeron_g1840,

            /// <remarks />
            celeron_3205u,

            /// <remarks />
            celeron_2961y,

            /// <remarks />
            atom_z3795,

            /// <remarks />
            atom_z3785,

            /// <remarks />
            atom_z3775d,

            /// <remarks />
            atom_z3775,

            /// <remarks />
            atom_z3770d,

            /// <remarks />
            atom_z3745d,

            /// <remarks />
            atom_z3745,

            /// <remarks />
            atom_z3740d,

            /// <remarks />
            atom_z3735g,

            /// <remarks />
            atom_z3735f,

            /// <remarks />
            atom_z3735e,

            /// <remarks />
            atom_z3735d,

            /// <remarks />
            atom_z3580,

            /// <remarks />
            atom_z3560,

            /// <remarks />
            atom_z3480,

            /// <remarks />
            atom_z3460,

            /// <remarks />
            core_i7_4710MQ,

            /// <remarks />
            amd_a6_6400k,

            /// <remarks />
            core_i7_4810MQ,

            /// <remarks />
            core_i7_4860HQ,

            /// <remarks />
            atom_z3735,

            /// <remarks />
            quad_core_a8_6410,

            /// <remarks />
            Atom_z3635G,

            /// <remarks />
            arm_v7,

            /// <remarks />
            core_i7_4980HQ,

            /// <remarks />
            intel_core_i7_4810mq,

            /// <remarks />
            tegra_k1,

            /// <remarks />
            intel_bay_trail_m_n2830_dual_core,

            /// <remarks />
            intel_core_m,

            /// <remarks />
            a10_7850k,

            /// <remarks />
            a8_7600,

            /// <remarks />
            Core_i7_4790,

            /// <remarks />
            Core_i5_4460,

            /// <remarks />
            Core_i7_4710HQ,

            /// <remarks />
            Celeron_N2830_Dual_Core,

            /// <remarks />
            Core_i3_4160T,

            /// <remarks />
            Pentium_G3250T,

            /// <remarks />
            Core_i5_4570T,

            /// <remarks />
            FX_8300,

            /// <remarks />
            a10_7800,

            /// <remarks />
            cortex_a8,

            /// <remarks />
            Core_i3_4150T,

            /// <remarks />
            Pentium_G3240,

            /// <remarks />
            Core_i3_4150,

            /// <remarks />
            a33_arm_cortex_a7_quad_core,

            /// <remarks />
            quad_core_a8_6410_accelerated,

            /// <remarks />
            Celeron_N2830,

            /// <remarks />
            Pentium_N3530,

            /// <remarks />
            mxs,

            /// <remarks />
            mtk_8121,

            /// <remarks />
            E1_6010,

            /// <remarks />
            A4_6210,

            /// <remarks />
            Celeron_2957U,

            /// <remarks />
            Pentium_3558U,

            /// <remarks />
            Core_i3_4030U,

            /// <remarks />
            Core_i5_4210U,

            /// <remarks />
            Core_i7_4510U,

            /// <remarks />
            A6_6310,

            /// <remarks />
            MediaTek_MT8125,

            /// <remarks />
            phenom_x2,

            /// <remarks />
            phenom_x3,

            /// <remarks />
            phenom_x4,

            /// <remarks />
            celeron_d,

            /// <remarks />
            core_2_extreme,

            /// <remarks />
            core_2_quad,

            /// <remarks />
            core_2_solo,

            /// <remarks />
            core_duo,

            /// <remarks />
            core_i7_extreme,

            /// <remarks />
            core_solo,

            /// <remarks />
            pentium_d,

            /// <remarks />
            pentium_ii,

            /// <remarks />
            pentium_iii,

            /// <remarks />
            a_series,

            /// <remarks />
            athlon_ii_x2,

            /// <remarks />
            athlon_x2,

            /// <remarks />
            athlon_x4,

            /// <remarks />
            e_series,

            /// <remarks />
            fx_4_core,

            /// <remarks />
            fx_6_core,

            /// <remarks />
            fx_8_core,

            /// <remarks />
            cortex,

            /// <remarks />
            securcore,

            /// <remarks />
            celeron_m,

            /// <remarks />
            xeon_phi,

            /// <remarks />
            alpha,

            /// <remarks />
            exynos_5_octa_5800,

            /// <remarks />
            exynos_5_octa_5420,

            /// <remarks />
            Pentium_G3220,

            /// <remarks />
            Celeron_G1820,

            /// <remarks />
            A20,

            /// <remarks />
            A31,

            /// <remarks />
            A31s,

            /// <remarks />
            Core_i3_4130T,

            /// <remarks />
            Core_i3_4570T,

            /// <remarks />
            apple_a7,

            /// <remarks />
            A6_5350M,

            /// <remarks />
            T40_S_TEGRA_4_A15_Quad_Core,

            /// <remarks />
            SOC_PXA986_Dual_Core,

            /// <remarks />
            Pentium_N3510,

            /// <remarks />
            [XmlEnum("1_2GHz_Cortex_A8")] Item1_2GHz_Cortex_A8,

            /// <remarks />
            [XmlEnum("1_2GHz_Cortex_A13")] Item1_2GHz_Cortex_A13,

            /// <remarks />
            [XmlEnum("1_2GHz_Cortex_A9")] Item1_2GHz_Cortex_A9,

            /// <remarks />
            Atom_Z3740,

            /// <remarks />
            Atom_Z2560,

            /// <remarks />
            Atom_Z2580,

            /// <remarks />
            Atom_Z3770,

            /// <remarks />
            Core_i7_4650U,

            /// <remarks />
            A4_1250,

            /// <remarks />
            Clover_Trail_Plus_Z2560,

            /// <remarks />
            Exynos_4412,

            /// <remarks />
            Intel_Core_i7_Extreme,

            /// <remarks />
            MT8317T,

            /// <remarks />
            A10_5757M,

            /// <remarks />
            A8_5557M,

            /// <remarks />
            Intel_Core_i7_4702MQ,

            /// <remarks />
            A13,

            /// <remarks />
            Core_i5_3340s,

            /// <remarks />
            Core_i5_4440s,

            /// <remarks />
            Pentium_G2030T,

            /// <remarks />
            Core_i5_3340M,

            /// <remarks />
            E1_2500,

            /// <remarks />
            A4_1200_Accelerated,

            /// <remarks />
            Exynos_5250,

            /// <remarks />
            Core_i7_4200U,

            /// <remarks />
            E1_2500_Accelerated_Processor,

            /// <remarks />
            amd_r_series,

            /// <remarks />
            Core_i7_4700MQ,

            /// <remarks />
            Celeron_2950M,

            /// <remarks />
            Celeron_2955U,

            /// <remarks />
            Core_i3_3229Y,

            /// <remarks />
            Core_i3_4000M,

            /// <remarks />
            Core_i3_4005U,

            /// <remarks />
            Core_i3_4010U,

            /// <remarks />
            Core_i3_4010Y,

            /// <remarks />
            Core_i3_4012Y,

            /// <remarks />
            Core_i3_4020Y,

            /// <remarks />
            Core_i3_4100M,

            /// <remarks />
            Core_i3_4100U,

            /// <remarks />
            Core_i3_4158U,

            /// <remarks />
            Core_i5_3339Y,

            /// <remarks />
            Core_i5_3439Y,

            /// <remarks />
            Core_i5_4200H,

            /// <remarks />
            Core_i5_4200M,

            /// <remarks />
            Core_i5_4200Y,

            /// <remarks />
            Core_i5_4202Y,

            /// <remarks />
            Core_i5_4210Y,

            /// <remarks />
            Core_i5_4250U,

            /// <remarks />
            Core_i5_4258U,

            /// <remarks />
            Core_i5_4288U,

            /// <remarks />
            Core_i7_3689Y,

            /// <remarks />
            Core_i7_4550U,

            /// <remarks />
            Core_i7_4558U,

            /// <remarks />
            Core_i7_4700HQ,

            /// <remarks />
            Core_i7_4702HQ,

            /// <remarks />
            Core_i7_4750HQ,

            /// <remarks />
            Core_i7_4820K,

            /// <remarks />
            Core_i7_4930K,

            /// <remarks />
            Core_i7_4960X,

            /// <remarks />
            Pentium_3550M,

            /// <remarks />
            Pentium_3556U,

            /// <remarks />
            Pentium_3560Y,

            /// <remarks />
            Rockchip_RK2928,

            /// <remarks />
            Rockchip_3188,

            /// <remarks />
            A4_5000,

            /// <remarks />
            A6_5200,

            /// <remarks />
            Core_i3_4130,

            /// <remarks />
            Core_i5_4440,

            /// <remarks />
            Pentium_Dual_Core_2030M,

            /// <remarks />
            Celeron_1017U,

            /// <remarks />
            Pentium_Dual_Core_2127U,

            /// <remarks />
            Pentium_2127U,

            /// <remarks />
            Intel_Celeron_G1610T,

            /// <remarks />
            Intel_Pentium_G2020T,

            /// <remarks />
            Intel_Core_i3_3240T,

            /// <remarks />
            ARMv7,

            /// <remarks />
            ARMv7_Dual_Core,

            /// <remarks />
            Celeron_887,

            /// <remarks />
            Core_i3_2348M,

            /// <remarks />
            Core_i5_4430S,

            /// <remarks />
            Core_i5_4570,

            /// <remarks />
            Core_i5_4570S,

            /// <remarks />
            Core_i5_4670,

            /// <remarks />
            Core_i5_4670K,

            /// <remarks />
            Core_i7_4702MQ,

            /// <remarks />
            Core_i7_4770K,

            /// <remarks />
            Core_i7_4770S,

            /// <remarks />
            E2_Series_Dual_Core_E2_2000,

            /// <remarks />
            E_Series_Dual_Core_E1_1500,

            /// <remarks />
            i5_4670k,

            /// <remarks />
            i7_4770K,

            /// <remarks />
            Intel_Celeron_G470,

            /// <remarks />
            Intel_Core_i5_3330S,

            /// <remarks />
            Intel_Core_i5_4200U,

            /// <remarks />
            Intel_Core_i7_4500U,

            /// <remarks />
            Intel_Pentium_G2020,

            /// <remarks />
            Pentium_2117U,

            /// <remarks />
            Pentium_2129Y,

            /// <remarks />
            AMD_Kabini_A6_5200M_Quad_Core,

            /// <remarks />
            AMD_Kabini_E1_2100,

            /// <remarks />
            AMD_Richland_A10_5750M,

            /// <remarks />
            AMD_Richland_A8_5550M,

            /// <remarks />
            Intel_Core_i3_3120M,

            /// <remarks />
            Intel_Pentium_2127U_ULV,

            /// <remarks />
            Intel_Pentium_Dual_Core_2020M,

            /// <remarks />
            Intel_Celeron_1007U,

            /// <remarks />
            Intel_PDC_G2030,

            /// <remarks />
            Intel_Core_i3_3130M,

            /// <remarks />
            Intel_Core_i3_3240,

            /// <remarks />
            Intel_Core_i5_4430,

            /// <remarks />
            Intel_Core_i7_4700MQ,

            /// <remarks />
            Intel_Core_i7_4770,

            /// <remarks />
            Mediatek_8317_Dual_Core,

            /// <remarks />
            Mediatek_8389_Quadcore,

            /// <remarks />
            Intel_Clover_Trail,

            /// <remarks />
            a_series_quad_core_a8_6500,

            /// <remarks />
            a_series_quad_core_a10_6700,

            /// <remarks />
            A10,

            /// <remarks />
            [XmlEnum("210")] Item210,

            /// <remarks />
            GP33003,

            /// <remarks />
            Core_i5_3330M,

            /// <remarks />
            Snapdragon_QSD8250,

            /// <remarks />
            GEODE_LX_LX_800,

            /// <remarks />
            Celeron_220,

            /// <remarks />
            Pentium_D_840,

            /// <remarks />
            Core_2_Duo_E6320,

            /// <remarks />
            Sempron_SI_42,

            /// <remarks />
            Phenom_II_X2_B55,

            /// <remarks />
            Athlon_64_3000,

            /// <remarks />
            Pentium_M_755,

            /// <remarks />
            C7_M_764,

            /// <remarks />
            Pentium_G524,

            /// <remarks />
            Sempron_2200,

            /// <remarks />
            Pentium_M_773,

            /// <remarks />
            Athlon_64_Mobile_3000,

            /// <remarks />
            Turion_64_MK_36,

            /// <remarks />
            C7_M_770_VIA,

            /// <remarks />
            Sempron_2100,

            /// <remarks />
            Sempron_3000,

            /// <remarks />
            Athlon_64_3800,

            /// <remarks />
            Athlon_XP_3000,

            /// <remarks />
            Celeron_T1600,

            /// <remarks />
            Pentium_M_710,

            /// <remarks />
            Pentium_M_750,

            /// <remarks />
            Pentium_G550,

            /// <remarks />
            Athlon_II_X3_445AIIX3,

            /// <remarks />
            Celeron_M_410,

            /// <remarks />
            Core_2_Duo_T5900,

            /// <remarks />
            Turion_X2_Ultra_ZM_84,

            /// <remarks />
            Pentium_G570,

            /// <remarks />
            Celeron_M_340,

            /// <remarks />
            Pentium_M_735,

            /// <remarks />
            Pentium_D_820,

            /// <remarks />
            Turion_II_ULTRA_M660,

            /// <remarks />
            Pentium_M_740,

            /// <remarks />
            Turion_64_ML_34,

            /// <remarks />
            Athlon_64_LE_1660,

            /// <remarks />
            Athlon_64_LE_1600,

            /// <remarks />
            Athlon_II_X3_415E,

            /// <remarks />
            Celeron_M_330,

            /// <remarks />
            Sempron_M_3100,

            /// <remarks />
            Celeron_D_345,

            /// <remarks />
            Celeron_540,

            /// <remarks />
            Pentium_E6500,

            /// <remarks />
            Turion_64_MT_28,

            /// <remarks />
            Pentium_D_940,

            /// <remarks />
            Celeron_M_370,

            /// <remarks />
            Core_Duo_T2300,

            /// <remarks />
            Core_2_Duo_T9800,

            /// <remarks />
            Turion_II_ULTRA_M600,

            /// <remarks />
            Pentium_M_A110,

            /// <remarks />
            Pentium_T2410,

            /// <remarks />
            Celeron_M_320,

            /// <remarks />
            Turion_64_ML_32,

            /// <remarks />
            Core_2_Duo_E4700,

            /// <remarks />
            Core_Duo_T2600,

            /// <remarks />
            Pentium_M_725A,

            /// <remarks />
            Celeron_M_380,

            /// <remarks />
            Pentium_G662,

            /// <remarks />
            Mobile_Pentium_4_538,

            /// <remarks />
            Core_2_Duo_E6700,

            /// <remarks />
            Pentium_G540,

            /// <remarks />
            Core_2_Duo_U7600,

            /// <remarks />
            Pentium_D_915,

            /// <remarks />
            Turion_64_MT_37,

            /// <remarks />
            Celeron_M_430,

            /// <remarks />
            Celeron_D_326,

            /// <remarks />
            Opteron_Quad_1354,

            /// <remarks />
            Sempron_3200,

            /// <remarks />
            Pentium_D_830,

            /// <remarks />
            Athlon_64_X2_QL_65,

            /// <remarks />
            Core_Solo_T1300,

            /// <remarks />
            Pentium_G517,

            /// <remarks />
            Sempron_M_3000,

            /// <remarks />
            Celeron_D_346,

            /// <remarks />
            Sempron_M_2600,

            /// <remarks />
            Athlon_64_X2_TK_55,

            /// <remarks />
            Sempron_3400,

            /// <remarks />
            Athlon_64_X2_4600,

            /// <remarks />
            Turion_64_MT_30,

            /// <remarks />
            Core_I3_2330E,

            /// <remarks />
            Athlon_64_3400,

            /// <remarks />
            Turion_64_ML_28,

            /// <remarks />
            Celeron_330,

            /// <remarks />
            Athlon_64_3200,

            /// <remarks />
            C7_M_772_VIA,

            /// <remarks />
            Pentium_D_945,

            /// <remarks />
            Pentium_M_760,

            /// <remarks />
            Pentium_M_745,

            /// <remarks />
            Athlon_64_L110,

            /// <remarks />
            Pentium_M_753,

            /// <remarks />
            Pentium_M_770,

            /// <remarks />
            Pentium_M_733,

            /// <remarks />
            Core_Duo_T2350,

            /// <remarks />
            Core_2_Duo_E8300,

            /// <remarks />
            Core_Solo_T1200,

            /// <remarks />
            Core_2_Duo_L7200,

            /// <remarks />
            Pentium_G519,

            /// <remarks />
            Core_Duo_T2050,

            /// <remarks />
            Pentium_G515,

            /// <remarks />
            Pentium_D_920,

            /// <remarks />
            Turion_64_MT_32,

            /// <remarks />
            Pentium_G631,

            /// <remarks />
            Turion_64_ML_37,

            /// <remarks />
            Pentium_D_930,

            /// <remarks />
            Pentium_G641,

            /// <remarks />
            Pentium_G650,

            /// <remarks />
            Celeron_M_420,

            /// <remarks />
            Celeron_D_335,

            /// <remarks />
            Pentium_G531,

            /// <remarks />
            Mobile_Pentium_4_532,

            /// <remarks />
            Turion_64_MK_38,

            /// <remarks />
            Pentium_G560,

            /// <remarks />
            Pentium_D_805,

            /// <remarks />
            Sempron_64_3000,

            /// <remarks />
            Pentium_D_950,

            /// <remarks />
            Pentium_G660,

            /// <remarks />
            V_SERIES_V160,

            /// <remarks />
            C_SERIES_C_60,

            /// <remarks />
            Turion_64_ML_30,

            /// <remarks />
            C_SERIES_C_30,

            /// <remarks />
            Athlon_X2_4050E,

            /// <remarks />
            Sempron_3300,

            /// <remarks />
            Celeron_M_350,

            /// <remarks />
            Celeron_M_390,

            /// <remarks />
            Pentium_G520,

            /// <remarks />
            Athlon_64_LE_1640,

            /// <remarks />
            Xeon_W3520,

            /// <remarks />
            Celeron_B800,

            /// <remarks />
            Sempron_3100,

            /// <remarks />
            Pentium_M_725,

            /// <remarks />
            Core_Solo_T1350,

            /// <remarks />
            Athlon_64_3700,

            /// <remarks />
            Celeron_M_360,

            /// <remarks />
            Pentium_G516,

            /// <remarks />
            Celeron_T3100,

            /// <remarks />
            Core_Duo_T2300E,

            /// <remarks />
            Phenom_II_X4_N960,

            /// <remarks />
            Pentium_M_730,

            /// <remarks />
            Core_Solo_U1400,

            /// <remarks />
            Pentium_M_715,

            /// <remarks />
            Celeron_D_340,

            /// <remarks />
            Sempron_210U,

            /// <remarks />
            Core_Solo_U1300,

            /// <remarks />
            Atom_N435,

            /// <remarks />
            Core_2_Duo_T7600,

            /// <remarks />
            Celeron_D_325,

            /// <remarks />
            Turion_64_X2_TL_68,

            /// <remarks />
            Celeron_G530,

            /// <remarks />
            Core_Duo_T2500,

            /// <remarks />
            Celeron_D_336,

            /// <remarks />
            Core_i7_3840QM,

            /// <remarks />
            Core_i3_3227U,

            /// <remarks />
            Core_i5_3337U,

            /// <remarks />
            Core_i7_3537U,

            /// <remarks />
            Core_i5_3230M,

            /// <remarks />
            Vision_A10_Quad_Core_APU,

            /// <remarks />
            Pentium_G870,

            /// <remarks />
            Core_i5_3350P,

            /// <remarks />
            Atom_Z2760,

            /// <remarks />
            Celeron_847,

            /// <remarks />
            Core_i3_2365M,

            /// <remarks />
            Exynos_5000_Series,

            /// <remarks />
            Core_i7_3632QM,

            /// <remarks />
            Core_i3_2328M,

            /// <remarks />
            Core_i7_3630QM,

            /// <remarks />
            Pentium_B980,

            /// <remarks />
            Core_i5_3330,

            /// <remarks />
            Core_i3_3220,

            /// <remarks />
            Celeron_B830,

            /// <remarks />
            Pentium_G645,

            /// <remarks />
            A_Series_Quad_Core_A8_3850,

            /// <remarks />
            ARM_Cortex_A_9,

            /// <remarks />
            Celeron_877,

            /// <remarks />
            A_Series_Eight_Core_A10_4600M,

            /// <remarks />
            Core_i3_2130,

            /// <remarks />
            ARM_Cortex_A5,

            /// <remarks />
            A_Series_Tri_Core_A6_3500,

            /// <remarks />
            Core_i5_2380P,

            /// <remarks />
            Celeron_B820,

            /// <remarks />
            Pentium_G640,

            /// <remarks />
            A_Series_Quad_Core_A10_5700,

            /// <remarks />
            Celeron_G540,

            /// <remarks />
            Atom_D2550,

            /// <remarks />
            cortex_a7,

            /// <remarks />
            Snapdragon_S5,

            /// <remarks />
            core_i7_3517um,

            /// <remarks />
            Core_i3_3217U,

            /// <remarks />
            OMAP_5400,

            /// <remarks />
            tegra_4,

            /// <remarks />
            Celeron_867,

            /// <remarks />
            OMAP_3500,

            /// <remarks />
            OMAP_3600,

            /// <remarks />
            Snapdragon_s2,

            /// <remarks />
            novathor_l9000,

            /// <remarks />
            Exynos_4200,

            /// <remarks />
            Snapdragon_S3,

            /// <remarks />
            nova_a9000,

            /// <remarks />
            OMAP_4400,

            /// <remarks />
            Snapdragon_S4,

            /// <remarks />
            core_i3_2370M,

            /// <remarks />
            Snapdragon_s1,

            /// <remarks />
            apple_a5x,

            /// <remarks />
            OMAP_3400,

            /// <remarks />
            Pentium_B820,

            /// <remarks />
            Core_i3_3110M,

            /// <remarks />
            core_i3_2377m,

            /// <remarks />
            Pentium_B967,

            /// <remarks />
            Exynos_5400,

            /// <remarks />
            novathor_l8000,

            /// <remarks />
            Exynos_5200,

            /// <remarks />
            Exynos_4400,

            /// <remarks />
            Celeron_B840,

            /// <remarks />
            A_Series_Quad_Core_A8_5500,

            /// <remarks />
            FX_Series_Eigth_Core_FX_8320,

            /// <remarks />
            E_Series_Dual_Core_E1_1200,

            /// <remarks />
            A_Series_Dual_Core_A6_3620,

            /// <remarks />
            A_Series_Dual_Core_A4_4300M,

            /// <remarks />
            FX_Series_Eight_Core_FX_8350,

            /// <remarks />
            FX_Series_Six_Core_FX_6300,

            /// <remarks />
            A_Series_Dual_Core_A6_5400K,

            /// <remarks />
            A_Series_Dual_Core_A4_4355M,

            /// <remarks />
            FX_Series_Quad_Core_FX_4320,

            /// <remarks />
            A_Series_Dual_Core_A6_4400M,

            /// <remarks />
            A_Series_Dual_Core_A4_3305,

            /// <remarks />
            A_Series_Quad_Core_A8_4500M,

            /// <remarks />
            Core_i7_3615QM,

            /// <remarks />
            A_Series_Dual_Core_A4_3420,

            /// <remarks />
            A_Series_Dual_Core_A6_4455M,

            /// <remarks />
            E_Series_Dual_Core_E3_3200,

            /// <remarks />
            FX_Series_Six_Core_FX_6200,

            /// <remarks />
            A_Series_Quad_Core_A6_3430MX,

            /// <remarks />
            A_Series_Quad_Core_A8_3520M,

            /// <remarks />
            FX_Series_Quad_Core_FX_4120,

            /// <remarks />
            A_Series_Dual_Core_A4_5300,

            /// <remarks />
            E_Series_Dual_Core_E2_3000,

            /// <remarks />
            A_Series_Quad_Core_A8_5600K,

            /// <remarks />
            A_Series_Quad_Core_A10_4655M,

            /// <remarks />
            A_Series_Quad_Core_A8_4555M,

            /// <remarks />
            A_Series_Eight_Core_A10_5800K,

            /// <remarks />
            A_Series_Quad_Core_A10_4600M,

            /// <remarks />
            A_Series_Eight_Core_A10_5700,

            /// <remarks />
            E_Series_Dual_Core_E2_1800,

            /// <remarks />
            A_Series_Dual_Core_A6_3650,

            /// <remarks />
            Pentium_G860,

            /// <remarks />
            Core_i7_3517U,

            /// <remarks />
            Core_i5_3550,

            /// <remarks />
            Core_i7_3520M,

            /// <remarks />
            Pentium_G630,

            /// <remarks />
            Pentium_B970,

            /// <remarks />
            Core_i7_3667U,

            /// <remarks />
            Core_i5_3470T,

            /// <remarks />
            Pentium_B960,

            /// <remarks />
            Core_i7_3770T,

            /// <remarks />
            Core_i5_2467M,

            /// <remarks />
            Core_i7_3610QM,

            /// <remarks />
            Core_i5_3570T,

            /// <remarks />
            Core_i7_3770S,

            /// <remarks />
            Pentium_G630T,

            /// <remarks />
            Core_i3_2390T,

            /// <remarks />
            Core_i7_3770K,

            /// <remarks />
            Core_i7_3820QM,

            /// <remarks />
            Core_i5_3450S,

            /// <remarks />
            Core_i5_3360M,

            /// <remarks />
            Core_i5_3210M,

            /// <remarks />
            Pentium_997,

            /// <remarks />
            Core_i7_3920XM,

            /// <remarks />
            Core_i5_3317U,

            /// <remarks />
            Core_i3_2120T,

            /// <remarks />
            Core_i5_3427U,

            /// <remarks />
            Core_i5_3320M,

            /// <remarks />
            Core_i5_3570K,

            /// <remarks />
            Core_i5_3450,

            /// <remarks />
            Core_i5_3550S,

            /// <remarks />
            Core_i7_3720QM,

            /// <remarks />
            Core_i7_3770,

            /// <remarks />
            Core_i7_3612QM,

            /// <remarks />
            tegra_ap_2600,

            /// <remarks />
            omap4470,

            /// <remarks />
            Snapdragon_MSM8260A,

            /// <remarks />
            Snapdragon_S3_MSM8260,

            /// <remarks />
            Snapdragon_S3_MSM8660,

            /// <remarks />
            apple_a4,

            /// <remarks />
            Snapdragon_S1_MSM7225,

            /// <remarks />
            Core_i5_2435M,

            /// <remarks />
            Snapdragon_S3_APQ8060,

            /// <remarks />
            Snapdragon_S4_APQ8064,

            /// <remarks />
            tegra_2_t20,

            /// <remarks />
            Exynos_4210,

            /// <remarks />
            tegra_2_t25,

            /// <remarks />
            Snapdragon_S2_MSM7230,

            /// <remarks />
            Atom_N2800,

            /// <remarks />
            brazos_e450,

            /// <remarks />
            Core_i5_2557M,

            /// <remarks />
            omap3630,

            /// <remarks />
            omap4430,

            /// <remarks />
            omap4460,

            /// <remarks />
            Exynos_3110,

            /// <remarks />
            apple_a5,

            /// <remarks />
            apple_a6,

            /// <remarks />
            tegra_650,

            /// <remarks />
            tegra_ap_2500,

            /// <remarks />
            a_series_dual_core_a4_3305m,

            /// <remarks />
            tegra_600,

            /// <remarks />
            omap3620,

            /// <remarks />
            omap5432,

            /// <remarks />
            Snapdragon_S4_MSM8230,

            /// <remarks />
            Snapdragon_S2_MSM8225,

            /// <remarks />
            Snapdragon_S4_MSM8270,

            /// <remarks />
            Snapdragon_S1_QSD8650,

            /// <remarks />
            Core_i7_2620M,

            /// <remarks />
            omap5430,

            /// <remarks />
            a_series_quad_core_a6_3420m,

            /// <remarks />
            Core_i3_2350M,

            /// <remarks />
            Core_i5_2450M,

            /// <remarks />
            Core_i7_2670QM,

            /// <remarks />
            Core_i5_2430M,

            /// <remarks />
            pentium_g530,

            /// <remarks />
            i3_2370m,

            /// <remarks />
            atom_n2600,

            /// <remarks />
            i3_2367m,

            /// <remarks />
            i7_2640m,

            /// <remarks />
            i5_2450m,

            /// <remarks />
            i3_2367,

            /// <remarks />
            atom_d2700,

            /// <remarks />
            i5_2320,

            /// <remarks />
            i7_2670qm,

            /// <remarks />
            celeron_b815,

            /// <remarks />
            i3_2350m,

            /// <remarks />
            i5_2430m,

            /// <remarks />
            i7_2675qm,

            /// <remarks />
            i7_2677m,

            /// <remarks />
            a_series_quad_core_a8_3500m,

            /// <remarks />
            a_series_quad_core_a6_3600m,

            /// <remarks />
            i7_3960x,

            /// <remarks />
            c_series_dual_core_c_60,

            /// <remarks />
            e_series_dual_core_e_300,

            /// <remarks />
            a_series_quad_core_a6_3400m,

            /// <remarks />
            a_series_quad_core_a6_3410m,

            /// <remarks />
            i7_2700k,

            /// <remarks />
            c_series_dual_core_c_50,

            /// <remarks />
            z_series_dual_core_z_01,

            /// <remarks />
            i7_3930k,

            /// <remarks />
            i7_2637m,

            /// <remarks />
            a_series_dual_core_a4_3400m,

            /// <remarks />
            e_series_single_core_e_240,

            /// <remarks />
            i7_3820,

            /// <remarks />
            phenom_ii_x4_quad_core_n970,

            /// <remarks />
            a_series_dual_core_a4_3310m,

            /// <remarks />
            i5_2467m,

            /// <remarks />
            arm_dual_core_cortex_a9_omap_4,

            /// <remarks />
            e_series_dual_core_e_450,

            /// <remarks />
            a_series_dual_core_a4_3300m,

            /// <remarks />
            ARM_9_2818,

            /// <remarks />
            ARM_11_Telechips_8902,

            /// <remarks />
            ARM_11_2818,

            /// <remarks />
            ARM_11_iMAPX210,

            /// <remarks />
            ARM_11_iMAP210,

            /// <remarks />
            ARM_11_ROCK_2818,

            /// <remarks />
            [XmlEnum("8803_CORTEX_A8")] Item8803_CORTEX_A8,

            /// <remarks />
            ARM_11_8902,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.66GHz")] Core_2_Duo_266GHz,

            /// <remarks />
            Turion_64_X2_RM_72,

            /// <remarks />
            Core_i5_430M_,

            /// <remarks />
            Celeron_485,

            /// <remarks />
            Core_2_Duo_SL9300_,

            /// <remarks />
            [XmlEnum("Quad_Core_2.26GHz")] Quad_Core_226GHz,

            /// <remarks />
            Core_i5_2400,

            /// <remarks />
            Phenom_II_X2_Dual_Core_B75,

            /// <remarks />
            Core_i5_2405S,

            /// <remarks />
            Core_2_Duo_T6500,

            /// <remarks />
            Athlon_X2_Dual_Core_5000_plus_,

            /// <remarks />
            Celeron_D_360,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.13GHz")] Core_2_Duo_213GHz,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.83GHz")] Core_2_Duo_183GHz,

            /// <remarks />
            Core_Duo_T2450,

            /// <remarks />
            Atom_230,

            /// <remarks />
            Turion_64_X2_ZM_82,

            /// <remarks />
            Turion_X2_ZM_82,

            /// <remarks />
            Pentium_P6300,

            /// <remarks />
            Pentium_957,

            /// <remarks />
            Phenom_II_X4_Quad_Core_B95,

            /// <remarks />
            Pentium_B940,

            /// <remarks />
            Core_i5_540UM,

            /// <remarks />
            Turion_X2_RM_75,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.5GHz")] Core_2_Duo_25GHz,

            /// <remarks />
            Core_i3_2105,

            /// <remarks />
            A_Series_Dual_Core_A4,

            /// <remarks />
            Atom_Z520,

            /// <remarks />
            Athlon_II_X2_Dual_Core_260,

            /// <remarks />
            Athlon_II_X3_Triple_Core_450,

            /// <remarks />
            [XmlEnum("Core_i3_3.2_GHz_")] Core_i3_32_GHz_,

            /// <remarks />
            Core_i5_2500K,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.66GHz")] Core_2_Duo_166GHz,

            /// <remarks />
            Core_i3_2357M,

            /// <remarks />
            Turion_64_X2_TL_56,

            /// <remarks />
            Turion_X2_Ultra_ZM_85,

            /// <remarks />
            Core_i3_2120,

            /// <remarks />
            [XmlEnum("Core_i5_2.8GHz")] Core_i5_28GHz,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.1GHz")] Core_2_Duo_21GHz,

            /// <remarks />
            Celeron_P4500,

            /// <remarks />
            Pentium_4_360,

            /// <remarks />
            Core_i5_2390T,

            /// <remarks />
            Turion_II_X2_Dual_Core_N530,

            /// <remarks />
            Athlon_X2_Dual_Core_QL_64,

            /// <remarks />
            Athlon_II_X2_Dual_Core_235e_,

            /// <remarks />
            Athlon_Dual_Core,

            /// <remarks />
            Athlon_II_X4_Quad_Core_620_,

            /// <remarks />
            Core_i5_520M,

            /// <remarks />
            Pentium_G620T,

            /// <remarks />
            [XmlEnum("Core_i7_2.7_GHz")] Core_i7_27_GHz,

            /// <remarks />
            Celeron_M_ULV,

            /// <remarks />
            Turion_II_X2_Dual_Core_M520_,

            /// <remarks />
            Core_i7_2617M,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.33GHz")] Core_2_Duo_233GHz,

            /// <remarks />
            Pentium_U3600,

            /// <remarks />
            Turion_X2_Ultra_ZM_82,

            /// <remarks />
            Pentium_G840,

            /// <remarks />
            [XmlEnum("Quad_Core_Xeon_2.8_GHz_")] Quad_Core_Xeon_28_GHz_,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.6GHz")] Core_2_Duo_16GHz,

            /// <remarks />
            Athlon_II_X2_Dual_Core_220,

            /// <remarks />
            A_Series_Quad_Core_A8,

            /// <remarks />
            Core_i7_2600K,

            /// <remarks />
            Athlon_II_X2_Dual_Core_240e_,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.2GHz")] Core_2_Duo_22GHz,

            /// <remarks />
            Core_i3_2100_,

            /// <remarks />
            Core_i5_470UM_,

            /// <remarks />
            Core_i7_2410M,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.4GHz_")] Core_2_Duo_14GHz_,

            /// <remarks />
            ARM_7500fe,

            /// <remarks />
            Core_i7_980X,

            /// <remarks />
            Core_i5_2537M,

            /// <remarks />
            Turion_64_X2_RM_70,

            /// <remarks />
            Pentium_G6960,

            /// <remarks />
            Pentium_M_ULV,

            /// <remarks />
            Athlon_II_X2_Dual_Core_B24,

            /// <remarks />
            Xeon_E5507,

            /// <remarks />
            Pentium_G850,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.8GHz")] Core_2_Duo_18GHz,

            /// <remarks />
            Phenom_II_X4_Quad_Core_910_,

            /// <remarks />
            Celeron_E3400,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.16GHz")] Core_2_Duo_216GHz,

            /// <remarks />
            Core_i5_2457M,

            /// <remarks />
            Athlon_X2_Dual_Core_QL_62,

            /// <remarks />
            Core_i7_820QM,

            /// <remarks />
            Core_i5_560UM,

            /// <remarks />
            Turion_X2_Ultra_ZM_87,

            /// <remarks />
            Athlon_II_X2_Dual_Core_B26,

            /// <remarks />
            Atom_N455,

            /// <remarks />
            Athlon_II_X4Quad_Core_600e,

            /// <remarks />
            Core_i5_540M,

            /// <remarks />
            Celeron_D_420,

            /// <remarks />
            [XmlEnum("Core_i3_3.06_GHz_")] Core_i3_306_GHz_,

            /// <remarks />
            Quad_Core_Xeon,

            /// <remarks />
            Athlon_X2_Dual_Core,

            /// <remarks />
            Atom_N570,

            /// <remarks />
            Core_i5_2310,

            /// <remarks />
            Core_2_Due_P8400,

            /// <remarks />
            Atom_330,

            /// <remarks />
            Pentium_T2060,

            /// <remarks />
            ARM_710a,

            /// <remarks />
            Athlon_X2_Dual_Core_TK_57,

            /// <remarks />
            Core_Duo_T2400__,

            /// <remarks />
            Atom_Z670,

            /// <remarks />
            Phenom_II_X4_Quad_Core_645,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.26GHz")] Core_2_Duo_226GHz,

            /// <remarks />
            Phenom_II_X4_Quad_Core_840T_,

            /// <remarks />
            Core_2_Duo_T6670_,

            /// <remarks />
            Athlon_II_X2_Dual_Core_QL_64,

            /// <remarks />
            Turion_Neo_X2_Dual_Core_L625,

            /// <remarks />
            Athlon_II_X2_Dual_Core_245e_,

            /// <remarks />
            Athlon_X2_Dual_Core_TK_53,

            /// <remarks />
            Athlon_64_X2_Dual_Core_TK_42_,

            /// <remarks />
            A_Series_Quad_Core_A6,

            /// <remarks />
            Turion_II_X2_Dual_Core_M620,

            /// <remarks />
            A110,

            /// <remarks />
            Phenom_II_X2_Dual_Core_511_,

            /// <remarks />
            [XmlEnum("Core_i5_2.3_GHz")] Core_i5_23_GHz,

            /// <remarks />
            Core_i5_2400s,

            /// <remarks />
            Core_2_Duo_T6600_,

            /// <remarks />
            Phenom_II_X2_Dual_Core_P650,

            /// <remarks />
            Athlon_II_X2_Dual_Core_260u,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.0GHz")] Core_2_Duo_20GHz,

            /// <remarks />
            Core_i7_720QM,

            /// <remarks />
            Turion_X2_ZM_80,

            /// <remarks />
            Phenom_II_X6_Six_Core_1100T,

            /// <remarks />
            Core_i5_2410M,

            /// <remarks />
            Athlon_II_X4_Quad_Core_610e_,

            /// <remarks />
            Athon_II_X2_Dual_Core_P360,

            /// <remarks />
            Core_i7_2600S,

            /// <remarks />
            Core_i7_660UM,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.93GHz")] Core_2_Duo_293GHz,

            /// <remarks />
            Turion_64_X2_TL_52,

            /// <remarks />
            Core_i3_390M,

            /// <remarks />
            Celeron_T3500,

            /// <remarks />
            Turion_64_X2_TL_64,

            /// <remarks />
            Core_i7_2657M,

            /// <remarks />
            Athlon_64_X2_Pro_L310,

            /// <remarks />
            Atom_Z540,

            /// <remarks />
            Atom_Z550,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.8GHz")] Core_2_Duo_28GHz,

            /// <remarks />
            [XmlEnum("Quad_Core_Xeon_2.4GHz_")] Quad_Core_Xeon_24GHz_,

            /// <remarks />
            Quad_Core_Q9000,

            /// <remarks />
            Athlon_II_X3_Triple_Core_440,

            /// <remarks />
            Core_2_Duo_SU9600,

            /// <remarks />
            ARM_610,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.86GHz_")] Core_2_Duo_186GHz_,

            /// <remarks />
            Core_i5_2500,

            /// <remarks />
            [XmlEnum("Core_i7_2.2_GHz")] Core_i7_22_GHz,

            /// <remarks />
            Celeron_D_440,

            /// <remarks />
            [XmlEnum("Core_2_Duo_1.86GHz")] Core_2_Duo_186GHz,

            /// <remarks />
            Athlon_II_X4_Quad_Core_610e,

            /// <remarks />
            Core_i5_2500S,

            /// <remarks />
            Celeron_E3500,

            /// <remarks />
            Core_i5_2500T,

            /// <remarks />
            [XmlEnum("Core_Duo_1.83GHz")] Core_Duo_183GHz,

            /// <remarks />
            Atom_N450,

            /// <remarks />
            ARM_710t,

            /// <remarks />
            [XmlEnum("Core_i7_2.0_GHz")] Core_i7_20_GHz,

            /// <remarks />
            Phenom_II_X4_Quad_Core_9100E_,

            /// <remarks />
            Xeon_Dual_Core,

            /// <remarks />
            Pentium_847,

            /// <remarks />
            Atom_Z530,

            /// <remarks />
            Athlon_X2_Dual_Core_M300,

            /// <remarks />
            ARM_710,

            /// <remarks />
            Athlon_II_X2_Dual_Core_B22,

            /// <remarks />
            [XmlEnum("Core_2_Duo_3.06GHz")] Core_2_Duo_306GHz,

            /// <remarks />
            Core_i3_330M,

            /// <remarks />
            Phenom_II_X4_Quad_Core_840,

            /// <remarks />
            Phenom_II_X2_Dual_Core_250,

            /// <remarks />
            Athlon_X2_Dual_Core_L335,

            /// <remarks />
            Pentium_G620,

            /// <remarks />
            Tablet_Processor,

            /// <remarks />
            Atom_N450_,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.4GHz")] Core_2_Duo_24GHz,

            /// <remarks />
            C_Series_Single_Core_C_30,

            /// <remarks />
            Pentium_B950,

            /// <remarks />
            [XmlEnum("Core_2_Duo_2.53GHz")] Core_2_Duo_253GHz,

            /// <remarks />
            Core_i3_2310M,

            /// <remarks />
            Athlon_X2_Dual_Core_QL_60,

            /// <remarks />
            Athlon_X2_Dual_Core_3250e,

            /// <remarks />
            Celeron_763,

            /// <remarks />
            intel_atom_z550,

            /// <remarks />
            intel_atom_z510,

            /// <remarks />
            [XmlEnum("")] Item
        }

        /// <remarks />
        public enum PromotionApplicationType
        {
            /// <remarks />
            Principal,

            /// <remarks />
            Shipping
        }

        /// <remarks />
        public enum RadiationUnitOfMeasure
        {
            /// <remarks />
            watts_per_kilogram
        }

        /// <remarks />
        public enum RefreshRateUnitOfMeasure
        {
            /// <remarks />
            GHz,

            /// <remarks />
            MHz
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum RelatedProductIDType
        {
            /// <remarks />
            UPC,

            /// <remarks />
            EAN,

            /// <remarks />
            GTIN
        }

        /// <remarks />
        public enum RemovableMemoryValues
        {
            /// <remarks />
            [XmlEnum("1_4_inch_audio")] Item1_4_inch_audio,

            /// <remarks />
            [XmlEnum("2_5_mm_audio")] Item2_5_mm_audio,

            /// <remarks />
            [XmlEnum("3.0_v_ttl")] Item30_v_ttl,

            /// <remarks />
            [XmlEnum("3_5_floppy")] Item3_5_floppy,

            /// <remarks />
            [XmlEnum("3_5_mm_audio")] Item3_5_mm_audio,

            /// <remarks />
            ata,

            /// <remarks />
            ata_flash_card,

            /// <remarks />
            audio_video_port,

            /// <remarks />
            bluetooth,

            /// <remarks />
            built_in_flash_memory,

            /// <remarks />
            [XmlEnum("cd-r")] cdr,

            /// <remarks />
            cd_rw,

            /// <remarks />
            cdr_drive,

            /// <remarks />
            compact_disc,

            /// <remarks />
            compact_flash_card,

            /// <remarks />
            compact_flash_type_i_or_ii,

            /// <remarks />
            compactflash_type_i,

            /// <remarks />
            compactflash_type_ii,

            /// <remarks />
            component_video,

            /// <remarks />
            composite_video,

            /// <remarks />
            d_sub,

            /// <remarks />
            dmi,

            /// <remarks />
            dssi,

            /// <remarks />
            dvd_r,

            /// <remarks />
            dvd_rw,

            /// <remarks />
            dvi_x_1,

            /// <remarks />
            dvi_x_2,

            /// <remarks />
            dvi_x_4,

            /// <remarks />
            eide,

            /// <remarks />
            eisa,

            /// <remarks />
            ethernet,

            /// <remarks />
            express_card,

            /// <remarks />
            fibre_channel,

            /// <remarks />
            firewire_1600,

            /// <remarks />
            firewire_3200,

            /// <remarks />
            firewire_400,

            /// <remarks />
            firewire_800,

            /// <remarks />
            firewire_esata,

            /// <remarks />
            game_port,

            /// <remarks />
            gbic,

            /// <remarks />
            hdmi,

            /// <remarks />
            headphone,

            /// <remarks />
            hp_hsc,

            /// <remarks />
            hp_pb,

            /// <remarks />
            hs_mmc,

            /// <remarks />
            ibm_microdrive,

            /// <remarks />
            ide,

            /// <remarks />
            ieee_1284,

            /// <remarks />
            ieee_1394,

            /// <remarks />
            infrared,

            /// <remarks />
            internal_w_removable_media,

            /// <remarks />
            iomega_clik_disk,

            /// <remarks />
            isa,

            /// <remarks />
            isp,

            /// <remarks />
            lanc,

            /// <remarks />
            mca,

            /// <remarks />
            media_card,

            /// <remarks />
            memory_stick,

            /// <remarks />
            memory_stick_duo,

            /// <remarks />
            memory_stick_micro,

            /// <remarks />
            memory_stick_pro,

            /// <remarks />
            memory_stick_pro_duo,

            /// <remarks />
            memory_stick_pro_hg_duo,

            /// <remarks />
            memory_stick_select,

            /// <remarks />
            memory_stick_xc,

            /// <remarks />
            memory_stick_xc_hg_micro,

            /// <remarks />
            memory_stick_xc_micro,

            /// <remarks />
            micard,

            /// <remarks />
            micro_sdhc,

            /// <remarks />
            micro_sdxc,

            /// <remarks />
            microsd,

            /// <remarks />
            mini_dvd,

            /// <remarks />
            mini_hdmi,

            /// <remarks />
            mini_pci,

            /// <remarks />
            mini_sdhc,

            /// <remarks />
            mini_sdxc,

            /// <remarks />
            minisd,

            /// <remarks />
            mmc_micro,

            /// <remarks />
            multimedia_card,

            /// <remarks />
            multimedia_card_mobile,

            /// <remarks />
            multimedia_card_plus,

            /// <remarks />
            multipronged_audio,

            /// <remarks />
            nubus,

            /// <remarks />
            parallel_interface,

            /// <remarks />
            pc_card,

            /// <remarks />
            pci,

            /// <remarks />
            pci_64,

            /// <remarks />
            pci_64_hot_plug,

            /// <remarks />
            pci_64_hot_plug_33_mhz,

            /// <remarks />
            pci_64_hot_plug_66_mhz,

            /// <remarks />
            pci_express_x4,

            /// <remarks />
            pci_express_x8,

            /// <remarks />
            pci_hot_plug,

            /// <remarks />
            pci_raid,

            /// <remarks />
            pci_x,

            /// <remarks />
            pci_x_1,

            /// <remarks />
            pci_x_100_mhz,

            /// <remarks />
            pci_x_133_mhz,

            /// <remarks />
            pci_x_16,

            /// <remarks />
            pci_x_16_gb,

            /// <remarks />
            pci_x_4,

            /// <remarks />
            pci_x_66_mhz,

            /// <remarks />
            pci_x_8,

            /// <remarks />
            pci_x_hot_plug,

            /// <remarks />
            pci_x_hot_plug_133_mhz,

            /// <remarks />
            pcmcia,

            /// <remarks />
            pcmcia_ii,

            /// <remarks />
            pcmcia_iii,

            /// <remarks />
            pictbridge,

            /// <remarks />
            [XmlEnum("ps/2")] ps2,

            /// <remarks />
            radio_frequency,

            /// <remarks />
            rs_mmc,

            /// <remarks />
            s_video,

            /// <remarks />
            sas,

            /// <remarks />
            sata_1_5_gb,

            /// <remarks />
            sata_3_0_gb,

            /// <remarks />
            sata_6_0_gb,

            /// <remarks />
            sbus,

            /// <remarks />
            scsi,

            /// <remarks />
            sdhc,

            /// <remarks />
            sdio,

            /// <remarks />
            sdxc,

            /// <remarks />
            secure_digital,

            /// <remarks />
            secure_mmc,

            /// <remarks />
            serial_interface,

            /// <remarks />
            sim_card,

            /// <remarks />
            smartmedia_card,

            /// <remarks />
            solid_state_drive,

            /// <remarks />
            spd,

            /// <remarks />
            springboard_module,

            /// <remarks />
            ssfdc,

            /// <remarks />
            superdisk,

            /// <remarks />
            transflash,

            /// <remarks />
            unknown,

            /// <remarks />
            usb,

            /// <remarks />
            [XmlEnum("usb1.0")] usb10,

            /// <remarks />
            [XmlEnum("usb1.1")] usb11,

            /// <remarks />
            [XmlEnum("usb3.0")] usb30,

            /// <remarks />
            usb_docking_station,

            /// <remarks />
            usb_streaming,

            /// <remarks />
            vga,

            /// <remarks />
            xd_picture_card,

            /// <remarks />
            xd_picture_card_h,

            /// <remarks />
            xd_picture_card_m,

            /// <remarks />
            xd_picture_card_m_plus
        }

        /// <remarks />
        public enum ResistanceUnitOfMeasure
        {
            /// <remarks />
            ohms
        }

        /// <remarks />
        public enum ResolutionUnitOfMeasure
        {
            /// <remarks />
            megapixels,

            /// <remarks />
            pixels,

            /// <remarks />
            lines_per_inch
        }

        /// <remarks />
        public enum SerialNumberFormatType
        {
            /// <remarks />
            a_or_z_alphanumeric_13,

            /// <remarks />
            alphanumeric_8,

            /// <remarks />
            numeric_14,

            /// <remarks />
            alphanumeric_14,

            /// <remarks />
            numeric_12,

            /// <remarks />
            w_alphanumeric_12
        }

        /// <remarks />
        public enum ServingUnit
        {
            /// <remarks />
            [XmlEnum("percent-fda")] percentfda,

            /// <remarks />
            mg,

            /// <remarks />
            gr,

            /// <remarks />
            ml,

            /// <remarks />
            grams,

            /// <remarks />
            milligrams,

            /// <remarks />
            milliliters
        }

        /// <remarks />
        public enum SimCardSlotCountType
        {
            /// <remarks />
            single_sim,

            /// <remarks />
            dual_sim,

            /// <remarks />
            triple_sim,

            /// <remarks />
            quad_sim
        }

        /// <remarks />
        public enum SpeedUnitOfMeasure
        {
            /// <remarks />
            feet_per_minute,

            /// <remarks />
            miles_per_hour,

            /// <remarks />
            kilometers_per_hour,

            /// <remarks />
            RPM,

            /// <remarks />
            RPS,

            /// <remarks />
            [XmlEnum("meters per second")] meterspersecond,

            /// <remarks />
            [XmlEnum("centimeters per second")] centimeterspersecond,

            /// <remarks />
            [XmlEnum("millimeters per second")] millimeterspersecond
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public enum StandardProductIDType
        {
            /// <remarks />
            ISBN,

            /// <remarks />
            UPC,

            /// <remarks />
            EAN,

            /// <remarks />
            ASIN,

            /// <remarks />
            GTIN,

            /// <remarks />
            GCID,

            /// <remarks />
            PZN
        }

        /// <remarks />
        public enum StoneCreationMethod
        {
            /// <remarks />
            natural,

            /// <remarks />
            simulated,

            /// <remarks />
            synthetic
        }

        /// <remarks />
        public enum SunProtectionUnitOfMeasure
        {
            /// <remarks />
            sun_protection_factor
        }

        /// <remarks />
        public enum SupportedImageTypeValues
        {
            /// <remarks />
            [XmlEnum("3f_tiff")] Item3f_tiff,

            /// <remarks />
            bmp,

            /// <remarks />
            canon_raw,

            /// <remarks />
            eps,

            /// <remarks />
            exif,

            /// <remarks />
            flashpix_fpx,

            /// <remarks />
            gif,

            /// <remarks />
            jpeg,

            /// <remarks />
            pcx,

            /// <remarks />
            pgpf,

            /// <remarks />
            pict,

            /// <remarks />
            png,

            /// <remarks />
            psd,

            /// <remarks />
            raw,

            /// <remarks />
            tga,

            /// <remarks />
            tiff,

            /// <remarks />
            unknown,

            /// <remarks />
            wif,

            /// <remarks />
            wmf
        }

        /// <remarks />
        public enum SweetnessAtHarvestUnitOfMeasure
        {
            /// <remarks />
            brix
        }

        /// <remarks />
        public enum TargetGenderType
        {
            /// <remarks />
            male,

            /// <remarks />
            female,

            /// <remarks />
            unisex
        }

        /// <remarks />
        public enum TemperatureRatingUnitOfMeasure
        {
            /// <remarks />
            [XmlEnum("degrees-celsius")] degreescelsius,

            /// <remarks />
            [XmlEnum("degrees-fahrenheit")] degreesfahrenheit,

            /// <remarks />
            kelvin
        }

        /// <remarks />
        public enum TemperatureUnitOfMeasure
        {
            /// <remarks />
            C,

            /// <remarks />
            F
        }

        /// <remarks />
        public enum ThreeDTechnologyValues
        {
            /// <remarks />
            active,

            /// <remarks />
            anaglyphic,

            /// <remarks />
            auto_stereoscopic,

            /// <remarks />
            passive
        }

        /// <remarks />
        public enum TimeUnitOfMeasure
        {
            /// <remarks />
            sec,

            /// <remarks />
            min,

            /// <remarks />
            hr,

            /// <remarks />
            days,

            /// <remarks />
            hours,

            /// <remarks />
            minutes,

            /// <remarks />
            seconds,

            /// <remarks />
            milliseconds,

            /// <remarks />
            microseconds,

            /// <remarks />
            nanoseconds,

            /// <remarks />
            picoseconds
        }

        /// <remarks />
        public enum TorqueUnitOfMeasure
        {
            /// <remarks />
            [XmlEnum("foot-lbs")] footlbs,

            /// <remarks />
            [XmlEnum("inch-lbs")] inchlbs,

            /// <remarks />
            centimeter_kilograms,

            /// <remarks />
            foot_pounds,

            /// <remarks />
            inch_ounces,

            /// <remarks />
            inch_pounds,

            /// <remarks />
            kilonewtons,

            /// <remarks />
            kilograms_per_millimeter,

            /// <remarks />
            newton_meters,

            /// <remarks />
            newton_millimeters,

            /// <remarks />
            newtons
        }

        /// <remarks />
        public enum ToyAwardType
        {
            /// <remarks />
            australia_toy_fair_boys_toy_of_the_year,

            /// <remarks />
            australia_toy_fair_toy_of_the_year,

            /// <remarks />
            baby_and_you,

            /// <remarks />
            babyworld,

            /// <remarks />
            child_magazine,

            /// <remarks />
            creative_child_magazine,

            /// <remarks />
            dr_toys_100_best_child_products,

            /// <remarks />
            energizer_battery_operated_toy_of_the_yr,

            /// <remarks />
            family_fun_toy_of_the_year_seal,

            /// <remarks />
            games_magazine,

            /// <remarks />
            gomama_today,

            /// <remarks />
            german_toy_association_toy_of_the_year,

            /// <remarks />
            hamleys_toy_of_the_year,

            /// <remarks />
            junior,

            /// <remarks />
            lion_mark,

            /// <remarks />
            mother_and_baby,

            /// <remarks />
            mum_knows_best,

            /// <remarks />
            national_parenting_approval_award,

            /// <remarks />
            norwegian_toy_association_toy_of_the_yr,

            /// <remarks />
            oppenheim_toys,

            /// <remarks />
            parents_choice_portfolio,

            /// <remarks />
            parents_magazine,

            /// <remarks />
            practical_parenting,

            /// <remarks />
            prima_baby,

            /// <remarks />
            reddot,

            /// <remarks />
            rdj_france_best_electronic_toy_of_the_yr,

            /// <remarks />
            rdj_france_best_toy_of_the_year,

            /// <remarks />
            the_times,

            /// <remarks />
            toy_wishes,

            /// <remarks />
            uk_npd_report_number_one_selling_toy,

            /// <remarks />
            unknown
        }

        /// <remarks />
        public enum UKMedicinesClassUnit
        {
            /// <remarks />
            professional_use_only,

            /// <remarks />
            general_sales_list,

            /// <remarks />
            pharmacy_p_line,

            /// <remarks />
            prescription_only
        }

        /// <remarks />
        public enum USKRatingType
        {
            /// <remarks />
            ages_6_and_over,

            /// <remarks />
            ages_12_and_over,

            /// <remarks />
            ages_16_and_over,

            /// <remarks />
            ages_18_and_over,

            /// <remarks />
            cannot_publicize,

            /// <remarks />
            checked_by_legal_department,

            /// <remarks />
            not_checked,

            /// <remarks />
            without_age_limitation,

            /// <remarks />
            unknown
        }

        /// <remarks />
        public enum VideotapeRecordingSpeedType
        {
            /// <remarks />
            unknown,

            /// <remarks />
            sp,

            /// <remarks />
            ep,

            /// <remarks />
            slp,

            /// <remarks />
            lp,

            /// <remarks />
            Unknown,

            /// <remarks />
            SP,

            /// <remarks />
            EP,

            /// <remarks />
            SLP,

            /// <remarks />
            LP
        }

        /// <remarks />
        public enum VineyardYieldUnitOfMeasure
        {
            /// <remarks />
            tons
        }

        /// <remarks />
        public enum VinylRecordDetailsType
        {
            /// <remarks />
            lp,

            /// <remarks />
            [XmlEnum("12_single")] Item12_single,

            /// <remarks />
            [XmlEnum("45")] Item45,

            /// <remarks />
            ep,

            /// <remarks />
            [XmlEnum("78")] Item78,

            /// <remarks />
            other,

            /// <remarks />
            unknown
        }

        /// <remarks />
        public enum VoltageUnitOfMeasure
        {
            /// <remarks />
            volts,

            /// <remarks />
            millivolts,

            /// <remarks />
            microvolts,

            /// <remarks />
            nanovolts,

            /// <remarks />
            kilovolts,

            /// <remarks />
            volts_of_alternating_current,

            /// <remarks />
            volts_of_direct_current
        }

        /// <remarks />
        public enum VolumeRateUnitOfMeasure
        {
            /// <remarks />
            [XmlEnum("milliliters per second")] milliliterspersecond,

            /// <remarks />
            [XmlEnum("centiliters per second")] centiliterspersecond,

            /// <remarks />
            [XmlEnum("liters per second")] literspersecond,

            /// <remarks />
            [XmlEnum("milliliters per minute")] millilitersperminute,

            /// <remarks />
            [XmlEnum("liters per minute")] litersperminute,

            /// <remarks />
            [XmlEnum("microliters per second")] microliterspersecond,

            /// <remarks />
            [XmlEnum("nanoliters per second")] nanoliterspersecond,

            /// <remarks />
            [XmlEnum("picoliters per second")] picoliterspersecond,

            /// <remarks />
            [XmlEnum("microliters per minute")] microlitersperminute,

            /// <remarks />
            [XmlEnum("nanoliters per minute")] nanolitersperminute,

            /// <remarks />
            [XmlEnum("picoliters per minute")] picolitersperminute,

            /// <remarks />
            gallons_per_day,

            /// <remarks />
            liters_per_day,

            /// <remarks />
            liters
        }

        /// <remarks />
        public enum VolumeUnitOfMeasure
        {
            /// <remarks />
            [XmlEnum("cubic-cm")] cubiccm,

            /// <remarks />
            [XmlEnum("cubic-ft")] cubicft,

            /// <remarks />
            [XmlEnum("cubic-in")] cubicin,

            /// <remarks />
            [XmlEnum("cubic-m")] cubicm,

            /// <remarks />
            [XmlEnum("cubic-yd")] cubicyd,

            /// <remarks />
            cup,

            /// <remarks />
            [XmlEnum("fluid-oz")] fluidoz,

            /// <remarks />
            gallon,

            /// <remarks />
            liter,

            /// <remarks />
            milliliter,

            /// <remarks />
            ounce,

            /// <remarks />
            pint,

            /// <remarks />
            quart,

            /// <remarks />
            liters,

            /// <remarks />
            deciliters,

            /// <remarks />
            centiliters,

            /// <remarks />
            milliliters,

            /// <remarks />
            microliters,

            /// <remarks />
            nanoliters,

            /// <remarks />
            picoliters
        }

        /// <remarks />
        public enum WaterResistantType
        {
            /// <remarks />
            not_water_resistant,

            /// <remarks />
            water_resistant,

            /// <remarks />
            waterproof
        }

        /// <remarks />
        public enum WattageUnitOfMeasure
        {
            /// <remarks />
            watts,

            /// <remarks />
            kilowatts
        }

        /// <remarks />
        public enum WeightUnitOfMeasure
        {
            /// <remarks />
            GR,

            /// <remarks />
            KG,

            /// <remarks />
            OZ,

            /// <remarks />
            LB,

            /// <remarks />
            MG,

            /// <remarks />
            hundredths_pounds,

            /// <remarks />
            kilograms,

            /// <remarks />
            pounds,

            /// <remarks />
            pounds_per_square_inch,

            /// <remarks />
            newtons,

            /// <remarks />
            pascal,

            /// <remarks />
            ounces,

            /// <remarks />
            grams_per_square_meter
        }

        /// <remarks />
        public enum WirelessTypeValues
        {
            /// <remarks />
            [XmlEnum("2.4_ghz_radio_frequency")] Item24_ghz_radio_frequency,

            /// <remarks />
            [XmlEnum("5.8_ghz_radio_frequency")] Item58_ghz_radio_frequency,

            /// <remarks />
            [XmlEnum("802_11_A")] Item802_11_A,

            /// <remarks />
            [XmlEnum("802_11_AB")] Item802_11_AB,

            /// <remarks />
            [XmlEnum("802_11_ABG")] Item802_11_ABG,

            /// <remarks />
            [XmlEnum("802_11_AG")] Item802_11_AG,

            /// <remarks />
            [XmlEnum("802_11_B")] Item802_11_B,

            /// <remarks />
            [XmlEnum("802_11_BGN")] Item802_11_BGN,

            /// <remarks />
            [XmlEnum("802_11_G")] Item802_11_G,

            /// <remarks />
            [XmlEnum("802_11_G_108Mbps")] Item802_11_G_108Mbps,

            /// <remarks />
            [XmlEnum("802_11_N")] Item802_11_N,

            /// <remarks />
            [XmlEnum("900_mhz_radio_frequency")] Item900_mhz_radio_frequency,

            /// <remarks />
            bluetooth,

            /// <remarks />
            dect,

            /// <remarks />
            [XmlEnum("dect_6.0")] dect_60,

            /// <remarks />
            infrared,

            /// <remarks />
            irda,

            /// <remarks />
            radio_frequency
        }

        /// <remarks />
        public enum ZoomUnitOfMeasure
        {
            /// <remarks />
            x
        }

        /// <summary>
        /// </summary>
        public class AddressType
        {
            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string Name { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string FormalTitle { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string GivenName { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string FamilyName { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string AddressFieldOne { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string AddressFieldTwo { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string AddressFieldThree { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string City { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string County { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string StateOrRegion { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string PostalCode { get; set; }

            /// <remarks />
            public string CountryCode { get; set; }

            /// <remarks />
            [XmlElement("PhoneNumber")]
            public PhoneNumberType[] PhoneNumber { get; set; }

            /// <remarks />
            public bool isDefaultShipping { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool isDefaultShippingSpecified { get; set; }

            /// <remarks />
            public bool isDefaultBilling { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool isDefaultBillingSpecified { get; set; }

            /// <remarks />
            public bool isDefaultOneClick { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool isDefaultOneClickSpecified { get; set; }
        }

        /// <remarks />
        public class PhoneNumberType
        {
            /// <remarks />
            [XmlAttribute]
            public PhoneNumberTypeType Type { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool TypeSpecified { get; set; }

            /// <remarks />
            [XmlAttribute]
            public string Description { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class AddressTypeSupportNonCity
        {
            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string Name { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string AddressFieldOne { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string AddressFieldTwo { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string AddressFieldThree { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string City { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string DistrictOrCounty { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string County { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string StateOrRegion { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string PostalCode { get; set; }

            /// <remarks />
            public string CountryCode { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string PhoneNumber { get; set; }
        }

        /// <remarks />
        public class EmailAddressType
        {
            /// <remarks />
            [XmlAttribute]
            public EmailAddressTypePreferredFormat PreferredFormat { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool PreferredFormatSpecified { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class AmazonFees
        {
            /// <remarks />
            [XmlElement("Fee")]
            public AmazonFeesFee[] Fee { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class AmazonFeesFee
        {
            /// <remarks />
            public string Type { get; set; }

            /// <remarks />
            public CurrencyAmount Amount { get; set; }
        }

        /// <remarks />
        public class CurrencyAmount
        {
            /// <remarks />
            [XmlAttribute]
            public BaseCurrencyCode currency { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool currencySpecified { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class BuyerPrice
        {
            /// <remarks />
            [XmlElement("Component")]
            public BuyerPriceComponent[] Component { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class BuyerPriceComponent
        {
            /// <remarks />
            public BuyerPriceComponentType Type { get; set; }

            /// <remarks />
            public CurrencyAmount Amount { get; set; }
        }

        /// <remarks />
        public class DirectPaymentType
        {
            /// <remarks />
            [XmlElement("Component")]
            public DirectPaymentTypeComponent[] Component { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class DirectPaymentTypeComponent
        {
            /// <remarks />
            public string Type { get; set; }

            /// <remarks />
            public CurrencyAmount Amount { get; set; }
        }

        /// <remarks />
        public class PositiveCurrencyAmount
        {
            /// <remarks />
            [XmlAttribute]
            public BaseCurrencyCode currency { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class DatedPrice
        {
            /// <remarks />
            public DateTime StartDate { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool StartDateSpecified { get; set; }

            /// <remarks />
            public DateTime EndDate { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool EndDateSpecified { get; set; }

            /// <remarks />
            [XmlElement("PreviousPrice", typeof(CurrencyAmount))]
            [XmlElement("Price", typeof(CurrencyAmount))]
            [XmlChoiceIdentifier("ItemElementName")]
            public CurrencyAmount Item { get; set; }

            /// <remarks />
            [XmlIgnore]
            public ItemChoiceType ItemElementName { get; set; }

            /// <remarks />
            [XmlAttribute]
            public bool delete { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool deleteSpecified { get; set; }
        }

        /// <remarks />
        public class DatedCompareAtPrice
        {
            /// <remarks />
            public DateTime StartDate { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool StartDateSpecified { get; set; }

            /// <remarks />
            public DateTime EndDate { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool EndDateSpecified { get; set; }

            /// <remarks />
            public CurrencyAmount CompareAtPrice { get; set; }

            /// <remarks />
            [XmlAttribute]
            public bool delete { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool deleteSpecified { get; set; }
        }

        /// <remarks />
        public class PromotionDataType
        {
            /// <remarks />
            public string PromotionClaimCode { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string MerchantPromotionID { get; set; }

            /// <remarks />
            [XmlElement("Component")]
            public PromotionDataTypeComponent[] Component { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class PromotionDataTypeComponent
        {
            /// <remarks />
            public PromotionApplicationType Type { get; set; }

            /// <remarks />
            public CurrencyAmount Amount { get; set; }
        }

        /// <remarks />
        public class ConditionInfo
        {
            /// <remarks />
            public ConditionType ConditionType { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string ConditionNote { get; set; }
        }

        /// <remarks />
        public class CustomizationInfoType
        {
            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string Type { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string Data { get; set; }
        }

        /// <remarks />
        public class RebateType
        {
            /// <remarks />
            public DateTime RebateStartDate { get; set; }

            /// <remarks />
            public DateTime RebateEndDate { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string RebateMessage { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string RebateName { get; set; }
        }

        /// <remarks />
        public class EnergyDimension
        {
            /// <remarks />
            [XmlAttribute]
            public EnergyUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class EnergyRatingType
        {
            /// <remarks />
            [XmlAttribute]
            public EnergyUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class AreaDimension
        {
            /// <remarks />
            [XmlAttribute]
            public AreaUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class AreaDimensionOptionalUnit
        {
            /// <remarks />
            [XmlAttribute]
            public AreaUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class AirFlowDisplacementDimension
        {
            /// <remarks />
            [XmlAttribute]
            public AirFlowDisplacementUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class BurnTimeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public BurnTimeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class CurencyDimension
        {
            /// <remarks />
            [XmlAttribute]
            public GlobalCurrencyCode unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class LengthDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LengthUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class LensFixedFocalLengthDimension
        {
            /// <remarks />
            [XmlAttribute]
            public FocalLengthDimension unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class LengthDimensionOptionalUnit
        {
            /// <remarks />
            [XmlAttribute]
            public LengthUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class LengthIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LengthUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class OptionalLengthIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LengthUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class LuminancePositiveIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LuminanceUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class LuminanceIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LuminanceUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "nonNegativeInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class LuminanceDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LuminanceUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class VolumeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public VolumeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class VolumeIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public VolumeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class VolumeRateDimension
        {
            /// <remarks />
            [XmlAttribute]
            public VolumeRateUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class WeightDimension
        {
            /// <remarks />
            [XmlAttribute]
            public WeightUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class WeightIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public WeightUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class JewelryLengthDimension
        {
            /// <remarks />
            [XmlAttribute]
            public JewelryLengthUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class JewelryWeightDimension
        {
            /// <remarks />
            [XmlAttribute]
            public JewelryWeightUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class PositiveWeightDimension
        {
            /// <remarks />
            [XmlAttribute]
            public WeightUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class PositiveNonZeroWeightDimension
        {
            /// <remarks />
            [XmlAttribute]
            public WeightUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class DegreeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public DegreeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class MemorySizeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public MemorySizeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class MemorySizeIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public MemorySizeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class FrequencyDimension
        {
            /// <remarks />
            [XmlAttribute]
            public FrequencyUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class FrequencyIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public FrequencyUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class AmperageDimension
        {
            /// <remarks />
            [XmlAttribute]
            public AmperageUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class ResistanceDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ResistanceUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class TimeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public TimeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class StringTimeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public TimeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class BatteryLifeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public BatteryAverageLifeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class TimeIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public TimeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class DateIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public DateUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class SubscriptionTermDimension
        {
            /// <remarks />
            [XmlAttribute]
            public DateUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class SunProtectionDimension
        {
            /// <remarks />
            [XmlAttribute]
            public SunProtectionUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class AssemblyTimeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public AssemblyTimeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class AgeRecommendedDimension
        {
            /// <remarks />
            [XmlAttribute]
            public AgeRecommendedUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class MinimumAgeRecommendedDimension
        {
            /// <remarks />
            [XmlAttribute]
            public AgeRecommendedUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "nonNegativeInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class BatteryPowerIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public BatteryPowerUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class BatteryPowerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public BatteryPowerUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class LuminiousIntensityDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LuminousIntensityUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class VoltageDecimalDimension
        {
            /// <remarks />
            [XmlAttribute]
            public VoltageUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class VoltageIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public VoltageUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class VoltageIntegerDimensionOptionalUnit
        {
            /// <remarks />
            [XmlAttribute]
            public VoltageUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class WattageIntegerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public WattageUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class WattageDimension
        {
            /// <remarks />
            [XmlAttribute]
            public WattageUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class WattageDimensionOptionalUnit
        {
            /// <remarks />
            [XmlAttribute]
            public WattageUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class MillimeterDecimalDimension
        {
            /// <remarks />
            [XmlAttribute]
            public MillimeterUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class NoiseLevelDimension
        {
            /// <remarks />
            [XmlAttribute]
            public NoiseLevelUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class TemperatureDimension
        {
            /// <remarks />
            [XmlAttribute]
            public TemperatureUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class StringTemperatureDimension
        {
            /// <remarks />
            [XmlAttribute]
            public TemperatureUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class TemperatureRatingDimension
        {
            /// <remarks />
            [XmlAttribute]
            public TemperatureRatingUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class ClothingSizeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ClothingSizeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class StringLengthOptionalDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LengthUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class StringLengthDimension
        {
            /// <remarks />
            [XmlAttribute]
            public LengthUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class CurrentDimension
        {
            /// <remarks />
            [XmlAttribute]
            public CurrentUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class GraduationInterval
        {
            /// <remarks />
            [XmlAttribute]
            public string unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class VolumeAndVolumeRateDimension
        {
            /// <remarks />
            [XmlAttribute]
            public string unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class ForceDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ForceUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class HardnessDimension
        {
            /// <remarks />
            [XmlAttribute]
            public HardnessUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class SweetnessAtHarvestDimension
        {
            /// <remarks />
            [XmlAttribute]
            public SweetnessAtHarvestUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class VineyardYieldDimension
        {
            /// <remarks />
            [XmlAttribute]
            public VineyardYieldUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class AlcoholContentDimension
        {
            /// <remarks />
            [XmlAttribute]
            public AlcoholContentUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class NicotineConcentrationDimension
        {
            /// <remarks />
            [XmlAttribute]
            public NicotineConcentrationUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class TorqueType
        {
            /// <remarks />
            [XmlAttribute]
            public TorqueUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class Customer
        {
            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string Name { get; set; }

            /// <remarks />
            public string FormalTitle { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string GivenName { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string FamilyName { get; set; }

            /// <remarks />
            public EmailAddressType Email { get; set; }

            /// <remarks />
            [XmlElement(DataType = "date")]
            public DateTime BirthDate { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool BirthDateSpecified { get; set; }

            /// <remarks />
            [XmlElement("CustomerAddress")]
            public AddressType[] CustomerAddress { get; set; }
        }

        /// <remarks />
        public class NameValuePair
        {
            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string Name { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class ZoomDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ZoomUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class PixelDimension
        {
            /// <remarks />
            [XmlAttribute]
            public PixelUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class PressureDimension
        {
            /// <remarks />
            [XmlAttribute]
            public PressureUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class OpticalPowerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public OpticalPowerUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class PowerDimension
        {
            /// <remarks />
            [XmlAttribute]
            public PowerUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class ResolutionDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ResolutionUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class OptionalResolutionDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ResolutionUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class ApertureDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ApertureUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class ContinuousShootingDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ContinuousShootingUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class EnergyConsumptionDimension
        {
            /// <remarks />
            [XmlAttribute]
            public EnergyConsumptionUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class LoyaltyCustomAttribute
        {
            /// <remarks />
            [XmlAttribute(DataType = "normalizedString")]
            public string attributeName { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class WeightRecommendationType
        {
            /// <remarks />
            public PositiveWeightDimension MaximumWeightRecommendation { get; set; }

            /// <remarks />
            public PositiveWeightDimension MinimumWeightRecommendation { get; set; }
        }

        /// <remarks />
        public class CharacterDataType
        {
            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string SKU { get; set; }

            /// <remarks />
            public DateTime EffectiveTimestamp { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool EffectiveTimestampSpecified { get; set; }

            /// <remarks />
            [XmlElement("Plugin")]
            public string[] Plugin { get; set; }

            /// <remarks />
            public string AdditionalMessageDiscriminator { get; set; }

            /// <remarks />
            public string Payload { get; set; }

            /// <remarks />
            [XmlAttribute]
            public string schemaVersion { get; set; }

            /// <remarks />
            [XmlAttribute]
            public bool isOfferOnlyUpdate { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool isOfferOnlyUpdateSpecified { get; set; }
        }

        /// <remarks />
        public class SpeedDimension
        {
            /// <remarks />
            [XmlAttribute]
            public SpeedUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class MagnificationDimension
        {
            /// <remarks />
            [XmlAttribute]
            public MagnificationUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "positiveInteger")]
            public string Value { get; set; }
        }

        /// <remarks />
        public class OptionalMagnificationDimension
        {
            /// <remarks />
            [XmlAttribute]
            public MagnificationUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class NeckSizeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public NeckSizeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class CycleLengthDimension
        {
            /// <remarks />
            [XmlAttribute]
            public CycleLengthUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class BootSizeDimension
        {
            /// <remarks />
            [XmlAttribute]
            public BootSizeUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class DensityDimension
        {
            /// <remarks />
            [XmlAttribute]
            public DensityUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class CapacityUnit
        {
            /// <remarks />
            [XmlAttribute]
            public CapacityUnitMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class ServingDimension
        {
            /// <remarks />
            [XmlAttribute]
            public ServingUnit unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class MaximumPowerType
        {
            /// <remarks />
            [XmlAttribute]
            public MaximumPowerUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class RadiationUnitDimension
        {
            /// <remarks />
            [XmlAttribute]
            public RadiationUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class RefreshRateDimension
        {
            /// <remarks />
            [XmlAttribute]
            public RefreshRateUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool unitOfMeasureSpecified { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class AirEfficiencyDimension
        {
            /// <remarks />
            [XmlAttribute]
            public AirEfficiencyUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class MeltingTemperatureDimension
        {
            /// <remarks />
            [XmlAttribute]
            public TemperatureRatingUnitOfMeasure unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText]
            public decimal Value { get; set; }
        }

        /// <remarks />
        public class NetContentCountUnit
        {
            /// <remarks />
            [XmlAttribute]
            public CountUnit unitOfMeasure { get; set; }

            /// <remarks />
            [XmlText(DataType = "normalizedString")]
            public string Value { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class Battery
        {
            /// <remarks />
            public bool AreBatteriesIncluded { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool AreBatteriesIncludedSpecified { get; set; }

            /// <remarks />
            public bool AreBatteriesRequired { get; set; }

            /// <remarks />
            [XmlIgnore]
            public bool AreBatteriesRequiredSpecified { get; set; }

            /// <remarks />
            [XmlElement("BatterySubgroup")]
            public BatteryBatterySubgroup[] BatterySubgroup { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class BatteryBatterySubgroup
        {
            /// <remarks />
            public BatteryBatterySubgroupBatteryType BatteryType { get; set; }

            /// <remarks />
            [XmlElement(DataType = "positiveInteger")]
            public string NumberOfBatteries { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class StandardProductID
        {
            /// <remarks />
            public StandardProductIDType Type { get; set; }

            /// <remarks />
            public string Value { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class RelatedProductID
        {
            /// <remarks />
            public RelatedProductIDType Type { get; set; }

            /// <remarks />
            public string Value { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class ComputerPlatform
        {
            /// <remarks />
            public ComputerPlatformType Type { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string SystemRequirements { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class ColorSpecification
        {
            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string Color { get; set; }

            /// <remarks />
            public ColorMap ColorMap { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class Recall
        {
            /// <remarks />
            public bool IsRecalled { get; set; }

            /// <remarks />
            [XmlElement(DataType = "normalizedString")]
            public string RecallDescription { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class AgeRecommendation
        {
            /// <remarks />
            public MinimumAgeRecommendedDimension MinimumManufacturerAgeRecommended { get; set; }

            /// <remarks />
            public AgeRecommendedDimension MaximumManufacturerAgeRecommended { get; set; }

            /// <remarks />
            public MinimumAgeRecommendedDimension MinimumMerchantAgeRecommended { get; set; }

            /// <remarks />
            public AgeRecommendedDimension MaximumMerchantAgeRecommended { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class WeightRecommendation
        {
            /// <remarks />
            public WeightIntegerDimension MinimumManufacturerWeightRecommended { get; set; }

            /// <remarks />
            public WeightIntegerDimension MaximumManufacturerWeightRecommended { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class HeightRecommendation
        {
            /// <remarks />
            public LengthDimension MinimumHeightRecommended { get; set; }

            /// <remarks />
            public LengthDimension MaximumHeightRecommended { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class ForwardFacingWeight
        {
            /// <remarks />
            public WeightDimension ForwardFacingMaximumWeight { get; set; }

            /// <remarks />
            public WeightDimension ForwardFacingMinimumWeight { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class RearFacingWeight
        {
            /// <remarks />
            public WeightDimension RearFacingMaximumWeight { get; set; }

            /// <remarks />
            public WeightDimension RearFacingMinimumWeight { get; set; }
        }

        /// <remarks />
        [XmlType(AnonymousType = true)]
        public class ShoulderHarnessHeight
        {
            /// <remarks />
            public LengthDimension ShoulderHarnessMaximumHeight { get; set; }

            /// <remarks />
            public LengthDimension ShoulderHarnessMinimumHeight { get; set; }
        }
    }
}