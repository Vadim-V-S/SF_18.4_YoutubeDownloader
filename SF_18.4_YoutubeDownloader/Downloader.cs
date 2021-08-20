using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;
using System.IO;

namespace SF_18._4_YoutubeDownloader
{
    public class Downloader
    {
        private string videoUrl;

        private string outputFilePath;

        private YoutubeClient youtube;

        private string videoTitle;

        public Downloader(string videoUrl)
        {
            this.videoUrl = videoUrl;
            outputFilePath = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DownloadedVideo\\";
            youtube = new YoutubeClient();
        }

        public async void Explode()
        {
            var ytb = await youtube.Videos.GetAsync(videoUrl);

            videoTitle = ytb.Title;
            var videoAuthor = ytb.Author.Title;

            Console.WriteLine("Название:\t{0}\nАвтор:\t{1}", videoTitle, videoAuthor);
        }

        public async void Download()
        {

            OutputPathCheck();

            await youtube.Videos.DownloadAsync(videoUrl, outputFilePath + videoTitle + ".mp4");

            Console.WriteLine("Загружено");
        }

        void OutputPathCheck()
        {
            if (!Directory.Exists(outputFilePath))
                Directory.CreateDirectory(outputFilePath);
        }
    }
}
