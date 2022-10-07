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
    /// Логика взаимодействия для Starsh_Smen.xaml
    /// </summary>
    public partial class Starsh_Smen : Page
    {
        public Starsh_Smen()
        {
            InitializeComponent();
            /// Путь к входным данным старших смены
            string Dann_Starsh_Smen = Ways.Dann_Starsh_Smen;
            /// Сортировка входных данных старших смены
            string[] Read_Dann_Starsh_Smen = File.ReadAllLines(Dann_Starsh_Smen);
            /// Путь к данным старших смены
            string Starsh_Smen_ID = Ways.Starsh_Smen_ID;
            /// Функция определения нужных данных
            using (StreamReader sr = new StreamReader(Starsh_Smen_ID))
            {
                int ID = Convert.ToInt32(sr.ReadLine());
                for (int j = 0; j < Read_Dann_Starsh_Smen.Length; j += 3)
                {
                    for (int i = 0; i < (Convert.ToInt32(ID) + 2); i += 1)
                    {
                        /// Замена в странице полей нужными данными 
                        Surname.Content = Read_Dann_Starsh_Smen[j];
                        Name.Content = Read_Dann_Starsh_Smen[j + 1];
                        Post.Content = Read_Dann_Starsh_Smen[j + 2];
                        int Id = Convert.ToInt32(ID) + 1;
                        Foto.Source = BitmapFrame.Create(new Uri(Ways.Foto_Starsh_Smen + Convert.ToString(Id) + ".png", UriKind.Relative));
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

        private void But_Click_Form_Zak(object sender, RoutedEventArgs e)
        {

        }

        private void But_Click_Prin_Tov(object sender, RoutedEventArgs e)
        {

        }
    }
}
