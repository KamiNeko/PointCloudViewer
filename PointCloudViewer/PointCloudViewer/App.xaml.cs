﻿using PointCloudViewer.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PointCloudViewer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}