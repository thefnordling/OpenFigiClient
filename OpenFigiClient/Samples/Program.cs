using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Services;
using System;
using System.Threading.Tasks;

namespace Samples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var request = new MappingRequest();
            var j1 = new MappingJob()
            {
                IdType = IdType.ID_EXCH_SYMBOL,
                Id = "MSFT",
                SecurityTypeTwo = SecurityTypeTwo.COMMON_STOCK,
                ExchangeCode = ExchangeCode.US
            };

            request.Add(j1);

            var j2 = new MappingJob()
            {
                IdType = IdType.ID_EXCH_SYMBOL,
                Id = "MSFT",
                SecurityTypeTwo = SecurityTypeTwo.OPTION,
                Expiration = new Range<DateTime?>(new DateTime(2018,11,1), new DateTime(2019,04,01)),
                OptionType = OptionType.Call,
                SecurityTypeOne = SecurityTypeOne.EQUITY_OPTION,
                MarketSectorDescription = MarketSectorDescription.EQUITY
                
            };
            request.Add(j2);

            using (var p = new MappingProvider())
            {
                var result = await p.RunMappingJobsAsync(request).ConfigureAwait(false);
            }
        }
    }
}
