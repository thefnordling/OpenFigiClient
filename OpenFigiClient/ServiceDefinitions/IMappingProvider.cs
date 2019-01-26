using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenFigiClient
{
    interface IMappingProvider
    {
        Task<MappingResponse> RunMappingJobsAsync(MappingRequest request);
        Task<MappingKeyLookupResults> LookupMappingKeyValuesAsync(MappingKey key);
    }
}
