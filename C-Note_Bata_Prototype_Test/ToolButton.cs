using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// Contain tool and display the button
    /// </summary>
    public class ToolButton : Control
    {
        static ToolButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToolButton), new FrameworkPropertyMetadata(typeof(ToolButton)));
        }

        #region == Tool ==

        public static readonly DependencyProperty ToolProperty = DependencyProperty.Register("Tool", typeof(IToolButton), typeof(ToolButton));
        public IToolButton Tool { get => (IToolButton)GetValue(ToolProperty); set => SetValue(ToolProperty, value); }

        #endregion

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            Tool.OnButtonDown();
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);
            Tool.OnButtonUp();
        }
    }
}
