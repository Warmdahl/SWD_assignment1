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

        //Implements the TakeOf function from ICommand
        public override void TakeOf()
        {
            //Checks with mediator for the airplanes takeoff status.
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
