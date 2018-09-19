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
	public partial class Profile2 : ContentPage
	{
        
		public Profile2 ()
		{
			InitializeComponent (); 
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public Profile2(CardDataModel item)
        {
       
            InitializeComponent();
            BindingContext = new Profile2ViewModel(item);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var itemToSend = BindingContext as Profile2ViewModel;
            var item = itemToSend.Item;
            await Navigation.PushAsync(new Page1(item));
        }

        private async void smallGreenT_Clicked(object sender, EventArgs e)
        {
            var itemToSend = BindingContext as Profile2ViewModel;
            var item = itemToSend.Item;
            await Navigation.PushAsync(new Invoice(item));
        }
    }
}