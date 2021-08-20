using System;
using System.Collections.Generic;
using System.Text;

namespace SF_18._4_YoutubeDownloader
{
    public class ExplodeCommand : Command
    {
        private Downloader downloader;

        public ExplodeCommand(Downloader downloader)
        {
            this.downloader = downloader;
        }

        public override void Run()
        {
            this.downloader.Explode();
        }
    }
}
