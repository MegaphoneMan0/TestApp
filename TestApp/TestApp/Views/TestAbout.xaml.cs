using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestApp.Views
{
    public partial class TestAbout : ContentPage
    {
        public TestAbout()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
        }
    }
}