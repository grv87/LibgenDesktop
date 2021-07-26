using System;

namespace LibgenDesktop.Models.Download
{
    internal class DownloadItemRequest
    {
        public Uri DownloadPageUrl { get; set; }
        public string FileNameWithoutExtension { get; set; }
        public string FileExtension { get; set; }
        public string Md5Hash { get; set; }
        public string DownloadTransformations { get; set; }
        public bool RestartSessionOnTimeout { get; set; }
    }
}
