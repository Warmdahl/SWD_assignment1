using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    public interface IControltowerMediator
    {
        public void Notify(object sender, Action action);
        public bool IsLandingPlatformEmpty();
        public bool AirVeicleLandingStatus();

    }

}
