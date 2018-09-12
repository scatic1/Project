using Project.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Homescreen : ContentPage
	{
		public Homescreen ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void bigGrey_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTimePage());
        }

        private async void bigGreyy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomeButton());
        }
    }
}