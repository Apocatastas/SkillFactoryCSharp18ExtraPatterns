using System.Reflection;
using YoutubeExplode;

namespace SkillFactoryCSharp18ExtraPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "https://www.youtube.com/watch?v=x12E4jQsbso";

            Sender sender = new Sender();
            Receiver receiver = new Receiver();
            YoutubeClient client = new YoutubeClient(); 

            CommandGetDesc commandGetDesc = new CommandGetDesc(receiver);
            sender.SetCommand(commandGetDesc);
            sender.Run(s, client);

            CommandDownload commandDownload = new CommandDownload(receiver);
            sender.SetCommand(commandDownload);
            sender.Run(s, client);
            Console.ReadKey();

        }
    }
}
