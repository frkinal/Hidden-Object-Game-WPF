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
using System.Windows.Threading;

namespace NesneBulmaca
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Window yuklendigi zaman 25 sn den geri sayacak bir timespan olusturuluyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();
        }
        private int _sayac = 25;
        private int sayac = 25;
        /// <summary>
        /// Sayac 0 a ulastiginda oyun ekraninin acilmasi icinm event olsuturuldu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtTicker(object sender,EventArgs e)
        {
            StartGame startGame = new StartGame();
            sayac--;
            TimerLabel.Content = sayac.ToString();
            if (sayac == 0)
            {
                this.Close();
                startGame.ShowDialog();
            }
        }
        /// <summary>
        /// Butona basilgi zamanoyun eklraninin acilmasi icin button_click eventi tanimlandi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartGame startGame = new StartGame();
            sayac = 0;
            this.Close();
            startGame.ShowDialog();
        }
    }
}
