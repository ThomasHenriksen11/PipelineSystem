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
using System.Windows.Shapes;

namespace PipelineSystem
{
    /// <summary>
    /// Interaction logic for PipelineWindow.xaml
    /// </summary>
    public partial class PipelineWindow : Window
    {
        //---------------------------Buttons--------------------------------//
        public PipelineWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void OpenAddDeal(object sender, RoutedEventArgs e)
        {
            AddDeal addDeal = new AddDeal();
            addDeal.Show();
            this.Close();
        }

        private void ToAddTitleWindow(object sender, RoutedEventArgs e)
        {
            AddTitle addTitle = new AddTitle();
            addTitle.Show();
            this.Close();
        }

        private void Button_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        //-------------------------------------Drag and drop------------------------------------------//



























        //private void Viewbox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //  Viewbox v = sender as Viewbox;
        //DataObject dataObj = new DataObject();
        //dataObj.SetData("Name");
        //DragDrop.DoDragDrop(v, dataObj, DragDropEffects.Move);
        //}

        //
        //private void ButtonMouseMove(object sender, MouseButtonEventArgs)
        //{
        //   Mouse.OverrideCursor = Cursors.Hand;
        //  fp_Move_Control(sender, e);
        //}
        //private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //
        //           Button btn = sender as Button;
        //          DataObject dataObj = new DataObject();
        //         dataObj.SetData("Name");
        //       DragDrop.DoDragDrop(btn, dataObj, DragDropEffects.Move);
        // }
        //private void Target_Drop(object sender, DragEventArgs e)
        //{
        //   Border target_control = (Border)sender;
        //}

    }
}
