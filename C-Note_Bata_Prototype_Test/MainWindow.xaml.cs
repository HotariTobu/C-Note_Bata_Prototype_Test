using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C_Note_Bata_Prototype_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Stroke Stroke;

        protected override void OnStylusDown(StylusDownEventArgs e)
        {
            base.OnStylusDown(e);
            Stroke = new Stroke(e.GetStylusPoints(this));
            ink.Strokes.Add(Stroke);

            System.Diagnostics.Debug.WriteLine($"down {IsErDown}");
        }

        protected override void OnStylusMove(StylusEventArgs e)
        {
            base.OnStylusMove(e);

            System.Diagnostics.Debug.WriteLine($"move {IsErDown}");
            if (IsErDown)
            {
                IEnumerable<Point> points = e.GetStylusPoints(this).Select(x => x.ToPoint());
                StylusShape shape = new EllipseStylusShape(2, 2);
                StrokeCollection strokes = ink.Strokes;
                int strokeCount = strokes.Count;
                int j = 0;
                while (j < strokeCount)
                {
                    if (strokes[j].HitTest(points, shape))
                    {
                        strokes.RemoveAt(j);
                        strokeCount--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            else
            {
                Stroke.StylusPoints.Add(e.GetStylusPoints(this));
            }
        }

        protected override void OnStylusUp(StylusEventArgs e)
        {
            base.OnStylusUp(e);
            Stroke.StylusPoints.Add(e.GetStylusPoints(this));

            System.Diagnostics.Debug.WriteLine($"up {IsErDown}");
        }

        private bool IsErDown
        {
            get => true;
            set
            {
                ink.EditingMode = value ? InkCanvasEditingMode.EraseByStroke : InkCanvasEditingMode.Ink;
            }
        }

        private void er_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IsErDown = true;
        }

        private void er_MouseUp(object sender, MouseButtonEventArgs e)
        {
            IsErDown = false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Key== Key.E)
            {
                IsErDown = true;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.Key == Key.E)
            {
                IsErDown = false;
            }
        }
    }
}
