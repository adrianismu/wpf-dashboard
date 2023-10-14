using System.Windows;
using System.Windows.Input;

namespace Dark_Admin_Panel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Item_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CartesianChart_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void InfoCard_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}