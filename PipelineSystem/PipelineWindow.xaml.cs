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
    /// Interaction logic for PipelineWindow.xaml
    /// </summary>
    public partial class PipelineWindow : Window
    {
        public PipelineWindow()
        {
            InitializeComponent();
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void OpenAddDeal(object sender, RoutedEventArgs e)
        {
            AddDeal addDeal = new AddDeal();
            addDeal.Show();
            this.Close();
        }

        private void ToAddTitleWindow(object sender, RoutedEventArgs e)
        {
            AddTitle addTitle = new AddTitle();
            addTitle.Show();
            this.Close();
        }
    }
}
