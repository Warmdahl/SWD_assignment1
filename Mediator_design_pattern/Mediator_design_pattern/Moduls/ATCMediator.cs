using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern.Moduls
{
    class ATCMediator : IATCMediator
    {
        private Flight flight;
        private Runway runway;
        public bool land;

        public void RegisterRunway(Runway runway)
        {
            this.runway = runway;
        }

        public void RegisterFlight(Flight flight)
        {
            this.flight = flight;
        }

        public bool IsLandingOk()
        {
            return land;
        }

        public void SetLandingStatus(bool status)
        {
            land = status;
        }
    }
}
