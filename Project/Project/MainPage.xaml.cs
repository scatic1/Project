using Project.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.FromHex("#5B5B5D");
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (null == e || null == e.SelectedItem)
                return;

            var item = (CardDataModel)e.SelectedItem;
            
            await Navigation.PushAsync(new Page1(item));
            listView.SelectedItem = null;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Homescreen());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddToShortList());
        }

        private async void bigRED_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
