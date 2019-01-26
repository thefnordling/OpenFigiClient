using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Services;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Samples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var settings = new OpenFigiSettings();
            var b = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();
            //set an environmental variable named OpenFigiSettings:ApiKey and give it the value
            //of the api key you create on the openfigi website
            b.GetSection("OpenFigiSettings").Bind(settings);

            var keyLookups = new List<MappingKey>();
            keyLookups.Add(MappingKey.CURRENCY);
            keyLookups.Add(MappingKey.EXCH_CODE);
            keyLookups.Add(MappingKey.ID_TYPE);
            keyLookups.Add(MappingKey.MARKET_SECTOR);
            keyLookups.Add(MappingKey.MIC_CODE);
            keyLookups.Add(MappingKey.SECURITY_TYPE_ONE);
            keyLookups.Add(MappingKey.SECURITY_TYPE_TWO);

            var keyValues = new Dictionary<MappingKey, List<string>>();

            using (var p = new MappingProvider(settings.ApiKey))
            {
                foreach (var kl in keyLookups)
                {
                    Console.WriteLine($"Looking up {kl} values...");
                    var vals = await p.LookupMappingKeyValuesAsync(kl).ConfigureAwait(false);
                    Console.WriteLine($"Found {vals?.Values?.Count() ?? 0:N0} values for key {kl}");
                    keyValues.Add(vals.Key, vals.Values.ToList());
                }
                var request = new MappingRequest();
                var j1 = new MappingJob()
                {
                    IdType = IdType.ID_EXCH_SYMBOL,
                    Id = "MSFT",
                    SecurityTypeTwo = "Common Stock",
                    ExchangeCode = "US"
                };

                request.Add(j1);

                var j2 = new MappingJob()
                {
                    IdType = IdType.ID_EXCH_SYMBOL,
                    Id = "MSFT",
                    SecurityTypeTwo = "Option",
                    Expiration = new Range<DateTime?>(new DateTime(2018, 11, 1), new DateTime(2019, 04, 01)),
                    OptionType = OptionType.Call
                };

                request.Add(j2);

                var r1 = await p.RunMappingJobsAsync(request).ConfigureAwait(false);
                foreach (var eq in r1[0].Records.Take(5))
                {
                    Console.WriteLine($"Ticker: {eq.Ticker}\t\t\tFIGI:{eq.Id}\tMarket Sector: {eq.MarketSectorDescription}\tDescription: {eq.Name}");
                }
                foreach (var op in r1[1].Records.Take(5))
                {
                    Console.WriteLine($"Ticker: {op.Ticker}\tFIGI:{op.Id}\tMarket Sector: {op.MarketSectorDescription}\tDescription: {op.Name}");
                }
            }

            Console.ReadLine();
        }
    }
}
