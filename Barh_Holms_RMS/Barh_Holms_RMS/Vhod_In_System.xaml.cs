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
using System.IO;

namespace Barh_Holms_RMS
{
    /// <summary>
    /// Логика взаимодействия для Vhod_In_System.xaml
    /// </summary>
    public partial class Vhod_In_System : Page
    {
        public Vhod_In_System()
        {
            InitializeComponent();
        }
        /// Функция показа кнопки "Назад"
        private void But_Click_Pokaz(object sender, RoutedEventArgs e)
        {
            /// Капирование введённых данных из PasswordBox в TextBox
            Password_2.Text = Password_1.Password.ToString();
            /// Скрытие раскрывающей кнопки и раскрытие скрывающей кнопки
            But_Skryt.Visibility = Visibility.Visible; But_Pokaz.Visibility = Visibility.Hidden;
            /// Скрытие PasswordBox и раскрытие TextBox
            Password_2.Visibility = Visibility.Visible; Password_1.Visibility = Visibility.Hidden;
        }
        /// Функция скрытия кнопки "Назад"
        private void But_Click_Skryt(object sender, RoutedEventArgs e)
        {
            /// Скрытие скрывающей кнопки и раскрытие раскрывающей кнопки
            But_Skryt.Visibility = Visibility.Hidden; But_Pokaz.Visibility = Visibility.Visible;
            /// Скрытие TextBox и раскрытие PasswordBox
            Password_2.Visibility = Visibility.Hidden; Password_1.Visibility = Visibility.Visible;
        }
        /// Настройка кнопки "Вход"
        private void But_Click_Vhod(object sender, RoutedEventArgs e)
        {
            /// Структурирование входных данных администраторов
            string Dann_Admins = Ways.Admins;
            string[] Read_Dann_Admin = File.ReadAllLines(Dann_Admins);
            /// Структурирование входных данных продавцов
            string Dann_Prodavec = Ways.Prodavec;
            string[] Read_Dann_Prodavec = File.ReadAllLines(Dann_Prodavec);
            /// Структурирование входных данных старших смены
            string Dann_Starsh_Smen = Ways.Starsh_Smen;
            string[] Read_Dann_Starsh_Smen = File.ReadAllLines(Dann_Starsh_Smen);
            /// Путь к файлу хранения ID продавцов
            string Prodavec_ID = Ways.Prodavec_ID;
            string[] Read_Prodavec_ID = File.ReadAllLines(Prodavec_ID);
            /// Путь к файлу хранения ID администраторов
            string Admins_ID = Ways.Admins_ID;
            /// Путь к файлу хранения ID старших смены
            string Starsh_Smen_ID = Ways.Starsh_Smen_ID;

            /// Капирование введённых данных из PasswordBox в TextBox
            Password_2.Text = Password_1.Password.ToString();

            /// Запись данных для истории
            string Hist_Data = Ways.Hist_Data;
            string Hist_Log = Ways.Hist_Log;
            string Hist_TF = Ways.Hist_TF;
            File.AppendAllText(Hist_Data, "\n" + Convert.ToString(DateTime.Now));
            File.AppendAllText(Hist_Log, "\n" + TextBox_Login.Text);

            /// Проверка введённых данных
            while (true)
            {
                /// Проверка входных данных продавцов
                for (int i = 0; i < Read_Dann_Prodavec.Length; i += 2)
                {
                    if (TextBox_Login.Text == Read_Dann_Prodavec[i])
                    {
                        if (Password_2.Text == Read_Dann_Prodavec[i + 1])
                        {
                            /// Очищаем файл ID
                            File.WriteAllText(Prodavec_ID, string.Empty);
                            /// Записываем ID В файл
                            File.WriteAllText(Prodavec_ID, Convert.ToString(i / 2));
                            /// Очистка полей ввода
                            TextBox_Login.Text = "";
                            Password_2.Text = "";
                            /// Сброс кнопки показа пороля
                            But_Skryt.Visibility = Visibility.Hidden; But_Pokaz.Visibility = Visibility.Visible;
                            Password_2.Visibility = Visibility.Hidden; Password_1.Visibility = Visibility.Visible;
                            /// Перевод на страницу пользователя
                            Manager.MainFrame.Navigate(new Prodavec());
                            /// Записываем в историю успех входа
                            File.AppendAllText(Hist_TF, "\n" + "Успех");
                            goto LoopEnd;
                        }
                    }
                }
                /// Проверка входных данных администраторов
                for (int j = 0; j < Read_Dann_Admin.Length; j += 2)
                {
                    if (TextBox_Login.Text == Read_Dann_Admin[j])
                    {
                        if (Password_2.Text == Read_Dann_Admin[j + 1])
                        {
                            /// Очищаем файл ID
                            File.WriteAllText(Admins_ID, string.Empty);
                            /// Записываем ID В файл
                            File.WriteAllText(Admins_ID, Convert.ToString(j / 2));
                            /// Очистка полей ввода
                            TextBox_Login.Text = "";
                            Password_2.Text = "";
                            /// Сброс кнопки показа пороля
                            But_Skryt.Visibility = Visibility.Hidden; But_Pokaz.Visibility = Visibility.Visible;
                            Password_2.Visibility = Visibility.Hidden; Password_1.Visibility = Visibility.Visible;
                            /// Перевод на страницу пользователя
                            Manager.MainFrame.Navigate(new Admins());
                            /// Записываем в историю успех входа
                            File.AppendAllText(Hist_TF, "\n" + "Успех");
                            goto LoopEnd;
                        }
                    }
                }
                /// Проверка входных данных старших смены
                for (int j = 0; j < Read_Dann_Starsh_Smen.Length; j += 2)
                {
                    if (TextBox_Login.Text == Read_Dann_Starsh_Smen[j])
                    {
                        if (Password_2.Text == Read_Dann_Starsh_Smen[j + 1])
                        {
                            /// Очищаем файл ID
                            File.WriteAllText(Starsh_Smen_ID, string.Empty);
                            /// Записываем ID В файл
                            File.WriteAllText(Starsh_Smen_ID, Convert.ToString(j / 2));
                            /// Очистка полей ввода
                            TextBox_Login.Text = "";
                            Password_2.Text = "";
                            /// Сброс кнопки показа пороля
                            But_Skryt.Visibility = Visibility.Hidden; But_Pokaz.Visibility = Visibility.Visible;
                            Password_2.Visibility = Visibility.Hidden; Password_1.Visibility = Visibility.Visible;
                            /// Перевод на страницу пользователя
                            Manager.MainFrame.Navigate(new Starsh_Smen());
                            /// Записываем в историю успех входа
                            File.AppendAllText(Hist_TF, "\n" + "Успех");
                            goto LoopEnd;
                        }
                    }
                }
                /// Вывод предупреждения
                MessageBox.Show("Неверный логин или пароль!");
                /// Записываем в историю провал входа
                File.AppendAllText(Hist_TF, "\n" + "Провал");
                break;
                LoopEnd: break;
            }
        }
    }
}
