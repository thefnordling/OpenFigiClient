using Models;
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
                SecurityTypeTwo = SecurityTypeTwo.COMMON_STOCK
            };

            request.Add(j1);
            try
            {
                using (var p = new MappingProvider())
                {
                    var result = await p.RunMappingJobsAsync(request).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
