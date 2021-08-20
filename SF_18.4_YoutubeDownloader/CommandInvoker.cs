using System;
using System.Collections.Generic;
using System.Text;

namespace SF_18._4_YoutubeDownloader
{
    class CommandInvoker
    {
        private Command explode;

        private Command download;

        public CommandInvoker(Command explode, Command download)
        {
            this.explode = explode;
            this.download = download;
        }

        public void Explode() => explode.Run();

        public void Download() => download.Run();

    }
}
