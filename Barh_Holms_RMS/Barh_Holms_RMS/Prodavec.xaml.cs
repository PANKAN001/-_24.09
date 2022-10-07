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
    /// Логика взаимодействия для Prodavec.xaml
    /// </summary>
    public partial class Prodavec : Page
    {
        public Prodavec()
        {
            InitializeComponent();
            /// Путь к входным данным продавцов
            string Dann_Prodavec = Ways.Dann_Prodavec;
            /// Сортировка входных данных старших смены
            string[] Read_Dann_Prodavec = File.ReadAllLines(Dann_Prodavec);
            /// Путь к данным старших смены
            string Prodavec_ID = Ways.Prodavec_ID;
            /// Функция определения нужных данных
            using (StreamReader sr = new StreamReader(Prodavec_ID))
            {
                int ID = Convert.ToInt32(sr.ReadLine());
                for (int j = 0; j < Read_Dann_Prodavec.Length; j += 3)
                {
                    for (int i = 0; i < (Convert.ToInt32(ID) + 2); i += 1)
                    {
                        /// Замена в странице полей нужными данными 
                        Surname.Content = Read_Dann_Prodavec[j];
                        Name.Content = Read_Dann_Prodavec[j + 1];
                        Post.Content = Read_Dann_Prodavec[j + 2];
                        int Id = Convert.ToInt32(ID) + 1;
                        Foto.Source = BitmapFrame.Create(new Uri(Ways.Foto_Prodavec + Convert.ToString(Id) + ".png", UriKind.Relative));
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
    }
}
