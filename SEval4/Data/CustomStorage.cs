using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Data
{
    public class CustomStorage
    {
        private static LocalStorage _storage;

        public static readonly string UserGuidKey = "seval_guid";

        public CustomStorage(IJSRuntime runtime)
        {
            _storage = new LocalStorage(runtime);
        }

        public async ValueTask SetItemAsync(string key, object value) =>
            await _storage.SetItemAsync(key, value.ToString());

        public async ValueTask SetUserGuidAsync(Guid value) =>
            await SetItemAsync(UserGuidKey, value);

        public async ValueTask<string> GetItem(string key) =>
            await _storage.GetItemAsync(key);
        
        public async ValueTask<Guid?> GetUserGuidOrNullAsync()
        {
            string storedGuid = await _storage.GetItemAsync(UserGuidKey);

            return string.IsNullOrEmpty(storedGuid)
                ? null
                : new Guid(storedGuid);
        }

        public async ValueTask<bool> HasValue(string key) =>
            string.IsNullOrEmpty(await _storage.GetItemAsync(key));

        public async ValueTask ClearAsync() =>
            await _storage.ClearAsync();
    }
}
