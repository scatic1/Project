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
       
        public Invoice ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public Invoice(CardDataModel item)
        {
    
            InitializeComponent();
            BindingContext = new InvoiceViewModel(item);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var itemToSend = BindingContext as InvoiceViewModel;
            var item = itemToSend.Item;
            await Navigation.PushAsync(new Profile2(item));
        }
    }
}