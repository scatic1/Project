using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TeamOverviewPage : ContentPage
	{
       
       
        public TeamOverviewPage ()
		{
            InitializeComponent();
            BindingContext = new TeamOverviewViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Clicked11(object sender, EventArgs e)
        {
            var kontejner = BindingContext as TeamOverviewViewModel;
            await Navigation.PushAsync(new Profile2(kontejner.random11));
        }

        private async void Clicked12(object sender, EventArgs e)
        {
            var kontejner = BindingContext as TeamOverviewViewModel;
            await Navigation.PushAsync(new Profile2(kontejner.random12));
        }

        private async void Clicked13(object sender, EventArgs e)
        {
            var kontejner = BindingContext as TeamOverviewViewModel;
            await Navigation.PushAsync(new Profile2(kontejner.random13));
        }

        private async void Clicked21(object sender, EventArgs e)
        {
            var kontejner = BindingContext as TeamOverviewViewModel;
            await Navigation.PushAsync(new Profile2(kontejner.random21));
        }

        private async void Clicked22(object sender, EventArgs e)
        {
            var kontejner = BindingContext as TeamOverviewViewModel;

            await Navigation.PushAsync(new Profile2(kontejner.random22));
        }

        private async void Clicked23(object sender, EventArgs e)
        {
            var kontejner= BindingContext as TeamOverviewViewModel;
            await Navigation.PushAsync(new Profile2(kontejner.random23));
        }
    }
}