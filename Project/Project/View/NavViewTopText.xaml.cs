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
	public partial class NavViewTopText : ContentView
	{
		public NavViewTopText ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Label label = new Label() { Text = "Brat moj ljepi!", VerticalOptions = LayoutOptions.Center };
            Content = label;
        }
    }
}