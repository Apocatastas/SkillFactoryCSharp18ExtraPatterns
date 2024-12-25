using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace SkillFactoryCSharp18ExtraPatterns
{
    public class Sender
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void Run(string url, YoutubeClient client)
        {
            command.Run(url, client);
        }
    }
}
