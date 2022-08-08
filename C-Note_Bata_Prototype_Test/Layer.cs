using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// One of layers in a sheet
    /// </summary>
    class Layer : SharedWPF.ViewModelBase
    {
        #region == Strokes ==

        private readonly ObservableCollection<Stroke> _Strokes = new ObservableCollection<Stroke>();
        public ObservableCollection<Stroke> Strokes => _Strokes;

        #endregion

        #region == Texts ==

        private readonly ObservableCollection<Text> _Texts = new ObservableCollection<Text>();
        public ObservableCollection<Text> Texts => _Texts;

        #endregion

        #region == Objects ==

        private readonly ObservableCollection<object> _Objects = new ObservableCollection<object>();
        public ObservableCollection<object> Objects => _Objects;

        #endregion
    }
}
