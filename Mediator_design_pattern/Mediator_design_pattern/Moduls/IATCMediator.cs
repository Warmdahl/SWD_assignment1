using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern.Moduls
{
    interface IATCMediator
    {
        public void RegisterRunway(Runway runway);

        public void RegisterFlight(Flight flight);

        public bool IsLandingOk();

        public void SetLandingStatus(bool status);
    }
}
