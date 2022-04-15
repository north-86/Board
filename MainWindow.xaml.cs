using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files (*.jpg)|*.jpg|All files(*.*)|*.*";
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            image.Source = new BitmapImage(new Uri(filename, UriKind.Absolute));
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
            image.Source = null;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SBlack_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void SRed_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void SYellow_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void SBlue_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void SGreen_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void SBisque_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Bisque;
        }

        private void SAquamarine_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Aquamarine;
        }

        private void SChartreuse_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Chartreuse;
        }

        private void SDarkViolet_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.DarkViolet;
        }

        private void SOrange_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Orange;
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void ClearPoint_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void ClearStroke_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        } 

        private void Ink_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void WeightlessRB_Checked(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.White);
            statusBar.Background = new SolidColorBrush(Colors.White);
            toolBar.Background = new SolidColorBrush(Colors.White);
            toolBarTray.Background = new SolidColorBrush(Colors.White);
            inkCanvas.Background = new SolidColorBrush(Colors.White);
        }

        private void LightRB_Checked(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.AliceBlue);
            statusBar.Background = new SolidColorBrush(Colors.AliceBlue);
            toolBar.Background = new SolidColorBrush(Colors.AliceBlue);
            toolBarTray.Background = new SolidColorBrush(Colors.AliceBlue);
            inkCanvas.Background = new SolidColorBrush(Colors.White);
        }

        private void DarkRB_Checked(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.Gray);
            statusBar.Background = new SolidColorBrush(Colors.Gray);
            toolBar.Background = new SolidColorBrush(Colors.Gray);
            toolBarTray.Background = new SolidColorBrush(Colors.Gray);
            inkCanvas.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void SliderValue_Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = slider.Value;
        }
    }
}
