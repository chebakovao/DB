using DBChebakov.ViewModel;
using System.Windows;

namespace DBChebakov.View
{
    public partial class AreaWindow : Window
    {
        public AreaWindow()
        {
            InitializeComponent();
            DataContext = new AreaViewModel();
        }
    }
}
