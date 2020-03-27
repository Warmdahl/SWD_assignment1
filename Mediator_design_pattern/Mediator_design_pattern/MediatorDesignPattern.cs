using System;

namespace Mediator_design_pattern
{
    class MediatorDesignPattern
    {
        public static void Main()
        {
            ControlTowerMediator controlTowerMediator = new ControlTowerMediator();
            Airplane airplane = new Airplane(controlTowerMediator);
            Runway runway = new Runway(controlTowerMediator);

            controlTowerMediator.RegisterAirVehicle(airplane);
            controlTowerMediator.RegisterLandingPlatform(runway);

            // Calls land two times to show that a plan cannot land when a runway is occupied.
            // This is only to prove a point, since in real life you wouldn't try to land
            // the same airplane twice.
            airplane.Land();
            airplane.Land();
            airplane.TakeOff();

        }
    }
}
