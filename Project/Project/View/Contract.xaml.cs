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
      
        public Contract()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public Contract(CardDataModel item)
        {
            InitializeComponent();
            BindingContext = new ContractViewModel(item);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var itemToSend = BindingContext as ContractViewModel;
            var item = itemToSend.Item;
            await Navigation.PushAsync(new Page1(item));
        }

        private async void bigGreen_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TeamOverviewPage());
        }
    }
}