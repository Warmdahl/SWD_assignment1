using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_design_pattern
{
    public abstract class LandingPlatform : ICommand
    {
        protected IControltowerMediator controlTowerMediator;

        public abstract void Land();

        public abstract void TakeOf();
    }
}
