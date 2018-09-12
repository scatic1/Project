using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImageCircle;
using ButtonCircle;


namespace Project
{
	public partial class HomeButton : ContentPage
	{
		public HomeButton()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Homescreen());
        }
    }
}
