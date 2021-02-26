using MailSender.ViewModels;
using System.Windows;

namespace MailSender
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new MainWindowViewModel();
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();
    }
}
