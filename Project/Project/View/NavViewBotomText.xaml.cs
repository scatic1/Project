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
	public partial class NavViewBotomText : ContentView
	{
		public NavViewBotomText ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Label label = new Label() { Text = "Vijaj ovo", VerticalOptions = LayoutOptions.Center };
            Content = label;
        }
    }
}