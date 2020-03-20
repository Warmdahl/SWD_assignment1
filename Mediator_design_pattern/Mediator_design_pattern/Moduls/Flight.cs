using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern.Moduls
{
    class Flight : ICommand
    {
        private IATCMediator atcMediator;

        public Flight(IATCMediator atcMediator)
        {
            this.atcMediator = atcMediator;
        }

        public void Land()
        {
            if (atcMediator.IsLandingOk())
            {
                Console.WriteLine("Successfully Landed.");
                atcMediator.SetLandingStatus(true);
            }
            else
            {
                Console.WriteLine("Waiting for landing.");
            }
        }

        public void getReady()
        {
            Console.WriteLine("Ready for landing.");
        }
    }
}
