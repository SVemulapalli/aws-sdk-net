﻿using CommonTests;
using CommonTests.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public TestRunner TestRunner { get; private set; }

        private CoreDispatcher dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            var credentialsFile = @"Assets\credentials.json";
            StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFile file = await InstallationFolder.GetFileAsync(credentialsFile);
            var stream = await file.OpenStreamForReadAsync();
            this.TestRunner = new WindowsAppRunner(stream, dispatcher, this.textBox);
        }

        //protected async override void OnGotFocus(RoutedEventArgs e)
        //{
            

            
        //}

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await TestRunner.ExecuteAllTestsAsync();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
