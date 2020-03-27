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

            // Calles land two times to show that a plan canot land when a runway is ocupied.
            // This is only to prove a point, since in real life toy wouldn't try to land
            // the same aitplane twho times.
            airplane.Land();
            airplane.Land();
            airplane.TakeOf();

        }
    }
}
