using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// Content which represent text
    /// </summary>
    class Text : SharedWPF.ViewModelBase
    {
        #region == Content ==

        private string _Content;
        public string Content
        {
            get => _Content;
            set
            {
                if (_Content != value)
                {
                    _Content = value;
                    RaisePropertyChanged(nameof(Content));
                }
            }
        }

        #endregion

        #region == Location ==

        private Point _Location;
        public Point Location
        {
            get => _Location;
            set
            {
                if (_Location != value)
                {
                    _Location = value;
                    RaisePropertyChanged(nameof(Location));
                }
            }
        }

        #endregion
    }
}
