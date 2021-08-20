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

        static void Main(string[] args)
        {
            Downloader downloader = new Downloader(InputUrl());
            Command explodeCommand = new ExplodeCommand(downloader);
            Command downloadCommand = new DownloadCommand(downloader);

            CommandInvoker invoker = new CommandInvoker(explodeCommand, downloadCommand);
            invoker.Explode();
            invoker.Download();

            Console.ReadKey();
        }
    }
}
