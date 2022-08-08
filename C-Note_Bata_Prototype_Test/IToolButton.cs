using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// Represent a button part which is used as Side Tool
    /// </summary>
    public interface IToolButton : IDisposable
    {
        void Initialize();
        void OnButtonDown();
        void OnButtonUp();
        Geometry GetGeometry();
    }
}
