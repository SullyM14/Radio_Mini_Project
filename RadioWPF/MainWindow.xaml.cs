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
using RadioApp;

namespace RadioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Radio _radio;

        public MainWindow()
        {
            InitializeComponent();
            _radio = new Radio();
        }

        private void TurnOff(object sender, RoutedEventArgs e)
        {
            _radio.TurnOff();
            radioText.Content = _radio.Play();

        }

        private void TurnOn(object sender, RoutedEventArgs e)
        {
            _radio.TurnOn();
            _radio.Channel = 4;
            radioText.Content = _radio.Play();
        }

        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            _radio.VolumeUp();
            var volumestring = Convert.ToString(_radio._volume);
            Volume.Content = $"Volume: {volumestring}";
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            _radio.VolumeDown();
            var volumestring = Convert.ToString(_radio._volume);
            Volume.Content = $"Volume: {volumestring}";
        }

        //Select Channels
        //Volume Slider maybe
        //Play button need to be implemented


    }
}
