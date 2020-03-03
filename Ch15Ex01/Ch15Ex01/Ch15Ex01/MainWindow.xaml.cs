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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ch15Ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RoraredButton_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void rotatedButton_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("roatedButton_KeyDown handler, bubbling up");
        }

        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, bubbling up");
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Gride handler, bubbling up");
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid handler, tunneling down");
            e.Handled = true;
        }

        private void rotatedButton_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("roraredButton handler, tunneling down");
        }

        private void window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, tunneling down");
        }
    }
}
