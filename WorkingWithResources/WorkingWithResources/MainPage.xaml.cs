using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace WorkingWithResources
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void clicked(object sender, EventArgs e)
        {
            this.img.Source = this.img.Source.ToString().EndsWith("_1.png") ?
                "/Resources/Images/jogger_2.png" :
                "/Resources/Images/jogger_1.png";
        }
       
    }
}
