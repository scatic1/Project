﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Project.Droid.Renderers;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(Picker), typeof(CustomPickerRenderer))]
//namespace Project.Droid.Renderers
//{ 
//        class CustomPickerRenderer : PickerRenderer
//        {
//            protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
//            {
//                base.OnElementChanged(e);
//                if (Control != null)
//                {
//                    GradientDrawable gd = new GradientDrawable();
//                    gd.SetStroke(0, Android.Graphics.Color.Transparent);
//                    Control.SetBackground(gd);
//                }
//            }
//        }
    
//}