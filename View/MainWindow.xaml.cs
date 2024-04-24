using DBChebakov.ViewModel;
using System.Windows;

namespace DBChebakov
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}