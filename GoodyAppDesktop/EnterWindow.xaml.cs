using System;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using GoodyDataLib.Models;
using GoodyDataLib.Services;

namespace GoodyAppDesktop
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        public static string ConnectionString { get; set; } = $"Data Source=zhekusonsql.database.windows.net;" +
            $" Initial Catalog = GoodyBase;" +
            $"Integrated Security = True;" +
            $"User ID = zhekuson;" +
            $"Password=wasd#1580;" +
            $"Trusted_Connection = False;" +
            $"Encrypt=True;";

        public EnterWindow()
        {
            InitializeComponent();

            SetContent();
        }

        private void SetContent()
        {
            Login.GotFocus += RemoveText;
            Login.LostFocus += AddText;
        }

        private void RemoveText(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "Введите логин";
            }
        }

        private async void EnterButtonClick(object sender, RoutedEventArgs e)
        {
            if(Login.Text != "Введите логин")
            {
                AdministratorService administrator = new AdministratorService(ConnectionString);
                System.Collections.Generic.List<AdministratorInfo> admins = await administrator.GetRecordsAsync("Login", Login.Text);
                if (admins.Count != 0)
                {
                    if (admins[0].Password == Password.Password)
                    {
                        Storage.Name = $"{admins[0].Name} {admins[0].FName}";
                        Window window = new MainWindow(Height, Width, Left, Top, WindowState);
                        window.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Несуществующий логин!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите логин!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void SendEmail()
        {
            try
            {
                //адрес почты отправителя и имя отправителя
                MailAddress from = new MailAddress("", "");
                //адрес почты получателя
                MailAddress to = new MailAddress("");
                MailMessage message = new MailMessage(from, to)
                {
                    Subject = "", //Заголовок сообщения
                    Body = $"" //Текст сообщения
                };
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    //Логин и пароль почты отправителя
                    Credentials = new NetworkCredential("", ""),
                    EnableSsl = true
                };
                await smtp.SendMailAsync(message);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка",
                "Восстановление пароля", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
            

        private void ForgotButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("На вашу почту было выслано письмо, для восстановления пароля",
                "Восстановление пароля", MessageBoxButton.OK, MessageBoxImage.Information);
            var name = "Алексей";
            var middleName = "Петрович";
            Storage.Name = $"{name} {middleName}";
            Window window = new MainWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            //SendEmail();
            Close();
        }
    }
}
