using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace GitXamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GitXamarinApp.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=ce517679-1d54-42bb-85ef-9d4c532ba7f2;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
