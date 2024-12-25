using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace SkillFactoryCSharp18ExtraPatterns
{
    public class Receiver
    {
        YoutubeClient client;
        public async void GetDesc(string url, YoutubeClient client)
        {
            
            this.client = client;
            Console.WriteLine("Запускаю скачивание описания...");
            var s = await client.Videos.GetAsync(url);
            Console.WriteLine(s.Title);
            Console.WriteLine(s.Description);
            Console.WriteLine(s.Duration);
        }

        public async Task DownloadAsync(string url, YoutubeClient client)
        {
            this.client = client;
            string path = Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../" + "download");
            Console.WriteLine("Запускаю скачивание видео...");
            var streamManifest = await client.Videos.Streams.GetManifestAsync(url);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await client.Videos.Streams.DownloadAsync(streamInfo, path);
        }
    }
}
