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

namespace Board
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearAllClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SBlackClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void SRedClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void SYellowClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void SBlueClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void SGreenClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void SBisqueClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Bisque;
        }

        private void SAquamarineClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Aquamarine;
        }

        private void SChartreuseClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Chartreuse;
        }

        private void SDarkVioletClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.DarkViolet;
        }

        private void SOrangeClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Orange;
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void ClearPointClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void ClearStrokeClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        } 

        private void InkClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void LightRBChecked(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.AliceBlue);
            statusBar.Background = new SolidColorBrush(Colors.AliceBlue);
            toolBar.Background = new SolidColorBrush(Colors.AliceBlue);
            toolBarTray.Background = new SolidColorBrush(Colors.AliceBlue);
            inkCanvas.Background = new SolidColorBrush(Colors.White);
        }

        private void DarkRBChecked(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.Gray);
            statusBar.Background = new SolidColorBrush(Colors.Gray);
            toolBar.Background = new SolidColorBrush(Colors.Gray);
            toolBarTray.Background = new SolidColorBrush(Colors.Gray);
            inkCanvas.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = slider.Value;
        }
    }
}
