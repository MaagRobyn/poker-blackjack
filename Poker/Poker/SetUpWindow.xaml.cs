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
using System.Windows.Shapes;

namespace Poker
{
    /// <summary>
    /// Interaction logic for SetUpWindow.xaml
    /// </summary>
    public partial class SetUpWindow : Window
    {
        public string GameType { get; set; }
        public SetUpWindow(string gt)
        {
            GameType = gt;
            InitializeComponent();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gw = new GameWindow(GameType, 2);
            gw.Show();
            this.Close();
        }
    }
}
