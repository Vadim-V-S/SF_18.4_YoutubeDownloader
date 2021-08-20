using System;
using System.Collections.Generic;
using System.Text;

namespace SF_18._4_YoutubeDownloader
{
    class DownloadCommand : Command
    {
        Downloader downloader;

        public DownloadCommand(Downloader downloader)
        {
            this.downloader = downloader;
        }

        public override void Run()
        {
            this.downloader.Download();
        }
    }
}
