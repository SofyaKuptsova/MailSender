using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace TestWPF
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
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var from = new MailAddress(EmailFromTb.Text, SenderName.Text); 
            var to = new MailAddress(EmailToTb.Text, RecipientName.Text);

            var message = new MailMessage(from, to);
            message.Subject = SubjectText.Text;
            message.Body = BodyText.Text;

            //var port = Convert.ToInt32(PortTb.Text);
            var client = new SmtpClient(ServerNameTb.Text, Convert.ToInt32(PortTb.Text));
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential
            {
                UserName = LoginEdit.Text,
                SecurePassword = PasswordEdit.SecurePassword
                //Password = "Password!"
            };

            try
            {
                client.Send(message);

                MessageBox.Show("Почта успешно отправлена!", "Отправка почты", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SmtpException)
            {
                MessageBox.Show("Ошибка авторизации", "Ошибка отправки почты", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Ошибка адреса сервера", "Ошибка отправки почты", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
