using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// One of sheets in a note
    /// </summary>
    class Sheet : IToolContext
    {
        Size Size;
        List<Layer> Layers = new();

        public Layer CurrentLayer => throw new NotImplementedException();

        public EditingMode EditingMode => throw new NotImplementedException();
    }
}
