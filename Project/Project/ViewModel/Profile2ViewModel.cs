using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModel
{
    public class Profile2ViewModel:BaseViewModel
    {
        private CardDataModel _item;
        public CardDataModel Item
        {
            get => _item;
            set { SetProperty(ref _item, value); }
        }

        public Profile2ViewModel(CardDataModel cardDataModel)
        {
            Item = cardDataModel;
        }
    }
}
