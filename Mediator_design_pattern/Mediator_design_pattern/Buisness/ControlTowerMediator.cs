using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    public enum Action
    {
        requestLanding,
        landingOK,

        requestTakeof,
        takeOfOK
    }

    public class ControlTowerMediator : IControltowerMediator
    {
        private AirVehicle airVehicle_ = null;
        private LandingPlatform landingPlatform_ = null;

        private bool landingStatus_;
        public bool isRunwayEmpty_;

        public ControlTowerMediator()
        {
            landingStatus_ = false;
            isRunwayEmpty_ = true;
        }

        public bool IsLandingPlatformEmpty()
        {
            return isRunwayEmpty_;
        }

        public bool AirVeicleLandingStatus()
        {
            return landingStatus_;
        }

        public void RegisterAirVehicle(AirVehicle airVehicle)
        {
            this.airVehicle_ = airVehicle;
        }

        public void RegisterRunway(LandingPlatform landingPlatform)
        {
            this.landingPlatform_ = landingPlatform;
        }

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
                    case Action.requestTakeof:
                        this.landingPlatform_.TakeOf();
                        break;
                    case Action.takeOfOK:
                        landingStatus_ = false;
                        isRunwayEmpty_ = true;
                        this.airVehicle_.TakeOf();
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
