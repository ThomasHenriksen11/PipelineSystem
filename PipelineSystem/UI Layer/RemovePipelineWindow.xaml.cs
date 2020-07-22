using PipelineSystem.Application_Layer;
using System.Windows;

namespace PipelineSystem.UI_Layer
{
    /// <summary>
    /// Interaction logic for RemovePipelineWindow.xaml
    /// </summary>
    public partial class RemovePipelineWindow : Window
    {
        private Controller controller;
        public RemovePipelineWindow(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            WindowState = WindowState.Maximized;

        }

        private void RemoveFromList_Click(object sender, RoutedEventArgs e)
        {
            /*Pipeline pipeline = new Pipeline();
            string pipelineName = Listbox2.SelectedItem.ToString;
            controller.pipeLineRepo.Delete(pipelineName);*/
        }

        private void OpenMainWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
