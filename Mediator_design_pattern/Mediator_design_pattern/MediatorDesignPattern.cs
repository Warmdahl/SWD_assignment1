using System;

namespace Mediator_design_pattern
{
    class MediatorDesignPattern
    {
        public static void Main()
        {
            ControlTowerMediator controlTowerMediator = new ControlTowerMediator();
            Airplane sparrow101 = new Airplane(controlTowerMediator);
            Runway mainRunway = new Runway(controlTowerMediator);

            sparrow101.Land();

            controlTowerMediator.RegisterAirVehicle(sparrow101);
            controlTowerMediator.RegisterRunway(mainRunway);

            //sparrow101.Land();
            //System.Threading.Thread.Sleep(1000);
            //sparrow101.Land();
            //sparrow101.TakeOf();

        }
    }
}
