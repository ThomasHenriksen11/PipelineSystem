using PipelineSystem.Application_Layer;
using System.Windows;

namespace PipelineSystem.UI_Layer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller = new Controller();
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            PipelineWindow pipelineWindow = new PipelineWindow(controller);
            pipelineWindow.Show();
            this.Close();
        }

        private void OpenAddPipeline(object sender, RoutedEventArgs e)
        {
            AddPipeline addPipeline = new AddPipeline(controller);
            addPipeline.Show();
            this.Close();

        }

        private void OpenRemovePipeline(object sender, RoutedEventArgs e)
        {
            RemovePipelineWindow removePipelineWindow = new RemovePipelineWindow(controller);
            removePipelineWindow.Show();
        }




    }
}
