using System;

namespace SF_18._4_YoutubeDownloader
{
    class Program
    {
        static string InputUrl()
        {
            Console.Write("Введите адрес видео:\t");
            return Console.ReadLine();
        }

        static string InputFileType()
        {
            Console.WriteLine("Выбрать формат загрузки: \n1 - mp4, \n2 - mp3");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1: return ".mp4";
                case 2: return ".mp3";
                default: return ".mp4";
            }
        }

        static void Main(string[] args)
        {
            Downloader downloader = new Downloader(InputUrl(), InputFileType());
            Command explodeCommand = new ExplodeCommand(downloader);
            Command downloadCommand = new DownloadCommand(downloader);

            CommandInvoker invoker = new CommandInvoker(explodeCommand, downloadCommand);
            invoker.Explode();
            invoker.Download();

            Console.ReadKey();
        }
    }
}
