using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

namespace Project.Droid
{
    public class CustomNavigationRenderer : NavigationPageRenderer
    {

        public CustomNavigationRenderer(Context context) : base(context)
        {
            //
            
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var name = e.PropertyName;
         
            if (name.Equals("CurrentPage"))
            {
                ChangeToolbarIconVisibility(Element.CurrentPage is MainPage);
            }
        }
       
        private void ChangeToolbarIconVisibility(bool visible)
        {
            var toolbarIcon = FindViewById<ImageView>(Resource.Id.toolbar);
            toolbarIcon.Visibility = visible ? Android.Views.ViewStates.Visible : Android.Views.ViewStates.Gone;
           
        }

    }
}
