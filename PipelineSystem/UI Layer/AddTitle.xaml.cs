using PipelineSystem.Application_Layer;
using PipelineSystem.UI_Layer;
using System;
using System.Windows;

namespace PipelineSystem
{
    /// <summary>
    /// Interaction logic for AddTitle.xaml
    /// </summary>
    public partial class AddTitle : Window
    {
        private Controller controller;

        public AddTitle(Controller controller)
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            this.controller = controller;
        }

        private void BackToPipelineWindow(object sender, RoutedEventArgs e)
        {
            PipelineWindow pipelineWindow = new PipelineWindow(controller);
            pipelineWindow.Show();
            this.Close();
        }
        private void SaveTitle(object sender, RoutedEventArgs e)
        {
            string titleName = TitleName.Text;
            if (titleName == null)
            {
                Console.WriteLine("Error no inputs");
                Console.ReadLine();
            }
            else
            {
                controller.titleRepo.Add(titleName);
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }

}
