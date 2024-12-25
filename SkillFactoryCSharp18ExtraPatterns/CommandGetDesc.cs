using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace SkillFactoryCSharp18ExtraPatterns
{
    public class CommandGetDesc : Command
    {
        Receiver r;
        public CommandGetDesc(Receiver r)
        {
            this.r = r;
        }
        public override void Run(string url, YoutubeClient client)
        {
            r.GetDesc(url, client);
        }
    }
}
