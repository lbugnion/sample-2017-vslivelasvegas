﻿using DesignDataSample.Uwp.ViewModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DesignDataSample.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RefreshButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await ((MainViewModel)(LayoutRoot.DataContext)).Refresh();
        }
    }
}