using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    // ControltowerMediator interface declares the functions used by the componments to 
    // comunicate to the mediator. The mediator can then act upun the events that the 
    // conponments comunicates to the mediator and f.x. comunicat on to other conponment classes.

    public interface IControltowerMediator
    {
        public void Notify(object sender, Action action);
        public bool IsLandingPlatformEmpty();
        public bool AirVeicleLandingStatus();

    }
}
