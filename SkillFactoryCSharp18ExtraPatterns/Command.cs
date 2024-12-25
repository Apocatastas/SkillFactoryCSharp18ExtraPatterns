using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace SkillFactoryCSharp18ExtraPatterns
{
    abstract public class Command
    {
        public abstract void Run(string url, YoutubeClient client);
    }
}
