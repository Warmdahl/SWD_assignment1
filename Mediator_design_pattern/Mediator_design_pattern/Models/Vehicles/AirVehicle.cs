using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_design_pattern
{
    public abstract class AirVehicle : ICommand
    {
        //Abstract class to implement different machines who can use an airport
        //in this example we have only implemented an Airplane, but this abclass would make it easy to implement others like a Helicopter.
        protected IControltowerMediator controlTowerMediator;

        //Inherits the ICommand functions
        public abstract void Land();

        public abstract void TakeOf();
    }
}
