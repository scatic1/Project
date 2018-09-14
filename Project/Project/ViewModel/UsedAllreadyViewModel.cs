using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModel
{
    public class UsedAllreadyViewModel: BaseViewModel
    {
        public CardDataViewModel collection { get; set; }
        public IList<CardDataModel> UsedAllready { get; set; }= new List<CardDataModel>();
        public object SelectedItem { get; set; }

        public UsedAllreadyViewModel()
        {
            collection = new CardDataViewModel();
            foreach (CardDataModel element in collection.CardDataCollection)
            {
                if (element.Availability)
                {
                   UsedAllready.Add(element);
                }
            }
        }
    }
}
