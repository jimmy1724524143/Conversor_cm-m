using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class convertir : ContentPage
	{

		double cm;
		double m;

       

        public convertir ()
		{
			InitializeComponent ();
		
			
		
		}
		
		private void Calcular()
		{
			cm = Convert.ToDouble(txtcm.Text);
			m = cm / 100;
			lblresult.Text = m.ToString() + " m ";
			
		}
		private void validar() 
		{
			if (!string.IsNullOrEmpty(txtcm.Text))
			{
				Calcular();
			}
			else {
				DisplayAlert("ERROR", "INGRESE UNA CANTIDAD", "OK");
			} 
		}



        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
			validar();
        }
    }
}