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
using System.Windows.Shapes;

namespace NesneBulmaca
{
    /// <summary>
    /// Interaction logic for StartGame.xaml
    /// </summary>
    public partial class StartGame : Window
    {
        public StartGame()
        {
            InitializeComponent();
        }
        int skor = 0;
        int bulunanNesne = 0;
        int kalanHak = 20;

        /// <summary>
        /// Oyundan cikmak icin event olusturuldu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Kapatmaniz Durumunda Tum Ilerlemeniz Kaybolacaktir. Cikmak Istediginize Emin Misiniz?", "Uyari", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (res == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Nesneler disinda bir yeer tiklandigi zaman olmasi gereken olayalr tanimlaniyor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            kalanHak--;
            skor -= 5;
            lblSkor.Content = skor;
            lblKalanHak.Content = kalanHak;
            if (kalanHak == 0)
            {
                MessageBoxResult res = MessageBox.Show("Tum Nesneleri bulamadiniz. Tekrar Oynamak Ister Misiniz? ", "Oyun Bitti", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (res==MessageBoxResult.Yes)
                {
                    TekrarBasla();
                }
                else
                {
                    this.Close();
                }
            }
        }
        /// <summary>
        /// Butonalara basildigi zaman olacak degiskliklerin saglanmasi icin event olusturldu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn1.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn2.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn3.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn4.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn5.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn6.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn7.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn8.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn9.Visibility = Visibility.Hidden;
            YeniOyun(); YeniOyun();
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn10.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn11.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn12.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn13.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn14.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            Bulundu();
            btn15.Visibility = Visibility.Hidden;
            YeniOyun();
        }

        /// <summary>
        /// Nesne bulundugu zaman degisikliklerin ekrana yazdirilmasi icin sinif olusturuldu
        /// </summary>
        private void Bulundu()
        {
            skor += 20;
            lblSkor.Content = skor;
            bulunanNesne++;
            lblBulunanNesne.Content = bulunanNesne;
        }

        /// <summary>
        /// Kan hak bittignde ya da oyun kazanildiginda oyunun tekrar acilmasi icin class olusturuldu
        /// </summary>
        private void TekrarBasla()
        {
            kalanHak = 20;
            skor = 0;
            bulunanNesne = 0;
            lblBulunanNesne.Content = bulunanNesne;
            lblKalanHak.Content = kalanHak;
            lblSkor.Content = skor;
            btn1.Visibility = Visibility.Visible;
            btn2.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Visible;
            btn4.Visibility = Visibility.Visible;
            btn5.Visibility = Visibility.Visible;
            btn6.Visibility = Visibility.Visible;
            btn8.Visibility = Visibility.Visible;
            btn9.Visibility = Visibility.Visible;
            btn10.Visibility = Visibility.Visible;
            btn11.Visibility = Visibility.Visible;
            btn12.Visibility = Visibility.Visible;
            btn13.Visibility = Visibility.Visible;
            btn14.Visibility = Visibility.Visible;
            btn15.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Yeni oyuna baslayabilmek icin class olusturuldu
        /// </summary>
        private void YeniOyun()
        {
            if (bulunanNesne == 15)
            {
                MessageBoxResult res = MessageBox.Show("Tebrikler Tum Nesneleri Buldunuz.Tekrar Oynamak Ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (res == MessageBoxResult.Yes)
                {
                    TekrarBasla();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
