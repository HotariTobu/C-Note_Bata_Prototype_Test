using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Note_Bata_Prototype_Test
{
    class ToolManager
    {
        #region == Tools ==

        List<IToolCore> _Tools = new();
        IEnumerable<IToolCore> Tools => _Tools;

        #endregion

        #region == MainTool ==

        IToolCore _MainTool;
        IToolCore MainTool
        {
            get => _MainTool;
            set
            {
                _MainTool = value;
                if (IsHoldingMainTool)
                {
                    _Tools.Clear();
                    _Tools.Add(value);
                }
            }
        }

        #endregion

        /// <summary>
        /// If no Side Tools are held, true. Else false
        /// </summary>
        private bool IsHoldingMainTool = true;

        /// <summary>
        /// Add a tool to <see cref="Tools"/>
        /// </summary>
        /// <param name="tool">pressed Side Tool</param>
        void HoldTool(IToolCore tool)
        {
            if (IsHoldingMainTool)
            {
                _Tools.Clear();
                IsHoldingMainTool = false;
            }

            _Tools.Add(tool);
        }

        /// <summary>
        /// remove a tool from <see cref="Tools"/>
        /// </summary>
        /// <param name="tool">released Side Tool</param>
        void ReleaseTool(IToolCore tool)
        {
            _Tools.Remove(tool);

            if (_Tools.Count == 0)
            {
                _Tools.Add(MainTool);
                IsHoldingMainTool = true;
            }
        }
    }
}
