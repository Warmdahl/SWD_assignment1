using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    // IControlTowerMediator interface declares the functions used by the components to 
    // communicate to the mediator. The mediator can then act upon the events that the 
    // components communicates to the mediator and f.x. communicate on to other component classes.

    public interface IControltowerMediator
    {
        public void Notify(object sender, Action action);
        public bool IsLandingPlatformEmpty();
        public bool AirVehicleLandingStatus();

    }
}
