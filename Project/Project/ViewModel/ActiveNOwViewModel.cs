using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModel
{
    public class ActiveNowViewModel: BaseViewModel
    {
        public CardDataViewModel collection  { get; set; }
        public IList<CardDataModel> ActiveNow { get; set; } = new List<CardDataModel>();
        public object SelectedItem { get; set; }
        
        public ActiveNowViewModel ()
        {
            collection = new CardDataViewModel();
            foreach(CardDataModel element in collection.CardDataCollection)
            {
                if (element.Availability)
                {
                    ActiveNow.Add(element);
                }
            }
        }
    }
}
