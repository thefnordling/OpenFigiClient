using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Services;
using System;
using System.Threading.Tasks;
using System.Linq;
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
                Expiration = new Range<DateTime?>(new DateTime(2018, 11, 1), new DateTime(2019, 04, 01)),
                OptionType = OptionType.Call
            };

            request.Add(j2);

            string apiKey = null;

            using (var p = new MappingProvider(apiKey))
            {
                var result = await p.RunMappingJobsAsync(request).ConfigureAwait(false);
                foreach (var eq in result[0].Records.Take(5))
                {
                    Console.WriteLine($"Ticker: {eq.Ticker}\t\t\tFIGI:{eq.Id}\tMarket Sector: {eq.MarketSectorDescription}\tDescription: {eq.Name}"); 
                }
                foreach (var op in result[1].Records.Take(5))
                {
                    Console.WriteLine($"Ticker: {op.Ticker}\tFIGI:{op.Id}\tMarket Sector: {op.MarketSectorDescription}\tDescription: {op.Name}"); 
                }
            }

            Console.ReadLine();
        }
    }
}
