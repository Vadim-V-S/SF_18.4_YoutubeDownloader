using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;
using System.IO;
using System.Threading.Tasks;


namespace SF_18._4_YoutubeDownloader
{
    public class Downloader
    {
        private string videoUrl { get; set; }

        private string fileType { get; set; }

        private string outputFilePath { get; set; }

       private YoutubeClient youtube;


        public Downloader(string videoUrl, string fileType)
        {
            this.videoUrl = videoUrl;
            this.fileType = fileType;
            outputFilePath = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DownloadedVideo\\";
            youtube = new YoutubeClient();
        }

        public async void Explode()
        {
            var ytb = await youtube.Videos.GetAsync(videoUrl);

            var videoTitle = ytb.Title;
            var videoAuthor = ytb.Author.Title;

            Console.Clear();
            Console.WriteLine("Название:\t{0}\nАвтор:\t{1}\nФормат:\t{2}", videoTitle, videoAuthor, this.fileType);
        }


        public async void Download()
        {
            OutputPathCheck();

            await youtube.Videos.DownloadAsync(videoUrl, string.Format("{0}downloaded{1}", outputFilePath, fileType));

            Console.WriteLine("Загружено (рабочий стол -> DownloadedVideo)");
        }

        void OutputPathCheck()
        {
            if (!Directory.Exists(outputFilePath))
                Directory.CreateDirectory(outputFilePath);
        }
    }
}
