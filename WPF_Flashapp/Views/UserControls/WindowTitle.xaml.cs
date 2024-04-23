using System.Windows;
using System.Windows.Controls;
using WPF_Flashapp.MVVM;

namespace WPF_Flashapp.Views.UserControls
{
    /// <summary>
    /// Interaction logic for WindowTitle.xaml
    /// </summary>
    public partial class WindowTitle : UserControl
    {
        public RelayCommand CloseWindow => new RelayCommand(execute => Application.Current.Shutdown());
        public RelayCommand MinimizeWindow => new RelayCommand(execute => Application.Current.MainWindow.WindowState = WindowState.Minimized);
        public RelayCommand MaximizeWindow => new RelayCommand(execute => maximizeWindow());
        public WindowTitle()
        {
            DataContext = this;
            InitializeComponent();
        }
        private void maximizeWindow()
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;
        }
    }
}
