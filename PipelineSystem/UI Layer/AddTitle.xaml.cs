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
        public AddTitle()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

        }

        private void BackToPipelineWindow(object sender, RoutedEventArgs e)
        {
           // PipelineWindow pipelineWindow = new PipelineWindow();
            //pipelineWindow.Show();
            this.Close();
        }
    }
}
