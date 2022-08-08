using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// Passed as a parameter of stylus events
    /// </summary>
    interface IToolContext
    {
        Layer CurrentLayer { get; }
        EditingMode EditingMode { get; }
    }
}
