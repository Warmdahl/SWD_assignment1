using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    public interface ICommand
    {
        public void Land();
        public void TakeOf();
    }
}
