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
	public partial class Contract : ContentPage
	{
        CardDataModel _item = new CardDataModel();
        public Contract()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public Contract(CardDataModel item)
        {
            InitializeComponent();
            _item = item;
            BindingContext = new ContractViewModel(item);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(_item));
        }
    }
}