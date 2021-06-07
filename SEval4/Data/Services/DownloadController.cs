using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEval4.Data.Services
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        [HttpGet, DisableRequestSizeLimit]
        public async Task<IActionResult> Download(Dictionary<string, string> fileNameContentPair)
        {
            using (MemoryStream zipStream = new())
            {
                using (ZipArchive zip = new(zipStream, ZipArchiveMode.Create))
                {
                    foreach (var pair in fileNameContentPair)
                    {
                        ZipArchiveEntry zipEntry = zip.CreateEntry(pair.Key);

                        using Stream entryStream = zipEntry.Open();
                        await using Stream text = new MemoryStream(Encoding.UTF8.GetBytes(pair.Value));
                        text.CopyTo(entryStream);
                    }
                }

                zipStream.Position = 0;

                return File(zipStream, "application/zip, application/octet-stream");
            }
        }

    }
}
