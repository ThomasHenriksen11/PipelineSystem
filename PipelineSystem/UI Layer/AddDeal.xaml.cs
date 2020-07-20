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
using PipelineSystem.Domain_Layer;
using PipelineSystem.Application_Layer;

namespace PipelineSystem.UI_Layer
{
    /// <summary>
    /// Interaction logic for AddDeal.xaml
    /// </summary>
    public partial class AddDeal : Window
    {
        private Controller controller;

        public AddDeal(Controller controller)
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            this.controller = controller;
        }

        private void OpenPipelineWindow(object sender, RoutedEventArgs e)
        {
            PipelineWindow pipelineWindow = new PipelineWindow(controller);
            pipelineWindow.Show();
            this.Close();
        }

        private void SaveTextboxValues(object sender, RoutedEventArgs e)
        {
            Deal deal = new Deal();
            string name = DealName.Text;
            string contactName = ContactName.Text;
            string value = Value.Text;
            if (name == ""|| contactName == "" || value == "")
            {
                Console.WriteLine("Error no inputs");
                Console.ReadLine();
            }
            else
            {
            controller.dealRepo.Add(name,contactName,value);
            }
            MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            this.Close();
        }
    }
}
