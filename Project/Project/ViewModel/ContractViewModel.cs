using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModel
{
    public class ContractViewModel:BaseViewModel
    {
        private CardDataModel _item;
        public CardDataModel Item
        {
            get => _item;
            set { SetProperty(ref _item, value); }
        }

        public ContractViewModel(CardDataModel cardDataModel)
        {
            Item = cardDataModel;
        }
    }
}

