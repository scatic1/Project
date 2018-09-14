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
	public partial class Invoice : ContentPage
	{
        CardDataModel _item = new CardDataModel();
        public Invoice ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public Invoice(CardDataModel item)
        {
            _item = item;
            InitializeComponent();
            BindingContext = new InvoiceViewModel(item);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile2(_item));
        }
    }
}