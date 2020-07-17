using PipelineSystem.Application_Layer;
using PipelineSystem.UI_Layer;
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
            //this.Close();
        }

        private void OpenAddPipeline(object sender, RoutedEventArgs e)
        {
            AddPipeline addPipeline = new AddPipeline(controller);
            addPipeline.Show();
            //this.Close();

        }

        private void OpenRemovePipeline(object sender, RoutedEventArgs e)
        {
            RemovePipelineWindow removePipelineWindow = new RemovePipelineWindow(controller);
            removePipelineWindow.Show();
        }

        


    }
}
