using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Data
{
    public class EasyStorage
    {
        private static LocalStorage Storage;

        public EasyStorage(IJSRuntime runtime)
        {
            Storage = new LocalStorage(runtime);
        }

        public string GetHello() => "Hello!";
    }
}
