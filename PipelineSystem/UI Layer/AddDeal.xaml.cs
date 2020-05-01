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
    /// Interaction logic for AddDeal.xaml
    /// </summary>
    public partial class AddDeal : Window
    {
        public AddDeal()
        {
            InitializeComponent();
        }

        private void OpenPipelineWindow(object sender, RoutedEventArgs e)
        {
            PipelineWindow pipelineWindow = new PipelineWindow();
            pipelineWindow.Show();
            this.Close();
        }

        private void SaveTextboxValues(object sender, RoutedEventArgs e)
        {

        }
    }
}
