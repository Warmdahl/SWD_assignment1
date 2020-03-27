using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    class Runway : LandingPlatform
    {


        public Runway(IControltowerMediator controltowerMediator)
        {
            this.controlTowerMediator = controltowerMediator;
        }
        
        public override void Land()
        {
            if(this.controlTowerMediator.IsLandingPlatformEmpty())
            {
                Console.WriteLine("Runway: Landing permission granted - Runway empty.");
                this.controlTowerMediator.Notify(this, Action.landingOK);
            }
            else 
            {
                Console.WriteLine("Runway: Landing permission Denied - Runway otherwise ocupied.");
            }
        }

        public override void TakeOf()
        {
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
