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
    /// Логика взаимодействия для Admins.xaml
    /// </summary>
    public partial class Admins : Page
    {
        public Admins()
        {
            InitializeComponent();
            /// Путь к входным данным администраторов
            string Dann_Admins = Ways.Dann_Admins;
            /// Сортировка входных данных администраторов
            string[] Read_Dann_Admins = File.ReadAllLines(Dann_Admins);
            /// Путь к данным администраторов
            string Admins_ID = Ways.Admins_ID;
            /// Функция определения нужных данных
            using (StreamReader sr = new StreamReader(Admins_ID))
            {
                int ID = Convert.ToInt32(sr.ReadLine());
                for (int j = 0; j < Read_Dann_Admins.Length; j += 3)
                {
                    for (int i = 0; i < (Convert.ToInt32(ID) + 2); i += 1)
                    {
                        /// Замена в странице полей нужными данными 
                        Surname.Content = Read_Dann_Admins[j];
                        Name.Content = Read_Dann_Admins[j + 1];
                        Post.Content = Read_Dann_Admins[j + 2];
                        int Id = Convert.ToInt32(ID) + 1;
                        Foto.Source = BitmapFrame.Create(new Uri(Ways.Foto_Admins + Convert.ToString(Id) + ".png", UriKind.Relative));
                        if (i == Convert.ToInt32(ID))
                        {
                            goto LoopEnd;
                        }
                        j += 3;
                    }
                LoopEnd: break;
                }
            }
        }

        private void But_Click_Form_Otch(object sender, RoutedEventArgs e)
        {

        }

        private void But_Click_Hustory_Vhod(object sender, RoutedEventArgs e)
        {
            /// Перевод на страницу история
            Manager.MainFrame.Navigate(new History());
        }

        private void But_Click_Rash_Mat(object sender, RoutedEventArgs e)
        {

        }
    }
}
