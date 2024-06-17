using System.Collections.Generic;
using System.Linq;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Exceptions;
using static FikaAmazonAPI.ConstructFeed.BaseXML;

namespace FikaAmazonAPI.Utils
{
    public class MarketPlace
    {
        private MarketPlace(string id, Region region, Country country, BaseCurrencyCode currencyCode)
        {
            ID = id;
            Region = region;
            Country = country;
            CurrencyCode = currencyCode;
        }

        public string ID { get; set; }
        public Region Region { get; set; }

        public Country Country { get; set; }
        public BaseCurrencyCode CurrencyCode { get; set; }

        //https://developer-docs.amazon.com/sp-api/docs/marketplace-ids

        //NorthAmerica
        public static MarketPlace US =>
            new MarketPlace("ATVPDKIKX0DER", Region.NorthAmerica, Country.US, BaseCurrencyCode.USD);

        public static MarketPlace Canada =>
            new MarketPlace("A2EUQ1WTGCTBG2", Region.NorthAmerica, Country.CA, BaseCurrencyCode.CAD);

        public static MarketPlace Mexico =>
            new MarketPlace("A1AM78C64UM0Y8", Region.NorthAmerica, Country.MX, BaseCurrencyCode.MXN);

        public static MarketPlace Brazil =>
            new MarketPlace("A2Q3Y263D00KWC", Region.NorthAmerica, Country.BR, BaseCurrencyCode.BRL);

        //Europe
        public static MarketPlace Spain =>
            new MarketPlace("A1RKKUPIHCS9HS", Region.Europe, Country.ES, BaseCurrencyCode.EUR);

        public static MarketPlace UnitedKingdom =>
            new MarketPlace("A1F83G8C2ARO7P", Region.Europe, Country.GB, BaseCurrencyCode.GBP);

        public static MarketPlace France =>
            new MarketPlace("A13V1IB3VIYZZH", Region.Europe, Country.FR, BaseCurrencyCode.EUR);

        public static MarketPlace Belgium =>
            new MarketPlace("AMEN7PMS3EDWL", Region.Europe, Country.BE, BaseCurrencyCode.EUR);

        public static MarketPlace Netherlands =>
            new MarketPlace("A1805IZSGTT6HS", Region.Europe, Country.NL, BaseCurrencyCode.EUR);

        public static MarketPlace Germany =>
            new MarketPlace("A1PA6795UKMFR9", Region.Europe, Country.DE, BaseCurrencyCode.EUR);

        public static MarketPlace Italy =>
            new MarketPlace("APJ6JRA9NG5V4", Region.Europe, Country.IT, BaseCurrencyCode.EUR);

        public static MarketPlace Sweden =>
            new MarketPlace("A2NODRKZP88ZB9", Region.Europe, Country.SE, BaseCurrencyCode.SEK);

        public static MarketPlace Egypt =>
            new MarketPlace("ARBP9OOSHTCHU", Region.Europe, Country.EG, BaseCurrencyCode.EGP);

        public static MarketPlace Poland =>
            new MarketPlace("A1C3SOZRARQ6R3", Region.Europe, Country.PL, BaseCurrencyCode.PLN);

        public static MarketPlace Turkey =>
            new MarketPlace("A33AVAJ2PDY3EV", Region.Europe, Country.TR, BaseCurrencyCode.TRY);

        public static MarketPlace UnitedArabEmirates =>
            new MarketPlace("A2VIGQ35RCS4UG", Region.Europe, Country.AE, BaseCurrencyCode.AED);

        public static MarketPlace India =>
            new MarketPlace("A21TJRUUN4KGV", Region.Europe, Country.IN, BaseCurrencyCode.INR);

        public static MarketPlace SaudiArabia =>
            new MarketPlace("A17E79C6D8DWNP", Region.Europe, Country.SA, BaseCurrencyCode.SAR);

        public static MarketPlace SouthAfrica =>
            new MarketPlace("AE08WJ6YKNBMC", Region.Europe, Country.ZA, BaseCurrencyCode.ZAR);

        //FarEast
        public static MarketPlace Singapore =>
            new MarketPlace("A19VAU5U5O7RUS", Region.FarEast, Country.SG, BaseCurrencyCode.SGD);

        public static MarketPlace Australia =>
            new MarketPlace("A39IBJ37TRP1C6", Region.FarEast, Country.AU, BaseCurrencyCode.AUD);

        public static MarketPlace Japan =>
            new MarketPlace("A1VC38T7YXB528", Region.FarEast, Country.JP, BaseCurrencyCode.JPY);

        public static MarketPlace GetMarketPlaceByID(string id)
        {
            var list = new List<MarketPlace>();
            //NorthAmerica
            list.Add(US);
            list.Add(Canada);
            list.Add(Mexico);
            list.Add(Brazil);
            //Europe
            list.Add(Spain);
            list.Add(UnitedKingdom);
            list.Add(France);
            list.Add(Belgium);
            list.Add(Netherlands);
            list.Add(Germany);
            list.Add(Italy);
            list.Add(Sweden);
            list.Add(Egypt);
            list.Add(Poland);
            list.Add(Turkey);
            list.Add(UnitedArabEmirates);
            list.Add(India);
            list.Add(SaudiArabia);
            list.Add(SouthAfrica);
            //FarEast
            list.Add(Singapore);
            list.Add(Australia);
            list.Add(Japan);

            var marketpalce = list.FirstOrDefault(a => a.ID == id);
            if (marketpalce == null)
                throw new AmazonInvalidInputException(
                    "InvalidInput, MarketPlace or MarketPlaceID cannot be null for both!");

            return marketpalce;
        }

        public static MarketPlace GetMarketplaceByCountryCode(string countryCode)
        {
            var list = new List<MarketPlace>();
            //NorthAmerica
            list.Add(US);
            list.Add(Canada);
            list.Add(Mexico);
            list.Add(Brazil);
            //Europe
            list.Add(Spain);
            list.Add(UnitedKingdom);
            list.Add(France);
            list.Add(Belgium);
            list.Add(Netherlands);
            list.Add(Germany);
            list.Add(Italy);
            list.Add(Sweden);
            list.Add(Egypt);
            list.Add(Poland);
            list.Add(Turkey);
            list.Add(UnitedArabEmirates);
            list.Add(India);
            list.Add(SaudiArabia);
            list.Add(SouthAfrica);
            //FarEast
            list.Add(Singapore);
            list.Add(Australia);
            list.Add(Japan);
            return list.FirstOrDefault(a => a.Country.Code == countryCode);
        }
    }
}