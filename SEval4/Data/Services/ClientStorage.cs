using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Data.Services
{
    public class ClientStorage
    {
        private static SessionStorage _storage;

        public static readonly string UserGuidKey = "seval_guid";
        public static readonly string StudyGroupKey = "seval_group";

        public ClientStorage(IJSRuntime runtime)
        {
            _storage = new SessionStorage(runtime);
        }

        public async ValueTask SetItemAsync(string key, object value) =>
            await _storage.SetItemAsync(key, value.ToString());

        public async ValueTask SetUserGuidAsync(Guid userGuid) =>
            await SetItemAsync(UserGuidKey, userGuid);

        public async ValueTask SetStudyGroupAsync(int studyGroupId) =>
            await SetItemAsync(StudyGroupKey, studyGroupId);

        public async ValueTask<string> GetItem(string key) =>
            await _storage.GetItemAsync(key);

        public async ValueTask<Guid?> GetUserGuidOrNullAsync()
        {
            string storedGuid = await _storage.GetItemAsync(UserGuidKey);

            return string.IsNullOrEmpty(storedGuid)
                ? null
                : new Guid(storedGuid);
        }

        public async ValueTask<int?> GetStudyGroupAsync()
        {
            string studyGroupId = await _storage.GetItemAsync(StudyGroupKey);

            return string.IsNullOrEmpty(studyGroupId)
                ? null
                : Convert.ToInt32(studyGroupId);
        }

        public async ValueTask<bool> HasValue(string key) =>
            string.IsNullOrEmpty(await _storage.GetItemAsync(key));

        public async ValueTask ClearAsync() =>
            await _storage.ClearAsync();
    }
}
