using PipelineSystem.Application_Layer;
using System.Windows;

namespace PipelineSystem.UI_Layer
{
    /// <summary>
    /// Interaction logic for PipelineWindow.xaml
    /// </summary>
    public partial class PipelineWindow : Window
    {

        /*private int startColumn;
        private int startRow;
        private int slutColumn;
        private int slutRow;*/
        private readonly Controller controller;
        //---------------------------Buttons--------------------------------//
        public PipelineWindow(Controller controller)
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            this.controller = controller;

        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            this.Close();
        }

        private void OpenAddDeal(object sender, RoutedEventArgs e)
        {
            AddDeal addDeal = new AddDeal(controller);
            addDeal.Show();
            this.Close();
        }

        private void ToAddTitleWindow(object sender, RoutedEventArgs e)
        {
            AddTitle addTitle = new AddTitle(controller);
            addTitle.Show();
            this.Close();
        }


        //-------------------------------------Drag and drop------------------------------------//
        /*  private void Target_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
          {
              //Tager den row og column musen er i når vestre museknap bliver holdt nede
              var element = (UIElement)e.Source;

              int startColumn = Grid.GetColumn(element);
              int startRow = Grid.GetRow(element);
          }

          private void Target_PreviewMouseMove(object sender, MouseEventArgs e)
          {

              if (e.LeftButton == MouseButtonState.Pressed)
              {
                  var element = (UIElement)e.Source;
                  Cursor = Cursors.SizeWE;
                  int c = Grid.GetColumn(element);
                  int r = Grid.GetRow(element);

              }
              if (e.LeftButton == MouseButtonState.Released)
              {
                  Cursor = Cursors.Arrow;
              }
          }
          private void Target_DragEnter(object sender, DragEventArgs e)
          {
              //Hvis det data som bliver trukket hen over drop spottet ikke kan være i spottet så  sker der ikke noget 
              if (!e.Data.GetDataPresent("MyFormat"))
              {
                  e.Effects = DragDropEffects.None;
              }
              //Hvis det data som bliver trukket hen over drop spottet kan være i spottet så ændre musen sig til et kryds
              if (e.Data.GetDataPresent("MyFormat"))
              {
                  Cursor = Cursors.Cross;
              }
          }

          private void Target_Drop(object sender, DragEventArgs e)
          {

              {
                  var element = (UIElement)e.Source;

                  int slutColumn= Grid.GetColumn(element);
                  int slutRow = Grid.GetRow(element);

              }
              //hvis dataen kan være i spottet så fjerner den dataen fra det sted det blev dragged fra og ligger det der hvor det blev droppet
              if (e.Data.GetDataPresent("MyFormat"))
              {
                  e.Effects = DragDropEffects.Move;
              }
          }

          private void Target_DragOver(object sender, DragEventArgs e)
          {
              var element = (UIElement)e.Source;

              int slutColumn = Grid.GetColumn(element);
              int slutRow = Grid.GetRow(element);
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

      */
    }
}
