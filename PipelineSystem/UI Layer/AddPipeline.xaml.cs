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
    /// Interaction logic for AddPipeline.xaml
    /// </summary>
    public partial class AddPipeline : Window
    {
        public AddPipeline()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

        }

        private void OpenMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
