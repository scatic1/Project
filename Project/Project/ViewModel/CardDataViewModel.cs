using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Project
{
    public class CardDataViewModel
    {
        DateTime test;
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
                    ProfileImage ="lars.jpg",
                    Name="Lars" ,
                    Availability =true,
                    Profession="Business Controller",
                   Education ="M.Sc. Business & Economics",
                    Rate="750",
                   Star=4.5,
                  Experience=new string[]{ "2017 Deloitte, Business Controler", "2016 PWC, Assistant Business Controller"},
                  About="is dedicated to detail and efficiency. As a former elite athlete she knows the value of working hard, but also the power of a strong team.",
                  SpiritAnimal="lion.png",
                  YearsExperience=2,
                 //NextAvailabil = DateTime.ParseExact("Sun 08 Jun 2013 8:30 AM -06:00", "ddd dd MMM yyyy h:mm tt zzz", null)
                 NextAvailabil = DateTime.ParseExact("07/05/2016 17:07:00", "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture)

        },
                 new CardDataModel
                {
                    ProfileImage ="https://scontent.fsjj2-1.fna.fbcdn.net/v/t1.0-9/15420992_1359484517395416_7247385033604416897_n.jpg?_nc_cat=0&oh=7350927e79d49b90e58a95e034072bae&oe=5BF1ED08",
                    Name="Merima" ,
                    Availability =false,
                    Profession="Web developer",
                   Education ="Bachelor engineer",
                    Rate="900 ",
                    Star=4,
                    Experience=new string[]{ "2018 Propeller, Developer","2017 ETF, Bachelor engineer"},
                         About="is dedicated to detail and efficiency. As a former elite athlete she knows the value of working hard, but also the power of a strong team.",
                           SpiritAnimal="bird.png",
                           YearsExperience=2,
                           NextAvailabil = DateTime.ParseExact("12/04/2019 17:12:00", "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
            },
                  new CardDataModel
                {
                    ProfileImage ="https://scontent.fsjj2-1.fna.fbcdn.net/v/t1.0-9/14492594_1282275388449663_643903162709279497_n.jpg?_nc_cat=0&oh=09e7a556ae937fa4a0d16741bdf1f268&oe=5BFA4322",
                    Name="Merima" ,
                    Availability =true,
                    Profession="Web developer",
                   Education ="Bachelor engineer",
                    Rate="340 ",
                    Star=5,
                    Experience=new string[]{ "2018 Propeller, Developer","2017 ETF, Bachelor engineer"},
                          About="is dedicated to detail and efficiency. As a former elite athlete she knows the value of working hard, but also the power of a strong team.",
                                SpiritAnimal="bird.png",
                                YearsExperience=2,
                                NextAvailabil = DateTime.ParseExact("12/04/2019 17:12:00", "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
            },
        };

        }
    }
}
