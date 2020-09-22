﻿using System;
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
        string _radioText;

        public MainWindow()
        {
            InitializeComponent();
            _radio = new Radio();
        }

        private void TurnOff(object sender, RoutedEventArgs e)
        {
            _radio.TurnOff();
            _radioText = _radio.Play(); 
            radioText.Content = _radioText;

        }

        private void TurnOn(object sender, RoutedEventArgs e)
        {
            _radio.TurnOn();
            _radio.Channel = 4;
            _radioText = _radio.Play();
            radioText.Content = _radioText;

        }

        private void numberB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
