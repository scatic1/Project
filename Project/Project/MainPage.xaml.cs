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
            //((NavigationPage)Application.Current.MainPage).BackgroundImage = "https://images.unsplash.com/photo-1521208916306-71fce562015a?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=7cd0806c18e8f10b8fddf53c5f6e71ca&w=1000&q=80";
            //listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            //{

            //    if (e.SelectedItem == null)
            //    {
            //        return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            //    }

            //    var foo = e.SelectedItem as CardDataModel;

            //    if (foo == null)
            //        return;

            //    DisplayAlert("Item Selected", foo.Name, "Ok");
            //    //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
            //};
            NavigationPage.SetHasNavigationBar(this, false);

        }


        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Page1());

        //}


        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (null == e || null == e.SelectedItem)
                return;

            var item = (CardDataModel)e.SelectedItem;

            // now you can reference item.Name, item.Location, etc

            //DisplayAlert("ItemSelected", item.Name, "Ok");

            await Navigation.PushAsync(new Page1(item));
            listView.SelectedItem = null;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new TeamOverviewPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddToShortList());
        }

        private async void bigRED_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Homescreen());
        }
    }
}
