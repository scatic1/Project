﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle;
using Project.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddToShortList : ContentPage
	{
   
        public AddToShortList(CardDataModel item)
        {
            InitializeComponent(); 
            BindingContext = new AddToShortListViewModel(item);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public AddToShortList ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void bigGreen_Clicked(object sender, EventArgs e)
        {
            var itemToSend = BindingContext as AddToShortListViewModel;
            var item = itemToSend.Item;
            await Navigation.PushAsync(new Contract(item));
        }
    }
}