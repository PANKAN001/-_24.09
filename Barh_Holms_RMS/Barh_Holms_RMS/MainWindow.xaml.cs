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
using System.Windows.Threading;
using System.IO;

namespace Barh_Holms_RMS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TimeSpan _time;
        public DispatcherTimer _timer;
        public MainWindow()
        {
            InitializeComponent();
            /// Отображение страницы входа
            MainFrame.Navigate(new Vhod_In_System());
            Manager.MainFrame = MainFrame;
        }
        /// Настройка кнопки возврата
        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
        /// Скрытие и раскрытие кнопки возврата
        private void Ubrat(object sender, EventArgs e)
        {
            /// Путь к файлу хранения ID продавцов
            string Prodavec_ID = Ways.Prodavec_ID;
            int Who = 0;
            if (MainFrame.CanGoBack)
            {
                Button_back.Visibility = Visibility.Visible;
                _time = TimeSpan.FromSeconds(600);
                _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
                {
                    tbTime.Text = _time.ToString("c");
                    if (_time == TimeSpan.FromSeconds(300))
                    {
                        MessageBox.Show("До окончания сеанса 5 минут!");
                    }
                    if (_time == TimeSpan.Zero)
                    {
                        if (Who == 0)
                        {
                            _time = TimeSpan.FromSeconds(180);
                            MainFrame.Navigate(new Vhod_In_System());
                            Button_back.Visibility = Visibility.Collapsed;
                            /// Очищаем файл ID
                            File.WriteAllText(Prodavec_ID, string.Empty);
                            /// Записываем ID В файл
                            File.WriteAllText(Prodavec_ID, "Yes");
                            Who = 1;
                        }
                        if (Who == 1)
                        {
                            /// Очищаем файл ID
                            File.WriteAllText(Prodavec_ID, string.Empty);
                        }
                    }
                    _time = _time.Add(TimeSpan.FromSeconds(-1));
                }, Application.Current.Dispatcher);
                _timer.Start();
            }
            else
            {
                Button_back.Visibility = Visibility.Collapsed;
                if (_timer != null)
                {
                    _timer.Stop();
                }
                tbTime.Text = "";
            }
        }
    }
}
