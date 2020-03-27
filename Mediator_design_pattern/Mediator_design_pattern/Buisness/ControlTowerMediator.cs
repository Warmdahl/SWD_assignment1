using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    // Enumeration Action that defines the different actions or events that can occur in the 
    // component classes. The actions that the concrete mediator class will act upon.
    public enum Action
    {
        requestLanding,
        landingOK,

        requestTakeoff,
        takeOffOK
    }

    // Concrete ControlTowerMediator implements the interface and the behaviour dependent 
    // on actions from the component classes.

    public class ControlTowerMediator : IControltowerMediator
    {
        private AirVehicle airVehicle_ = null;
        private LandingPlatform landingPlatform_ = null;

        private bool landingStatus_;
        public bool isRunwayEmpty_;

        // The ControlTowerMediator starts with an empty LandingPlatform with no landed AirVehicles.
        public ControlTowerMediator()
        {
            landingStatus_ = false;
            isRunwayEmpty_ = true;
        }

        // IsLandingPlatformEmpty lets the components know the status of the LandingPlatform
        // held by the ControlTowerMediator.
        public bool IsLandingPlatformEmpty()
        {
            return isRunwayEmpty_;
        }

        // IsLandingPlatformEmpty lets the components know the status of the LandingPlatform
        // held by the ControlTowerMediator.
        public bool AirVehicleLandingStatus()
        {
            return landingStatus_;
        }

        // Binds a concrete AirVehicle to the ControlTowerMediator so they can communicate.
        public void RegisterAirVehicle(AirVehicle airVehicle)
        {
            this.airVehicle_ = airVehicle;
        }

        // Binds a concrete RegisterLandingPlatform to the ControlTowerMediator so they can communicate.
        public void RegisterLandingPlatform(LandingPlatform landingPlatform)
        {
            this.landingPlatform_ = landingPlatform;
        }

        // Notify is used by the components to communicate events based on actions to ControlTowerMediator
        // Notify reacts to these actions and pass execution to other components.
        public void Notify(object sender, Action action)
        {
            try
            {
                switch (action)
                {
                    case Action.requestLanding:
                        this.landingPlatform_.Land();
                        break;
                    case Action.landingOK:
                        landingStatus_ = true;
                        airVehicle_.Land();
                        isRunwayEmpty_ = false;
                        break;
                    case Action.requestTakeoff:
                        this.landingPlatform_.TakeOff();
                        break;
                    case Action.takeOffOK:
                        landingStatus_ = false;
                        isRunwayEmpty_ = true;
                        this.airVehicle_.TakeOff();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ControlTower: ERROR({e}) - Missing registration of AirVehicle or LandingPlatform!");
            }
        }
    }
}
