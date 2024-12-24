
namespace SkillFactoryCSharp18ExtraPatterns
{
    /// <summary>
    ///  Клиентский код
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
        }
    }
}