using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    class Runway : LandingPlatform
    {
        //Binds the component to the mediator (control tower)
        public Runway(IControltowerMediator controltowerMediator)
        {
            this.controlTowerMediator = controltowerMediator;
        }
        
        //Implements the land function from ICommand
        public override void Land()
        {
            //Checks with the mediator if the landing platform is empty for landing
            if (this.controlTowerMediator.IsLandingPlatformEmpty()) 
            {
                Console.WriteLine("Runway: Landing permission granted - Runway empty.");
                this.controlTowerMediator.Notify(this, Action.landingOK);
            }
            else 
            {
                Console.WriteLine("Runway: Landing permission Denied - Runway otherwise ocupied.");
            }
        }

        //Implements the TakeOf function from ICommand
        public override void TakeOf()
        {
            //Checks with the mediator if the landing platform is empty for takeoff
            if (!this.controlTowerMediator.IsLandingPlatformEmpty())
            {
                Console.WriteLine("Runway: Take-Off permission granted.");
                this.controlTowerMediator.Notify(this, Action.takeOfOK);
            }
            else
            {
                Console.WriteLine("Runway: Take-Off permission Denied.");
            }
        }
    }
}
