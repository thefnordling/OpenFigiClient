using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    interface IMappingProvider
    {
        Task<MappingResponse> RunMappingJobsAsync(MappingRequest request);
    }
}
