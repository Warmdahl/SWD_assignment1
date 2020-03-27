using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    public interface ICommand
    {
        //Interface to implement the Land and TakeOff functions for the different models
        public void Land();
        public void TakeOff();
    }
}
