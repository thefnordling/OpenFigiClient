using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Reflection;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Services
{
    public class MappingProvider : IMappingProvider, IDisposable
    {
        protected string ApiKey { get; set; }
        protected HttpClientHandler HttpHandler { get; set; }
        protected HttpClient HttpClient { get; set; }
        protected string MappingUrl { get; set; } = "https://api.openfigi.com/v2/mapping";
        protected string KeyValuesUrl { get; set; } = "https://api.openfigi.com/v2/mapping/values/";
        protected JsonSerializerSettings SerializerSettings { get; set; }
        public MappingProvider(string apiKey = null, string mappingUrl = null, string keyValuesUrl = null)
        {
            if (apiKey != null)
                this.ApiKey = apiKey;

            if (mappingUrl != null)
                this.MappingUrl = mappingUrl;

            if (!this.MappingUrl.EndsWith("/"))
                this.MappingUrl = $"{this.MappingUrl}/";

            if (keyValuesUrl != null)
                this.KeyValuesUrl = keyValuesUrl;

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
            using (var message = await HttpClient.PostAsync(new Uri(this.MappingUrl), content).ConfigureAwait(false))
            {
                message.EnsureSuccessStatusCode();
                var json = await message.Content.ReadAsStringAsync().ConfigureAwait(false);
                var response = JsonConvert.DeserializeObject<MappingResponse>(json, this.SerializerSettings);
                return response;
            }
        }
        async public Task<MappingKeyLookupResults> LookupMappingKeyValuesAsync(MappingKey key)
        {
            var keyDescription = GetValue(key);
            if (string.IsNullOrEmpty(keyDescription))
            {
                throw new InvalidEnumArgumentException($"MappingKey must have a description");
            }
            using (var message = await HttpClient.GetAsync(new Uri($"{this.KeyValuesUrl}{keyDescription}")).ConfigureAwait(false))
            {
                message.EnsureSuccessStatusCode();
                var json = await message.Content.ReadAsStringAsync().ConfigureAwait(false);
                var response = JsonConvert.DeserializeObject<MappingKeyLookupResults>(json, this.SerializerSettings);
                response.Key = key;
                return response;
            }
        }
        private string GetValue<T>(T member) where T : Enum
        {
            string name = Enum.GetName(typeof(T), member);
            if (name != null)
            {
                FieldInfo field = typeof(T).GetField(name);
                if (field != null)
                {
                    EnumMemberAttribute attr = Attribute.GetCustomAttribute(field, typeof(EnumMemberAttribute)) as EnumMemberAttribute;
                    if (attr != null)
                    {
                        return attr.Value;
                    }
                }
            }
            return null;
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
