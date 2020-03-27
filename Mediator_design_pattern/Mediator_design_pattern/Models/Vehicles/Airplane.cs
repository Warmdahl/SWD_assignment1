using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    class Airplane : AirVehicle
    {
        //Binds the component to the mediator (Control Tower)
        public Airplane(IControltowerMediator controlTowerMediator)
        {
            this.controlTowerMediator = controlTowerMediator;
        }

        //Implements the Land function from ICommand
        public override void Land()
        {
            //Checks with the mediator for the airplanes landing status and if the landing platform is empty
            if ((controlTowerMediator.AirVehicleLandingStatus())&&(controlTowerMediator.IsLandingPlatformEmpty()))
            {
                Console.WriteLine("Airplane: Successfully Landed.");
            }
            else
            {
                Console.WriteLine("Airplane: Requesting landing.");
                this.controlTowerMediator.Notify(this, Action.requestLanding);
            }
        }

        //Implements the TakeOff function from ICommand
        public override void TakeOff()
        {
            //Checks with mediator for the airplanes takeoff status.
            if (controlTowerMediator.AirVehicleLandingStatus())
            {
                Console.WriteLine("Airplane: Requesting take off.");
                this.controlTowerMediator.Notify(this, Action.requestTakeoff);
            }
            else
            {
                Console.WriteLine("Airplane: Successfully taking off.");
            }
        }
    }
}
