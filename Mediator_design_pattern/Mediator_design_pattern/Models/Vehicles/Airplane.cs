using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    class Airplane : AirVehicle
    {
        public Airplane(IControltowerMediator controlTowerMediator)
        {
            this.controlTowerMediator = controlTowerMediator;
        }

        public override void Land()
        {
            if ((controlTowerMediator.AirVeicleLandingStatus())&&(controlTowerMediator.IsLandingPlatformEmpty()))
            {
                Console.WriteLine("Airplane: Successfully Landed.");
                //this.controlTowerMediator.Notify(this, Action.landing);
            }
            else
            {
                Console.WriteLine("Airplane: Requesting landing.");
                this.controlTowerMediator.Notify(this, Action.requestLanding);
            }
        }

        public override void TakeOf()
        {
            if (controlTowerMediator.AirVeicleLandingStatus())
            {
                Console.WriteLine("Airplane: Requesting take off.");
                this.controlTowerMediator.Notify(this, Action.requestTakeof);
            }
            else
            {
                Console.WriteLine("Airplane: Successfully taking off.");
            }
        }
    }
}
