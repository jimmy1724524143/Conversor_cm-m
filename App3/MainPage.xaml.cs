using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            

        }

        private void Image_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btniniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new convertir()); 
        }
    }
}
