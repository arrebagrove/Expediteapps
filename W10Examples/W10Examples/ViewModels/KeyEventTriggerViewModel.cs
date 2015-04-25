using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using W10Examples.ViewModels.Base;
using Windows.System;

namespace W10Examples.ViewModels
{
    public class KeyEventTriggerViewModel
    {
        public Command<VirtualKey> KeyTestCommand => new Command<VirtualKey>(
            (k) =>
            {
                if (k == VirtualKey.Enter)
                {
                    //Do Something
                }
            });
    }

   
}
