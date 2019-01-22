using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Services
{
    public class MappingProvider : IMappingProvider, IDisposable
    {
        protected string ApiKey { get; set; }
        protected HttpClientHandler HttpHandler { get; set; }
        protected HttpClient HttpClient { get; set; }
        protected Uri MappingUri { get; set; } = new Uri("https://api.openfigi.com/v2/mapping");
        protected JsonSerializerSettings SerializerSettings { get; set; }
        public MappingProvider(string apiKey = null, Uri mappingUri = null)
        {
            if (mappingUri != null)
                this.MappingUri = mappingUri;

            if (apiKey != null)
                this.ApiKey = apiKey;

            HttpHandler = new HttpClientHandler();
            HttpHandler.CookieContainer = new CookieContainer();
            HttpHandler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpHandler.UseCookies = true;

            HttpClient = new HttpClient(this.HttpHandler);
            if (!string.IsNullOrEmpty(ApiKey))
            {
                HttpClient.DefaultRequestHeaders.Add("X-OPENFIGI-APIKEY", ApiKey);
            }

            SerializerSettings = new JsonSerializerSettings()
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat
            };

            SerializerSettings.Converters.Add(new StringEnumConverter());
            SerializerSettings.Converters.Add(new RangeConverter<DateTime?>());
            SerializerSettings.Converters.Add(new RangeConverter<decimal?>());
        }

        async public Task<MappingResponse> RunMappingJobsAsync(MappingRequest request)
        {
            var content = new StringContent(JsonConvert.SerializeObject(request, this.SerializerSettings), Encoding.UTF8, "application/json");
            using (var message = await HttpClient.PostAsync(this.MappingUri, content).ConfigureAwait(false))
            {
                message.EnsureSuccessStatusCode();
                var json = await message.Content.ReadAsStringAsync().ConfigureAwait(false);
                var response = JsonConvert.DeserializeObject<MappingResponse>(json, this.SerializerSettings);
                return response;
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    try
                    {

                        this.HttpClient?.Dispose();
                    }
                    catch { }

                    try
                    {
                        this.HttpHandler?.Dispose();
                    }
                    catch { }
                }
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            disposedValue = true;
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~MappingProvider() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
