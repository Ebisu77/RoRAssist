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

namespace RoRAssist.Pages
{
    /// <summary>
    /// Interaction logic for DefaultPage.xaml    
    /// </summary>
    public partial class DefaultPage : Page
    {
        public DefaultPage()
        {
            InitializeComponent();
            
        }

        private void clickPersuadeButton(object sender, RoutedEventArgs e)
        {
            PersuasionPage page = new PersuasionPage();
            this.FrameGameplayContent.Navigate(page);
        }
    }
}
