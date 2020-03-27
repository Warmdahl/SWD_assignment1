using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_design_pattern
{
    public abstract class LandingPlatform : ICommand
    {
        //Abstract class to implement different runways which can be present at an airport
        //in this example we have only implemented a runway, but this abstract class would make it easy to implement others like multiple runways or helipads.
        protected IControltowerMediator controlTowerMediator;

        //Inherits the ICommand functions
        public abstract void Land();

        public abstract void TakeOff();
    }
}
