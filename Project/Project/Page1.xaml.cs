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
            //CustomNavigationPage.SetBarBackgroundColor(this,Color.Transparent);
            ((NavigationPage)Application.Current.MainPage).BackgroundImage = "https://www.pictorem.com/collection/900_Travenesia_Early%20Morning%20Sunshine%20Mount%20Latimojong%20-%20Indonesia.jpg";
            NavigationPage.SetHasNavigationBar(this, false);

        }

        public Page1(CardDataModel item)
        {
            InitializeComponent();
            BindingContext = new Page1ViewModel(item);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }


        //public static readonly Xamarin.Forms.BindableProperty IsNavigationBarTranslucentProperty;

    }

}