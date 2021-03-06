﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DataAccessLibrary;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Vinylist.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class wantlist : Page
    {
        public wantlist()
        {
            this.InitializeComponent();

        }


        // ========================ADD DATA==================================
        private void AddDataWantlist(object sender, RoutedEventArgs e)
        {
            DataAccess.AddDataWantlist("=========================");
            DataAccess.AddDataWantlist("ARTIST:   " + Artist.Text);
            DataAccess.AddDataWantlist("ALBUM:    " + Album.Text);

            Output.ItemsSource = DataAccess.GetDataWantlist();
        }
        // ===================END OF ADD DATA==================================

      
        
        // =====================BACK BUTTON=========================
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

    }
}
