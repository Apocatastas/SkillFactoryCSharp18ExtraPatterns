using System;
namespace SkillFactoryCSharp18ExtraPatterns
{
    class Pult
    {
        IAction _action;

        public void SetAction(IAction action)
        {
            _action = action;
        }

        public void OpenButton()
        {
            _action.Run();
        }

        public void CloseButton()
        {
            _action.Undo();
        }
    }
}

