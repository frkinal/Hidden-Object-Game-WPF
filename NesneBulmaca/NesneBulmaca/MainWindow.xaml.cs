
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

namespace NesneBulmaca
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
         /// <summary>
         /// Start dugmesinew basildiginde oyun ekranlarinin acilmasi icin event olusturuldu.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Start start = new Start();
            start.ShowDialog();
        }

        /// <summary>
        /// Butona basildigi zaman Nasil Oynanir ekraninin  acilmasi icin event tanimlandi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NasilOynanir nslOynanir = new NasilOynanir();
            nslOynanir.ShowDialog();
        }
    }
}
