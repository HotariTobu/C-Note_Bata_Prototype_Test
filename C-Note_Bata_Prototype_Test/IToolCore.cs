using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// Represent events which are called when drawing events are fired
    /// </summary>
    interface IToolCore
    {
        void OnStylusDown(IToolContext context, StylusPointCollection points);
        void OnStylusMove(IToolContext context, StylusPointCollection points);
        void OnStylusUp(IToolContext context, StylusPointCollection points);
    }
}
