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
    
        private int startColumn;
        private int startRow;
        private int slutColumn;
        private int slutRow;
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


        //-------------------------------------Drag and drop------------------------------------//
        private void Target_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //startPoint  = e.GetPosition(null);
            var element = (UIElement)e.Source;

            int startColumn = Grid.GetColumn(element);
            int startRow = Grid.GetRow(element);
        }

        private void Target_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var element = (UIElement)e.Source;

                int c = Grid.GetColumn(element);
                int r = Grid.GetRow(element);

            }
        }
        private void Target_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("MyFormat") || sender = e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void Target_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("MyFormat"))
            {
                var element = (UIElement)e.Source;

                int slutColumn= Grid.GetColumn(element);
                int slutRow = Grid.GetRow(element);
            }
        }






























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
