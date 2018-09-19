using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImageCircle;
using ButtonCircle;
using Project.View;

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

        private async void CircleButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTimePage());
        }
    }
}
