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
using PipelineSystem.Application_Layer;
using PipelineSystem.Application_Layer_V2;
using PipelineSystem.Domain_Layer;

namespace PipelineSystem
{
    /// <summary>
    /// Interaction logic for AddPipeline.xaml
    /// </summary>
    public partial class AddPipeline : Window
    {
        private Controller controller;

        public AddPipeline(Controller controller)
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            this.controller = controller;

        }

        private void OpenMainWindow(object sender, RoutedEventArgs e)
        {
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            this.Close();

        }
        private void AddToList_Click(object sender, RoutedEventArgs e)
        {
            Pipeline pipeline = new Pipeline();
            controller.pipeLineRepo.AddNewPipeline(pipeline);
           // MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            this.Close();
        }
    }
}
