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
