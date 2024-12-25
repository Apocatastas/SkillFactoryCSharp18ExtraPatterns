using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace SkillFactoryCSharp18ExtraPatterns
{
    class CommandDownload : Command
    {
        Receiver r;
       
        public CommandDownload(Receiver r)
        {
            this.r = r;
        }

        public override void Run(string url, YoutubeClient client)
        {
            r.DownloadAsync(url, client);
        }


    }
}
