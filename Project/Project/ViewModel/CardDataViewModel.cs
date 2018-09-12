using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Project
{
    public class CardDataViewModel
    {
        public IList<CardDataModel> CardDataCollection { get; set; }
        public object SelectedItem { get; set; }
        public CardDataViewModel()
        {
            CardDataCollection = new List<CardDataModel>();
            GenerateCardModel();
        }
        //private CardDataModel _selectedItem { get; set; }

        //public CardDataModel SelectedItem
        //{

        //    get
        //    {
        //        return _selectedItem;
        //    }

        //    set
        //    {
        //        _selectedItem = value;

        //        // When your item is selected, you can open a new "PageDetail" and pass the value
        //        Application.Current.MainPage.Navigation.PushAsync(new Page1(_selectedItem)); // If you are in a Navigation page
        //    }
        //}
        private void GenerateCardModel()
        {
            CardDataCollection = new ObservableCollection<CardDataModel>
            {
                new CardDataModel
                {
                    ProfileImage ="https://scontent.fsjj2-1.fna.fbcdn.net/v/t1.0-9/37375855_2003064403037421_6435417763254108160_n.jpg?_nc_cat=0&oh=12429706f92c7140c38e8037cb7a525c&oe=5C303160",
                    Name="Merima" ,
                    Availability =false,
                    Profession="Web developer",
                   Education ="Bachelor engineer",
                    Rate="870 ",
                   Star=3.5,
                  Experience=new string[]{ "Propeller","ETF"}
      
        },
                 new CardDataModel
                {
                    ProfileImage ="https://scontent.fsjj2-1.fna.fbcdn.net/v/t1.0-9/15420992_1359484517395416_7247385033604416897_n.jpg?_nc_cat=0&oh=7350927e79d49b90e58a95e034072bae&oe=5BF1ED08",
                    Name="Merima" ,
                    Availability =true,
                    Profession="Web developer",
                   Education ="Bachelor engineer",
                    Rate="900 ",
                    Star=4
                    
            },
                  new CardDataModel
                {
                    ProfileImage ="https://scontent.fsjj2-1.fna.fbcdn.net/v/t1.0-9/14492594_1282275388449663_643903162709279497_n.jpg?_nc_cat=0&oh=09e7a556ae937fa4a0d16741bdf1f268&oe=5BFA4322",
                    Name="Merima" ,
                    Availability =true,
                    Profession="Web developer",
                   Education ="Bachelor engineer",
                    Rate="340 ",
                    Star=5
            },
        };

        }
    }
}
