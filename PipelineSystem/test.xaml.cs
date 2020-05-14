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
    /// Interaction logic for test.xaml
    /// </summary>
    //public partial class test : Window
    //{
      //  public test()
        //{
          //  InitializeComponent();
        //}
        //private void List_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
            // Store the mouse position
          //  startPoint = e.GetPosition(null);
        //}
        //private void List_MouseMove(object sender, MouseEventArgs e)
        //{
            // Get the current mouse position
          //  Point mousePos = e.GetPosition(null);
            //Vector diff = startPoint - mousePos;

            //if (e.LeftButton == MouseButtonState.Pressed &&
              //  Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                //Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
            //{
                // Get the dragged ListViewItem
              //  ListView listView = sender as ListView;
               // ListViewItem listViewItem =
                 //   FindAnchestor<ListViewItem>((DependencyObject)e.OriginalSource);

                // Find the data behind the ListViewItem
                //Contact contact = (Contact)listView.ItemContainerGenerator.
                  //  ItemFromContainer(listViewItem);

                // Initialize the drag & drop operation
                //DataObject dragData = new DataObject("myFormat", contact);
                //DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
            //}
        //}
        //private static T FindAnchestor<T>(DependencyObject current)
    //where T : DependencyObject
        //{
          //  do
            //{
              //  if (current is T)
                //{
                  //  return (T)current;
                //}
                //current = VisualTreeHelper.GetParent(current);
            //}
            //while (current != null);
            //return null;
        //}
    //}
}
