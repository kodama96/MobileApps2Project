﻿using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Vinylist.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class about : Page
    {
        public about()
        {
            this.InitializeComponent();

            // ============= LIST FOR ITEMS IN COLLECTION =========================
            /*ObservableCollection<CollectionClass> dataList = new ObservableCollection<CollectionClass>();

            CollectionClass c1 = new CollectionClass() { Artist = "Danny Brown", Album = "XXX", Year = "2012" };

            CollectionClass c2 = new CollectionClass() { Artist = "Kendrick Lamar", Album = "DAMN.", Year = "2017" };

            CollectionClass c3 = new CollectionClass() { Artist = "Gorillaz", Album = "Demon Days", Year = "2006" };

            dataList.Add(c1);

            dataList.Add(c2);

            dataList.Add(c3);

            CollectionList.ItemsSource = dataList;*/
            // ====================================================================

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}