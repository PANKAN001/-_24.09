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
    /// Логика взаимодействия для History.xaml
    /// </summary>
    public partial class History : Page
    {
        public History()
        {
            InitializeComponent();
            /// Путь к хранилищю истории
            string Hist_Data = Ways.Hist_Data;
            string Hist_Log = Ways.Hist_Log;
            string Hist_TF = Ways.Hist_TF;

            /// Структурирование данных истории
            string[] Read_Hist_Data = File.ReadAllLines(Hist_Data);
            string[] Read_Hist_Log = File.ReadAllLines(Hist_Log);
            string[] Read_Hist_TF = File.ReadAllLines(Hist_TF);

            /// Переводим массивы в списки
            var myList_HD = Read_Hist_Data.ToList();
            var myList_HL = Read_Hist_Log.ToList();
            var myList_HTF = Read_Hist_TF.ToList();

            /// Удоляем данные заказа
            myList_HD.Sort();
            myList_HL.Sort();
            myList_HTF.Sort();

            /// Переводим списки в массивы
            string[] Read_Hist_Data_S = myList_HD.ToArray();
            string[] Read_Hist_Log_S = myList_HL.ToArray();
            string[] Read_Hist_TF_S = myList_HTF.ToArray();

            /// Проверка входных данных продавцов
            for (int i = 0; i < Read_Hist_Data.Length; i += 1)
            {
                TB_Data.Text += "\n" + Read_Hist_Data_S[i];
                TB_Log.Text += "\n" + Read_Hist_Log_S[i];
                TB_PV.Text += "\n" + Read_Hist_TF_S[i];
            }

            TB_Data.IsReadOnly = true;
            TB_Log.IsReadOnly = true;
            TB_PV.IsReadOnly = true;
        }

        private void Chec_Log(object sender, RoutedEventArgs e)
        {

        }

        private void Chec_Data(object sender, RoutedEventArgs e)
        {

        }

        private void Unchec_Log(object sender, RoutedEventArgs e)
        {

        }

        private void Unchec_Data(object sender, RoutedEventArgs e)
        {

        }
    }
}
