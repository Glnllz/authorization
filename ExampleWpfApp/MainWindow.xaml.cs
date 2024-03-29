using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
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
using static ExampleWpfApp.Code;



namespace ExampleWpfApp
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

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (EmailTB.Text != string.Empty || PasswordTB.Password != string.Empty)
            {
                Code codeWindow = new Code();
                codeWindow.Show();

                MailSender.SendCode("ilizagalina4@gmail.com");
            }
            else
            {
                MessageBox.Show("Вы забыли ввести пароль или логин!");
            }
        }
        public static class MailSender
        {
            public static void SendMail(string recipient, string subject, string body)
            {
                // кто отправляет
                MailAddress fromM = new MailAddress("ilizagalina4@gmail.com", "C#");
                // куда отправляет
                MailAddress toM = new MailAddress(recipient);

                using (MailMessage message = new MailMessage(fromM, toM))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    message.Subject = subject; // Заголовок
                    message.Body = body; // Содержание письма

                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    // задаем ящик который отправляет письмо (адрес и пароль)
                    smtpClient.Credentials = new NetworkCredential(fromM.Address, "pfyx oajj ztyk dzov");

                    smtpClient.Send(message);
                }
            }
            public static void SendCode(string recipient)
            {
                Random rnd = new Random();
                int code = rnd.Next(1000, 9999);
                sendedCode = $"{code}";
                MailAddress fromM = new MailAddress("ilizagalina4@gmail.com", "C#");
                MailAddress toM = new MailAddress(recipient); //куда отправить

                using (MailMessage message = new MailMessage(fromM, toM))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    message.Subject = "Welcome to prop.online!"; // Заголовок
                    message.Body = $"<h1>This is code for you registration : {code}</h1>"; //Содержание
                    message.IsBodyHtml = true;

                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromM.Address, "pfyx oajj ztyk dzov");

                    smtpClient.Send(message);
                }
            }
        }
    }
}