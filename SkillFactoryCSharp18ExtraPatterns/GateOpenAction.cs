using System;
namespace SkillFactoryCSharp18ExtraPatterns
{
    class GateOpenAction : IAction
    {
        Gate _gate;

        public GateOpenAction(Gate gateSet)
        {
            _gate = gateSet;
        }

        public void Run()
        {
            _gate.Open();
        }

        public void Undo()
        {
            _gate.Close();
        }
    }

}

