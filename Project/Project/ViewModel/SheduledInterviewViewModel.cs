using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModel
{
    public class SheduledInterviewViewModel: BaseViewModel
    {
        private CardDataModel _item;
        public CardDataModel Item
        {
            get => _item;
            set { SetProperty(ref _item, value); }
        }

        public SheduledInterviewViewModel(CardDataModel cardDataModel)
        {
            Item = cardDataModel;
        }
    }
}
