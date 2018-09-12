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

        CardDataModel itemToSend = new CardDataModel();
        public Page1()
        {
            InitializeComponent();
            //CustomNavigationPage.SetBarBackgroundColor(this,Color.Transparent);
           // ((NavigationPage)Application.Current.MainPage).BackgroundImage = "https://www.pictorem.com/collection/900_Travenesia_Early%20Morning%20Sunshine%20Mount%20Latimojong%20-%20Indonesia.jpg";
            NavigationPage.SetHasNavigationBar(this, false);

        }

        public Page1(CardDataModel item)
        {
            itemToSend = item;
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
            // await Navigation.PushAsync(new AddToShortList());
            await Navigation.PushAsync(new AddToShortList(itemToSend));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SheduleInterview(itemToSend));
        }


        //public static readonly Xamarin.Forms.BindableProperty IsNavigationBarTranslucentProperty;

    }

}