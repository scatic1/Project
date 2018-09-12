using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModel
{
    public class AddToShortListViewModel: BaseViewModel
    {
        private CardDataModel _item;
        public CardDataModel Item
        {
            get => _item;
            set { SetProperty(ref _item, value); }
        }

        public AddToShortListViewModel(CardDataModel cardDataModel)
        {
            Item = cardDataModel;
        }
    }
}
