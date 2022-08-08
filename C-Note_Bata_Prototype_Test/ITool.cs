using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// Tool interface: set of <see cref="IToolCore"/> and <see cref="IToolButton"/>
    /// </summary>
    interface ITool : IToolCore, IToolButton
    {
    }
}
