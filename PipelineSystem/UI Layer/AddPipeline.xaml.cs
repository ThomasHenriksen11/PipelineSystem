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
using PipelineSystem.Domain_Layer;

namespace PipelineSystem.UI_Layer
{
    /// <summary>
    /// Interaction logic for AddPipeline.xaml
    /// </summary>
    public partial class AddPipeline : Window
    {
        private readonly Controller controller;

        public AddPipeline(Controller controller)
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            this.controller = controller;

        }

        private void OpenMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
        private void AddToList_Click(object sender, RoutedEventArgs e)
        {
            //Pipeline pipeline = new Pipeline();
            string pipelineName = PipelineName.Text;
            if (pipelineName == null)
            {
                Console.WriteLine("Error no inputs");
                Console.ReadLine();
            }
            else
            {
            controller.pipeLineRepo.Add(pipelineName);
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        
    }
}
