﻿using App1.Controls;
using App1.ViewModels;
using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Authentication.OnlineId;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace App1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var vm = new MainViewModel();
            this.DataContext = vm;
        }

        private async void ListBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("你点击了");
            await md.ShowAsync();
        }

        private async void ListBox_Holding(object sender, HoldingRoutedEventArgs e)
        {
            //MessageDialog md = new MessageDialog("你Holding了");
            //await md.ShowAsync();
        }
    }

}
