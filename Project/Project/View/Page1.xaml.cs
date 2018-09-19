using Project.View;
using Project.ViewModel;
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
    public partial class Page1 : ContentPage
    {

        
        public Page1()
        {
            InitializeComponent();     
            NavigationPage.SetHasNavigationBar(this, false);

        }

        public Page1(CardDataModel item)
        {
           
            InitializeComponent();
            BindingContext = new Page1ViewModel(item);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void bigGreen_Clicked(object sender, EventArgs e)
        {
            
            var itemToSend = BindingContext as Page1ViewModel;
            var item = itemToSend.Item;
            await Navigation.PushAsync(new SheduleInterview(item));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var itemToSend = BindingContext as Page1ViewModel;
            var item = itemToSend.Item;
            await Navigation.PushAsync(new SheduleInterview(item));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            var itemToSend = BindingContext as Page1ViewModel;
            var item = itemToSend.Item;
            await Navigation.PushAsync(new Contract(item));
        }






        //public static readonly Xamarin.Forms.BindableProperty IsNavigationBarTranslucentProperty;

    }

}