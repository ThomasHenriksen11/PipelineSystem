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
using System.Windows.Shapes;

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
            Title title = new Title(); //Der mangler en Title Class det er derfor koden ikke kan kører
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
}
