using System;
namespace SkillFactoryCSharp18ExtraPatterns
{
    public interface IAction
    {
        void Run();
        void Undo();
    }
}

