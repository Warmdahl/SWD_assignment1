using Mediator_design_pattern.Moduls;
using System;

namespace Mediator_design_patternv2
{
    class MediatorDesignPattern
    {
        public static void Main()
        {
            IATCMediator atcMediator = new ATCMediator();
            Flight sparrow101 = new Flight(atcMediator);
            Runway mainRunway = new Runway(atcMediator);
            atcMediator.RegisterFlight(sparrow101);
            atcMediator.RegisterRunway(mainRunway);
            sparrow101.getReady();
            mainRunway.Land();
            sparrow101.Land();
        }
    }
}
